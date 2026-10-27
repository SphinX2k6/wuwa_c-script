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

// Token: 0x02001695 RID: 5781
[NullableContext(1)]
[Nullable(0)]
public class AdventureGuideView : UiViewBase
{
	// Token: 0x0600A4FA RID: 42234 RVA: 0x0024CBC7 File Offset: 0x0024ADC7
	public AdventureGuideView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600A4FB RID: 42235 RVA: 0x0024CBDC File Offset: 0x0024ADDC
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

	// Token: 0x0600A4FC RID: 42236 RVA: 0x0024CD4C File Offset: 0x0024AF4C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.AdventureHelpBtn, new Action<int>(this.AdventureHelpBtn));
		EventSystem.Instance.Add<string, string>(EEventName.DailyActivityCountDownUpdate, new Action<string, string>(this.SetCountDownText));
		EventSystem.Instance.Add<EUiTabViewName, int?>(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.SwitchTabView));
		EventSystem.Instance.Add<AdventureGuideViewOpenData>(EEventName.SwitchAdventureGuideViewTab, new Action<AdventureGuideViewOpenData>(this.SwitchAdventureGuideViewTab));
	}

	// Token: 0x0600A4FD RID: 42237 RVA: 0x0024CDC4 File Offset: 0x0024AFC4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.AdventureHelpBtn, new Action<int>(this.AdventureHelpBtn));
		EventSystem.Instance.Remove(EEventName.DailyActivityCountDownUpdate, new Action<string, string>(this.SetCountDownText));
		EventSystem.Instance.Remove(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.SwitchTabView));
		EventSystem.Instance.Remove(EEventName.SwitchAdventureGuideViewTab, new Action<AdventureGuideViewOpenData>(this.SwitchAdventureGuideViewTab));
	}

	// Token: 0x0600A4FE RID: 42238 RVA: 0x0024CE3C File Offset: 0x0024B03C
	protected override UniTask OnBeforeStartAsync()
	{
		AdventureGuideView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdventureGuideView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A4FF RID: 42239 RVA: 0x0024CE7F File Offset: 0x0024B07F
	protected override void OnBeforeShow()
	{
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.SelectToggleByIndex(this.CurSelectTabIndex, true);
	}

	// Token: 0x0600A500 RID: 42240 RVA: 0x0024CE98 File Offset: 0x0024B098
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

	// Token: 0x0600A501 RID: 42241 RVA: 0x0024CEDC File Offset: 0x0024B0DC
	protected UniTask InitTabComponent()
	{
		AdventureGuideView.<InitTabComponent>d__16 <InitTabComponent>d__;
		<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabComponent>d__.<>4__this = this;
		<InitTabComponent>d__.<>1__state = -1;
		<InitTabComponent>d__.<>t__builder.Start<AdventureGuideView.<InitTabComponent>d__16>(ref <InitTabComponent>d__);
		return <InitTabComponent>d__.<>t__builder.Task;
	}

	// Token: 0x0600A502 RID: 42242 RVA: 0x0024CF1F File Offset: 0x0024B11F
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600A503 RID: 42243 RVA: 0x0024CF28 File Offset: 0x0024B128
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

	// Token: 0x0600A504 RID: 42244 RVA: 0x0024D040 File Offset: 0x0024B240
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

	// Token: 0x0600A505 RID: 42245 RVA: 0x0024D0AC File Offset: 0x0024B2AC
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0600A506 RID: 42246 RVA: 0x0024D0E4 File Offset: 0x0024B2E4
	protected UniTask RebuildTabItem()
	{
		AdventureGuideView.<RebuildTabItem>d__21 <RebuildTabItem>d__;
		<RebuildTabItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RebuildTabItem>d__.<>4__this = this;
		<RebuildTabItem>d__.<>1__state = -1;
		<RebuildTabItem>d__.<>t__builder.Start<AdventureGuideView.<RebuildTabItem>d__21>(ref <RebuildTabItem>d__);
		return <RebuildTabItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A507 RID: 42247 RVA: 0x0024D128 File Offset: 0x0024B328
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

	// Token: 0x0600A508 RID: 42248 RVA: 0x0024D1E4 File Offset: 0x0024B3E4
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

	// Token: 0x0600A509 RID: 42249 RVA: 0x0024D24C File Offset: 0x0024B44C
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

	// Token: 0x0600A50A RID: 42250 RVA: 0x0024D2AE File Offset: 0x0024B4AE
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

	// Token: 0x0600A50B RID: 42251 RVA: 0x0024D2DD File Offset: 0x0024B4DD
	public void SetTabViewOpenData(AdventureGuideViewOpenData data)
	{
		this.TabViewOpenData = data;
		if (data.OpenTabViewName != null)
		{
			this.CurSelectTabIndex = this.GetIndexByTabViewName(data.OpenTabViewName.Value);
		}
	}

	// Token: 0x0600A50C RID: 42252 RVA: 0x0024D30C File Offset: 0x0024B50C
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

	// Token: 0x0600A50D RID: 42253 RVA: 0x0024D368 File Offset: 0x0024B568
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.AdventureGuideView, null);
	}

	// Token: 0x0600A50E RID: 42254 RVA: 0x0024D37C File Offset: 0x0024B57C
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

	// Token: 0x0600A50F RID: 42255 RVA: 0x0024D3B8 File Offset: 0x0024B5B8
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

	// Token: 0x0600A510 RID: 42256 RVA: 0x0024D411 File Offset: 0x0024B611
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A511 RID: 42257 RVA: 0x0024D41C File Offset: 0x0024B61C
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

	// Token: 0x0600A512 RID: 42258 RVA: 0x0024D460 File Offset: 0x0024B660
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

	// Token: 0x04004AA7 RID: 19111
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04004AA8 RID: 19112
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04004AA9 RID: 19113
	[Nullable(2)]
	private UUIExtendButtonComponent HelpBtn;

	// Token: 0x04004AAA RID: 19114
	private int CurSelectTabIndex;

	// Token: 0x04004AAB RID: 19115
	protected UiDynamicTab[] TabDataList = new UiDynamicTab[0];

	// Token: 0x04004AAC RID: 19116
	[Nullable(2)]
	private AdventureGuideViewOpenData TabViewOpenData;

	// Token: 0x04004AAD RID: 19117
	private double? LastClickTime;

	// Token: 0x04004AAE RID: 19118
	private bool TimePanelShowFlag;

	// Token: 0x02007C6E RID: 31854
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x04028D32 RID: 167218
		BackBtn,
		// Token: 0x04028D33 RID: 167219
		TabComponent,
		// Token: 0x04028D34 RID: 167220
		TabRootItem,
		// Token: 0x04028D35 RID: 167221
		HelpBtn,
		// Token: 0x04028D36 RID: 167222
		PanelTime,
		// Token: 0x04028D37 RID: 167223
		TextTime,
		// Token: 0x04028D38 RID: 167224
		IntroductionBtn
	}
}
