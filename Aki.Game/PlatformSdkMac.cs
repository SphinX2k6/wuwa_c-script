using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000E50 RID: 3664
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkMac : PlatformSdkBase
{
	// Token: 0x060058EA RID: 22762 RVA: 0x00101AC4 File Offset: 0x000FFCC4
	public PlatformSdkMac()
	{
		this.SdkParamCacheMap = new Dictionary<string, string>();
	}

	// Token: 0x060058EB RID: 22763 RVA: 0x00101AD8 File Offset: 0x000FFCD8
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		if (KuroSdkController.Instance.CanUseSdk() && UKuroLauncherLibrary.IsFirstIntoLauncher())
		{
			UKuroSDKManager.PostSplashScreenEndSuccess();
		}
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x060058EC RID: 22764 RVA: 0x00101B2D File Offset: 0x000FFD2D
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x060058ED RID: 22765 RVA: 0x00101B5C File Offset: 0x000FFD5C
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkMac.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkMac.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x060058EE RID: 22766 RVA: 0x00101B94 File Offset: 0x000FFD94
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		OpenCustomerServiceParamMac openCustomerServiceParamMac = new OpenCustomerServiceParamMac();
		openCustomerServiceParamMac.islogin = ((instance.IsSdkLoggedIn() > false) ? 1 : 0);
		openCustomerServiceParamMac.from = fromType;
		openCustomerServiceParamMac.RoleId = this.GetCustomServerRoleId();
		openCustomerServiceParamMac.RoleName = instance2.GetAccountName(true);
		openCustomerServiceParamMac.ServerId = (instance.GetServerId() ?? "");
		openCustomerServiceParamMac.ServerName = (instance.GetServerName() ?? "");
		int? playerLevel = instance2.GetPlayerLevel();
		openCustomerServiceParamMac.RoleLevel = ((playerLevel != null && playerLevel.Value != 0) ? playerLevel.Value.ToString() : "");
		openCustomerServiceParamMac.ExtendsInfo = this.GetCustomServerExtendsInfo();
		UKuroSDKManager.OpenCustomerService(JsonSerializer.Serialize<OpenCustomerServiceParamMac>(openCustomerServiceParamMac, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x00101C5B File Offset: 0x000FFE5B
	public override string GetChannelId()
	{
		return this.GetSdkParamData("channelId");
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x00101C68 File Offset: 0x000FFE68
	public override void SetFont()
	{
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "Mac SetFont";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fontPath", deviceFontAsset);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.SetFont(deviceFontAsset);
	}

	// Token: 0x060058F1 RID: 22769 RVA: 0x00101CB0 File Offset: 0x000FFEB0
	private string GetSdkParamData(string needParam)
	{
		if (this.SdkParamCacheMap.Count == 0)
		{
			string[] array = UKuroSDKManager.GetSdkParams("").Split(',', StringSplitOptions.None);
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string[] array2 = array[i].Split('=', StringSplitOptions.None);
				if (array2.Length == 2)
				{
					this.SdkParamCacheMap[array2[0]] = array2[1];
				}
			}
		}
		string text;
		if (this.SdkParamCacheMap.TryGetValue(needParam, out text) && text != null && !StringUtils.IsEmpty(text))
		{
			return text;
		}
		return "";
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x00101D36 File Offset: 0x000FFF36
	public override void SdkExit()
	{
		UKuroSDKManager.ShowExitGameDialog();
	}

	// Token: 0x040028A8 RID: 10408
	private readonly Dictionary<string, string> SdkParamCacheMap;

	// Token: 0x020074DC RID: 29916
	[NullableContext(0)]
	private class ISdkCustomerService
	{
		// Token: 0x04026B54 RID: 158548
		[Nullable(1)]
		public string cuid = "";

		// Token: 0x04026B55 RID: 158549
		public int isredot;
	}
}
