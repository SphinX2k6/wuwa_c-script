using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000576 RID: 1398
[NullableContext(2)]
[Nullable(0)]
public class ActivityLinkageSubView : ActivitySubViewBase
{
	// Token: 0x17000995 RID: 2453
	// (get) Token: 0x06004349 RID: 17225 RVA: 0x00174887 File Offset: 0x00172A87
	// (set) Token: 0x0600434A RID: 17226 RVA: 0x0017488F File Offset: 0x00172A8F
	protected ActivityLinkageData ActivityData { get; set; }

	// Token: 0x17000996 RID: 2454
	// (get) Token: 0x0600434B RID: 17227 RVA: 0x00174898 File Offset: 0x00172A98
	// (set) Token: 0x0600434C RID: 17228 RVA: 0x001748A0 File Offset: 0x00172AA0
	private ActivityButtonItem ButtonItem { get; set; }

	// Token: 0x17000997 RID: 2455
	// (get) Token: 0x0600434D RID: 17229 RVA: 0x001748A9 File Offset: 0x00172AA9
	// (set) Token: 0x0600434E RID: 17230 RVA: 0x001748B1 File Offset: 0x00172AB1
	private int TabId { get; set; }

	// Token: 0x17000998 RID: 2456
	// (get) Token: 0x0600434F RID: 17231 RVA: 0x001748BA File Offset: 0x00172ABA
	// (set) Token: 0x06004350 RID: 17232 RVA: 0x001748C2 File Offset: 0x00172AC2
	private ActivityLinkageTabData TabData { get; set; }

	// Token: 0x17000999 RID: 2457
	// (get) Token: 0x06004351 RID: 17233 RVA: 0x001748CB File Offset: 0x00172ACB
	// (set) Token: 0x06004352 RID: 17234 RVA: 0x001748D3 File Offset: 0x00172AD3
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700099A RID: 2458
	// (get) Token: 0x06004353 RID: 17235 RVA: 0x001748DC File Offset: 0x00172ADC
	// (set) Token: 0x06004354 RID: 17236 RVA: 0x001748E4 File Offset: 0x00172AE4
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivityLinkageTabItem, ActivityLinkageTabData> TabLayout { [return: Nullable(new byte[]
	{
		2,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1
	})] set; }

	// Token: 0x1700099B RID: 2459
	// (get) Token: 0x06004355 RID: 17237 RVA: 0x001748ED File Offset: 0x00172AED
	// (set) Token: 0x06004356 RID: 17238 RVA: 0x001748F5 File Offset: 0x00172AF5
	private ActivityLinkageUrl? UrlConfig { get; set; }

	// Token: 0x06004357 RID: 17239 RVA: 0x001748FE File Offset: 0x00172AFE
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLinkageData)this.ActivityBaseData;
	}

	// Token: 0x06004358 RID: 17240 RVA: 0x00174914 File Offset: 0x00172B14
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UTexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UTexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIInturnAnimController));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004359 RID: 17241 RVA: 0x00174A87 File Offset: 0x00172C87
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x0600435A RID: 17242 RVA: 0x00174AA5 File Offset: 0x00172CA5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x0600435B RID: 17243 RVA: 0x00174AC4 File Offset: 0x00172CC4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityLinkageSubView.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityLinkageSubView.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600435C RID: 17244 RVA: 0x00174B07 File Offset: 0x00172D07
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.ActivityData.IsReceiveReward(this.TabId))
		};
	}

	// Token: 0x0600435D RID: 17245 RVA: 0x00174B20 File Offset: 0x00172D20
	[NullableContext(1)]
	private ActivityLinkageTabItem InitActivityLinkageTabItem()
	{
		ActivityLinkageTabItem activityLinkageTabItem = new ActivityLinkageTabItem();
		activityLinkageTabItem.SetToggleCallBack(new Action<int, ActivityLinkageTabData>(this.TabItemToggleClick));
		return activityLinkageTabItem;
	}

	// Token: 0x0600435E RID: 17246 RVA: 0x00174B39 File Offset: 0x00172D39
	protected override void OnBeforeShow()
	{
		UUIInturnAnimController uiInturnAnimController = base.GetUiInturnAnimController(9);
		if (uiInturnAnimController == null)
		{
			return;
		}
		uiInturnAnimController.Play("", -1, false);
	}

	// Token: 0x0600435F RID: 17247 RVA: 0x00174B54 File Offset: 0x00172D54
	[NullableContext(1)]
	public void TabItemToggleClick(int gridIndex, ActivityLinkageTabData tabData)
	{
		this.PlaySubViewSequence("Switch", false);
		this.TabLayout.SelectGridProxy(gridIndex, false);
		this.RefreshUi(tabData);
		LinkageSwitchModuleEvent linkageSwitchModuleEvent = new LinkageSwitchModuleEvent();
		linkageSwitchModuleEvent.i_activity_id = this.ActivityData.Id;
		linkageSwitchModuleEvent.i_activity_type = (int)this.ActivityData.Type;
		linkageSwitchModuleEvent.i_id = tabData.TabId;
		linkageSwitchModuleEvent.i_if_finish = ((tabData.IsReceive > false) ? 1 : 0);
		LogReportController.Instance.LogReport(linkageSwitchModuleEvent);
	}

	// Token: 0x06004360 RID: 17248 RVA: 0x00174BD0 File Offset: 0x00172DD0
	[NullableContext(1)]
	private void RefreshUi(ActivityLinkageTabData tabData)
	{
		this.TabData = tabData;
		this.TabId = tabData.TabId;
		ActivityLinkage? config = ConfigActivityLinkageById.GetConfig(this.TabId, true);
		if (config == null)
		{
			return;
		}
		base.SetTextureByPath(config.Value.BgImage, base.GetTexture(0), null, null);
		this.RefreshTimerText();
		List<TItem> list = new List<TItem>();
		for (int i = 0; i < config.Value.RewardLength; i++)
		{
			list.Add(new TItem(new InventoryDefine.GetItemData(config.Value.Reward(i).Value.Key, 0), config.Value.Reward(i).Value.Value));
		}
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout != null)
		{
			rewardLayout.RefreshByData(list, null, false);
		}
		this.RefreshButtonRedDot();
		int languageType = LanguageSystem.Instance.GetLanguageDefineByCode(LanguageSystem.Instance.PackageLanguage).LanguageType;
		ActivityLinkageInfo? config2 = ConfigActivityLinkageInfoByIdAndLanguage.GetConfig(this.TabId, languageType, true);
		if (config2 == null)
		{
			return;
		}
		base.SetTextureByPath(config2.Value.BigImage, base.GetTexture(1), null, null);
		bool p1IsNational = !KuroSdkController.Instance.GetIfGlobalSdk();
		this.UrlConfig = ConfigActivityLinkageUrlByIdAndIsNational.GetConfig(this.TabId, p1IsNational, true);
	}

	// Token: 0x06004361 RID: 17249 RVA: 0x00174D4C File Offset: 0x00172F4C
	private void RefreshTimerText()
	{
		bool show = ConfigActivityLinkageById.GetConfig(this.TabId, true).Value.Show;
		UUIText text = base.GetText(4);
		text.SetUIActive(show);
		if (show)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string newText = ActivityModel.Instance.GetRemainTimeText(this.TabData.EndTimeStamp / 1000L, localTextNew) ?? "";
			text.SetText(newText, true);
		}
	}

	// Token: 0x06004362 RID: 17250 RVA: 0x00174DC7 File Offset: 0x00172FC7
	private void OnRefreshRedDot(int id)
	{
		if (id != this.ActivityData.Id)
		{
			return;
		}
		this.RewardLayout.RefreshWithoutDataSync();
		this.RefreshButtonRedDot();
	}

	// Token: 0x06004363 RID: 17251 RVA: 0x00174DEC File Offset: 0x00172FEC
	private void RefreshButtonRedDot()
	{
		bool redDotVisible = !this.ActivityData.IsReceiveReward(this.TabId);
		ActivityButtonItem buttonItem = this.ButtonItem;
		if (buttonItem == null)
		{
			return;
		}
		buttonItem.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06004364 RID: 17252 RVA: 0x00174E20 File Offset: 0x00173020
	protected override void OnTimer(float gap)
	{
		if (this.ActivityData.IsNeedShowTabsChange())
		{
			List<ActivityLinkageTabData> tabInfoList = this.ActivityData.GetTabInfoList();
			this.TabLayout.RefreshByData(tabInfoList, null, false);
			this.TabLayout.SelectGridProxy(0, false);
			this.RefreshUi(tabInfoList[0]);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
		}
		this.RefreshTimerText();
	}

	// Token: 0x06004365 RID: 17253 RVA: 0x00174E90 File Offset: 0x00173090
	private unsafe void OnClickGotoBtn()
	{
		if (string.IsNullOrEmpty(this.UrlConfig.Value.LinkUrl))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "联动页链接为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tabId", this.TabId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string str = PublicUtil.Instance.OverridePackageId ?? KuroSdkController.Instance.GetPackageId();
		string text = this.UrlConfig.Value.LinkUrl + "?packageId=" + str;
		if (this.UrlConfig.Value.IsNeedToken)
		{
			text = text + "&" + PublicUtil.Instance.GetPublicInfo();
		}
		bool isNational = this.UrlConfig.Value.IsNational;
		if (!isNational)
		{
			text = text + "&language=" + LanguageSystem.Instance.PackageLanguage;
		}
		text = PublicUtil.Instance.GetExtendExternalUrl(text, this.UrlConfig.Value.IsInternalLink);
		string platformStr = KuroSdkModel.Instance.GetPlatformStr();
		text = text + "&platform=" + platformStr;
		if (this.UrlConfig.Value.IsInternalLink)
		{
			KuroSdkController.Instance.SdkOpenUrlWnd("", text, true, true, true);
		}
		else
		{
			KuroSdkController.Instance.OpenExternalUrl(text);
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Activity;
		ELogAuthor author2 = ELogAuthor.CXJ;
		string message2 = "联动页打开链接";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", text);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否为国内包体", isNational);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		LinkageClickGoEvent linkageClickGoEvent = new LinkageClickGoEvent();
		linkageClickGoEvent.i_activity_id = this.ActivityData.Id;
		linkageClickGoEvent.i_activity_type = (int)this.ActivityData.Type;
		linkageClickGoEvent.i_id = this.TabId;
		LogReportController.Instance.LogReport(linkageClickGoEvent);
		ActivityLinkageData activityData = this.ActivityData;
		if (activityData == null || !activityData.IsReceiveReward(this.TabId))
		{
			ActivityLinkageController.Instance.RequestReward(this.TabId);
		}
	}

	// Token: 0x02006824 RID: 26660
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022544 RID: 140612
		public const int TextureBg = 0;

		// Token: 0x04022545 RID: 140613
		public const int TextureImage = 1;

		// Token: 0x04022546 RID: 140614
		public const int TextStartDate = 2;

		// Token: 0x04022547 RID: 140615
		public const int TextEndDate = 3;

		// Token: 0x04022548 RID: 140616
		public const int TextLeftTime = 4;

		// Token: 0x04022549 RID: 140617
		public const int LayoutTabList = 5;

		// Token: 0x0402254A RID: 140618
		public const int ButtonGoto = 6;

		// Token: 0x0402254B RID: 140619
		public const int LayoutReward = 7;

		// Token: 0x0402254C RID: 140620
		public const int TextTitle = 8;

		// Token: 0x0402254D RID: 140621
		public const int ListAnimController = 9;
	}
}
