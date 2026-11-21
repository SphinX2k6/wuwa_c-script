using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Extensions;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020003AB RID: 939
[NullableContext(1)]
[Nullable(0)]
public class ThirdPartySdkManager : Singleton
{
	// Token: 0x060033B8 RID: 13240 RVA: 0x001290F8 File Offset: 0x001272F8
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

	// Token: 0x060033B9 RID: 13241 RVA: 0x001291C0 File Offset: 0x001273C0
	private void TestCrashSight()
	{
		if (UBlueprintPathsLibrary.FileExists(UKuroLauncherLibrary.GameSavedDir() + "crashes/trigger"))
		{
			Log.Instance.Error(ELogModule.Login, ELogAuthor.LRA, "崩溃测试！", default(ReadOnlySpan<ValueTuple<string, object>>));
			FCrashSightProxy.Test();
		}
	}

	// Token: 0x060033BA RID: 13242 RVA: 0x00129204 File Offset: 0x00127404
	public void SetUserInfo(string userId)
	{
		if (userId == "")
		{
			return;
		}
		this.SetUserIdForCrashSight(userId);
	}

	// Token: 0x060033BB RID: 13243 RVA: 0x0012921B File Offset: 0x0012741B
	private void SetUserIdForCrashSight(string userId)
	{
		FCrashSightProxy.SetUserId(userId);
	}

	// Token: 0x060033BC RID: 13244 RVA: 0x00129224 File Offset: 0x00127424
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

	// Token: 0x060033BD RID: 13245 RVA: 0x00129260 File Offset: 0x00127460
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

	// Token: 0x060033BE RID: 13246 RVA: 0x001292A8 File Offset: 0x001274A8
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

	// Token: 0x060033BF RID: 13247 RVA: 0x001292FC File Offset: 0x001274FC
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

	// Token: 0x060033C0 RID: 13248 RVA: 0x00129359 File Offset: 0x00127559
	private int GetAccountTypeByChannel()
	{
		if (Platform.Instance.IsWindowsPlatform())
		{
			return 601;
		}
		return 99;
	}

	// Token: 0x060033C1 RID: 13249 RVA: 0x0012936F File Offset: 0x0012756F
	public void Logout()
	{
		FTpSafeProxy.Logout();
	}

	// Token: 0x060033C2 RID: 13250 RVA: 0x00129376 File Offset: 0x00127576
	public void Clear()
	{
		if (this.AceDataTransferTimerId != null)
		{
			TimerSystem.Instance.Remove(this.AceDataTransferTimerId);
			this.AceDataTransferTimerId = null;
		}
	}

	// Token: 0x17000787 RID: 1927
	// (get) Token: 0x060033C3 RID: 13251 RVA: 0x00129398 File Offset: 0x00127598
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

	// Token: 0x060033C4 RID: 13252 RVA: 0x001293BB File Offset: 0x001275BB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060033C5 RID: 13253 RVA: 0x001293BD File Offset: 0x001275BD
	public static void ResetStaticDefaultValue()
	{
		ThirdPartySdkManager instance = ThirdPartySdkManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ThirdPartySdkManager._instance = null;
	}

	// Token: 0x060033C6 RID: 13254 RVA: 0x001293D6 File Offset: 0x001275D6
	static ThirdPartySdkManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ThirdPartySdkManager.CreateStaticDefaultValue), new Action(ThirdPartySdkManager.ResetStaticDefaultValue));
	}

	// Token: 0x04002C89 RID: 11401
	private const int ACE_DATA_TRANSFER_INTERVAL_PC = 100;

	// Token: 0x04002C8A RID: 11402
	private const int ACE_DATA_TRANSFER_INTERVAL_MOBILE = 4000;

	// Token: 0x04002C8B RID: 11403
	[Nullable(2)]
	private TimerHandle AceDataTransferTimerId;

	// Token: 0x04002C8C RID: 11404
	[Nullable(2)]
	private static ThirdPartySdkManager _instance;
}
