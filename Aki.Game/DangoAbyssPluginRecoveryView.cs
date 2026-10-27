using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A4C RID: 6732
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginRecoveryView : UiViewBase
{
	// Token: 0x0600C622 RID: 50722 RVA: 0x002D068F File Offset: 0x002CE88F
	public DangoAbyssPluginRecoveryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C623 RID: 50723 RVA: 0x002D06BC File Offset: 0x002CE8BC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickClose)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickConfirm)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickMask)),
			new ValueTuple<int, Delegate>(13, new Action<EToggleState>(this.OnClickAll))
		};
	}

	// Token: 0x0600C624 RID: 50724 RVA: 0x002D087A File Offset: 0x002CEA7A
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C625 RID: 50725 RVA: 0x002D088C File Offset: 0x002CEA8C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssPluginRecoveryView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssPluginRecoveryView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C626 RID: 50726 RVA: 0x002D08CF File Offset: 0x002CEACF
	protected override void OnBeforeShow()
	{
		this.RefreshList();
		this.RefreshAwardText();
		base.GetItem(0).SetUIActive(true);
	}

	// Token: 0x0600C627 RID: 50727 RVA: 0x002D08EC File Offset: 0x002CEAEC
	private void RefreshList()
	{
		global::AbyssPluginItemInfo[] allPluginItemList = DangoAbyssModel.Instance.GetAllPluginItemList();
		this.DataList = allPluginItemList.ToList<global::AbyssPluginItemInfo>();
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), "Text_DangoPluginCount_Text", new <>z__ReadOnlySingleElementList<object>(allPluginItemList.Length));
		base.GetItem(9).SetUIActive(allPluginItemList.Length == 0);
		this.ItemScroll.UpdateComponent(allPluginItemList.ToList<global::AbyssPluginItemInfo>(), this.Selection, null);
		int dangoId = this.ViewModel.GetDangoId();
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.DangoAbyssPluginRecovery, this.DataList, new object[]
		{
			dangoId
		});
	}

	// Token: 0x0600C628 RID: 50728 RVA: 0x002D098C File Offset: 0x002CEB8C
	private void RefreshAwardText()
	{
		int pluginItemPackageCapacity = DangoAbyssModel.Instance.GetPluginItemPackageCapacity();
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "Text_RecoverySelect_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.Selection.Count,
			pluginItemPackageCapacity
		}));
		Dictionary<int, int> recoverySelectionCountMap = DangoAbyssModel.Instance.GetRecoverySelectionCountMap(this.Selection);
		Dictionary<int, int> recoveryTimesCountMap = DangoAbyssModel.Instance.GetRecoveryTimesCountMap(recoverySelectionCountMap);
		Dictionary<int, int> recoveryRewardItemMap = DangoAbyssModel.Instance.GetRecoveryRewardItemMap(recoveryTimesCountMap);
		List<DangoAbyssDefine.IRecoveryRewardData> list = new List<DangoAbyssDefine.IRecoveryRewardData>();
		foreach (KeyValuePair<int, int> keyValuePair in recoveryRewardItemMap)
		{
			DangoAbyssDefine.IRecoveryRewardData item = new DangoAbyssDefine.IRecoveryRewardData
			{
				ItemId = keyValuePair.Key,
				Count = keyValuePair.Value
			};
			list.Add(item);
		}
		int num;
		recoveryRewardItemMap.TryGetValue(80200001, out num);
		this.AwardScroll.RefreshByData(list, null, false);
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), "Text_RecoveryTimes_Text", new <>z__ReadOnlySingleElementList<object>(num));
	}

	// Token: 0x0600C629 RID: 50729 RVA: 0x002D0AB8 File Offset: 0x002CECB8
	public void ShowTipsComponent(ItemTipsData data)
	{
		this.TipsComponent.Refresh(data);
		base.GetItem(11).SetUIActive(true);
		base.GetButton(12).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600C62A RID: 50730 RVA: 0x002D0AFC File Offset: 0x002CECFC
	private void SwitchAllSelection(bool isClear)
	{
		if (isClear)
		{
			this.Selection = new List<ISelectedData>();
		}
		else
		{
			foreach (global::AbyssPluginItemInfo abyssPluginItemInfo in this.DataList)
			{
				int uniqueId = abyssPluginItemInfo.GetUniqueId();
				if (abyssPluginItemInfo.GetCanRecovery())
				{
					ISelectedData selectedData = null;
					foreach (ISelectedData selectedData2 in this.Selection)
					{
						if (selectedData2.IncId == uniqueId)
						{
							selectedData = selectedData2;
							break;
						}
					}
					if (selectedData == null)
					{
						ISelectedData selectablePropData = SelectablePropDataUtil.GetSelectablePropData(abyssPluginItemInfo);
						selectablePropData.SelectedCount = 1;
						this.Selection.Add(selectablePropData);
					}
				}
			}
		}
		this.ItemScroll.UpdateComponent(this.DataList.ToList<global::AbyssPluginItemInfo>(), this.Selection, null);
		this.ItemScroll.UpdateDataList(this.DataList.ToList<global::AbyssPluginItemInfo>());
		this.RefreshAwardText();
	}

	// Token: 0x0600C62B RID: 50731 RVA: 0x002D0C14 File Offset: 0x002CEE14
	private void OnChangeSelection(List<ISelectedData> dataList, SelectableExpData _)
	{
		this.Selection = dataList;
		this.RefreshAwardText();
	}

	// Token: 0x0600C62C RID: 50732 RVA: 0x002D0C23 File Offset: 0x002CEE23
	private RecoveryRewardItem InitAwardItem()
	{
		return new RecoveryRewardItem();
	}

	// Token: 0x0600C62D RID: 50733 RVA: 0x002D0C2A File Offset: 0x002CEE2A
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C62E RID: 50734 RVA: 0x002D0C34 File Offset: 0x002CEE34
	private void OnClickConfirm()
	{
		Log.Instance.Info(ELogModule.Activity, ELogAuthor.WDX, "OnClickConfirm", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.GetItem(11).SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		Dictionary<int, int> recoverySelectionCountMap = DangoAbyssModel.Instance.GetRecoverySelectionCountMap(this.Selection);
		if (DangoAbyssModel.Instance.GetRecoveryTimesCountAll(recoverySelectionCountMap) <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_NotEnoughItem_Text", Array.Empty<object>());
			return;
		}
		List<int> list = new List<int>();
		foreach (ISelectedData selectedData in this.Selection)
		{
			list.Add(selectedData.IncId);
		}
		DangoAbyssActivityController.Instance.RequestPluginRecovery(list);
	}

	// Token: 0x0600C62F RID: 50735 RVA: 0x002D0D1C File Offset: 0x002CEF1C
	protected void OnClickMask()
	{
		base.GetItem(11).SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600C630 RID: 50736 RVA: 0x002D0D52 File Offset: 0x002CEF52
	protected void OnClickAll(EToggleState state)
	{
		this.SwitchAllSelection(state == EToggleState.ETT_UnChecked);
	}

	// Token: 0x0600C631 RID: 50737 RVA: 0x002D0D60 File Offset: 0x002CEF60
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
		EventSystem.Instance.Add<IReadOnlyList<AddCountItemInfo>>(EEventName.OnAbyssPluginRecovery, new Action<IReadOnlyList<AddCountItemInfo>>(this.OnEventRecovery));
	}

	// Token: 0x0600C632 RID: 50738 RVA: 0x002D0DC4 File Offset: 0x002CEFC4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
		EventSystem.Instance.Remove<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
		EventSystem.Instance.Remove<IReadOnlyList<AddCountItemInfo>>(EEventName.OnAbyssPluginRecovery, new Action<IReadOnlyList<AddCountItemInfo>>(this.OnEventRecovery));
	}

	// Token: 0x0600C633 RID: 50739 RVA: 0x002D0E28 File Offset: 0x002CF028
	private void OnEventClickItem(int itemId, int uniqueId)
	{
		ItemTipsData tipsDataByPram = ItemTipsComponentUtilTool.GetTipsDataByPram(DangoAbyssModel.Instance.GetPluginItemTipsData(itemId, uniqueId, null, null));
		this.ShowTipsComponent(tipsDataByPram);
	}

	// Token: 0x0600C634 RID: 50740 RVA: 0x002D0E60 File Offset: 0x002CF060
	private void OnEventItemFuncValueChange(int uniqueId)
	{
		int num = -1;
		for (int i = 0; i < this.Selection.Count; i++)
		{
			if (this.Selection[i].IncId == uniqueId)
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			this.Selection.RemoveAt(num);
		}
		this.ItemScroll.RemoveAndRefresh(uniqueId);
		this.RefreshAwardText();
	}

	// Token: 0x0600C635 RID: 50741 RVA: 0x002D0EC0 File Offset: 0x002CF0C0
	private void OnEventRecovery(IReadOnlyList<AddCountItemInfo> infoList)
	{
		if (infoList == null || infoList.Count <= 0)
		{
			this.Selection = new List<ISelectedData>();
			this.RefreshList();
			this.RefreshAwardText();
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssPluginRecoveryResultView, infoList.ToArray<AddCountItemInfo>(), delegate(bool _1, int _2)
		{
			this.Selection = new List<ISelectedData>();
			this.RefreshList();
			this.RefreshAwardText();
		});
	}

	// Token: 0x0600C636 RID: 50742 RVA: 0x002D0F14 File Offset: 0x002CF114
	private void OnFilterSortRefresh(List<global::AbyssPluginItemInfo> list, bool _1, EFilterSortType _2)
	{
		this.DataList = list;
		this.ItemScroll.UpdateDataList(this.DataList);
		base.GetItem(11).SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x04005B4C RID: 23372
	private List<ISelectedData> Selection = new List<ISelectedData>();

	// Token: 0x04005B4D RID: 23373
	private List<global::AbyssPluginItemInfo> DataList = new List<global::AbyssPluginItemInfo>();

	// Token: 0x04005B4E RID: 23374
	[Nullable(2)]
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04005B4F RID: 23375
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<global::AbyssPluginItemInfo> FilterSortEntrance;

	// Token: 0x04005B50 RID: 23376
	private readonly DangoAbyssSelectableComponent<global::AbyssPluginItemInfo> ItemScroll = new DangoAbyssSelectableComponent<global::AbyssPluginItemInfo>(false);

	// Token: 0x04005B51 RID: 23377
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RecoveryRewardItem, DangoAbyssDefine.IRecoveryRewardData> AwardScroll;

	// Token: 0x04005B52 RID: 23378
	[Nullable(2)]
	private PluginEquipViewModel ViewModel;

	// Token: 0x02007F93 RID: 32659
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A70 RID: 170608
		PanelReward,
		// Token: 0x04029A71 RID: 170609
		LayoutReward,
		// Token: 0x04029A72 RID: 170610
		TextSelection,
		// Token: 0x04029A73 RID: 170611
		TextCount,
		// Token: 0x04029A74 RID: 170612
		BtnConfirm,
		// Token: 0x04029A75 RID: 170613
		BtnClose,
		// Token: 0x04029A76 RID: 170614
		TextPluginCount,
		// Token: 0x04029A77 RID: 170615
		ItemFilterSort,
		// Token: 0x04029A78 RID: 170616
		LoopScrollPlugin,
		// Token: 0x04029A79 RID: 170617
		ItemEmpty,
		// Token: 0x04029A7A RID: 170618
		ItemPlugin,
		// Token: 0x04029A7B RID: 170619
		ItemTips,
		// Token: 0x04029A7C RID: 170620
		BtnMask,
		// Token: 0x04029A7D RID: 170621
		ToggleAll
	}
}
