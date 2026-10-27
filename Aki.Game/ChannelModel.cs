using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x02001787 RID: 6023
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ChannelModel : ModelBase
{
	// Token: 0x0600AF15 RID: 44821 RVA: 0x00278954 File Offset: 0x00276B54
	protected override bool OnInit()
	{
		this.OpenShareChannel = new List<EChannelShare>();
		this.OpenKuroStreetId = new List<EChannelKuroStreet>();
		this.OpenAccountSetting = new List<EChannelAccountSetting>();
		this.SharedActionTypeMap = new List<int>();
		EventSystem.Instance.Add(EEventName.SdkInitDone, new Action(this.ResetOpenFunc));
		return true;
	}

	// Token: 0x0600AF16 RID: 44822 RVA: 0x002789A7 File Offset: 0x00276BA7
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.SdkInitDone, new Action(this.ResetOpenFunc));
		return true;
	}

	// Token: 0x0600AF17 RID: 44823 RVA: 0x002789C4 File Offset: 0x00276BC4
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

	// Token: 0x0600AF18 RID: 44824 RVA: 0x00278E04 File Offset: 0x00277004
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

	// Token: 0x0600AF19 RID: 44825 RVA: 0x00278E68 File Offset: 0x00277068
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

	// Token: 0x0600AF1A RID: 44826 RVA: 0x00278EBC File Offset: 0x002770BC
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

	// Token: 0x0600AF1B RID: 44827 RVA: 0x00278F24 File Offset: 0x00277124
	public bool CheckShareChannelOpen(EChannelShare type)
	{
		this.TryResetOpenMap();
		return this.OpenShareChannel.Contains(type);
	}

	// Token: 0x0600AF1C RID: 44828 RVA: 0x00278F38 File Offset: 0x00277138
	public bool CheckKuroStreetOpen()
	{
		this.TryResetOpenMap();
		return this.OpenKuroStreetId.Count > 0;
	}

	// Token: 0x0600AF1D RID: 44829 RVA: 0x00278F4E File Offset: 0x0027714E
	public bool CheckAccountSettingOpen(EChannelAccountSetting type)
	{
		this.TryResetOpenMap();
		return this.OpenAccountSetting.Contains(type);
	}

	// Token: 0x0600AF1E RID: 44830 RVA: 0x00278F64 File Offset: 0x00277164
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

	// Token: 0x0600AF1F RID: 44831 RVA: 0x00278FB0 File Offset: 0x002771B0
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

	// Token: 0x0600AF20 RID: 44832 RVA: 0x00279039 File Offset: 0x00277239
	private void TryResetOpenMap()
	{
		if (this.OpenAccountSetting.Count == 0)
		{
			this.ResetOpenFunc();
		}
	}

	// Token: 0x0600AF21 RID: 44833 RVA: 0x00279050 File Offset: 0x00277250
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

	// Token: 0x0600AF22 RID: 44834 RVA: 0x00279137 File Offset: 0x00277337
	public List<EChannelShare> GetOpenedShareIds()
	{
		this.TryResetOpenMap();
		return this.OpenShareChannel;
	}

	// Token: 0x0600AF23 RID: 44835 RVA: 0x00279148 File Offset: 0x00277348
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

	// Token: 0x0600AF24 RID: 44836 RVA: 0x002791D0 File Offset: 0x002773D0
	public void MarkActionShared(EShareActionId id)
	{
		ShareReward? shareReward;
		int? num = (ConfigShareRewardById.GetConfig((int)id, true) != null) ? new int?(shareReward.GetValueOrDefault().ShareType) : null;
		if (num != null)
		{
			this.SharedActionTypeMap.Add(num.Value);
		}
	}

	// Token: 0x0600AF25 RID: 44837 RVA: 0x0027922C File Offset: 0x0027742C
	[NullableContext(2)]
	private void OpenAddress(string url)
	{
		if (url != null)
		{
			string url2 = url.Replace("{0}", LanguageSystem.Instance.PackageLanguage);
			KuroSdkController.Instance.OpenExternalUrl(url2);
		}
	}

	// Token: 0x0600AF26 RID: 44838 RVA: 0x0027925D File Offset: 0x0027745D
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

	// Token: 0x17000E82 RID: 3714
	// (get) Token: 0x0600AF27 RID: 44839 RVA: 0x00279289 File Offset: 0x00277489
	public static ChannelModel Instance
	{
		get
		{
			return ChannelModel._Instance;
		}
	}

	// Token: 0x0600AF28 RID: 44840 RVA: 0x00279290 File Offset: 0x00277490
	public static ChannelModel GetOrCreateInstance()
	{
		if (ChannelModel._Instance == null)
		{
			ChannelModel.CreateInstance();
		}
		return ChannelModel._Instance;
	}

	// Token: 0x0600AF29 RID: 44841 RVA: 0x002792A4 File Offset: 0x002774A4
	public static bool CreateInstance()
	{
		if (ChannelModel._Instance != null)
		{
			return true;
		}
		ChannelModel._Instance = new ChannelModel();
		return true;
	}

	// Token: 0x0600AF2A RID: 44842 RVA: 0x002792BA File Offset: 0x002774BA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AF2B RID: 44843 RVA: 0x002792BC File Offset: 0x002774BC
	public static void ResetStaticDefaultValue()
	{
		ChannelModel._Instance = null;
	}

	// Token: 0x0600AF2C RID: 44844 RVA: 0x002792C4 File Offset: 0x002774C4
	static ChannelModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChannelModel.CreateStaticDefaultValue), new Action(ChannelModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004F97 RID: 20375
	[Nullable(2)]
	private List<EChannelShare> OpenShareChannel;

	// Token: 0x04004F98 RID: 20376
	[Nullable(2)]
	private List<EChannelKuroStreet> OpenKuroStreetId;

	// Token: 0x04004F99 RID: 20377
	[Nullable(2)]
	private List<EChannelAccountSetting> OpenAccountSetting;

	// Token: 0x04004F9A RID: 20378
	[Nullable(2)]
	private List<int> SharedActionTypeMap;

	// Token: 0x04004F9B RID: 20379
	private bool IsCustomerServiceOpen;

	// Token: 0x04004F9C RID: 20380
	public EShareActionId SharingActionId = EShareActionId.Photo;

	// Token: 0x04004F9D RID: 20381
	public int SharingConfigId;

	// Token: 0x04004F9E RID: 20382
	public EShareReportExtraType ShareReportExtraType;

	// Token: 0x04004F9F RID: 20383
	public string GameIntroductionUrl = "";

	// Token: 0x04004FA0 RID: 20384
	[Nullable(2)]
	private static ChannelModel _Instance;
}
