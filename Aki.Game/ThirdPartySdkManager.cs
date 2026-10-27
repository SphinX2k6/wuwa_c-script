using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Extensions;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02000EF6 RID: 3830
[NullableContext(1)]
[Nullable(0)]
public class ThirdPartySdkManager : Singleton
{
	// Token: 0x06006020 RID: 24608 RVA: 0x001210F4 File Offset: 0x0011F2F4
	public void Init()
	{
		string packageConfigOrDefault = BaseConfigController.Instance.GetPackageConfigOrDefault("Stream", null);
		string packageConfigOrDefault2 = BaseConfigController.Instance.GetPackageConfigOrDefault("Changelist", "");
		FCrashSightProxy.SetBranchInfo(packageConfigOrDefault, packageConfigOrDefault2);
		string appChangeList = UKuroLauncherLibrary.GetAppChangeList();
		FCrashSightProxy.SetCustomData("AppChangelist", appChangeList);
		if (UKuroStaticLibrary.IsModuleLoaded("TpSafe"))
		{
			if (this.AceDataTransferTimerId != null)
			{
				TimerSystem.Instance.Remove(this.AceDataTransferTimerId);
				this.AceDataTransferTimerId = null;
			}
			this.InitDataTransferTimerForTpSafe();
			Net.Instance.Register(ENotifyMessageId.AceAntiDataNotify, new Action<IMessage, Net.CallbackStatus>(this.AceAntiDataNotify));
		}
		if (Platform.Instance.IsAndroidPlatform())
		{
			bool flag = UKuroAudioStatics.IsAndroidApiUsingOpenSL();
			FCrashSightProxy.SetCustomData("AudioAPI", flag ? "OpenSL" : "AAudio");
		}
		this.TestCrashSight();
	}

	// Token: 0x06006021 RID: 24609 RVA: 0x001211BC File Offset: 0x0011F3BC
	private void TestCrashSight()
	{
		if (UBlueprintPathsLibrary.FileExists(UKuroLauncherLibrary.GameSavedDir() + "crashes/trigger"))
		{
			Log.Instance.Error(ELogModule.Login, ELogAuthor.LRA, "崩溃测试！", default(ReadOnlySpan<ValueTuple<string, object>>));
			FCrashSightProxy.Test();
		}
	}

	// Token: 0x06006022 RID: 24610 RVA: 0x00121200 File Offset: 0x0011F400
	public void SetUserInfo(string userId)
	{
		if (userId == "")
		{
			return;
		}
		this.SetUserIdForCrashSight(userId);
	}

	// Token: 0x06006023 RID: 24611 RVA: 0x00121217 File Offset: 0x0011F417
	private void SetUserIdForCrashSight(string userId)
	{
		FCrashSightProxy.SetUserId(userId);
	}

	// Token: 0x06006024 RID: 24612 RVA: 0x00121220 File Offset: 0x0011F420
	public void SetUserInfoForTpSafe(string userId, int playerId)
	{
		FCrashSightProxy.SetCustomData("PlayerId", playerId.ToString());
		if (UKuroStaticLibrary.IsModuleLoaded("TpSafe"))
		{
			int accountTypeByChannel = this.GetAccountTypeByChannel();
			int worldId = 0;
			FTpSafeProxy.SetUserInfo(accountTypeByChannel, worldId, userId, playerId);
		}
	}

	// Token: 0x06006025 RID: 24613 RVA: 0x0012125C File Offset: 0x0011F45C
	public void InitDataTransferTimerForTpSafe()
	{
		int num = 4000;
		if (Platform.Instance.IsWindowsPlatform())
		{
			num = 100;
		}
		this.AceDataTransferTimerId = TimerSystem.Instance.Forever(delegate(float _)
		{
			this.SendAceData();
		}, (float)num, 1f, null, null, true);
	}

	// Token: 0x06006026 RID: 24614 RVA: 0x001212A4 File Offset: 0x0011F4A4
	private void SendAceData()
	{
		if (!Net.Instance.IsServerConnected())
		{
			return;
		}
		FArrayBuffer antiData = FTpSafeProxy.GetAntiData();
		if (antiData.Length > 0UL)
		{
			AceAntiDataPush aceAntiDataPush = AceAntiDataPush.Create();
			aceAntiDataPush.AntiData = ByteString.CopyFrom(antiData.ToByteArray());
			Net.Instance.Send(EPushMessageId.AceAntiDataPush, aceAntiDataPush);
		}
	}

	// Token: 0x06006027 RID: 24615 RVA: 0x001212F8 File Offset: 0x0011F4F8
	[NullableContext(2)]
	private unsafe void AceAntiDataNotify(IMessage msg, Net.CallbackStatus status)
	{
		byte[] array = ((AceAntiDataNotify)msg).AntiData.ToByteArray();
		byte[] array2;
		byte* data;
		if ((array2 = array) == null || array2.Length == 0)
		{
			data = null;
		}
		else
		{
			data = &array2[0];
		}
		FArrayBuffer farrayBuffer = new FArrayBuffer
		{
			Data = (void*)data,
			Length = (ulong)((long)array.Length)
		};
		FTpSafeProxy.RecvAntiData(farrayBuffer);
		array2 = null;
	}

	// Token: 0x06006028 RID: 24616 RVA: 0x00121355 File Offset: 0x0011F555
	private int GetAccountTypeByChannel()
	{
		if (Platform.Instance.IsWindowsPlatform())
		{
			return 601;
		}
		return 99;
	}

	// Token: 0x06006029 RID: 24617 RVA: 0x0012136B File Offset: 0x0011F56B
	public void Logout()
	{
		FTpSafeProxy.Logout();
	}

	// Token: 0x0600602A RID: 24618 RVA: 0x00121372 File Offset: 0x0011F572
	public void Clear()
	{
		if (this.AceDataTransferTimerId != null)
		{
			TimerSystem.Instance.Remove(this.AceDataTransferTimerId);
			this.AceDataTransferTimerId = null;
		}
	}

	// Token: 0x17000765 RID: 1893
	// (get) Token: 0x0600602B RID: 24619 RVA: 0x00121394 File Offset: 0x0011F594
	public static ThirdPartySdkManager Instance
	{
		get
		{
			if (ThirdPartySdkManager._instance == null)
			{
				ThirdPartySdkManager._instance = new ThirdPartySdkManager();
				ThirdPartySdkManager._instance.OnInit();
			}
			return ThirdPartySdkManager._instance;
		}
	}

	// Token: 0x0600602C RID: 24620 RVA: 0x001213B7 File Offset: 0x0011F5B7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600602D RID: 24621 RVA: 0x001213B9 File Offset: 0x0011F5B9
	public static void ResetStaticDefaultValue()
	{
		ThirdPartySdkManager instance = ThirdPartySdkManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ThirdPartySdkManager._instance = null;
	}

	// Token: 0x0600602E RID: 24622 RVA: 0x001213D2 File Offset: 0x0011F5D2
	static ThirdPartySdkManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ThirdPartySdkManager.CreateStaticDefaultValue), new Action(ThirdPartySdkManager.ResetStaticDefaultValue));
	}

	// Token: 0x04002BF0 RID: 11248
	private const int ACE_DATA_TRANSFER_INTERVAL_PC = 100;

	// Token: 0x04002BF1 RID: 11249
	private const int ACE_DATA_TRANSFER_INTERVAL_MOBILE = 4000;

	// Token: 0x04002BF2 RID: 11250
	[Nullable(2)]
	private TimerHandle AceDataTransferTimerId;

	// Token: 0x04002BF3 RID: 11251
	[Nullable(2)]
	private static ThirdPartySdkManager _instance;
}
