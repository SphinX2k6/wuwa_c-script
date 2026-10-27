using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000E4E RID: 3662
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkIos : PlatformSdkBase
{
	// Token: 0x060058BA RID: 22714 RVA: 0x00100B60 File Offset: 0x000FED60
	protected override void OnInit()
	{
		this.CurrentDid = UKuroSDKManager.GetBasicInfo().DeviceId;
		if (KuroSdkController.Instance.CanUseSdk() && UKuroLauncherLibrary.IsFirstIntoLauncher())
		{
			UKuroSDKManager.PostSplashScreenEndSuccess();
		}
		FCrashSightProxy.SetCustomData("SdkDeviceId", this.CurrentDid);
		FCrashSightProxy.SetCustomData("Sdkidfv", this.Getidfv());
		FCrashSightProxy.SetCustomData("SdkJyId", this.GetJyDid());
		FCrashSightProxy.SetCustomData("SdkChannelId", this.GetChannelId());
	}

	// Token: 0x060058BB RID: 22715 RVA: 0x00100BD8 File Offset: 0x000FEDD8
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(this.AnnounceRedPointCallBack);
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x060058BC RID: 22716 RVA: 0x00100C34 File Offset: 0x000FEE34
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkIos.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkIos.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x060058BD RID: 22717 RVA: 0x00100C6C File Offset: 0x000FEE6C
	public override void OpenCustomerService(EKuroSdkOpenCustomerServerType fromType)
	{
		LoginModel instance = LoginModel.Instance;
		PlayerInfoModel instance2 = PlayerInfoModel.Instance;
		UKuroSDKManager.OpenCustomerService(JsonSerializer.Serialize<OpenCustomerServiceParamIos>(new OpenCustomerServiceParamIos
		{
			islogin = ((instance.IsSdkLoggedIn() > false) ? 1 : 0),
			from = fromType,
			RoleId = this.GetCustomServerRoleId(),
			RoleName = instance2.GetAccountName(true),
			ServerId = instance.GetServerId(),
			ServerName = instance.GetServerName(),
			RoleLevel = instance2.GetPlayerLevel().GetValueOrDefault(),
			ExtendsInfo = this.GetCustomServerExtendsInfo()
		}, KuroSdkJsonOptions.Unescaped));
	}

	// Token: 0x060058BE RID: 22718 RVA: 0x00100D00 File Offset: 0x000FEF00
	public override string GetChannelId()
	{
		return this.GetSdkParamData("channelId");
	}

	// Token: 0x060058BF RID: 22719 RVA: 0x00100D10 File Offset: 0x000FEF10
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x060058C0 RID: 22720 RVA: 0x00100D2C File Offset: 0x000FEF2C
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify<ShareData>(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x060058C1 RID: 22721 RVA: 0x00100D48 File Offset: 0x000FEF48
	protected override void OnGetSharePlatform(string str)
	{
		PlatformSdkIos.SharePlatform sharePlatform = Json.Parse<PlatformSdkIos.SharePlatform>(str, null);
		if (sharePlatform.KRMAINLAND_SDK_EVENT_KEY_RESULT == 0)
		{
			PlatformSdkIos.SharePlatformContent[] array = Json.Parse<PlatformSdkIos.SharePlatformContent[]>(sharePlatform.KRMAINLAND_SDK_EVENT_KEY_DATA, null);
			List<SharePlatformSt> shareResult = new List<SharePlatformSt>();
			if (array != null)
			{
				foreach (PlatformSdkIos.SharePlatformContent sharePlatformContent in array)
				{
					SharePlatformSt sharePlatformSt = new SharePlatformSt();
					sharePlatformSt.IconUrl = sharePlatformContent.iconUrl;
					sharePlatformSt.PlatformId = sharePlatformContent.platform.ToString();
					shareResult.Add(sharePlatformSt);
				}
			}
			this.GetSharePlatformCallBackList.ForEach(delegate(Action<SharePlatformSt[]> value)
			{
				value(shareResult.ToArray());
			});
			this.GetSharePlatformCallBackList = new List<Action<SharePlatformSt[]>>();
		}
		base.OnGetSharePlatform(str);
	}

	// Token: 0x060058C2 RID: 22722 RVA: 0x00100E04 File Offset: 0x000FF004
	public override void SetFont()
	{
		string deviceFontAsset = KuroSdkModel.Instance.GetDeviceFontAsset();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "SetFont";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fontPath", deviceFontAsset);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroSDKManager.SetFont(deviceFontAsset);
	}

	// Token: 0x060058C3 RID: 22723 RVA: 0x00100E4C File Offset: 0x000FF04C
	protected unsafe override void OnShareResult(int code, string jsonStr, string msg)
	{
		string text = jsonStr.Replace("\n", "").Replace(" ", "");
		PlatformSdkIos.ShareResult shareResult = Json.Parse<PlatformSdkIos.ShareResult>(text, null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "OnShareResult";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("code", code);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("platform", jsonStr);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("finalMsg", text);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("shareResult", shareResult);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		if (shareResult != null && shareResult.KRMAINLAND_SDK_EVENT_KEY_RESULT)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, true);
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnShareResult, false);
	}

	// Token: 0x060058C4 RID: 22724 RVA: 0x00100F37 File Offset: 0x000FF137
	private string Getidfv()
	{
		return this.GetSdkParamData("idfv");
	}

	// Token: 0x060058C5 RID: 22725 RVA: 0x00100F44 File Offset: 0x000FF144
	public override string GetJyDid()
	{
		return this.GetSdkParamData("jyDeviceId");
	}

	// Token: 0x060058C6 RID: 22726 RVA: 0x00100F54 File Offset: 0x000FF154
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
		string text = this.SdkParamCacheMap.ContainsKey(needParam) ? this.SdkParamCacheMap[needParam] : null;
		if (text != null && !StringUtils.IsEmpty(text))
		{
			return text;
		}
		return "";
	}

	// Token: 0x060058C7 RID: 22727 RVA: 0x00100FE8 File Offset: 0x000FF1E8
	public override void OpenExternalUrl(string url)
	{
		UKuroSDKManager.OpenDefaultWebView(url);
	}

	// Token: 0x060058C8 RID: 22728 RVA: 0x00100FF0 File Offset: 0x000FF1F0
	protected override int CurrentPlatformYearReviewTime()
	{
		return 3;
	}

	// Token: 0x060058C9 RID: 22729 RVA: 0x00100FF3 File Offset: 0x000FF1F3
	protected unsafe void KuroBindExternalLoginResult()
	{
		UKuroSDKManager.Get().ExternalLoginCallBack.Clear();
		UKuroSDKManager.Get().ExternalLoginCallBack.Add(delegate(bool result, string msg)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "ShowExternalLoginUI";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("result", result);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("msg", msg);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (result)
			{
				this.ExternalLoginState = true;
				base.QueryExternalAchievement();
			}
			this.ExternalLoginState = result;
		});
	}

	// Token: 0x060058CA RID: 22730 RVA: 0x0010101F File Offset: 0x000FF21F
	protected override void BindExternalEvent()
	{
		this.KuroBindExternalLoginResult();
		base.KuroBindExternalAchievementWriteResult();
		base.KuroBindExternalAchievementQueryResult();
	}

	// Token: 0x060058CB RID: 22731 RVA: 0x00101033 File Offset: 0x000FF233
	public override void UnlockSdkTrophy(string id)
	{
		this.UpdateExternalAchievementProgress(id, 100);
	}

	// Token: 0x060058CC RID: 22732 RVA: 0x00101040 File Offset: 0x000FF240
	public void UpdateExternalAchievementProgress(string achievementName, int progress)
	{
		if (!this.ExternalLoginState)
		{
			return;
		}
		if ((this.AchievementMap.ContainsKey(achievementName) ? this.AchievementMap[achievementName].Progress : 0) >= 100)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "UpdateExternalAchievementProgress";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("achievementName", achievementName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		SdkAchievementContentData sdkAchievementContentData = new SdkAchievementContentData();
		sdkAchievementContentData.AchievementId = achievementName;
		sdkAchievementContentData.Progress = progress;
		UKuroSDKManager.WriteExternalAchievements(Json.Stringify<SdkAchievementData>(new SdkAchievementData
		{
			Achievements = new SdkAchievementContentData[]
			{
				sdkAchievementContentData
			}
		}, null) ?? "");
	}

	// Token: 0x040028A1 RID: 10401
	private const int MAXREVIEWTIME = 3;

	// Token: 0x040028A2 RID: 10402
	private readonly Dictionary<string, string> SdkParamCacheMap = new Dictionary<string, string>();

	// Token: 0x040028A3 RID: 10403
	public readonly Action<string> AnnounceRedPointCallBack = delegate(string result)
	{
		if (result.Contains("showRed") && (result.Contains("1") || result.Contains("YES")))
		{
			KuroSdkController.Instance.SetPostWebViewRedPointState(true);
			EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
			return;
		}
		KuroSdkController.Instance.SetPostWebViewRedPointState(false);
		EventSystem.Instance.Emit(EEventName.SdkPostWebViewRedPointRefresh);
	};

	// Token: 0x020074C7 RID: 29895
	public interface ISharePlatform
	{
		// Token: 0x17009FDB RID: 40923
		// (get) Token: 0x06048A4C RID: 297548
		// (set) Token: 0x06048A4D RID: 297549
		string KRMAINLAND_SDK_EVENT_KEY_DATA { get; set; }

		// Token: 0x17009FDC RID: 40924
		// (get) Token: 0x06048A4E RID: 297550
		// (set) Token: 0x06048A4F RID: 297551
		int KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }
	}

	// Token: 0x020074C8 RID: 29896
	[Nullable(0)]
	public class SharePlatform : PlatformSdkIos.ISharePlatform
	{
		// Token: 0x17009FDD RID: 40925
		// (get) Token: 0x06048A50 RID: 297552 RVA: 0x012B4946 File Offset: 0x012B2B46
		// (set) Token: 0x06048A51 RID: 297553 RVA: 0x012B494E File Offset: 0x012B2B4E
		public string KRMAINLAND_SDK_EVENT_KEY_DATA { get; set; }

		// Token: 0x17009FDE RID: 40926
		// (get) Token: 0x06048A52 RID: 297554 RVA: 0x012B4957 File Offset: 0x012B2B57
		// (set) Token: 0x06048A53 RID: 297555 RVA: 0x012B495F File Offset: 0x012B2B5F
		public int KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }
	}

	// Token: 0x020074C9 RID: 29897
	public interface ISharePlatformContent
	{
		// Token: 0x17009FDF RID: 40927
		// (get) Token: 0x06048A55 RID: 297557
		// (set) Token: 0x06048A56 RID: 297558
		string iconUrl { get; set; }

		// Token: 0x17009FE0 RID: 40928
		// (get) Token: 0x06048A57 RID: 297559
		// (set) Token: 0x06048A58 RID: 297560
		string platform { get; set; }
	}

	// Token: 0x020074CA RID: 29898
	[Nullable(0)]
	public class SharePlatformContent : PlatformSdkIos.ISharePlatformContent
	{
		// Token: 0x17009FE1 RID: 40929
		// (get) Token: 0x06048A59 RID: 297561 RVA: 0x012B4970 File Offset: 0x012B2B70
		// (set) Token: 0x06048A5A RID: 297562 RVA: 0x012B4978 File Offset: 0x012B2B78
		public string iconUrl { get; set; }

		// Token: 0x17009FE2 RID: 40930
		// (get) Token: 0x06048A5B RID: 297563 RVA: 0x012B4981 File Offset: 0x012B2B81
		// (set) Token: 0x06048A5C RID: 297564 RVA: 0x012B4989 File Offset: 0x012B2B89
		public string platform { get; set; }
	}

	// Token: 0x020074CB RID: 29899
	public interface IShareResult
	{
		// Token: 0x17009FE3 RID: 40931
		// (get) Token: 0x06048A5E RID: 297566
		// (set) Token: 0x06048A5F RID: 297567
		bool KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }

		// Token: 0x17009FE4 RID: 40932
		// (get) Token: 0x06048A60 RID: 297568
		// (set) Token: 0x06048A61 RID: 297569
		string KRMAINLAND_SDK_EVENT_KEY_REASON { get; set; }
	}

	// Token: 0x020074CC RID: 29900
	[Nullable(0)]
	public class ShareResult : PlatformSdkIos.IShareResult
	{
		// Token: 0x17009FE5 RID: 40933
		// (get) Token: 0x06048A62 RID: 297570 RVA: 0x012B499A File Offset: 0x012B2B9A
		// (set) Token: 0x06048A63 RID: 297571 RVA: 0x012B49A2 File Offset: 0x012B2BA2
		public bool KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }

		// Token: 0x17009FE6 RID: 40934
		// (get) Token: 0x06048A64 RID: 297572 RVA: 0x012B49AB File Offset: 0x012B2BAB
		// (set) Token: 0x06048A65 RID: 297573 RVA: 0x012B49B3 File Offset: 0x012B2BB3
		public string KRMAINLAND_SDK_EVENT_KEY_REASON { get; set; }
	}

	// Token: 0x020074CD RID: 29901
	[NullableContext(0)]
	public class ISdkCustomerService
	{
		// Token: 0x04026B36 RID: 158518
		[Nullable(1)]
		public string cuid;

		// Token: 0x04026B37 RID: 158519
		public int isredot;
	}
}
