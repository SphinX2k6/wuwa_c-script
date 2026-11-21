using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000305 RID: 773
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkMac : PlatformSdkBase
{
	// Token: 0x06002C80 RID: 11392 RVA: 0x00109738 File Offset: 0x00107938
	public PlatformSdkMac()
	{
		this.SdkParamCacheMap = new Dictionary<string, string>();
	}

	// Token: 0x06002C81 RID: 11393 RVA: 0x0010974C File Offset: 0x0010794C
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

	// Token: 0x06002C82 RID: 11394 RVA: 0x001097A1 File Offset: 0x001079A1
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06002C83 RID: 11395 RVA: 0x001097D0 File Offset: 0x001079D0
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkMac.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkMac.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002C84 RID: 11396 RVA: 0x00109808 File Offset: 0x00107A08
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

	// Token: 0x06002C85 RID: 11397 RVA: 0x001098CF File Offset: 0x00107ACF
	public override string GetChannelId()
	{
		return this.GetSdkParamData("channelId");
	}

	// Token: 0x06002C86 RID: 11398 RVA: 0x001098DC File Offset: 0x00107ADC
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

	// Token: 0x06002C87 RID: 11399 RVA: 0x00109924 File Offset: 0x00107B24
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

	// Token: 0x06002C88 RID: 11400 RVA: 0x001099AA File Offset: 0x00107BAA
	public override void SdkExit()
	{
		UKuroSDKManager.ShowExitGameDialog();
	}

	// Token: 0x04002943 RID: 10563
	private readonly Dictionary<string, string> SdkParamCacheMap;

	// Token: 0x02006670 RID: 26224
	[NullableContext(0)]
	private class ISdkCustomerService
	{
		// Token: 0x04021E99 RID: 138905
		[Nullable(1)]
		public string cuid = "";

		// Token: 0x04021E9A RID: 138906
		public int isredot;
	}
}
