using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using UnrealEngine;

// Token: 0x02000BA2 RID: 2978
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AntiCheatModel : ModelBase
{
	// Token: 0x06007C13 RID: 31763 RVA: 0x002677B4 File Offset: 0x002659B4
	public string GetVersion()
	{
		return this.Version;
	}

	// Token: 0x06007C14 RID: 31764 RVA: 0x002677BC File Offset: 0x002659BC
	public string GetBundleId()
	{
		return this.BundleId;
	}

	// Token: 0x06007C15 RID: 31765 RVA: 0x002677C4 File Offset: 0x002659C4
	protected override bool OnInit()
	{
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		this.Version = LocalStorage.GetDeviceSaved<string>(ELocalStorageDeviceKey.PatchVersion, appVersion);
		this.BundleId = UKismetSystemLibrary.GetGameBundleId();
		return true;
	}

	// Token: 0x06007C16 RID: 31766 RVA: 0x002677F0 File Offset: 0x002659F0
	public static AntiCheatBundleData GetBundleData()
	{
		AntiCheatBundleData antiCheatBundleData = new AntiCheatBundleData();
		antiCheatBundleData.event_id = "8";
		string unique_id = LoginModel.Instance.GetAccount();
		if (KuroSdkController.Instance.CanUseSdk())
		{
			unique_id = LoginModel.Instance.GetSdkLoginConfig().Uid;
		}
		antiCheatBundleData.unique_id = unique_id;
		antiCheatBundleData.s_bundle_id = AntiCheatModel.Instance.GetBundleId();
		antiCheatBundleData.s_version = AntiCheatModel.Instance.GetVersion();
		return antiCheatBundleData;
	}

	// Token: 0x06007C17 RID: 31767 RVA: 0x0026785B File Offset: 0x00265A5B
	public void ResetHeartbeatException()
	{
		this.HeartbeatExceptionCount = 0;
	}

	// Token: 0x06007C18 RID: 31768 RVA: 0x00267864 File Offset: 0x00265A64
	public void HitHeartbeatException()
	{
		this.HeartbeatExceptionCount++;
	}

	// Token: 0x06007C19 RID: 31769 RVA: 0x00267874 File Offset: 0x00265A74
	public int GetHeartbeatException()
	{
		return this.HeartbeatExceptionCount;
	}

	// Token: 0x06007C1A RID: 31770 RVA: 0x0026787C File Offset: 0x00265A7C
	public bool HasHeartbeatException()
	{
		return this.HeartbeatExceptionCount > 0;
	}

	// Token: 0x06007C1B RID: 31771 RVA: 0x00267888 File Offset: 0x00265A88
	public AntiCheatHeartbeatData GetHeartbeatData()
	{
		AntiCheatHeartbeatData antiCheatHeartbeatData = new AntiCheatHeartbeatData();
		antiCheatHeartbeatData.event_id = "9";
		string unique_id = LoginModel.Instance.GetAccount();
		if (KuroSdkController.Instance.CanUseSdk())
		{
			unique_id = LoginModel.Instance.GetSdkLoginConfig().Uid;
		}
		antiCheatHeartbeatData.unique_id = unique_id;
		antiCheatHeartbeatData.i_exception_count = this.HeartbeatExceptionCount;
		return antiCheatHeartbeatData;
	}

	// Token: 0x17000E11 RID: 3601
	// (get) Token: 0x06007C1C RID: 31772 RVA: 0x002678DF File Offset: 0x00265ADF
	public static AntiCheatModel Instance
	{
		get
		{
			return AntiCheatModel._Instance;
		}
	}

	// Token: 0x06007C1D RID: 31773 RVA: 0x002678E6 File Offset: 0x00265AE6
	public static AntiCheatModel GetOrCreateInstance()
	{
		if (AntiCheatModel._Instance == null)
		{
			AntiCheatModel.CreateInstance();
		}
		return AntiCheatModel._Instance;
	}

	// Token: 0x06007C1E RID: 31774 RVA: 0x002678FA File Offset: 0x00265AFA
	public static bool CreateInstance()
	{
		if (AntiCheatModel._Instance != null)
		{
			return true;
		}
		AntiCheatModel._Instance = new AntiCheatModel();
		return true;
	}

	// Token: 0x06007C1F RID: 31775 RVA: 0x00267910 File Offset: 0x00265B10
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007C20 RID: 31776 RVA: 0x00267912 File Offset: 0x00265B12
	public static void ResetStaticDefaultValue()
	{
		AntiCheatModel._Instance = null;
	}

	// Token: 0x06007C21 RID: 31777 RVA: 0x0026791A File Offset: 0x00265B1A
	static AntiCheatModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AntiCheatModel.CreateStaticDefaultValue), new Action(AntiCheatModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004C6A RID: 19562
	private const string BUNDLE_DATA_EVENT_ID = "8";

	// Token: 0x04004C6B RID: 19563
	private const string HEARTBEAT_DATA_EVENT_ID = "9";

	// Token: 0x04004C6C RID: 19564
	private string Version = "";

	// Token: 0x04004C6D RID: 19565
	private string BundleId = "";

	// Token: 0x04004C6E RID: 19566
	private int HeartbeatExceptionCount;

	// Token: 0x04004C6F RID: 19567
	[Nullable(2)]
	private static AntiCheatModel _Instance;
}
