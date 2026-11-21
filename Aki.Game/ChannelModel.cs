using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x02000C40 RID: 3136
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ChannelModel : ModelBase
{
	// Token: 0x060082FD RID: 33533 RVA: 0x00282E88 File Offset: 0x00281088
	protected override bool OnInit()
	{
		this.OpenShareChannel = new List<EChannelShare>();
		this.OpenKuroStreetId = new List<EChannelKuroStreet>();
		this.OpenAccountSetting = new List<EChannelAccountSetting>();
		this.SharedActionTypeMap = new List<int>();
		EventSystem.Instance.Add(EEventName.SdkInitDone, new Action(this.ResetOpenFunc));
		return true;
	}

	// Token: 0x060082FE RID: 33534 RVA: 0x00282EDB File Offset: 0x002810DB
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.SdkInitDone, new Action(this.ResetOpenFunc));
		return true;
	}

	// Token: 0x060082FF RID: 33535 RVA: 0x00282EF8 File Offset: 0x002810F8
	private unsafe void ResetOpenFunc()
	{
		this.OpenShareChannel = new List<EChannelShare>();
		this.OpenKuroStreetId = new List<EChannelKuroStreet>();
		this.OpenAccountSetting = new List<EChannelAccountSetting>();
		this.IsCustomerServiceOpen = false;
		if (!LoginController.Instance.IsSdkLoginMode())
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.JT, "不可使用SDK", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bool ifGlobalSdk = KuroSdkController.Instance.GetIfGlobalSdk();
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		int num = int.Parse(KuroSdkController.Instance.GetChannelId());
		string sdkPackageId = KuroSdkModel.Instance.GetSdkPackageId();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.JT;
		string message = "当前包体信息";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("是否海外", ifGlobalSdk);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前语言码", packageLanguage);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("当前渠道", num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		FeatureRestrictionTemplate templateForPioneerClient = FeatureRestrictionTemplate.TemplateForPioneerClient;
		if (Info.Instance.IsMobilePlatform())
		{
			IReadOnlyList<SharePlatform> configList = ConfigSharePlatformAll.GetConfigList((!ifGlobalSdk) ? 1 : 0, true);
			if (configList != null)
			{
				foreach (SharePlatform config in configList)
				{
					if (this.CheckLanguage(packageLanguage, config.ToLanguageEnumerable()) && this.CheckChannel(num, config.ToChannelEnumerable()) && this.CheckPackageId(sdkPackageId, config.ToPackageIdEnumerable()) && !templateForPioneerClient.Check())
					{
						this.OpenShareChannel.Add((EChannelShare)config.Id);
					}
				}
			}
		}
		this.OpenShareChannel.Sort(delegate(EChannelShare a, EChannelShare b)
		{
			SharePlatform? config5 = ConfigSharePlatformById.GetConfig((int)a, true);
			SharePlatform? config6 = ConfigSharePlatformById.GetConfig((int)b, true);
			if (config5 != null && config6 != null && config5.Value.Sort != config6.Value.Sort)
			{
				return config5.Value.Sort - config6.Value.Sort;
			}
			return a - b;
		});
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.KuroSdk;
		ELogAuthor author2 = ELogAuthor.YZY;
		string message2 = "开启分享渠道id ";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("OpenShareChannel", this.OpenShareChannel);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (Community config2 in ConfigCommunityAll.GetConfigList((!ifGlobalSdk) ? 1 : 0, true))
		{
			if (this.CheckLanguage(packageLanguage, config2.ToLanguageEnumerable()) && this.CheckChannel(num, config2.ToChannelEnumerable()) && this.CheckPackageId(sdkPackageId, config2.ToPackageIdEnumerable()) && !templateForPioneerClient.Check())
			{
				this.OpenKuroStreetId.Add((EChannelKuroStreet)config2.Id);
			}
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.KuroSdk;
		ELogAuthor author3 = ELogAuthor.YZY;
		string message3 = "开启库街区id ";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("OpenKuroStreetId", this.OpenKuroStreetId);
		instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		foreach (SetAccount config3 in ConfigSetAccountAll.GetConfigList((!ifGlobalSdk) ? 1 : 0, true))
		{
			if (this.CheckLanguage(packageLanguage, config3.ToLanguageEnumerable()) && this.CheckChannel(num, config3.ToChannelEnumerable()) && this.CheckPackageId(sdkPackageId, config3.ToPackageIdEnumerable()) && (!templateForPioneerClient.Check() || (config3.Id != 1 && config3.Id != 9)))
			{
				this.OpenAccountSetting.Add((EChannelAccountSetting)config3.Id);
			}
		}
		Log instance4 = Log.Instance;
		ELogModule module4 = ELogModule.KuroSdk;
		ELogAuthor author4 = ELogAuthor.YZY;
		string message4 = "开启账号中心id ";
		ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("OpenAccountSetting", this.OpenAccountSetting);
		instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		foreach (CustomerService config4 in ConfigCustomerServiceAll.GetConfigList((!ifGlobalSdk) ? 1 : 0, true))
		{
			if (this.CheckLanguage(packageLanguage, config4.ToLanguageEnumerable()) && this.CheckChannel(num, config4.ToChannelEnumerable()) && this.CheckPackageId(sdkPackageId, config4.ToPackageIdEnumerable()))
			{
				this.IsCustomerServiceOpen = true;
			}
		}
		Log instance5 = Log.Instance;
		ELogModule module5 = ELogModule.KuroSdk;
		ELogAuthor author5 = ELogAuthor.XXJ;
		string message5 = "客服开启";
		ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("state", this.IsCustomerServiceOpen);
		instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		EventSystem.Instance.Emit(EEventName.ChannelReset);
	}

	// Token: 0x06008300 RID: 33536 RVA: 0x00283338 File Offset: 0x00281538
	private bool CheckLanguage(string checkLanguage, IEnumerable<string> checkIter)
	{
		foreach (string a in checkIter)
		{
			if (a == "all")
			{
				return true;
			}
			if (a == checkLanguage)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008301 RID: 33537 RVA: 0x0028339C File Offset: 0x0028159C
	private bool CheckChannel(int checkChannel, IEnumerable<int> checkIter)
	{
		foreach (int num in checkIter)
		{
			if (num == 0)
			{
				return true;
			}
			if (num == checkChannel)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008302 RID: 33538 RVA: 0x002833F0 File Offset: 0x002815F0
	private bool CheckPackageId([Nullable(2)] string checkPackageId, IEnumerable<string> packageIdIter)
	{
		if (checkPackageId == null)
		{
			return false;
		}
		foreach (string a in packageIdIter)
		{
			if (a == "all")
			{
				return true;
			}
			if (a == checkPackageId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008303 RID: 33539 RVA: 0x00283458 File Offset: 0x00281658
	public bool CheckShareChannelOpen(EChannelShare type)
	{
		this.TryResetOpenMap();
		return this.OpenShareChannel.Contains(type);
	}

	// Token: 0x06008304 RID: 33540 RVA: 0x0028346C File Offset: 0x0028166C
	public bool CheckKuroStreetOpen()
	{
		this.TryResetOpenMap();
		return this.OpenKuroStreetId.Count > 0;
	}

	// Token: 0x06008305 RID: 33541 RVA: 0x00283482 File Offset: 0x00281682
	public bool CheckAccountSettingOpen(EChannelAccountSetting type)
	{
		this.TryResetOpenMap();
		return this.OpenAccountSetting.Contains(type);
	}

	// Token: 0x06008306 RID: 33542 RVA: 0x00283498 File Offset: 0x00281698
	public bool CheckCustomerServiceOpen()
	{
		this.TryResetOpenMap();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "客服是否开启";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IsCustomerServiceOpen", this.IsCustomerServiceOpen);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return this.IsCustomerServiceOpen;
	}

	// Token: 0x06008307 RID: 33543 RVA: 0x002834E4 File Offset: 0x002816E4
	public void OpenKuroStreet()
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.Android)
		{
			UKuroStaticAndroidLibrary.OpenAppWithUrl("kjq://kuro/home?gameId=3", "https://www.kurobbs.com/download.html");
			return;
		}
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			UKuroStaticiOSLibrary.OpenAppWithUrl("kjq://kuro/home?gameId=3", "itms-apps://itunes.apple.com/app/id/1659339393");
			return;
		}
		if (this.OpenKuroStreetId.Count > 0)
		{
			Community? community;
			this.OpenAddress((ConfigCommunityById.GetConfig((int)this.OpenKuroStreetId[0], true) != null) ? community.GetValueOrDefault().Adress : null);
		}
	}

	// Token: 0x06008308 RID: 33544 RVA: 0x0028356D File Offset: 0x0028176D
	private void TryResetOpenMap()
	{
		if (this.OpenAccountSetting.Count == 0)
		{
			this.ResetOpenFunc();
		}
	}

	// Token: 0x06008309 RID: 33545 RVA: 0x00283584 File Offset: 0x00281784
	public void ProcessAccountSetting(EChannelAccountSetting type)
	{
		if (type == EChannelAccountSetting.UserCenter || type == EChannelAccountSetting.UserCenterGlobal)
		{
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KuroOpenUserCenter);
			return;
		}
		if (type == EChannelAccountSetting.SDKPrivacy)
		{
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KuroShowAgreement);
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KuroOpenPrivacyClauseWnd);
			return;
		}
		SetAccount? setAccount;
		string url = (ConfigSetAccountById.GetConfig((int)type, true) != null) ? setAccount.GetValueOrDefault().Adress : null;
		bool flag = Info.Instance.PlatformType == ESourcePlatformType.PS4 || Info.Instance.PlatformType == ESourcePlatformType.PS5;
		if (type == EChannelAccountSetting.UserAgreement || type == EChannelAccountSetting.Privacy || type == EChannelAccountSetting.ChildPrivacy || type == EChannelAccountSetting.UserAgreementGlobal || type == EChannelAccountSetting.PrivacyGlobal)
		{
			KuroSdkReport.Instance.Report(new SdkReportOpenPrivacy(null));
		}
		if (flag)
		{
			if (type == EChannelAccountSetting.Privacy || type == EChannelAccountSetting.PrivacyGlobal)
			{
				url = PlatformSdkConfig.Instance.GetPrivacyPolicy();
			}
			else if (type == EChannelAccountSetting.UserAgreementGlobal || type == EChannelAccountSetting.UserAgreement)
			{
				url = PlatformSdkConfig.Instance.GetTermsOfService();
			}
			else if (type == EChannelAccountSetting.ChildPrivacy)
			{
				url = PlatformSdkConfig.Instance.GetChildPolicy();
			}
		}
		this.OpenAddress(url);
	}

	// Token: 0x0600830A RID: 33546 RVA: 0x0028366B File Offset: 0x0028186B
	public List<EChannelShare> GetOpenedShareIds()
	{
		this.TryResetOpenMap();
		return this.OpenShareChannel;
	}

	// Token: 0x0600830B RID: 33547 RVA: 0x0028367C File Offset: 0x0028187C
	public bool CouldGetShareReward(EShareActionId id)
	{
		ShareReward? config = ConfigShareRewardById.GetConfig((int)id, true);
		if (config == null || config.Value.RewardLength == 0)
		{
			return false;
		}
		int? num = (config != null) ? new int?(config.GetValueOrDefault().ShareType) : null;
		return this.OpenShareChannel.Count > 0 && num != null && !this.SharedActionTypeMap.Contains(num.Value);
	}

	// Token: 0x0600830C RID: 33548 RVA: 0x00283704 File Offset: 0x00281904
	public void MarkActionShared(EShareActionId id)
	{
		ShareReward? shareReward;
		int? num = (ConfigShareRewardById.GetConfig((int)id, true) != null) ? new int?(shareReward.GetValueOrDefault().ShareType) : null;
		if (num != null)
		{
			this.SharedActionTypeMap.Add(num.Value);
		}
	}

	// Token: 0x0600830D RID: 33549 RVA: 0x00283760 File Offset: 0x00281960
	[NullableContext(2)]
	private void OpenAddress(string url)
	{
		if (url != null)
		{
			string url2 = url.Replace("{0}", LanguageSystem.Instance.PackageLanguage);
			KuroSdkController.Instance.OpenExternalUrl(url2);
		}
	}

	// Token: 0x0600830E RID: 33550 RVA: 0x00283791 File Offset: 0x00281991
	public void GmOpenShareId(EChannelShare id)
	{
		if (this.OpenAccountSetting.Count == 0)
		{
			this.OpenAccountSetting.Add(EChannelAccountSetting.ThirdParty);
		}
		List<EChannelShare> openShareChannel = this.OpenShareChannel;
		if (openShareChannel == null)
		{
			return;
		}
		openShareChannel.Add(id);
	}

	// Token: 0x17000EA5 RID: 3749
	// (get) Token: 0x0600830F RID: 33551 RVA: 0x002837BD File Offset: 0x002819BD
	public static ChannelModel Instance
	{
		get
		{
			return ChannelModel._Instance;
		}
	}

	// Token: 0x06008310 RID: 33552 RVA: 0x002837C4 File Offset: 0x002819C4
	public static ChannelModel GetOrCreateInstance()
	{
		if (ChannelModel._Instance == null)
		{
			ChannelModel.CreateInstance();
		}
		return ChannelModel._Instance;
	}

	// Token: 0x06008311 RID: 33553 RVA: 0x002837D8 File Offset: 0x002819D8
	public static bool CreateInstance()
	{
		if (ChannelModel._Instance != null)
		{
			return true;
		}
		ChannelModel._Instance = new ChannelModel();
		return true;
	}

	// Token: 0x06008312 RID: 33554 RVA: 0x002837EE File Offset: 0x002819EE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008313 RID: 33555 RVA: 0x002837F0 File Offset: 0x002819F0
	public static void ResetStaticDefaultValue()
	{
		ChannelModel._Instance = null;
	}

	// Token: 0x06008314 RID: 33556 RVA: 0x002837F8 File Offset: 0x002819F8
	static ChannelModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChannelModel.CreateStaticDefaultValue), new Action(ChannelModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005041 RID: 20545
	[Nullable(2)]
	private List<EChannelShare> OpenShareChannel;

	// Token: 0x04005042 RID: 20546
	[Nullable(2)]
	private List<EChannelKuroStreet> OpenKuroStreetId;

	// Token: 0x04005043 RID: 20547
	[Nullable(2)]
	private List<EChannelAccountSetting> OpenAccountSetting;

	// Token: 0x04005044 RID: 20548
	[Nullable(2)]
	private List<int> SharedActionTypeMap;

	// Token: 0x04005045 RID: 20549
	private bool IsCustomerServiceOpen;

	// Token: 0x04005046 RID: 20550
	public EShareActionId SharingActionId = EShareActionId.Photo;

	// Token: 0x04005047 RID: 20551
	public int SharingConfigId;

	// Token: 0x04005048 RID: 20552
	public EShareReportExtraType ShareReportExtraType;

	// Token: 0x04005049 RID: 20553
	public string GameIntroductionUrl = "";

	// Token: 0x0400504A RID: 20554
	[Nullable(2)]
	private static ChannelModel _Instance;
}
