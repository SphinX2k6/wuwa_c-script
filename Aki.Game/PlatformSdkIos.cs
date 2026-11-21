using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000303 RID: 771
[NullableContext(1)]
[Nullable(0)]
public class PlatformSdkIos : PlatformSdkBase
{
	// Token: 0x06002C50 RID: 11344 RVA: 0x001087D4 File Offset: 0x001069D4
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

	// Token: 0x06002C51 RID: 11345 RVA: 0x0010884C File Offset: 0x00106A4C
	protected override void BindSpecialEvent()
	{
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Clear();
		UKuroSDKManager.Get().AnnounceRedPointDelegate.Add(this.AnnounceRedPointCallBack);
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Clear();
		UKuroSDKManager.Get().CustomerServiceResultDelegate.Add(new Action<string>(this.CustomerServiceResultCallBack));
	}

	// Token: 0x06002C52 RID: 11346 RVA: 0x001088A8 File Offset: 0x00106AA8
	public void CustomerServiceResultCallBack(string result)
	{
		PlatformSdkIos.ISdkCustomerService sdkCustomerService = Json.Parse<PlatformSdkIos.ISdkCustomerService>(result, null);
		if (sdkCustomerService != null)
		{
			this.CurrentCustomerShowState = (sdkCustomerService.isredot > 0);
		}
		EventSystem.Instance.Emit(EEventName.SdkCustomerRedPointRefresh);
	}

	// Token: 0x06002C53 RID: 11347 RVA: 0x001088E0 File Offset: 0x00106AE0
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

	// Token: 0x06002C54 RID: 11348 RVA: 0x00108974 File Offset: 0x00106B74
	public override string GetChannelId()
	{
		return this.GetSdkParamData("channelId");
	}

	// Token: 0x06002C55 RID: 11349 RVA: 0x00108984 File Offset: 0x00106B84
	public override void Share(ShareData shareData, string imagePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(imagePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x001089A0 File Offset: 0x00106BA0
	public override void ShareTexture(ShareData shareData, string texturePath)
	{
		string sKuroSDKEventParameter = Json.Stringify(shareData, null);
		UKuroSDKStaticLibrary.Share(texturePath, sKuroSDKEventParameter);
	}

	// Token: 0x06002C57 RID: 11351 RVA: 0x001089BC File Offset: 0x00106BBC
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

	// Token: 0x06002C58 RID: 11352 RVA: 0x00108A78 File Offset: 0x00106C78
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

	// Token: 0x06002C59 RID: 11353 RVA: 0x00108AC0 File Offset: 0x00106CC0
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

	// Token: 0x06002C5A RID: 11354 RVA: 0x00108BAB File Offset: 0x00106DAB
	private string Getidfv()
	{
		return this.GetSdkParamData("idfv");
	}

	// Token: 0x06002C5B RID: 11355 RVA: 0x00108BB8 File Offset: 0x00106DB8
	public override string GetJyDid()
	{
		return this.GetSdkParamData("jyDeviceId");
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x00108BC8 File Offset: 0x00106DC8
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

	// Token: 0x06002C5D RID: 11357 RVA: 0x00108C5C File Offset: 0x00106E5C
	public override void OpenExternalUrl(string url)
	{
		UKuroSDKManager.OpenDefaultWebView(url);
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x00108C64 File Offset: 0x00106E64
	protected override int CurrentPlatformYearReviewTime()
	{
		return 3;
	}

	// Token: 0x06002C5F RID: 11359 RVA: 0x00108C67 File Offset: 0x00106E67
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

	// Token: 0x06002C60 RID: 11360 RVA: 0x00108C93 File Offset: 0x00106E93
	protected override void BindExternalEvent()
	{
		this.KuroBindExternalLoginResult();
		base.KuroBindExternalAchievementWriteResult();
		base.KuroBindExternalAchievementQueryResult();
	}

	// Token: 0x06002C61 RID: 11361 RVA: 0x00108CA7 File Offset: 0x00106EA7
	public override void UnlockSdkTrophy(string id)
	{
		this.UpdateExternalAchievementProgress(id, 100);
	}

	// Token: 0x06002C62 RID: 11362 RVA: 0x00108CB4 File Offset: 0x00106EB4
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
		UKuroSDKManager.WriteExternalAchievements(Json.Stringify(new SdkAchievementData
		{
			Achievements = new SdkAchievementContentData[]
			{
				sdkAchievementContentData
			}
		}, null) ?? "");
	}

	// Token: 0x0400293C RID: 10556
	private const int MAXREVIEWTIME = 3;

	// Token: 0x0400293D RID: 10557
	private readonly Dictionary<string, string> SdkParamCacheMap = new Dictionary<string, string>();

	// Token: 0x0400293E RID: 10558
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

	// Token: 0x0200665B RID: 26203
	public interface ISharePlatform
	{
		// Token: 0x17007779 RID: 30585
		// (get) Token: 0x0603EEAC RID: 257708
		// (set) Token: 0x0603EEAD RID: 257709
		string KRMAINLAND_SDK_EVENT_KEY_DATA { get; set; }

		// Token: 0x1700777A RID: 30586
		// (get) Token: 0x0603EEAE RID: 257710
		// (set) Token: 0x0603EEAF RID: 257711
		int KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }
	}

	// Token: 0x0200665C RID: 26204
	[Nullable(0)]
	public class SharePlatform : PlatformSdkIos.ISharePlatform
	{
		// Token: 0x1700777B RID: 30587
		// (get) Token: 0x0603EEB0 RID: 257712 RVA: 0x01257CAE File Offset: 0x01255EAE
		// (set) Token: 0x0603EEB1 RID: 257713 RVA: 0x01257CB6 File Offset: 0x01255EB6
		public string KRMAINLAND_SDK_EVENT_KEY_DATA { get; set; }

		// Token: 0x1700777C RID: 30588
		// (get) Token: 0x0603EEB2 RID: 257714 RVA: 0x01257CBF File Offset: 0x01255EBF
		// (set) Token: 0x0603EEB3 RID: 257715 RVA: 0x01257CC7 File Offset: 0x01255EC7
		public int KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }
	}

	// Token: 0x0200665D RID: 26205
	public interface ISharePlatformContent
	{
		// Token: 0x1700777D RID: 30589
		// (get) Token: 0x0603EEB5 RID: 257717
		// (set) Token: 0x0603EEB6 RID: 257718
		string iconUrl { get; set; }

		// Token: 0x1700777E RID: 30590
		// (get) Token: 0x0603EEB7 RID: 257719
		// (set) Token: 0x0603EEB8 RID: 257720
		string platform { get; set; }
	}

	// Token: 0x0200665E RID: 26206
	[Nullable(0)]
	public class SharePlatformContent : PlatformSdkIos.ISharePlatformContent
	{
		// Token: 0x1700777F RID: 30591
		// (get) Token: 0x0603EEB9 RID: 257721 RVA: 0x01257CD8 File Offset: 0x01255ED8
		// (set) Token: 0x0603EEBA RID: 257722 RVA: 0x01257CE0 File Offset: 0x01255EE0
		public string iconUrl { get; set; }

		// Token: 0x17007780 RID: 30592
		// (get) Token: 0x0603EEBB RID: 257723 RVA: 0x01257CE9 File Offset: 0x01255EE9
		// (set) Token: 0x0603EEBC RID: 257724 RVA: 0x01257CF1 File Offset: 0x01255EF1
		public string platform { get; set; }
	}

	// Token: 0x0200665F RID: 26207
	public interface IShareResult
	{
		// Token: 0x17007781 RID: 30593
		// (get) Token: 0x0603EEBE RID: 257726
		// (set) Token: 0x0603EEBF RID: 257727
		bool KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }

		// Token: 0x17007782 RID: 30594
		// (get) Token: 0x0603EEC0 RID: 257728
		// (set) Token: 0x0603EEC1 RID: 257729
		string KRMAINLAND_SDK_EVENT_KEY_REASON { get; set; }
	}

	// Token: 0x02006660 RID: 26208
	[Nullable(0)]
	public class ShareResult : PlatformSdkIos.IShareResult
	{
		// Token: 0x17007783 RID: 30595
		// (get) Token: 0x0603EEC2 RID: 257730 RVA: 0x01257D02 File Offset: 0x01255F02
		// (set) Token: 0x0603EEC3 RID: 257731 RVA: 0x01257D0A File Offset: 0x01255F0A
		public bool KRMAINLAND_SDK_EVENT_KEY_RESULT { get; set; }

		// Token: 0x17007784 RID: 30596
		// (get) Token: 0x0603EEC4 RID: 257732 RVA: 0x01257D13 File Offset: 0x01255F13
		// (set) Token: 0x0603EEC5 RID: 257733 RVA: 0x01257D1B File Offset: 0x01255F1B
		public string KRMAINLAND_SDK_EVENT_KEY_REASON { get; set; }
	}

	// Token: 0x02006661 RID: 26209
	[NullableContext(0)]
	public class ISdkCustomerService
	{
		// Token: 0x04021E7B RID: 138875
		[Nullable(1)]
		public string cuid;

		// Token: 0x04021E7C RID: 138876
		public int isredot;
	}
}
