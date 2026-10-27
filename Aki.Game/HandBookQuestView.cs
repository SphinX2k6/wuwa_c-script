using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E27 RID: 7719
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestView : UiViewBase
{
	// Token: 0x0600EA97 RID: 60055 RVA: 0x00379035 File Offset: 0x00377235
	public HandBookQuestView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EA98 RID: 60056 RVA: 0x0037904C File Offset: 0x0037724C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600EA99 RID: 60057 RVA: 0x003790D4 File Offset: 0x003772D4
	protected override UniTask OnBeforeStartAsync()
	{
		HandBookQuestView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HandBookQuestView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA9A RID: 60058 RVA: 0x00379117 File Offset: 0x00377317
	protected override void OnStart()
	{
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.SetHelpButtonShowState(false);
		}
		this.Refresh();
		this.AddEvent();
	}

	// Token: 0x0600EA9B RID: 60059 RVA: 0x00379137 File Offset: 0x00377337
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600EA9C RID: 60060 RVA: 0x0037913F File Offset: 0x0037733F
	protected void Refresh()
	{
		this.RefreshLoopScrollView();
		this.RefreshCollectText();
	}

	// Token: 0x0600EA9D RID: 60061 RVA: 0x00379150 File Offset: 0x00377350
	protected void AddEvent()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Add(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600EA9E RID: 60062 RVA: 0x003791D0 File Offset: 0x003773D0
	protected void RemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Remove(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600EA9F RID: 60063 RVA: 0x00379250 File Offset: 0x00377450
	protected override void OnBeforeShow()
	{
		bool flag = true;
		foreach (HandBookQuestItem handBookQuestItem in this.HandBookItemList)
		{
			foreach (HandBookQuestChildItem handBookQuestChildItem in handBookQuestItem.GetChildItemList())
			{
				UUIExtendToggle tog = handBookQuestChildItem.GetTog();
				if (flag && handBookQuestChildItem.GetIsUnlock())
				{
					tog.SetToggleStateForce(EToggleState.ETT_Checked, false, true, false);
					flag = false;
				}
				else
				{
					tog.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
				}
			}
		}
		this.TabComponent.SelectToggleByIndex(this.CurSelectTabIndex, false);
	}

	// Token: 0x0600EAA0 RID: 60064 RVA: 0x00379318 File Offset: 0x00377518
	protected UniTask InitCommonTabTitle()
	{
		HandBookQuestView.<InitCommonTabTitle>d__19 <InitCommonTabTitle>d__;
		<InitCommonTabTitle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCommonTabTitle>d__.<>4__this = this;
		<InitCommonTabTitle>d__.<>1__state = -1;
		<InitCommonTabTitle>d__.<>t__builder.Start<HandBookQuestView.<InitCommonTabTitle>d__19>(ref <InitCommonTabTitle>d__);
		return <InitCommonTabTitle>d__.<>t__builder.Task;
	}

	// Token: 0x0600EAA1 RID: 60065 RVA: 0x0037935B File Offset: 0x0037755B
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600EAA2 RID: 60066 RVA: 0x00379364 File Offset: 0x00377564
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		this.CurSelectTabIndex = index;
		this.Refresh();
		(base.GetScrollViewWithScrollbar(1).GetContent().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController).Play("", -1, false);
	}

	// Token: 0x0600EAA3 RID: 60067 RVA: 0x003793C0 File Offset: 0x003775C0
	[NullableContext(2)]
	private CommonTabData GetCommonData(int index)
	{
		HandBookQuestTab handBookQuestTab = this.TabDataList[index];
		return new CommonTabData(handBookQuestTab.Icon, new CommonTabTitleData(handBookQuestTab.Name, Array.Empty<object>()), null);
	}

	// Token: 0x0600EAA4 RID: 60068 RVA: 0x003793F8 File Offset: 0x003775F8
	protected bool CanToggleChange()
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		if (this.LastClickTime != null)
		{
			double? num = Time.Instance.Now - this.LastClickTime;
			int? interval = this.Interval;
			double? num2 = (interval != null) ? new double?((double)interval.GetValueOrDefault()) : null;
			if (!(num.GetValueOrDefault() >= num2.GetValueOrDefault() & (num != null & num2 != null)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600EAA5 RID: 60069 RVA: 0x003794AC File Offset: 0x003776AC
	protected void RefreshLoopScrollView()
	{
		if (this.TypeList == null)
		{
			this.TypeList = HandBookConfig.Instance.GetPlotTypeConfigList();
		}
		List<PlotType> list = new List<PlotType>();
		int type = this.TabDataList[this.CurSelectTabIndex].Type;
		foreach (PlotType item in this.TypeList)
		{
			if (item.Type == type)
			{
				IReadOnlyList<PhotographHandBook> plotHandBookConfigByType = HandBookConfig.Instance.GetPlotHandBookConfigByType(item.Id);
				if (plotHandBookConfigByType != null)
				{
					bool flag = true;
					foreach (PhotographHandBook photographHandBook in plotHandBookConfigByType)
					{
						flag = (HandBookModel.Instance.GetHandBookInfo((EHandBookTabType)item.Type, photographHandBook.Id) == null && flag);
					}
					if (!flag)
					{
						list.Add(item);
					}
				}
			}
		}
		list.Sort(new Comparison<PlotType>(this.SortIndex));
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (this.GenericScroll == null)
		{
			this.GenericScroll = new GenericScrollViewNew<HandBookQuestItem, PlotType>(scrollViewWithScrollbar, new Func<HandBookQuestItem>(this.InitHandBookQuestItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, null);
		}
		if (list.Count > 0)
		{
			this.GenericScroll.SetActive(true);
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.GenericScroll.RefreshByData(list, delegate
			{
				GenericScrollViewNew<HandBookQuestItem, PlotType> genericScroll = this.GenericScroll;
				UUIItem uuiitem = (genericScroll != null) ? genericScroll.GetItemByIndex(0) : null;
				if (uuiitem != null)
				{
					GenericScrollViewNew<HandBookQuestItem, PlotType> genericScroll2 = this.GenericScroll;
					if (genericScroll2 == null)
					{
						return;
					}
					genericScroll2.ScrollTo(uuiitem, false);
				}
			}, false);
			return;
		}
		this.GenericScroll.SetActive(false);
		UUIItem item3 = base.GetItem(4);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(true);
	}

	// Token: 0x0600EAA6 RID: 60070 RVA: 0x0037966C File Offset: 0x0037786C
	private HandBookQuestItem InitHandBookQuestItem()
	{
		HandBookQuestItem handBookQuestItem = new HandBookQuestItem();
		this.HandBookItemList.Add(handBookQuestItem);
		return handBookQuestItem;
	}

	// Token: 0x0600EAA7 RID: 60071 RVA: 0x0037968C File Offset: 0x0037788C
	private int SortIndex(PlotType a, PlotType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600EAA8 RID: 60072 RVA: 0x0037969D File Offset: 0x0037789D
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600EAA9 RID: 60073 RVA: 0x003796A8 File Offset: 0x003778A8
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Quest);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600EAAA RID: 60074 RVA: 0x003796F8 File Offset: 0x003778F8
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != (EHandBookTabType)this.TabDataList[this.CurSelectTabIndex].Type)
		{
			return;
		}
		int count = this.HandBookItemList.Count;
		for (int i = 0; i < count; i++)
		{
			List<HandBookQuestChildItem> childItemList = this.HandBookItemList[i].GetChildItemList();
			int count2 = childItemList.Count;
			for (int j = 0; j < count2; j++)
			{
				HandBookQuestChildItem handBookQuestChildItem = childItemList[j];
				HandBookCommonItemData data = handBookQuestChildItem.GetData();
				if (data != null && data.ConfigId == id)
				{
					handBookQuestChildItem.SetNewState(false);
					return;
				}
			}
		}
	}

	// Token: 0x0600EAAB RID: 60075 RVA: 0x00379790 File Offset: 0x00377990
	protected void OnPhotoSelect(int configId)
	{
		foreach (HandBookQuestItem handBookQuestItem in this.HandBookItemList)
		{
			foreach (HandBookQuestChildItem handBookQuestChildItem in handBookQuestItem.GetChildItemList())
			{
				handBookQuestChildItem.GetTog().SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
			}
		}
	}

	// Token: 0x0600EAAC RID: 60076 RVA: 0x00379824 File Offset: 0x00377A24
	protected override void OnBeforeDestroy()
	{
		this.RoleRootUiCameraHandleData = null;
		this.GenericScroll = null;
		this.TypeList = null;
		this.HandBookItemList = new List<HandBookQuestItem>();
		this.RemoveEvent();
	}

	// Token: 0x0600EAAD RID: 60077 RVA: 0x0037984C File Offset: 0x00377A4C
	private void InitTabData()
	{
		this.TabDataList = HandBookConfig.Instance.GetQuestTabList();
	}

	// Token: 0x04006CEE RID: 27886
	[Nullable(2)]
	protected UiCameraHandleData RoleRootUiCameraHandleData;

	// Token: 0x04006CEF RID: 27887
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<HandBookQuestItem, PlotType> GenericScroll;

	// Token: 0x04006CF0 RID: 27888
	[Nullable(2)]
	private IReadOnlyList<PlotType> TypeList;

	// Token: 0x04006CF1 RID: 27889
	private List<HandBookQuestItem> HandBookItemList = new List<HandBookQuestItem>();

	// Token: 0x04006CF2 RID: 27890
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04006CF3 RID: 27891
	private int CurSelectTabIndex;

	// Token: 0x04006CF4 RID: 27892
	[Nullable(2)]
	private IReadOnlyList<HandBookQuestTab> TabDataList;

	// Token: 0x04006CF5 RID: 27893
	private double? LastClickTime;

	// Token: 0x04006CF6 RID: 27894
	private int? Interval;

	// Token: 0x020083D7 RID: 33751
	[NullableContext(0)]
	private class EHandBookQuestViewDefine
	{
		// Token: 0x0402AEBC RID: 175804
		public const int TitleItem = 0;

		// Token: 0x0402AEBD RID: 175805
		public const int ScrollView = 1;

		// Token: 0x0402AEBE RID: 175806
		public const int CollectCountText = 2;

		// Token: 0x0402AEBF RID: 175807
		public const int ScrollViewItem = 3;

		// Token: 0x0402AEC0 RID: 175808
		public const int EmptyItem = 4;
	}
}
