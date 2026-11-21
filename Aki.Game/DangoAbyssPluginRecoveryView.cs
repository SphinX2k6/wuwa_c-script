using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F0B RID: 3851
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginRecoveryView : UiViewBase
{
	// Token: 0x06009A32 RID: 39474 RVA: 0x002DB78C File Offset: 0x002D998C
	public DangoAbyssPluginRecoveryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009A33 RID: 39475 RVA: 0x002DB7B8 File Offset: 0x002D99B8
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

	// Token: 0x06009A34 RID: 39476 RVA: 0x002DB976 File Offset: 0x002D9B76
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x06009A35 RID: 39477 RVA: 0x002DB988 File Offset: 0x002D9B88
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssPluginRecoveryView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssPluginRecoveryView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A36 RID: 39478 RVA: 0x002DB9CB File Offset: 0x002D9BCB
	protected override void OnBeforeShow()
	{
		this.RefreshList();
		this.RefreshAwardText();
		base.GetItem(0).SetUIActive(true);
	}

	// Token: 0x06009A37 RID: 39479 RVA: 0x002DB9E8 File Offset: 0x002D9BE8
	private void RefreshList()
	{
		global::AbyssPluginItemInfo[] allPluginItemList = DangoAbyssModel.Instance.GetAllPluginItemList();
		this.DataList = new List<global::AbyssPluginItemInfo>(allPluginItemList);
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), "Text_DangoPluginCount_Text", new <>z__ReadOnlySingleElementList<object>(allPluginItemList.Length));
		base.GetItem(9).SetUIActive(allPluginItemList.Length == 0);
		this.ItemScroll.UpdateComponent(this.DataList, this.Selection, null);
		int dangoId = this.ViewModel.GetDangoId();
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.DangoAbyssPluginRecovery, this.DataList, new object[]
		{
			dangoId
		});
	}

	// Token: 0x06009A38 RID: 39480 RVA: 0x002DBA88 File Offset: 0x002D9C88
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

	// Token: 0x06009A39 RID: 39481 RVA: 0x002DBBB4 File Offset: 0x002D9DB4
	public void ShowTipsComponent(ItemTipsData data)
	{
		this.TipsComponent.Refresh(data);
		base.GetItem(11).SetUIActive(true);
		base.GetButton(12).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x06009A3A RID: 39482 RVA: 0x002DBBF8 File Offset: 0x002D9DF8
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
		this.ItemScroll.UpdateComponent(this.DataList, this.Selection, null);
		this.ItemScroll.UpdateDataList(this.DataList);
		this.RefreshAwardText();
	}

	// Token: 0x06009A3B RID: 39483 RVA: 0x002DBD08 File Offset: 0x002D9F08
	private void OnChangeSelection(List<ISelectedData> dataList, SelectableExpData _)
	{
		this.Selection = dataList;
		this.RefreshAwardText();
	}

	// Token: 0x06009A3C RID: 39484 RVA: 0x002DBD17 File Offset: 0x002D9F17
	private RecoveryRewardItem InitAwardItem()
	{
		return new RecoveryRewardItem();
	}

	// Token: 0x06009A3D RID: 39485 RVA: 0x002DBD1E File Offset: 0x002D9F1E
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009A3E RID: 39486 RVA: 0x002DBD28 File Offset: 0x002D9F28
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

	// Token: 0x06009A3F RID: 39487 RVA: 0x002DBE10 File Offset: 0x002DA010
	protected void OnClickMask()
	{
		base.GetItem(11).SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06009A40 RID: 39488 RVA: 0x002DBE46 File Offset: 0x002DA046
	protected void OnClickAll(EToggleState state)
	{
		this.SwitchAllSelection(state == EToggleState.ETT_UnChecked);
	}

	// Token: 0x06009A41 RID: 39489 RVA: 0x002DBE54 File Offset: 0x002DA054
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
		EventSystem.Instance.Add<IReadOnlyList<AddCountItemInfo>>(EEventName.OnAbyssPluginRecovery, new Action<IReadOnlyList<AddCountItemInfo>>(this.OnEventRecovery));
	}

	// Token: 0x06009A42 RID: 39490 RVA: 0x002DBEB8 File Offset: 0x002DA0B8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
		EventSystem.Instance.Remove<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
		EventSystem.Instance.Remove<IReadOnlyList<AddCountItemInfo>>(EEventName.OnAbyssPluginRecovery, new Action<IReadOnlyList<AddCountItemInfo>>(this.OnEventRecovery));
	}

	// Token: 0x06009A43 RID: 39491 RVA: 0x002DBF1C File Offset: 0x002DA11C
	private void OnEventClickItem(int itemId, int uniqueId)
	{
		ItemTipsData tipsDataByPram = ItemTipsComponentUtilTool.GetTipsDataByPram(DangoAbyssModel.Instance.GetPluginItemTipsData(itemId, uniqueId, null, null));
		this.ShowTipsComponent(tipsDataByPram);
	}

	// Token: 0x06009A44 RID: 39492 RVA: 0x002DBF54 File Offset: 0x002DA154
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

	// Token: 0x06009A45 RID: 39493 RVA: 0x002DBFB4 File Offset: 0x002DA1B4
	private void OnEventRecovery(IReadOnlyList<AddCountItemInfo> infoList)
	{
		if (infoList == null || infoList.Count <= 0)
		{
			this.Selection = new List<ISelectedData>();
			this.RefreshList();
			this.RefreshAwardText();
			return;
		}
		AddCountItemInfo[] array = new AddCountItemInfo[infoList.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = infoList[i];
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssPluginRecoveryResultView, array, delegate(bool _1, int _2)
		{
			this.Selection = new List<ISelectedData>();
			this.RefreshList();
			this.RefreshAwardText();
		});
	}

	// Token: 0x06009A46 RID: 39494 RVA: 0x002DC028 File Offset: 0x002DA228
	private void OnFilterSortRefresh(List<global::AbyssPluginItemInfo> list, bool _1, EFilterSortType _2)
	{
		this.DataList = list;
		this.ItemScroll.UpdateDataList(this.DataList);
		base.GetItem(11).SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x04005C1B RID: 23579
	private List<ISelectedData> Selection = new List<ISelectedData>();

	// Token: 0x04005C1C RID: 23580
	private List<global::AbyssPluginItemInfo> DataList = new List<global::AbyssPluginItemInfo>();

	// Token: 0x04005C1D RID: 23581
	[Nullable(2)]
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04005C1E RID: 23582
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<global::AbyssPluginItemInfo> FilterSortEntrance;

	// Token: 0x04005C1F RID: 23583
	private readonly DangoAbyssSelectableComponent<global::AbyssPluginItemInfo> ItemScroll = new DangoAbyssSelectableComponent<global::AbyssPluginItemInfo>(false);

	// Token: 0x04005C20 RID: 23584
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RecoveryRewardItem, DangoAbyssDefine.IRecoveryRewardData> AwardScroll;

	// Token: 0x04005C21 RID: 23585
	[Nullable(2)]
	private PluginEquipViewModel ViewModel;

	// Token: 0x02007122 RID: 28962
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024DAD RID: 150957
		PanelReward,
		// Token: 0x04024DAE RID: 150958
		LayoutReward,
		// Token: 0x04024DAF RID: 150959
		TextSelection,
		// Token: 0x04024DB0 RID: 150960
		TextCount,
		// Token: 0x04024DB1 RID: 150961
		BtnConfirm,
		// Token: 0x04024DB2 RID: 150962
		BtnClose,
		// Token: 0x04024DB3 RID: 150963
		TextPluginCount,
		// Token: 0x04024DB4 RID: 150964
		ItemFilterSort,
		// Token: 0x04024DB5 RID: 150965
		LoopScrollPlugin,
		// Token: 0x04024DB6 RID: 150966
		ItemEmpty,
		// Token: 0x04024DB7 RID: 150967
		ItemPlugin,
		// Token: 0x04024DB8 RID: 150968
		ItemTips,
		// Token: 0x04024DB9 RID: 150969
		BtnMask,
		// Token: 0x04024DBA RID: 150970
		ToggleAll
	}
}
