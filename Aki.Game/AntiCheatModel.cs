using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using UnrealEngine;

// Token: 0x020016EA RID: 5866
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AntiCheatModel : ModelBase
{
	// Token: 0x0600A833 RID: 43059 RVA: 0x0025D394 File Offset: 0x0025B594
	public string GetVersion()
	{
		return this.Version;
	}

	// Token: 0x0600A834 RID: 43060 RVA: 0x0025D39C File Offset: 0x0025B59C
	public string GetBundleId()
	{
		return this.BundleId;
	}

	// Token: 0x0600A835 RID: 43061 RVA: 0x0025D3A4 File Offset: 0x0025B5A4
	protected override bool OnInit()
	{
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		this.Version = LocalStorage.GetDeviceSaved<string>(ELocalStorageDeviceKey.PatchVersion, appVersion);
		this.BundleId = UKismetSystemLibrary.GetGameBundleId();
		return true;
	}

	// Token: 0x0600A836 RID: 43062 RVA: 0x0025D3D0 File Offset: 0x0025B5D0
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

	// Token: 0x0600A837 RID: 43063 RVA: 0x0025D43B File Offset: 0x0025B63B
	public void ResetHeartbeatException()
	{
		this.HeartbeatExceptionCount = 0;
	}

	// Token: 0x0600A838 RID: 43064 RVA: 0x0025D444 File Offset: 0x0025B644
	public void HitHeartbeatException()
	{
		this.HeartbeatExceptionCount++;
	}

	// Token: 0x0600A839 RID: 43065 RVA: 0x0025D454 File Offset: 0x0025B654
	public int GetHeartbeatException()
	{
		return this.HeartbeatExceptionCount;
	}

	// Token: 0x0600A83A RID: 43066 RVA: 0x0025D45C File Offset: 0x0025B65C
	public bool HasHeartbeatException()
	{
		return this.HeartbeatExceptionCount > 0;
	}

	// Token: 0x0600A83B RID: 43067 RVA: 0x0025D468 File Offset: 0x0025B668
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

	// Token: 0x17000DF0 RID: 3568
	// (get) Token: 0x0600A83C RID: 43068 RVA: 0x0025D4BF File Offset: 0x0025B6BF
	public static AntiCheatModel Instance
	{
		get
		{
			return AntiCheatModel._Instance;
		}
	}

	// Token: 0x0600A83D RID: 43069 RVA: 0x0025D4C6 File Offset: 0x0025B6C6
	public static AntiCheatModel GetOrCreateInstance()
	{
		if (AntiCheatModel._Instance == null)
		{
			AntiCheatModel.CreateInstance();
		}
		return AntiCheatModel._Instance;
	}

	// Token: 0x0600A83E RID: 43070 RVA: 0x0025D4DA File Offset: 0x0025B6DA
	public static bool CreateInstance()
	{
		if (AntiCheatModel._Instance != null)
		{
			return true;
		}
		AntiCheatModel._Instance = new AntiCheatModel();
		return true;
	}

	// Token: 0x0600A83F RID: 43071 RVA: 0x0025D4F0 File Offset: 0x0025B6F0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A840 RID: 43072 RVA: 0x0025D4F2 File Offset: 0x0025B6F2
	public static void ResetStaticDefaultValue()
	{
		AntiCheatModel._Instance = null;
	}

	// Token: 0x0600A841 RID: 43073 RVA: 0x0025D4FA File Offset: 0x0025B6FA
	static AntiCheatModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AntiCheatModel.CreateStaticDefaultValue), new Action(AntiCheatModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004BC3 RID: 19395
	private const string BUNDLE_DATA_EVENT_ID = "8";

	// Token: 0x04004BC4 RID: 19396
	private const string HEARTBEAT_DATA_EVENT_ID = "9";

	// Token: 0x04004BC5 RID: 19397
	private string Version = "";

	// Token: 0x04004BC6 RID: 19398
	private string BundleId = "";

	// Token: 0x04004BC7 RID: 19399
	private int HeartbeatExceptionCount;

	// Token: 0x04004BC8 RID: 19400
	[Nullable(2)]
	private static AntiCheatModel _Instance;
}
