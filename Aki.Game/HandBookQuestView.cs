using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012E9 RID: 4841
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestView : UiViewBase
{
	// Token: 0x0600BEB6 RID: 48822 RVA: 0x00384CC1 File Offset: 0x00382EC1
	public HandBookQuestView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BEB7 RID: 48823 RVA: 0x00384CD8 File Offset: 0x00382ED8
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

	// Token: 0x0600BEB8 RID: 48824 RVA: 0x00384D60 File Offset: 0x00382F60
	protected override UniTask OnBeforeStartAsync()
	{
		HandBookQuestView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HandBookQuestView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BEB9 RID: 48825 RVA: 0x00384DA3 File Offset: 0x00382FA3
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

	// Token: 0x0600BEBA RID: 48826 RVA: 0x00384DC3 File Offset: 0x00382FC3
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600BEBB RID: 48827 RVA: 0x00384DCB File Offset: 0x00382FCB
	protected void Refresh()
	{
		this.RefreshLoopScrollView();
		this.RefreshCollectText();
	}

	// Token: 0x0600BEBC RID: 48828 RVA: 0x00384DDC File Offset: 0x00382FDC
	protected void AddEvent()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Add(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600BEBD RID: 48829 RVA: 0x00384E5C File Offset: 0x0038305C
	protected void RemoveEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Remove(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600BEBE RID: 48830 RVA: 0x00384EDC File Offset: 0x003830DC
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

	// Token: 0x0600BEBF RID: 48831 RVA: 0x00384FA4 File Offset: 0x003831A4
	protected UniTask InitCommonTabTitle()
	{
		HandBookQuestView.<InitCommonTabTitle>d__19 <InitCommonTabTitle>d__;
		<InitCommonTabTitle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCommonTabTitle>d__.<>4__this = this;
		<InitCommonTabTitle>d__.<>1__state = -1;
		<InitCommonTabTitle>d__.<>t__builder.Start<HandBookQuestView.<InitCommonTabTitle>d__19>(ref <InitCommonTabTitle>d__);
		return <InitCommonTabTitle>d__.<>t__builder.Task;
	}

	// Token: 0x0600BEC0 RID: 48832 RVA: 0x00384FE7 File Offset: 0x003831E7
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600BEC1 RID: 48833 RVA: 0x00384FF0 File Offset: 0x003831F0
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		this.CurSelectTabIndex = index;
		this.Refresh();
		(base.GetScrollViewWithScrollbar(1).GetContent().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController).Play("", -1, false);
	}

	// Token: 0x0600BEC2 RID: 48834 RVA: 0x0038504C File Offset: 0x0038324C
	[NullableContext(2)]
	private CommonTabData GetCommonData(int index)
	{
		HandBookQuestTab handBookQuestTab = this.TabDataList[index];
		return new CommonTabData(handBookQuestTab.Icon, new CommonTabTitleData(handBookQuestTab.Name, Array.Empty<object>()), null);
	}

	// Token: 0x0600BEC3 RID: 48835 RVA: 0x00385084 File Offset: 0x00383284
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

	// Token: 0x0600BEC4 RID: 48836 RVA: 0x00385138 File Offset: 0x00383338
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

	// Token: 0x0600BEC5 RID: 48837 RVA: 0x003852F8 File Offset: 0x003834F8
	private HandBookQuestItem InitHandBookQuestItem()
	{
		HandBookQuestItem handBookQuestItem = new HandBookQuestItem();
		this.HandBookItemList.Add(handBookQuestItem);
		return handBookQuestItem;
	}

	// Token: 0x0600BEC6 RID: 48838 RVA: 0x00385318 File Offset: 0x00383518
	private int SortIndex(PlotType a, PlotType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600BEC7 RID: 48839 RVA: 0x00385329 File Offset: 0x00383529
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BEC8 RID: 48840 RVA: 0x00385334 File Offset: 0x00383534
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Quest);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600BEC9 RID: 48841 RVA: 0x00385384 File Offset: 0x00383584
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

	// Token: 0x0600BECA RID: 48842 RVA: 0x0038541C File Offset: 0x0038361C
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

	// Token: 0x0600BECB RID: 48843 RVA: 0x003854B0 File Offset: 0x003836B0
	protected override void OnBeforeDestroy()
	{
		this.RoleRootUiCameraHandleData = null;
		this.GenericScroll = null;
		this.TypeList = null;
		this.HandBookItemList = new List<HandBookQuestItem>();
		this.RemoveEvent();
	}

	// Token: 0x0600BECC RID: 48844 RVA: 0x003854D8 File Offset: 0x003836D8
	private void InitTabData()
	{
		this.TabDataList = HandBookConfig.Instance.GetQuestTabList();
	}

	// Token: 0x04006DCF RID: 28111
	[Nullable(2)]
	protected UiCameraHandleData RoleRootUiCameraHandleData;

	// Token: 0x04006DD0 RID: 28112
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<HandBookQuestItem, PlotType> GenericScroll;

	// Token: 0x04006DD1 RID: 28113
	[Nullable(2)]
	private IReadOnlyList<PlotType> TypeList;

	// Token: 0x04006DD2 RID: 28114
	private List<HandBookQuestItem> HandBookItemList = new List<HandBookQuestItem>();

	// Token: 0x04006DD3 RID: 28115
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04006DD4 RID: 28116
	private int CurSelectTabIndex;

	// Token: 0x04006DD5 RID: 28117
	[Nullable(2)]
	private IReadOnlyList<HandBookQuestTab> TabDataList;

	// Token: 0x04006DD6 RID: 28118
	private double? LastClickTime;

	// Token: 0x04006DD7 RID: 28119
	private int? Interval;

	// Token: 0x0200755C RID: 30044
	[NullableContext(0)]
	private class EHandBookQuestViewDefine
	{
		// Token: 0x040261DF RID: 156127
		public const int TitleItem = 0;

		// Token: 0x040261E0 RID: 156128
		public const int ScrollView = 1;

		// Token: 0x040261E1 RID: 156129
		public const int CollectCountText = 2;

		// Token: 0x040261E2 RID: 156130
		public const int ScrollViewItem = 3;

		// Token: 0x040261E3 RID: 156131
		public const int EmptyItem = 4;
	}
}
