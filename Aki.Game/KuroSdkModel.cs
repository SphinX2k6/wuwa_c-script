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

// Token: 0x020002E2 RID: 738
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class KuroSdkModel : ModelBase
{
	// Token: 0x06002AA7 RID: 10919 RVA: 0x00101B74 File Offset: 0x000FFD74
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

	// Token: 0x06002AA8 RID: 10920 RVA: 0x00101C38 File Offset: 0x000FFE38
	protected override bool OnInit()
	{
		this.CanUseSdk = (UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1");
		KuroSdkReport.Instance.Init();
		this.InitSdkTrophyInfo();
		this.InitProgressActivityList();
		return true;
	}

	// Token: 0x06002AA9 RID: 10921 RVA: 0x00101C8B File Offset: 0x000FFE8B
	public void OnGetSdkBlockUserMap(Dictionary<string, bool> blockUserMap)
	{
		this.SdkBlockUserMap = blockUserMap;
		this.GetSdkBlockUserState = true;
	}

	// Token: 0x06002AAA RID: 10922 RVA: 0x00101C9C File Offset: 0x000FFE9C
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

	// Token: 0x06002AAB RID: 10923 RVA: 0x00101CE0 File Offset: 0x000FFEE0
	private UniTask InitSdkTrophyInfo()
	{
		KuroSdkModel.<InitSdkTrophyInfo>d__39 <InitSdkTrophyInfo>d__;
		<InitSdkTrophyInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSdkTrophyInfo>d__.<>4__this = this;
		<InitSdkTrophyInfo>d__.<>1__state = -1;
		<InitSdkTrophyInfo>d__.<>t__builder.Start<KuroSdkModel.<InitSdkTrophyInfo>d__39>(ref <InitSdkTrophyInfo>d__);
		return <InitSdkTrophyInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06002AAC RID: 10924 RVA: 0x00101D23 File Offset: 0x000FFF23
	public Dictionary<string, ISdkTrophyInfo> GetSdkTrophyInfo()
	{
		return this.SdkTrophyInfoMap;
	}

	// Token: 0x06002AAD RID: 10925 RVA: 0x00101D2C File Offset: 0x000FFF2C
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

	// Token: 0x06002AAE RID: 10926 RVA: 0x00101D80 File Offset: 0x000FFF80
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

	// Token: 0x06002AAF RID: 10927 RVA: 0x00101DCC File Offset: 0x000FFFCC
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

	// Token: 0x06002AB0 RID: 10928 RVA: 0x00101E94 File Offset: 0x00100094
	private bool UpdateDynamicActivityProgress(int oldCurrentProgressActivityIndex)
	{
		if (this.ProgressActivityList == null || this.ProgressActivityList.Length == 0)
		{
			return false;
		}
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (this.CurrentProgressActivityIndex < 0)
		{
			this.CurrentProgressActivityIndex = 0;
			platformSdk.StartActivity(this.ProgressActivityList[0].ActivityStringId);
		}
		if (this.CurrentProgressActivityIndex >= this.ProgressActivityList.Length - 1)
		{
			return oldCurrentProgressActivityIndex != this.CurrentProgressActivityIndex;
		}
		int num = this.ProgressActivityList.Length;
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

	// Token: 0x06002AB1 RID: 10929 RVA: 0x00101F94 File Offset: 0x00100194
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

	// Token: 0x06002AB2 RID: 10930 RVA: 0x00102090 File Offset: 0x00100290
	public int GetNextProgressActivityQuestId()
	{
		if (this.ProgressActivityList == null || this.CurrentProgressActivityIndex < 0 || this.CurrentProgressActivityIndex + 1 >= this.ProgressActivityList.Length)
		{
			return -1;
		}
		return this.ProgressActivityList[this.CurrentProgressActivityIndex + 1].QuestId;
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x001020D0 File Offset: 0x001002D0
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

	// Token: 0x06002AB4 RID: 10932 RVA: 0x00102128 File Offset: 0x00100328
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

	// Token: 0x06002AB5 RID: 10933 RVA: 0x00102198 File Offset: 0x00100398
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

	// Token: 0x06002AB6 RID: 10934 RVA: 0x00102270 File Offset: 0x00100470
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

	// Token: 0x06002AB7 RID: 10935 RVA: 0x00102380 File Offset: 0x00100580
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

	// Token: 0x06002AB8 RID: 10936 RVA: 0x001023D0 File Offset: 0x001005D0
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

	// Token: 0x06002AB9 RID: 10937 RVA: 0x0010241D File Offset: 0x0010061D
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

	// Token: 0x06002ABA RID: 10938 RVA: 0x00102458 File Offset: 0x00100658
	public string GetDeviceFontAsset()
	{
		string fontAsset = this.GetFontAsset();
		return this.GetFontPlatformName(fontAsset);
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x00102474 File Offset: 0x00100674
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

	// Token: 0x06002ABC RID: 10940 RVA: 0x00102614 File Offset: 0x00100814
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

	// Token: 0x06002ABD RID: 10941 RVA: 0x0010269C File Offset: 0x0010089C
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

	// Token: 0x06002ABE RID: 10942 RVA: 0x00102718 File Offset: 0x00100918
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

	// Token: 0x06002ABF RID: 10943 RVA: 0x00102796 File Offset: 0x00100996
	public bool GetSdkFocusState()
	{
		return this.SdkGetFocusState;
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x0010279E File Offset: 0x0010099E
	public void SetPlayStationPlayOnlyState(bool state)
	{
		this.PlayStationPlayOnlyState = state;
		KuroSdkController.Instance.SetPlayOnly(state);
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.PlayStationOnly);
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x001027C7 File Offset: 0x001009C7
	public void SetXboxPlayOnlyState(bool state)
	{
		this.XboxPlayOnlyState = state;
		KuroSdkController.Instance.SetPlayOnly(state);
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.XboxOnly);
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x001027F0 File Offset: 0x001009F0
	[NullableContext(2)]
	public string GetSdkPackageId()
	{
		if (PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return PlatformSdkManagerNew.Instance.GetPlatformSdk().GetProductId();
		}
		return KuroSdkController.Instance.GetPackageId();
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x00102818 File Offset: 0x00100A18
	[NullableContext(2)]
	public void SetEntryPointData(PostWebViewEntryPointData data)
	{
		this.EntryPointData = data;
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x00102821 File Offset: 0x00100A21
	[NullableContext(2)]
	public PostWebViewEntryPointData GetEntryPointData()
	{
		return this.EntryPointData;
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x00102829 File Offset: 0x00100A29
	[NullableContext(2)]
	public void SetIntroductionData(IntroductionData data)
	{
		this.IntroductionData = data;
		this.RefreshIntroductionRedDotState();
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x00102838 File Offset: 0x00100A38
	[NullableContext(2)]
	public IntroductionData GetIntroductionData()
	{
		return this.IntroductionData;
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x00102840 File Offset: 0x00100A40
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

	// Token: 0x06002AC8 RID: 10952 RVA: 0x001028B0 File Offset: 0x00100AB0
	public void SaveCurrentClickIntroductionVersion()
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.IntroductionVersion) as ServerStorageString).Set((this.IntroductionData != null) ? this.IntroductionData.version.ToString() : "");
		this.IntroductionNoticeState = false;
		EventSystem.Instance.Emit(EEventName.SdkIntroductionRedPointRefresh);
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x00102909 File Offset: 0x00100B09
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

	// Token: 0x06002ACA RID: 10954 RVA: 0x00102944 File Offset: 0x00100B44
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

	// Token: 0x06002ACB RID: 10955 RVA: 0x00102A1C File Offset: 0x00100C1C
	private bool CheckNoticeContentInValidTime(NoticeContentData data)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = data.startTimeMs / 1000.0;
		double num2 = data.endTimeMs / 1000.0;
		return serverTime >= num && serverTime <= num2;
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x00102A64 File Offset: 0x00100C64
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

	// Token: 0x06002ACD RID: 10957 RVA: 0x00102AA4 File Offset: 0x00100CA4
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

	// Token: 0x06002ACE RID: 10958 RVA: 0x00102AE4 File Offset: 0x00100CE4
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

	// Token: 0x06002ACF RID: 10959 RVA: 0x00102B1C File Offset: 0x00100D1C
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

	// Token: 0x06002AD0 RID: 10960 RVA: 0x00102B64 File Offset: 0x00100D64
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

	// Token: 0x06002AD1 RID: 10961 RVA: 0x00102C2C File Offset: 0x00100E2C
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

	// Token: 0x06002AD2 RID: 10962 RVA: 0x00102CA4 File Offset: 0x00100EA4
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

	// Token: 0x06002AD3 RID: 10963 RVA: 0x00102CEC File Offset: 0x00100EEC
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

	// Token: 0x06002AD4 RID: 10964 RVA: 0x00102D7C File Offset: 0x00100F7C
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

	// Token: 0x06002AD5 RID: 10965 RVA: 0x00102F74 File Offset: 0x00101174
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

	// Token: 0x06002AD6 RID: 10966 RVA: 0x001030EC File Offset: 0x001012EC
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

	// Token: 0x06002AD7 RID: 10967 RVA: 0x00103148 File Offset: 0x00101348
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

	// Token: 0x06002AD8 RID: 10968 RVA: 0x001031B0 File Offset: 0x001013B0
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

	// Token: 0x06002AD9 RID: 10969 RVA: 0x00103218 File Offset: 0x00101418
	public void RefreshPlayerChatPermissionByPlayerDetails(PlayerDetails playerDetails)
	{
		if (!string.IsNullOrEmpty(playerDetails.XboxUserId))
		{
			this.RefreshPlayerChatPermission(playerDetails.PlayerId, playerDetails.XboxUserId);
		}
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x0010323C File Offset: 0x0010143C
	public void RefreshPlayerChatPermission(int playerId, string userId)
	{
		KuroSdkController.Instance.CheckPermission(userId, ESdkPermission.CommunicateUsingText, delegate(bool result)
		{
			this.PlayerChatPermissionMap[playerId] = result;
		});
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x00103275 File Offset: 0x00101475
	public bool GetPlayerChatPermission(int playerId)
	{
		return this.PlayerChatPermissionMap.GetValueOrDefault(playerId, true);
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x00103284 File Offset: 0x00101484
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

	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x06002ADD RID: 10973 RVA: 0x001032B9 File Offset: 0x001014B9
	public static KuroSdkModel Instance
	{
		get
		{
			return KuroSdkModel._Instance;
		}
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x001032C0 File Offset: 0x001014C0
	public static KuroSdkModel GetOrCreateInstance()
	{
		if (KuroSdkModel._Instance == null)
		{
			KuroSdkModel.CreateInstance();
		}
		return KuroSdkModel._Instance;
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x001032D4 File Offset: 0x001014D4
	public static bool CreateInstance()
	{
		if (KuroSdkModel._Instance != null)
		{
			return true;
		}
		KuroSdkModel._Instance = new KuroSdkModel();
		return true;
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x001032EA File Offset: 0x001014EA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x001032EC File Offset: 0x001014EC
	public static void ResetStaticDefaultValue()
	{
		KuroSdkModel._Instance = null;
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x001032F4 File Offset: 0x001014F4
	static KuroSdkModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkModel.CreateStaticDefaultValue), new Action(KuroSdkModel.ResetStaticDefaultValue));
	}

	// Token: 0x040028AD RID: 10413
	private const string LAGUSANSBOLD = "LaguSansBold.otf";

	// Token: 0x040028AE RID: 10414
	private const string MOTOYTA = "MotoyaAporoStdW5.otf";

	// Token: 0x040028AF RID: 10415
	private const string SUITEBOLD = "SUITE-Bold.otf";

	// Token: 0x040028B0 RID: 10416
	private const string H7GBKHEAVY = "H7GBKHeavy.TTF";

	// Token: 0x040028B1 RID: 10417
	private const string KANIT = "Kanit-Medium.ttf";

	// Token: 0x040028B2 RID: 10418
	private const string DEFAULTEMPTY = " ";

	// Token: 0x040028B3 RID: 10419
	public bool ReportedInitState;

	// Token: 0x040028B4 RID: 10420
	[Nullable(2)]
	private FBasicInfo BaseInfo;

	// Token: 0x040028B5 RID: 10421
	private readonly Dictionary<string, QueryProductSt> QueryProductInfoMap;

	// Token: 0x040028B6 RID: 10422
	private Dictionary<string, ISdkTrophyInfo> SdkTrophyInfoMap;

	// Token: 0x040028B7 RID: 10423
	public bool CanUseSdk;

	// Token: 0x040028B8 RID: 10424
	public string CurrentPayItemName;

	// Token: 0x040028B9 RID: 10425
	public bool SdkGetFocusState;

	// Token: 0x040028BA RID: 10426
	public Dictionary<string, bool> SdkBlockUserMap;

	// Token: 0x040028BB RID: 10427
	private bool GetSdkBlockUserState;

	// Token: 0x040028BC RID: 10428
	public bool PlayStationPlayOnlyState;

	// Token: 0x040028BD RID: 10429
	public bool XboxPlayOnlyState;

	// Token: 0x040028BE RID: 10430
	[Nullable(2)]
	public string UserId;

	// Token: 0x040028BF RID: 10431
	[Nullable(2)]
	public string OnlineId;

	// Token: 0x040028C0 RID: 10432
	private int CurrentProgressActivityIndex;

	// Token: 0x040028C1 RID: 10433
	[Nullable(2)]
	private PlayStationActivityConfig[] ProgressActivityList;

	// Token: 0x040028C2 RID: 10434
	[Nullable(2)]
	public string AccountId;

	// Token: 0x040028C3 RID: 10435
	public string CurrentPayingOrderId;

	// Token: 0x040028C4 RID: 10436
	public bool NeedOpenReviewState;

	// Token: 0x040028C5 RID: 10437
	public int ReviewDelay;

	// Token: 0x040028C6 RID: 10438
	public int CurrentReviewId;

	// Token: 0x040028C7 RID: 10439
	public bool NeedReviewConfirmBox;

	// Token: 0x040028C8 RID: 10440
	[Nullable(2)]
	public CustomPromise<bool> QueryPromise;

	// Token: 0x040028C9 RID: 10441
	[Nullable(2)]
	private PostWebViewEntryPointData EntryPointData;

	// Token: 0x040028CA RID: 10442
	[Nullable(2)]
	private IntroductionData IntroductionData;

	// Token: 0x040028CB RID: 10443
	public bool NoticeRedDotState;

	// Token: 0x040028CC RID: 10444
	public string NoticeSign;

	// Token: 0x040028CD RID: 10445
	public string GmIntroductionLink = "";

	// Token: 0x040028CE RID: 10446
	public bool IntroductionNoticeState;

	// Token: 0x040028CF RID: 10447
	private readonly List<string> CurrentOpeningStaticActivityList = new List<string>();

	// Token: 0x040028D0 RID: 10448
	private readonly Dictionary<int, bool> PlayerChatPermissionMap = new Dictionary<int, bool>();

	// Token: 0x040028D1 RID: 10449
	[Nullable(2)]
	private static KuroSdkModel _Instance;
}
