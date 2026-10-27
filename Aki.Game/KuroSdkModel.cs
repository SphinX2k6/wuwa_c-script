using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E2D RID: 3629
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class KuroSdkModel : ModelBase
{
	// Token: 0x06005717 RID: 22295 RVA: 0x000FA38C File Offset: 0x000F858C
	public KuroSdkModel()
	{
		this.ReportedInitState = false;
		this.QueryProductInfoMap = new Dictionary<string, QueryProductSt>();
		this.SdkTrophyInfoMap = new Dictionary<string, ISdkTrophyInfo>();
		this.CanUseSdk = false;
		this.CurrentPayItemName = "";
		this.SdkGetFocusState = false;
		this.SdkBlockUserMap = new Dictionary<string, bool>();
		this.GetSdkBlockUserState = false;
		this.PlayStationPlayOnlyState = false;
		this.CurrentProgressActivityIndex = -1;
		this.CurrentPayingOrderId = "";
		this.NeedOpenReviewState = false;
		this.ReviewDelay = 0;
		this.CurrentReviewId = 0;
		this.NeedReviewConfirmBox = false;
		this.NoticeRedDotState = false;
		this.NoticeSign = "1";
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x000FA450 File Offset: 0x000F8650
	protected override bool OnInit()
	{
		this.CanUseSdk = (UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1");
		KuroSdkReport.Instance.Init();
		this.InitSdkTrophyInfo();
		this.InitProgressActivityList();
		return true;
	}

	// Token: 0x06005719 RID: 22297 RVA: 0x000FA4A3 File Offset: 0x000F86A3
	public void OnGetSdkBlockUserMap(Dictionary<string, bool> blockUserMap)
	{
		this.SdkBlockUserMap = blockUserMap;
		this.GetSdkBlockUserState = true;
	}

	// Token: 0x0600571A RID: 22298 RVA: 0x000FA4B4 File Offset: 0x000F86B4
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public UniTask<Dictionary<string, bool>> GetSdkBlockUserMap()
	{
		KuroSdkModel.<GetSdkBlockUserMap>d__38 <GetSdkBlockUserMap>d__;
		<GetSdkBlockUserMap>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, bool>>.Create();
		<GetSdkBlockUserMap>d__.<>4__this = this;
		<GetSdkBlockUserMap>d__.<>1__state = -1;
		<GetSdkBlockUserMap>d__.<>t__builder.Start<KuroSdkModel.<GetSdkBlockUserMap>d__38>(ref <GetSdkBlockUserMap>d__);
		return <GetSdkBlockUserMap>d__.<>t__builder.Task;
	}

	// Token: 0x0600571B RID: 22299 RVA: 0x000FA4F8 File Offset: 0x000F86F8
	private UniTask InitSdkTrophyInfo()
	{
		KuroSdkModel.<InitSdkTrophyInfo>d__39 <InitSdkTrophyInfo>d__;
		<InitSdkTrophyInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSdkTrophyInfo>d__.<>4__this = this;
		<InitSdkTrophyInfo>d__.<>1__state = -1;
		<InitSdkTrophyInfo>d__.<>t__builder.Start<KuroSdkModel.<InitSdkTrophyInfo>d__39>(ref <InitSdkTrophyInfo>d__);
		return <InitSdkTrophyInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x000FA53B File Offset: 0x000F873B
	public Dictionary<string, ISdkTrophyInfo> GetSdkTrophyInfo()
	{
		return this.SdkTrophyInfoMap;
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x000FA544 File Offset: 0x000F8744
	public void InitProgressActivityList()
	{
		IReadOnlyList<PlayStationActivityConfig> configList = ConfigPlayStationActivityConfigAll.GetConfigList(true);
		if (configList == null || configList.Count == 0)
		{
			return;
		}
		int count = configList.Count;
		this.ProgressActivityList = new PlayStationActivityConfig[count];
		for (int i = 0; i < count; i++)
		{
			this.ProgressActivityList[i] = configList[i];
		}
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x000FA598 File Offset: 0x000F8798
	public void UpdateActivityProgress(int currentFinishQuestId = 0)
	{
		bool flag = false;
		int nextProgressActivityQuestId = this.GetNextProgressActivityQuestId();
		if (currentFinishQuestId == 0 || (currentFinishQuestId != 0 && currentFinishQuestId == nextProgressActivityQuestId))
		{
			flag = true;
		}
		bool flag2 = false;
		if (flag)
		{
			int currentProgressActivityIndex = this.CurrentProgressActivityIndex;
			flag2 = this.UpdateDynamicActivityProgress(currentProgressActivityIndex);
		}
		bool flag3 = this.UpdateStaticActivityProgress();
		if (flag2 || flag3)
		{
			this.UpdateActivityAvailability();
		}
	}

	// Token: 0x0600571F RID: 22303 RVA: 0x000FA5E4 File Offset: 0x000F87E4
	private bool UpdateStaticActivityProgress()
	{
		IReadOnlyList<PlayStationStaticActivity> configList = ConfigPlayStationStaticActivityAll.GetConfigList(true);
		if (configList == null || configList.Count == 0)
		{
			return false;
		}
		bool result = false;
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		QuestNewModel instance = QuestNewModel.Instance;
		foreach (PlayStationStaticActivity playStationStaticActivity in configList)
		{
			if (instance.CheckQuestFinished(playStationStaticActivity.QuestId) && !this.CurrentOpeningStaticActivityList.Contains(playStationStaticActivity.ActivityStringId))
			{
				platformSdk.StartActivity(playStationStaticActivity.ActivityStringId);
				if (!this.CurrentOpeningStaticActivityList.Contains(playStationStaticActivity.ActivityStringId))
				{
					this.CurrentOpeningStaticActivityList.Add(playStationStaticActivity.ActivityStringId);
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x06005720 RID: 22304 RVA: 0x000FA6AC File Offset: 0x000F88AC
	private bool UpdateDynamicActivityProgress(int oldCurrentProgressActivityIndex)
	{
		if (this.ProgressActivityList == null)
		{
			return false;
		}
		int num = this.ProgressActivityList.Length;
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		QuestNewModel instance = QuestNewModel.Instance;
		int num2 = this.CurrentProgressActivityIndex;
		for (int i = num2 + 1; i < num; i++)
		{
			PlayStationActivityConfig playStationActivityConfig = this.ProgressActivityList[num2];
			PlayStationActivityConfig playStationActivityConfig2 = this.ProgressActivityList[i];
			if (playStationActivityConfig2.QuestId != 0 && !instance.CheckQuestFinished(playStationActivityConfig2.QuestId))
			{
				break;
			}
			platformSdk.EndActivity(playStationActivityConfig.ActivityStringId);
			platformSdk.StartActivity(playStationActivityConfig2.ActivityStringId);
			this.CurrentProgressActivityIndex = i;
			num2++;
		}
		return oldCurrentProgressActivityIndex != this.CurrentProgressActivityIndex;
	}

	// Token: 0x06005721 RID: 22305 RVA: 0x000FA760 File Offset: 0x000F8960
	public void UpdateActivityAvailability()
	{
		if (this.ProgressActivityList == null || this.CurrentProgressActivityIndex < 0 || this.CurrentProgressActivityIndex >= this.ProgressActivityList.Length)
		{
			return;
		}
		TArray<string> tarray = new TArray<string>();
		TArray<string> tarray2 = new TArray<string>();
		for (int i = 0; i < this.ProgressActivityList.Length; i++)
		{
			if (i == this.CurrentProgressActivityIndex)
			{
				tarray.Add(this.ProgressActivityList[i].ActivityStringId);
			}
			else
			{
				string activityStringId = this.ProgressActivityList[i].ActivityStringId;
				if (!this.CurrentOpeningStaticActivityList.Contains(activityStringId))
				{
					tarray2.Add(activityStringId);
				}
			}
		}
		foreach (string value in this.CurrentOpeningStaticActivityList)
		{
			if (!tarray.Contains(value))
			{
				tarray.Add(value);
			}
		}
		PlatformSdkManagerNew.Instance.GetPlatformSdk().ChangeActivityAvailability(tarray, tarray2);
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x000FA85C File Offset: 0x000F8A5C
	public int GetNextProgressActivityQuestId()
	{
		if (this.ProgressActivityList == null || this.CurrentProgressActivityIndex < 0 || this.CurrentProgressActivityIndex + 1 >= this.ProgressActivityList.Length)
		{
			return -1;
		}
		return this.ProgressActivityList[this.CurrentProgressActivityIndex + 1].QuestId;
	}

	// Token: 0x06005723 RID: 22307 RVA: 0x000FA89C File Offset: 0x000F8A9C
	public void OnQueryProductInfo([Nullable(new byte[]
	{
		2,
		1
	})] QueryProductSt[] data)
	{
		if (data != null)
		{
			foreach (QueryProductSt queryProductSt in data)
			{
				if (queryProductSt.GoodId != null)
				{
					this.QueryProductInfoMap[queryProductSt.GoodId] = queryProductSt;
				}
			}
		}
		CustomPromise<bool> queryPromise = this.QueryPromise;
		if (queryPromise != null)
		{
			queryPromise.SetResult(true);
		}
		this.QueryPromise = null;
	}

	// Token: 0x06005724 RID: 22308 RVA: 0x000FA8F4 File Offset: 0x000F8AF4
	public string GetQueryProductCurrency(string payId)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return "";
		}
		Pay? payConf = PayItemConfig.Instance.GetPayConf(int.Parse(payId));
		QueryProductSt queryProductSt;
		if (payConf != null && this.QueryProductInfoMap.TryGetValue(payConf.Value.ProductId, out queryProductSt) && !string.IsNullOrEmpty(queryProductSt.Currency))
		{
			return queryProductSt.Currency;
		}
		return "";
	}

	// Token: 0x06005725 RID: 22309 RVA: 0x000FA964 File Offset: 0x000F8B64
	public float GetQueryProductPrice(string payId)
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			Pay? pay;
			string text = (PayItemConfig.Instance.GetPayConf(int.Parse(payId)) != null) ? pay.GetValueOrDefault().ProductId : null;
			DisplayProductInfo productInfoByGoodsId = PayItemModel.Instance.GetProductInfoByGoodsId(text ?? "");
			float result;
			if (productInfoByGoodsId != null && productInfoByGoodsId.Price != null && float.TryParse(productInfoByGoodsId.Price, out result))
			{
				return result;
			}
			return 0f;
		}
		else
		{
			Pay? payConf = PayItemConfig.Instance.GetPayConf(int.Parse(payId));
			QueryProductSt queryProductSt;
			if (payConf != null && this.QueryProductInfoMap.TryGetValue(payConf.Value.ProductId, out queryProductSt) && queryProductSt.Price != null)
			{
				return queryProductSt.Price.Value;
			}
			return 0f;
		}
	}

	// Token: 0x06005726 RID: 22310 RVA: 0x000FAA3C File Offset: 0x000F8C3C
	[return: Nullable(2)]
	public string GetQueryProductShowPrice(string payId)
	{
		if (!PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			Pay? payConf = PayItemConfig.Instance.GetPayConf(int.Parse(payId));
			QueryProductSt queryProductSt;
			if (payConf != null && this.QueryProductInfoMap.TryGetValue(payConf.Value.ProductId, out queryProductSt) && !string.IsNullOrEmpty(queryProductSt.Currency) && queryProductSt.Price != null)
			{
				float? price = queryProductSt.Price;
				float num = 0f;
				if (!(price.GetValueOrDefault() == num & price != null))
				{
					string currency = queryProductSt.Currency;
					price = queryProductSt.Price;
					return currency + price.ToString();
				}
			}
			return null;
		}
		Pay? pay;
		string goodsId = (PayItemConfig.Instance.GetPayConf(int.Parse(payId)) != null) ? pay.GetValueOrDefault().ProductId : null;
		DisplayProductInfo productInfoByGoodsId = PayItemModel.Instance.GetProductInfoByGoodsId(goodsId);
		if (productInfoByGoodsId != null)
		{
			return productInfoByGoodsId.Price;
		}
		if (!PlatformSdkManagerNew.Instance.GetPlatformSdk().GetIfShowDefaultPrice())
		{
			return " ";
		}
		return null;
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x000FAB4C File Offset: 0x000F8D4C
	[return: Nullable(2)]
	public string GetQueryProductName(string payId)
	{
		Pay? payConf = PayItemConfig.Instance.GetPayConf(int.Parse(payId));
		QueryProductSt queryProductSt;
		if (payConf != null && this.QueryProductInfoMap.TryGetValue(payConf.Value.ProductId, out queryProductSt))
		{
			return queryProductSt.Name;
		}
		return null;
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x000FAB9C File Offset: 0x000F8D9C
	[return: Nullable(2)]
	public string GetQueryProductDesc(string payId)
	{
		Pay? payConf = PayItemConfig.Instance.GetPayConf(int.Parse(payId));
		QueryProductSt queryProductSt;
		if (payConf != null && this.QueryProductInfoMap.TryGetValue(payConf.Value.ProductId, out queryProductSt))
		{
			return queryProductSt.Desc;
		}
		return null;
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x000FABE9 File Offset: 0x000F8DE9
	[NullableContext(2)]
	public FBasicInfo GetBasicInfo()
	{
		if (!this.CanUseSdk)
		{
			return null;
		}
		FBasicInfo baseInfo = this.BaseInfo;
		if (baseInfo != null && baseInfo.bIsValid)
		{
			return this.BaseInfo;
		}
		this.BaseInfo = UKuroSDKManager.GetBasicInfo();
		return this.BaseInfo;
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x000FAC24 File Offset: 0x000F8E24
	public string GetDeviceFontAsset()
	{
		string fontAsset = this.GetFontAsset();
		return this.GetFontPlatformName(fontAsset);
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x000FAC40 File Offset: 0x000F8E40
	public string GetFontAsset()
	{
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		if (packageLanguage != null)
		{
			int length = packageLanguage.Length;
			if (length == 2)
			{
				switch (packageLanguage[1])
				{
				case 'a':
					if (packageLanguage == "ja")
					{
						return "MotoyaAporoStdW5.otf";
					}
					break;
				case 'd':
					if (packageLanguage == "id")
					{
						return "LaguSansBold.otf";
					}
					break;
				case 'e':
					if (packageLanguage == "de")
					{
						return "LaguSansBold.otf";
					}
					break;
				case 'h':
					if (packageLanguage == "th")
					{
						return "Kanit-Medium.ttf";
					}
					break;
				case 'i':
					if (packageLanguage == "vi")
					{
						return "LaguSansBold.otf";
					}
					break;
				case 'n':
					if (packageLanguage == "en")
					{
						return "LaguSansBold.otf";
					}
					break;
				case 'o':
					if (packageLanguage == "ko")
					{
						return "SUITE-Bold.otf";
					}
					break;
				case 'r':
					if (packageLanguage == "fr")
					{
						return "LaguSansBold.otf";
					}
					break;
				case 's':
					if (packageLanguage == "es")
					{
						return "LaguSansBold.otf";
					}
					break;
				case 't':
					if (packageLanguage == "pt")
					{
						return "LaguSansBold.otf";
					}
					break;
				case 'u':
					if (packageLanguage == "ru")
					{
						return "LaguSansBold.otf";
					}
					break;
				}
			}
		}
		return "H7GBKHeavy.TTF";
	}

	// Token: 0x0600572C RID: 22316 RVA: 0x000FADE0 File Offset: 0x000F8FE0
	private string GetFontPlatformName(string source)
	{
		if (!Platform.Instance.IsIOSPlatform() && !Platform.Instance.IsMacPlatform())
		{
			return source;
		}
		if (source == "LaguSansBold.otf")
		{
			return "LaguSans-Bold.otf";
		}
		if (source == "H7GBKHeavy.TTF")
		{
			return "ARFangXinShuH7GBK-Heavy.TTF";
		}
		if (source == "MotoyaAporoStdW5.otf")
		{
			return "MotoyaAporoStd-W5.otf";
		}
		if (source == "SUITE-Bold.otf")
		{
			return "SUITE-Bold.otf";
		}
		if (source == "Kanit-Medium.ttf")
		{
			return "Kanit-Medium.ttf";
		}
		return source;
	}

	// Token: 0x0600572D RID: 22317 RVA: 0x000FAE68 File Offset: 0x000F9068
	public string GetCurrentFontName()
	{
		string fontAsset = this.GetFontAsset();
		if (fontAsset == "LaguSansBold.otf")
		{
			return "Lagu Sans";
		}
		if (fontAsset == "H7GBKHeavy.TTF")
		{
			return "文鼎方新书H7GBK_H";
		}
		if (fontAsset == "MotoyaAporoStdW5.otf")
		{
			return "Motoya Aporo Std W5";
		}
		if (fontAsset == "SUITE-Bold.otf")
		{
			return "SUITE";
		}
		if (!(fontAsset == "Kanit-Medium.ttf"))
		{
			return "文鼎方新书H7GBK_H";
		}
		return "Kanit Medium";
	}

	// Token: 0x0600572E RID: 22318 RVA: 0x000FAEE4 File Offset: 0x000F90E4
	public void OnSdkFocusChange(bool sdkGetFocusState)
	{
		this.SdkGetFocusState = sdkGetFocusState;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "OnSdkFocusChange";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", sdkGetFocusState);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.SdkGetFocusState)
		{
			UiNavigationGlobalData.AddBlockListenerFocusTag("SdkFocus");
		}
		else
		{
			UiNavigationGlobalData.DeleteBlockListenerFocusTag("SdkFocus");
		}
		InputDistributeController.Instance.RefreshInputTag();
		EventSystem.Instance.Emit<bool>(EEventName.OnSdkFocusStateChange, this.SdkGetFocusState);
	}

	// Token: 0x0600572F RID: 22319 RVA: 0x000FAF62 File Offset: 0x000F9162
	public bool GetSdkFocusState()
	{
		return this.SdkGetFocusState;
	}

	// Token: 0x06005730 RID: 22320 RVA: 0x000FAF6A File Offset: 0x000F916A
	public void SetPlayStationPlayOnlyState(bool state)
	{
		this.PlayStationPlayOnlyState = state;
		KuroSdkController.Instance.SetPlayOnly(state);
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.PlayStationOnly);
	}

	// Token: 0x06005731 RID: 22321 RVA: 0x000FAF93 File Offset: 0x000F9193
	public void SetXboxPlayOnlyState(bool state)
	{
		this.XboxPlayOnlyState = state;
		KuroSdkController.Instance.SetPlayOnly(state);
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.XboxOnly);
	}

	// Token: 0x06005732 RID: 22322 RVA: 0x000FAFBC File Offset: 0x000F91BC
	[NullableContext(2)]
	public string GetSdkPackageId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetProductId();
		}
		return KuroSdkController.Instance.GetPackageId();
	}

	// Token: 0x06005733 RID: 22323 RVA: 0x000FAFE4 File Offset: 0x000F91E4
	[NullableContext(2)]
	public void SetEntryPointData(PostWebViewEntryPointData data)
	{
		this.EntryPointData = data;
	}

	// Token: 0x06005734 RID: 22324 RVA: 0x000FAFED File Offset: 0x000F91ED
	[NullableContext(2)]
	public PostWebViewEntryPointData GetEntryPointData()
	{
		return this.EntryPointData;
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x000FAFF5 File Offset: 0x000F91F5
	[NullableContext(2)]
	public void SetIntroductionData(IntroductionData data)
	{
		this.IntroductionData = data;
		this.RefreshIntroductionRedDotState();
	}

	// Token: 0x06005736 RID: 22326 RVA: 0x000FB004 File Offset: 0x000F9204
	[NullableContext(2)]
	public IntroductionData GetIntroductionData()
	{
		return this.IntroductionData;
	}

	// Token: 0x06005737 RID: 22327 RVA: 0x000FB00C File Offset: 0x000F920C
	private void RefreshIntroductionRedDotState()
	{
		string s = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.IntroductionVersion) as ServerStorageString).Get() ?? "";
		long num = 0L;
		long.TryParse(s, out num);
		if (this.IntroductionData != null && this.IntroductionData.version != num)
		{
			this.IntroductionNoticeState = true;
		}
		else
		{
			this.IntroductionNoticeState = false;
		}
		EventSystem.Instance.Emit(EEventName.SdkIntroductionRedPointRefresh);
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x000FB07C File Offset: 0x000F927C
	public void SaveCurrentClickIntroductionVersion()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.IntroductionVersion) as ServerStorageString).Set((this.IntroductionData != null) ? this.IntroductionData.version.ToString() : "");
		this.IntroductionNoticeState = false;
		EventSystem.Instance.Emit(EEventName.SdkIntroductionRedPointRefresh);
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x000FB0D5 File Offset: 0x000F92D5
	public int GetNoticePlatformId()
	{
		if (Platform.Instance.IsAndroidPlatform())
		{
			return 2;
		}
		if (Platform.Instance.IsIOSPlatform())
		{
			return 3;
		}
		if (Platform.Instance.IsPs5Platform())
		{
			return 4;
		}
		if (Platform.Instance.IsMacPlatform())
		{
			return 5;
		}
		return 1;
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x000FB110 File Offset: 0x000F9310
	public NoticeContentData[] FilterCurrentNeedShowNoticeContent(NoticeData source, string roleId)
	{
		List<NoticeContentData> list = new List<NoticeContentData>();
		string channelId = KuroSdkController.Instance.GetChannelId();
		NoticeContentData[] game = source.game;
		NoticeContentData[] activity = source.activity;
		List<NoticeContentData> list2 = new List<NoticeContentData>();
		list2.AddRange(game);
		list2.AddRange(activity);
		int noticePlatformId = this.GetNoticePlatformId();
		foreach (NoticeContentData noticeContentData in list2)
		{
			bool flag = roleId != "0";
			if (this.CheckNoticeContentInValidTime(noticeContentData) && this.CheckNoticeContentInWhiteList(noticeContentData, roleId) && (noticeContentData.permanent != 0 || flag) && this.CheckNoticeContentInChannel(noticeContentData, channelId) && this.CheckNoticeContentInPlatform(noticeContentData, noticePlatformId))
			{
				list.Add(noticeContentData);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x000FB1E8 File Offset: 0x000F93E8
	private bool CheckNoticeContentInValidTime(NoticeContentData data)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = data.startTimeMs / 1000.0;
		double num2 = data.endTimeMs / 1000.0;
		return serverTime >= num && serverTime <= num2;
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x000FB230 File Offset: 0x000F9430
	private bool CheckNoticeContentInWhiteList(NoticeContentData data, string roleId)
	{
		bool result = true;
		if (data.whiteList.Length != 0)
		{
			int[] whiteList = data.whiteList;
			for (int i = 0; i < whiteList.Length; i++)
			{
				if (whiteList[i] == int.Parse(roleId))
				{
					return true;
				}
			}
			result = false;
		}
		return result;
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x000FB270 File Offset: 0x000F9470
	private bool CheckNoticeContentInChannel(NoticeContentData data, string channelId)
	{
		bool result = true;
		if (data.channel.Length != 0)
		{
			string[] channel = data.channel;
			for (int i = 0; i < channel.Length; i++)
			{
				if (channel[i] == channelId)
				{
					return true;
				}
			}
			result = false;
		}
		return result;
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x000FB2B0 File Offset: 0x000F94B0
	private bool CheckNoticeContentInPlatform(NoticeContentData data, int platformId)
	{
		bool result = true;
		if (data.platform.Length != 0)
		{
			int[] platform = data.platform;
			for (int i = 0; i < platform.Length; i++)
			{
				if (platform[i] == platformId)
				{
					return true;
				}
			}
			result = false;
		}
		return result;
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x000FB2E8 File Offset: 0x000F94E8
	public string GetNoticeContentUrl(int currentIndex)
	{
		if (KuroSdkModel.Instance.GetEntryPointData() == null)
		{
			return "";
		}
		PostWebViewEntryPointData entryPointData = KuroSdkModel.Instance.GetEntryPointData();
		if (currentIndex >= entryPointData.contentUrl.Length)
		{
			return entryPointData.contentUrl[currentIndex - 1];
		}
		return entryPointData.contentUrl[currentIndex];
	}

	// Token: 0x06005740 RID: 22336 RVA: 0x000FB330 File Offset: 0x000F9530
	public string GetQueryNoticeReadStateUrl(int currentIndex = 0)
	{
		if (KuroSdkModel.Instance.GetEntryPointData() == null)
		{
			return "";
		}
		string apiUrl = this.GetApiUrl(currentIndex);
		string value = (PlayerInfoModel.Instance.GetId() == null) ? "0" : PlayerInfoModel.Instance.GetId().ToString();
		string noticeSign = KuroSdkModel.Instance.NoticeSign;
		string currentLoginServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 4);
		defaultInterpolatedStringHandler.AppendFormatted(apiUrl);
		defaultInterpolatedStringHandler.AppendLiteral("/notice/read-ids/list?uid=");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("&sign=");
		defaultInterpolatedStringHandler.AppendFormatted(noticeSign);
		defaultInterpolatedStringHandler.AppendLiteral("&serverId=");
		defaultInterpolatedStringHandler.AppendFormatted(currentLoginServerId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005741 RID: 22337 RVA: 0x000FB3F8 File Offset: 0x000F95F8
	public string GetEntryPointUrl()
	{
		string currentLoginServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
		defaultInterpolatedStringHandler.AppendFormatted(PublicUtil.Instance.GetNoticeBaseUrl());
		defaultInterpolatedStringHandler.AppendLiteral("/gamenotice/");
		defaultInterpolatedStringHandler.AppendFormatted(PublicUtil.Instance.GetGameId());
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(currentLoginServerId);
		defaultInterpolatedStringHandler.AppendLiteral("/entrypoint.json");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005742 RID: 22338 RVA: 0x000FB470 File Offset: 0x000F9670
	private string GetNoticePreUrl(int currentIndex = 0)
	{
		if (KuroSdkModel.Instance.GetEntryPointData() == null)
		{
			return "";
		}
		PostWebViewEntryPointData entryPointData = KuroSdkModel.Instance.GetEntryPointData();
		if (currentIndex >= entryPointData.h5AppUrl.Length)
		{
			return entryPointData.h5AppUrl[currentIndex - 1];
		}
		return entryPointData.h5AppUrl[currentIndex];
	}

	// Token: 0x06005743 RID: 22339 RVA: 0x000FB4B8 File Offset: 0x000F96B8
	public string GetPlatformStr()
	{
		if (Platform.Instance.IsAndroidPlatform())
		{
			return "Android";
		}
		if (Platform.Instance.IsIOSPlatform())
		{
			return "iOS";
		}
		if (Platform.Instance.IsMacPlatform())
		{
			return "Mac";
		}
		if (Platform.Instance.IsPs5Platform())
		{
			return "PS5";
		}
		if (Platform.Instance.IsXSXPlatform())
		{
			return "XSX";
		}
		if (Platform.Instance.IsWinGDKPlatform())
		{
			return "WinGDK";
		}
		if (Platform.Instance.IsOpenHarmonyPlatform())
		{
			return "OpenHarmony";
		}
		return "PC";
	}

	// Token: 0x06005744 RID: 22340 RVA: 0x000FB548 File Offset: 0x000F9748
	public string GetNoticeUrl(int currentIndex = 0, EOpenNoticeStage stage = EOpenNoticeStage.Normal)
	{
		string noticePreUrl = this.GetNoticePreUrl(currentIndex);
		string currentLoginServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		string deviceDid = KuroSdkController.Instance.GetDeviceDid();
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		string value = KuroSdkController.Instance.GetIfGlobalSdk() ? "global" : "cn";
		string gameId = PublicUtil.Instance.GetGameId();
		string channelId = KuroSdkController.Instance.GetChannelId();
		string platformStr = this.GetPlatformStr();
		string noticeSign = KuroSdkModel.Instance.NoticeSign;
		string value2 = UKuroStaticLibrary.Base64Encode(PublicUtil.Instance.GetPublicInfo());
		string value3;
		string value4;
		if (stage == EOpenNoticeStage.BeforeLogin)
		{
			value3 = "before_login";
			value4 = "1000000000";
		}
		else
		{
			SdkLoginInfo sdkLoginInfo = LoginModel.Instance.GetSdkLoginInfo();
			value3 = (((sdkLoginInfo != null) ? sdkLoginInfo.Uid : null) ?? "");
			value4 = ((instance.GetId() == null) ? "0" : instance.GetId().ToString());
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(96, 12);
		defaultInterpolatedStringHandler.AppendFormatted(noticePreUrl);
		defaultInterpolatedStringHandler.AppendLiteral("?server_id=");
		defaultInterpolatedStringHandler.AppendFormatted(currentLoginServerId);
		defaultInterpolatedStringHandler.AppendLiteral("&lang=");
		defaultInterpolatedStringHandler.AppendFormatted(packageLanguage);
		defaultInterpolatedStringHandler.AppendLiteral("&did=");
		defaultInterpolatedStringHandler.AppendFormatted(deviceDid);
		defaultInterpolatedStringHandler.AppendLiteral("&role_id=");
		defaultInterpolatedStringHandler.AppendFormatted(value4);
		defaultInterpolatedStringHandler.AppendLiteral("&svr_area=");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("&game_id=");
		defaultInterpolatedStringHandler.AppendFormatted(gameId);
		defaultInterpolatedStringHandler.AppendLiteral("&channel=");
		defaultInterpolatedStringHandler.AppendFormatted(channelId);
		defaultInterpolatedStringHandler.AppendLiteral("&platform=");
		defaultInterpolatedStringHandler.AppendFormatted(platformStr);
		defaultInterpolatedStringHandler.AppendLiteral("&user_id=");
		defaultInterpolatedStringHandler.AppendFormatted(value3);
		defaultInterpolatedStringHandler.AppendLiteral("&sign=");
		defaultInterpolatedStringHandler.AppendFormatted(noticeSign);
		defaultInterpolatedStringHandler.AppendLiteral("&login_info=");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005745 RID: 22341 RVA: 0x000FB740 File Offset: 0x000F9940
	public string GetQueryNoticeRedDotStateUrl(int currentIndex = 0)
	{
		if (KuroSdkModel.Instance.GetEntryPointData() == null)
		{
			return "";
		}
		string apiUrl = this.GetApiUrl(currentIndex);
		string currentLoginServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		string value = (PlayerInfoModel.Instance.GetId() == null) ? "0" : PlayerInfoModel.Instance.GetId().ToString();
		string noticeSign = KuroSdkModel.Instance.NoticeSign;
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		string channelId = KuroSdkController.Instance.GetChannelId();
		string platformStr = this.GetPlatformStr();
		string gameId = PublicUtil.Instance.GetGameId();
		string value2 = KuroSdkController.Instance.GetIfGlobalSdk() ? "global" : "cn";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(86, 9);
		defaultInterpolatedStringHandler.AppendFormatted(apiUrl);
		defaultInterpolatedStringHandler.AppendLiteral("/notice/red-dot/get?uid=");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("&sign=");
		defaultInterpolatedStringHandler.AppendFormatted(noticeSign);
		defaultInterpolatedStringHandler.AppendLiteral("&serverId=");
		defaultInterpolatedStringHandler.AppendFormatted(currentLoginServerId);
		defaultInterpolatedStringHandler.AppendLiteral("&language=");
		defaultInterpolatedStringHandler.AppendFormatted(packageLanguage);
		defaultInterpolatedStringHandler.AppendLiteral("&channel=");
		defaultInterpolatedStringHandler.AppendFormatted(channelId);
		defaultInterpolatedStringHandler.AppendLiteral("&platform=");
		defaultInterpolatedStringHandler.AppendFormatted(platformStr);
		defaultInterpolatedStringHandler.AppendLiteral("&gameId=");
		defaultInterpolatedStringHandler.AppendFormatted(gameId);
		defaultInterpolatedStringHandler.AppendLiteral("&svrArea=");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005746 RID: 22342 RVA: 0x000FB8B8 File Offset: 0x000F9AB8
	private string GetApiUrl(int currentIndex = 0)
	{
		PostWebViewEntryPointData entryPointData = KuroSdkModel.Instance.GetEntryPointData();
		if (entryPointData == null)
		{
			return "";
		}
		if (entryPointData.apiUrls != null && entryPointData.apiUrls.Length != 0)
		{
			int num = (currentIndex < entryPointData.apiUrls.Length) ? currentIndex : (entryPointData.apiUrls.Length - 1);
			return entryPointData.apiUrls[num];
		}
		return entryPointData.apiUrl;
	}

	// Token: 0x06005747 RID: 22343 RVA: 0x000FB914 File Offset: 0x000F9B14
	public string GetIntroductionVersionUrl()
	{
		string text = "";
		if (this.GmIntroductionLink != "")
		{
			text = this.GmIntroductionLink;
		}
		if (text == "")
		{
			if (KuroSdkController.Instance.GetIfGlobalSdk())
			{
				text = CommonConfig.Instance.GetGuideOverseaLinkUrl();
			}
			else
			{
				text = CommonConfig.Instance.GetGuideMainlandLinkUrl();
			}
		}
		return text + "/introduction/redot.json";
	}

	// Token: 0x06005748 RID: 22344 RVA: 0x000FB97C File Offset: 0x000F9B7C
	public void OnMatchTeamNotify(MatchTeamInfo matchTeamInfo)
	{
		foreach (MatchPlayerInfo matchPlayerInfo in matchTeamInfo.PlayerInfos)
		{
			if (!string.IsNullOrEmpty(matchPlayerInfo.XboxOnlineId))
			{
				this.RefreshPlayerChatPermission(matchPlayerInfo.PlayerId, matchPlayerInfo.XboxOnlineId);
			}
		}
	}

	// Token: 0x06005749 RID: 22345 RVA: 0x000FB9E4 File Offset: 0x000F9BE4
	public void RefreshPlayerChatPermissionByPlayerDetails(PlayerDetails playerDetails)
	{
		if (!string.IsNullOrEmpty(playerDetails.XboxUserId))
		{
			this.RefreshPlayerChatPermission(playerDetails.PlayerId, playerDetails.XboxUserId);
		}
	}

	// Token: 0x0600574A RID: 22346 RVA: 0x000FBA08 File Offset: 0x000F9C08
	public void RefreshPlayerChatPermission(int playerId, string userId)
	{
		KuroSdkController.Instance.CheckPermission(userId, ESdkPermission.CommunicateUsingText, delegate(bool result)
		{
			this.PlayerChatPermissionMap[playerId] = result;
		});
	}

	// Token: 0x0600574B RID: 22347 RVA: 0x000FBA41 File Offset: 0x000F9C41
	public bool GetPlayerChatPermission(int playerId)
	{
		return this.PlayerChatPermissionMap.GetValueOrDefault(playerId, true);
	}

	// Token: 0x0600574C RID: 22348 RVA: 0x000FBA50 File Offset: 0x000F9C50
	public EXboxMultiplayerActivityJoinRestriction GetRoomRestriction()
	{
		EPlayStationJoinAble gameJoinTypeToPlayStationJoinType = OnlineModel.Instance.GetGameJoinTypeToPlayStationJoinType();
		EXboxMultiplayerActivityJoinRestriction result;
		if (gameJoinTypeToPlayStationJoinType == EPlayStationJoinAble.Anyone)
		{
			result = EXboxMultiplayerActivityJoinRestriction.Activity_Public;
		}
		else if (gameJoinTypeToPlayStationJoinType == EPlayStationJoinAble.Friends)
		{
			result = EXboxMultiplayerActivityJoinRestriction.Activity_Followed;
		}
		else if (gameJoinTypeToPlayStationJoinType == EPlayStationJoinAble.NoOne)
		{
			result = EXboxMultiplayerActivityJoinRestriction.Activity_InviteOnly;
		}
		else
		{
			result = EXboxMultiplayerActivityJoinRestriction.Activity_Followed;
		}
		return result;
	}

	// Token: 0x1700064E RID: 1614
	// (get) Token: 0x0600574D RID: 22349 RVA: 0x000FBA85 File Offset: 0x000F9C85
	public static KuroSdkModel Instance
	{
		get
		{
			return KuroSdkModel._Instance;
		}
	}

	// Token: 0x0600574E RID: 22350 RVA: 0x000FBA8C File Offset: 0x000F9C8C
	public static KuroSdkModel GetOrCreateInstance()
	{
		if (KuroSdkModel._Instance == null)
		{
			KuroSdkModel.CreateInstance();
		}
		return KuroSdkModel._Instance;
	}

	// Token: 0x0600574F RID: 22351 RVA: 0x000FBAA0 File Offset: 0x000F9CA0
	public static bool CreateInstance()
	{
		if (KuroSdkModel._Instance != null)
		{
			return true;
		}
		KuroSdkModel._Instance = new KuroSdkModel();
		return true;
	}

	// Token: 0x06005750 RID: 22352 RVA: 0x000FBAB6 File Offset: 0x000F9CB6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005751 RID: 22353 RVA: 0x000FBAB8 File Offset: 0x000F9CB8
	public static void ResetStaticDefaultValue()
	{
		KuroSdkModel._Instance = null;
	}

	// Token: 0x06005752 RID: 22354 RVA: 0x000FBAC0 File Offset: 0x000F9CC0
	static KuroSdkModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkModel.CreateStaticDefaultValue), new Action(KuroSdkModel.ResetStaticDefaultValue));
	}

	// Token: 0x04002814 RID: 10260
	private const string LAGUSANSBOLD = "LaguSansBold.otf";

	// Token: 0x04002815 RID: 10261
	private const string MOTOYTA = "MotoyaAporoStdW5.otf";

	// Token: 0x04002816 RID: 10262
	private const string SUITEBOLD = "SUITE-Bold.otf";

	// Token: 0x04002817 RID: 10263
	private const string H7GBKHEAVY = "H7GBKHeavy.TTF";

	// Token: 0x04002818 RID: 10264
	private const string KANIT = "Kanit-Medium.ttf";

	// Token: 0x04002819 RID: 10265
	private const string DEFAULTEMPTY = " ";

	// Token: 0x0400281A RID: 10266
	public bool ReportedInitState;

	// Token: 0x0400281B RID: 10267
	[Nullable(2)]
	private FBasicInfo BaseInfo;

	// Token: 0x0400281C RID: 10268
	private readonly Dictionary<string, QueryProductSt> QueryProductInfoMap;

	// Token: 0x0400281D RID: 10269
	private Dictionary<string, ISdkTrophyInfo> SdkTrophyInfoMap;

	// Token: 0x0400281E RID: 10270
	public bool CanUseSdk;

	// Token: 0x0400281F RID: 10271
	public string CurrentPayItemName;

	// Token: 0x04002820 RID: 10272
	public bool SdkGetFocusState;

	// Token: 0x04002821 RID: 10273
	public Dictionary<string, bool> SdkBlockUserMap;

	// Token: 0x04002822 RID: 10274
	private bool GetSdkBlockUserState;

	// Token: 0x04002823 RID: 10275
	public bool PlayStationPlayOnlyState;

	// Token: 0x04002824 RID: 10276
	public bool XboxPlayOnlyState;

	// Token: 0x04002825 RID: 10277
	[Nullable(2)]
	public string UserId;

	// Token: 0x04002826 RID: 10278
	[Nullable(2)]
	public string OnlineId;

	// Token: 0x04002827 RID: 10279
	private int CurrentProgressActivityIndex;

	// Token: 0x04002828 RID: 10280
	[Nullable(2)]
	private PlayStationActivityConfig[] ProgressActivityList;

	// Token: 0x04002829 RID: 10281
	[Nullable(2)]
	public string AccountId;

	// Token: 0x0400282A RID: 10282
	public string CurrentPayingOrderId;

	// Token: 0x0400282B RID: 10283
	public bool NeedOpenReviewState;

	// Token: 0x0400282C RID: 10284
	public int ReviewDelay;

	// Token: 0x0400282D RID: 10285
	public int CurrentReviewId;

	// Token: 0x0400282E RID: 10286
	public bool NeedReviewConfirmBox;

	// Token: 0x0400282F RID: 10287
	[Nullable(2)]
	public CustomPromise<bool> QueryPromise;

	// Token: 0x04002830 RID: 10288
	[Nullable(2)]
	private PostWebViewEntryPointData EntryPointData;

	// Token: 0x04002831 RID: 10289
	[Nullable(2)]
	private IntroductionData IntroductionData;

	// Token: 0x04002832 RID: 10290
	public bool NoticeRedDotState;

	// Token: 0x04002833 RID: 10291
	public string NoticeSign;

	// Token: 0x04002834 RID: 10292
	public string GmIntroductionLink = "";

	// Token: 0x04002835 RID: 10293
	public bool IntroductionNoticeState;

	// Token: 0x04002836 RID: 10294
	private readonly List<string> CurrentOpeningStaticActivityList = new List<string>();

	// Token: 0x04002837 RID: 10295
	private readonly Dictionary<int, bool> PlayerChatPermissionMap = new Dictionary<int, bool>();

	// Token: 0x04002838 RID: 10296
	[Nullable(2)]
	private static KuroSdkModel _Instance;
}
