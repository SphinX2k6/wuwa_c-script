using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000B4D RID: 2893
[NullableContext(1)]
[Nullable(0)]
public class AdventureGuideView : UiViewBase
{
	// Token: 0x060078DA RID: 30938 RVA: 0x00256F4B File Offset: 0x0025514B
	public AdventureGuideView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060078DB RID: 30939 RVA: 0x00256F60 File Offset: 0x00255160
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBackBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnIntroductionBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060078DC RID: 30940 RVA: 0x002570D0 File Offset: 0x002552D0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.AdventureHelpBtn, new Action<int>(this.AdventureHelpBtn));
		EventSystem.Instance.Add<string, string>(EEventName.DailyActivityCountDownUpdate, new Action<string, string>(this.SetCountDownText));
		EventSystem.Instance.Add<EUiTabViewName, int?>(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.SwitchTabView));
		EventSystem.Instance.Add<AdventureGuideViewOpenData>(EEventName.SwitchAdventureGuideViewTab, new Action<AdventureGuideViewOpenData>(this.SwitchAdventureGuideViewTab));
	}

	// Token: 0x060078DD RID: 30941 RVA: 0x00257148 File Offset: 0x00255348
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.AdventureHelpBtn, new Action<int>(this.AdventureHelpBtn));
		EventSystem.Instance.Remove(EEventName.DailyActivityCountDownUpdate, new Action<string, string>(this.SetCountDownText));
		EventSystem.Instance.Remove(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.SwitchTabView));
		EventSystem.Instance.Remove(EEventName.SwitchAdventureGuideViewTab, new Action<AdventureGuideViewOpenData>(this.SwitchAdventureGuideViewTab));
	}

	// Token: 0x060078DE RID: 30942 RVA: 0x002571C0 File Offset: 0x002553C0
	protected override UniTask OnBeforeStartAsync()
	{
		AdventureGuideView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdventureGuideView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060078DF RID: 30943 RVA: 0x00257203 File Offset: 0x00255403
	protected override void OnBeforeShow()
	{
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.SelectToggleByIndex(this.CurSelectTabIndex, true);
	}

	// Token: 0x060078E0 RID: 30944 RVA: 0x0025721C File Offset: 0x0025541C
	private int GetIndexByTabViewName(EUiTabViewName viewName)
	{
		int num = this.TabDataList.Length;
		for (int i = 0; i < num; i++)
		{
			if (this.TabDataList[i].ChildViewName == viewName)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x060078E1 RID: 30945 RVA: 0x00257260 File Offset: 0x00255460
	protected UniTask InitTabComponent()
	{
		AdventureGuideView.<InitTabComponent>d__16 <InitTabComponent>d__;
		<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabComponent>d__.<>4__this = this;
		<InitTabComponent>d__.<>1__state = -1;
		<InitTabComponent>d__.<>t__builder.Start<AdventureGuideView.<InitTabComponent>d__16>(ref <InitTabComponent>d__);
		return <InitTabComponent>d__.<>t__builder.Task;
	}

	// Token: 0x060078E2 RID: 30946 RVA: 0x002572A3 File Offset: 0x002554A3
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x060078E3 RID: 30947 RVA: 0x002572AC File Offset: 0x002554AC
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		UiDynamicTab data = this.TabDataList[index];
		string childViewName = data.ChildViewName;
		AdventureGuideModel.Instance.CurrentGuideTabName = new EUiTabViewName?((EUiTabViewName)childViewName);
		this.ShowCountDownPanel(false);
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		List<CommonCurrencyItem> list = (tabComponent != null) ? tabComponent.GetCurrencyItemList() : null;
		if (list != null)
		{
			foreach (CommonCurrencyItem commonCurrencyItem in list)
			{
				commonCurrencyItem.SetUiActive(childViewName == EUiTabViewName.NewSoundAreaView || childViewName == EUiTabViewName.DisposableChallengeView);
			}
		}
		TabComponentWithCaptionItem<CommonTabItem> tabComponent2 = this.TabComponent;
		CommonTabItem tabItem = (tabComponent2 != null) ? tabComponent2.GetTabItemByIndex(index) : null;
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		if (tabViewComponent != null)
		{
			tabViewComponent.ToggleCallBack(data, (EUiTabViewName)childViewName, tabItem, this.TabViewOpenData, null);
		}
		this.CurSelectTabIndex = index;
		this.RefreshIntroductionBtn();
	}

	// Token: 0x060078E4 RID: 30948 RVA: 0x002573C4 File Offset: 0x002555C4
	private void RefreshIntroductionBtn()
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[this.CurSelectTabIndex];
		EUiTabViewName left = (EUiTabViewName)uiDynamicTab.ChildViewName;
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(FunctionModel.Instance.IsOpen(10097) && left == EUiTabViewName.NewSoundAreaView);
	}

	// Token: 0x060078E5 RID: 30949 RVA: 0x00257430 File Offset: 0x00255630
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x060078E6 RID: 30950 RVA: 0x00257468 File Offset: 0x00255668
	protected UniTask RebuildTabItem()
	{
		AdventureGuideView.<RebuildTabItem>d__21 <RebuildTabItem>d__;
		<RebuildTabItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RebuildTabItem>d__.<>4__this = this;
		<RebuildTabItem>d__.<>1__state = -1;
		<RebuildTabItem>d__.<>t__builder.Start<AdventureGuideView.<RebuildTabItem>d__21>(ref <RebuildTabItem>d__);
		return <RebuildTabItem>d__.<>t__builder.Task;
	}

	// Token: 0x060078E7 RID: 30951 RVA: 0x002574AC File Offset: 0x002556AC
	protected bool CanToggleChange(int index, bool? state)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
		if (this.LastClickTime != null)
		{
			double? num = Time.Instance.Now - this.LastClickTime;
			int? num2 = intConfig;
			double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
			if (!(num.GetValueOrDefault() >= num3.GetValueOrDefault() & (num != null & num3 != null)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060078E8 RID: 30952 RVA: 0x00257568 File Offset: 0x00255768
	private void SwitchAdventureGuideViewTab(AdventureGuideViewOpenData data)
	{
		this.TabViewOpenData = data;
		this.CurSelectTabIndex = this.GetIndexByTabViewName(data.OpenTabViewName ?? EUiTabViewName.DailyActivityTabView);
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.SelectToggleByIndex(this.CurSelectTabIndex, true);
		}
		AdventureGuideModel.Instance.CurrentGuideTabName = data.OpenTabViewName;
	}

	// Token: 0x060078E9 RID: 30953 RVA: 0x002575D0 File Offset: 0x002557D0
	private void SwitchTabView(EUiTabViewName tabViewName, int? param)
	{
		AdventureGuideViewOpenData tabViewOpenData = new AdventureGuideViewOpenData
		{
			OpenTabViewName = new EUiTabViewName?(tabViewName),
			OpenParam = param
		};
		this.TabViewOpenData = tabViewOpenData;
		this.CurSelectTabIndex = this.GetIndexByTabViewName(tabViewName);
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.SelectToggleByIndex(this.CurSelectTabIndex, true);
		}
		AdventureGuideModel.Instance.CurrentGuideTabName = new EUiTabViewName?(tabViewName);
	}

	// Token: 0x060078EA RID: 30954 RVA: 0x00257632 File Offset: 0x00255832
	private void ShowCountDownPanel(bool bVisible)
	{
		if (bVisible)
		{
			this.SetCountDownText("", "");
		}
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(bVisible);
		}
		this.TimePanelShowFlag = bVisible;
	}

	// Token: 0x060078EB RID: 30955 RVA: 0x00257661 File Offset: 0x00255861
	public void SetTabViewOpenData(AdventureGuideViewOpenData data)
	{
		this.TabViewOpenData = data;
		if (data.OpenTabViewName != null)
		{
			this.CurSelectTabIndex = this.GetIndexByTabViewName(data.OpenTabViewName.Value);
		}
	}

	// Token: 0x060078EC RID: 30956 RVA: 0x00257690 File Offset: 0x00255890
	private void SetCountDownText(string textParam, string textId)
	{
		if (!StringUtils.IsEmpty(textParam) || !StringUtils.IsEmpty(textId))
		{
			if (!this.TimePanelShowFlag)
			{
				this.ShowCountDownPanel(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textId, new <>z__ReadOnlySingleElementList<object>(textParam));
			return;
		}
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		text.SetText("", true);
	}

	// Token: 0x060078ED RID: 30957 RVA: 0x002576EC File Offset: 0x002558EC
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.AdventureGuideView, null);
	}

	// Token: 0x060078EE RID: 30958 RVA: 0x00257700 File Offset: 0x00255900
	private void OnIntroductionBtnClick()
	{
		int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
		if (devTargetRoleId == 0 || RoleDevelopUtil.IsAnyProspectRole(devTargetRoleId))
		{
			ChannelController.Instance.OpenGameIntroduction();
			return;
		}
		ChannelController.Instance.OpenGameIntroductionByRoleId(devTargetRoleId);
	}

	// Token: 0x060078EF RID: 30959 RVA: 0x0025773C File Offset: 0x0025593C
	protected override void OnBeforeDestroy()
	{
		AdventureGuideModel.Instance.CurrentGuideTabName = null;
		this.TabViewOpenData = null;
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
	}

	// Token: 0x060078F0 RID: 30960 RVA: 0x00257795 File Offset: 0x00255995
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060078F1 RID: 30961 RVA: 0x002577A0 File Offset: 0x002559A0
	private void AdventureHelpBtn(int helpId)
	{
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(helpId != 0);
		}
		if (this.HelpBtn != null)
		{
			this.HelpBtn.HelpGroupId = helpId;
		}
	}

	// Token: 0x060078F2 RID: 30962 RVA: 0x002577E4 File Offset: 0x002559E4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num = int.Parse(configParams[0]);
		int index = -1;
		for (int i = 0; i < this.TabDataList.Length; i++)
		{
			if (this.TabDataList[i].Id == num)
			{
				index = i;
				break;
			}
		}
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		UUIItem uuiitem;
		if (tabComponent == null)
		{
			uuiitem = null;
		}
		else
		{
			CommonTabItem tabItemByIndex = tabComponent.GetTabItemByIndex(index);
			uuiitem = ((tabItemByIndex != null) ? tabItemByIndex.GetRootItem() : null);
		}
		UUIItem uuiitem2 = uuiitem;
		if (uuiitem2 != null)
		{
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Guide;
		ELogAuthor author = ELogAuthor.JT;
		string message = "聚焦引导extraParam项配置有误";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x04004B4E RID: 19278
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04004B4F RID: 19279
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04004B50 RID: 19280
	[Nullable(2)]
	private UUIExtendButtonComponent HelpBtn;

	// Token: 0x04004B51 RID: 19281
	private int CurSelectTabIndex;

	// Token: 0x04004B52 RID: 19282
	protected UiDynamicTab[] TabDataList = new UiDynamicTab[0];

	// Token: 0x04004B53 RID: 19283
	[Nullable(2)]
	private AdventureGuideViewOpenData TabViewOpenData;

	// Token: 0x04004B54 RID: 19284
	private double? LastClickTime;

	// Token: 0x04004B55 RID: 19285
	private bool TimePanelShowFlag;

	// Token: 0x02006DF3 RID: 28147
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x0402405B RID: 147547
		BackBtn,
		// Token: 0x0402405C RID: 147548
		TabComponent,
		// Token: 0x0402405D RID: 147549
		TabRootItem,
		// Token: 0x0402405E RID: 147550
		HelpBtn,
		// Token: 0x0402405F RID: 147551
		PanelTime,
		// Token: 0x04024060 RID: 147552
		TextTime,
		// Token: 0x04024061 RID: 147553
		IntroductionBtn
	}
}
