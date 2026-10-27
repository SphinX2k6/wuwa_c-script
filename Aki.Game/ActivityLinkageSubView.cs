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

// Token: 0x020010C2 RID: 4290
[NullableContext(2)]
[Nullable(0)]
public class ActivityLinkageSubView : ActivitySubViewBase
{
	// Token: 0x17000975 RID: 2421
	// (get) Token: 0x06006FB3 RID: 28595 RVA: 0x0016BECB File Offset: 0x0016A0CB
	// (set) Token: 0x06006FB4 RID: 28596 RVA: 0x0016BED3 File Offset: 0x0016A0D3
	protected ActivityLinkageData ActivityData { get; set; }

	// Token: 0x17000976 RID: 2422
	// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x0016BEDC File Offset: 0x0016A0DC
	// (set) Token: 0x06006FB6 RID: 28598 RVA: 0x0016BEE4 File Offset: 0x0016A0E4
	private ActivityButtonItem ButtonItem { get; set; }

	// Token: 0x17000977 RID: 2423
	// (get) Token: 0x06006FB7 RID: 28599 RVA: 0x0016BEED File Offset: 0x0016A0ED
	// (set) Token: 0x06006FB8 RID: 28600 RVA: 0x0016BEF5 File Offset: 0x0016A0F5
	private int TabId { get; set; }

	// Token: 0x17000978 RID: 2424
	// (get) Token: 0x06006FB9 RID: 28601 RVA: 0x0016BEFE File Offset: 0x0016A0FE
	// (set) Token: 0x06006FBA RID: 28602 RVA: 0x0016BF06 File Offset: 0x0016A106
	private ActivityLinkageTabData TabData { get; set; }

	// Token: 0x17000979 RID: 2425
	// (get) Token: 0x06006FBB RID: 28603 RVA: 0x0016BF0F File Offset: 0x0016A10F
	// (set) Token: 0x06006FBC RID: 28604 RVA: 0x0016BF17 File Offset: 0x0016A117
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

	// Token: 0x1700097A RID: 2426
	// (get) Token: 0x06006FBD RID: 28605 RVA: 0x0016BF20 File Offset: 0x0016A120
	// (set) Token: 0x06006FBE RID: 28606 RVA: 0x0016BF28 File Offset: 0x0016A128
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

	// Token: 0x1700097B RID: 2427
	// (get) Token: 0x06006FBF RID: 28607 RVA: 0x0016BF31 File Offset: 0x0016A131
	// (set) Token: 0x06006FC0 RID: 28608 RVA: 0x0016BF39 File Offset: 0x0016A139
	private ActivityLinkageUrl? UrlConfig { get; set; }

	// Token: 0x06006FC1 RID: 28609 RVA: 0x0016BF42 File Offset: 0x0016A142
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLinkageData)this.ActivityBaseData;
	}

	// Token: 0x06006FC2 RID: 28610 RVA: 0x0016BF58 File Offset: 0x0016A158
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

	// Token: 0x06006FC3 RID: 28611 RVA: 0x0016C0CB File Offset: 0x0016A2CB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x06006FC4 RID: 28612 RVA: 0x0016C0E9 File Offset: 0x0016A2E9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x06006FC5 RID: 28613 RVA: 0x0016C108 File Offset: 0x0016A308
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityLinkageSubView.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityLinkageSubView.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006FC6 RID: 28614 RVA: 0x0016C14B File Offset: 0x0016A34B
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.ActivityData.IsReceiveReward(this.TabId))
		};
	}

	// Token: 0x06006FC7 RID: 28615 RVA: 0x0016C164 File Offset: 0x0016A364
	[NullableContext(1)]
	private ActivityLinkageTabItem InitActivityLinkageTabItem()
	{
		ActivityLinkageTabItem activityLinkageTabItem = new ActivityLinkageTabItem();
		activityLinkageTabItem.SetToggleCallBack(new Action<int, ActivityLinkageTabData>(this.TabItemToggleClick));
		return activityLinkageTabItem;
	}

	// Token: 0x06006FC8 RID: 28616 RVA: 0x0016C17D File Offset: 0x0016A37D
	protected override void OnBeforeShow()
	{
		UUIInturnAnimController uiInturnAnimController = base.GetUiInturnAnimController(9);
		if (uiInturnAnimController == null)
		{
			return;
		}
		uiInturnAnimController.Play("", -1, false);
	}

	// Token: 0x06006FC9 RID: 28617 RVA: 0x0016C198 File Offset: 0x0016A398
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

	// Token: 0x06006FCA RID: 28618 RVA: 0x0016C214 File Offset: 0x0016A414
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

	// Token: 0x06006FCB RID: 28619 RVA: 0x0016C390 File Offset: 0x0016A590
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

	// Token: 0x06006FCC RID: 28620 RVA: 0x0016C40B File Offset: 0x0016A60B
	private void OnRefreshRedDot(int id)
	{
		if (id != this.ActivityData.Id)
		{
			return;
		}
		this.RewardLayout.RefreshWithoutDataSync();
		this.RefreshButtonRedDot();
	}

	// Token: 0x06006FCD RID: 28621 RVA: 0x0016C430 File Offset: 0x0016A630
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

	// Token: 0x06006FCE RID: 28622 RVA: 0x0016C464 File Offset: 0x0016A664
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

	// Token: 0x06006FCF RID: 28623 RVA: 0x0016C4D4 File Offset: 0x0016A6D4
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

	// Token: 0x02007690 RID: 30352
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040271FB RID: 160251
		public const int TextureBg = 0;

		// Token: 0x040271FC RID: 160252
		public const int TextureImage = 1;

		// Token: 0x040271FD RID: 160253
		public const int TextStartDate = 2;

		// Token: 0x040271FE RID: 160254
		public const int TextEndDate = 3;

		// Token: 0x040271FF RID: 160255
		public const int TextLeftTime = 4;

		// Token: 0x04027200 RID: 160256
		public const int LayoutTabList = 5;

		// Token: 0x04027201 RID: 160257
		public const int ButtonGoto = 6;

		// Token: 0x04027202 RID: 160258
		public const int LayoutReward = 7;

		// Token: 0x04027203 RID: 160259
		public const int TextTitle = 8;

		// Token: 0x04027204 RID: 160260
		public const int ListAnimController = 9;
	}
}
