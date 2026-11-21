using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F05 RID: 3845
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginEquipView : UiViewBase
{
	// Token: 0x060099F4 RID: 39412 RVA: 0x002DA0F6 File Offset: 0x002D82F6
	public DangoAbyssPluginEquipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060099F5 RID: 39413 RVA: 0x002DA138 File Offset: 0x002D8338
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnRecovery))
		};
	}

	// Token: 0x060099F6 RID: 39414 RVA: 0x002DA2DB File Offset: 0x002D84DB
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x060099F7 RID: 39415 RVA: 0x002DA2EC File Offset: 0x002D84EC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssPluginEquipView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssPluginEquipView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060099F8 RID: 39416 RVA: 0x002DA32F File Offset: 0x002D852F
	private DangoAbyssItemMediumItemGrid CreateGridItem()
	{
		DangoAbyssItemMediumItemGrid dangoAbyssItemMediumItemGrid = new DangoAbyssItemMediumItemGrid();
		dangoAbyssItemMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickItem));
		dangoAbyssItemMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteChange));
		return dangoAbyssItemMediumItemGrid;
	}

	// Token: 0x060099F9 RID: 39417 RVA: 0x002DA35C File Offset: 0x002D855C
	protected override void OnBeforeShow()
	{
		this.ViewModel.SetPluginItem(null, true);
		this.ViewModel.Bind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
		this.AttributeScrollData = new List<DangoAbyssDefine.EquipViewAttributeData>();
		this.LastSlotIndexForList = this.ViewModel.GetSlotIndex();
		int dangoId = this.ViewModel.GetDangoId();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.WDX;
		string message = "打开装备页";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dangoId", dangoId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		bool recoveryAvailable = DangoAbyssModel.Instance.GetRecoveryAvailable();
		base.GetButton(2).RootUIComp.Get().SetUIActive(recoveryAvailable);
		base.SetButtonUiActive(13, false);
		this.RefreshAll();
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
		this.CurEquipListForGuide = ((dangoAbyssRoleData == null) ? new List<int>() : new List<int>(dangoAbyssRoleData.GetEquipItems()));
	}

	// Token: 0x060099FA RID: 39418 RVA: 0x002DA440 File Offset: 0x002D8640
	private void OnDataUpdate(EPluginEquipViewData key)
	{
		switch (key)
		{
		case EPluginEquipViewData.DangoId:
			this.OnDangoIdUpdate();
			return;
		case EPluginEquipViewData.SlotIndex:
			this.OnSlotIndexUpdate();
			return;
		case EPluginEquipViewData.PluginItem:
			this.OnPluginItemUpdate();
			return;
		default:
			return;
		}
	}

	// Token: 0x060099FB RID: 39419 RVA: 0x002DA469 File Offset: 0x002D8669
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.SetSlotIndex(-1, true);
		this.ViewModel.SetPluginItem(null, true);
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x060099FC RID: 39420 RVA: 0x002DA49C File Offset: 0x002D869C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnEventRoleUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
	}

	// Token: 0x060099FD RID: 39421 RVA: 0x002DA4D6 File Offset: 0x002D86D6
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnEventRoleUpdate));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
	}

	// Token: 0x060099FE RID: 39422 RVA: 0x002DA510 File Offset: 0x002D8710
	private void RefreshAll()
	{
		this.RefreshPlugin();
		this.RefreshList();
		this.RefreshAttribute();
		this.RefreshTipsComponent();
	}

	// Token: 0x060099FF RID: 39423 RVA: 0x002DA52A File Offset: 0x002D872A
	private void RefreshPlugin()
	{
		this.PluginPanel.Refresh();
	}

	// Token: 0x06009A00 RID: 39424 RVA: 0x002DA538 File Offset: 0x002D8738
	private void RefreshList()
	{
		int slotIndex = this.ViewModel.GetSlotIndex();
		AbyssPluginItemInfo[] pluginItemListBySlotIndex = DangoAbyssModel.Instance.GetPluginItemListBySlotIndex(slotIndex);
		int dangoId = this.ViewModel.GetDangoId();
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.DangoAbyssPluginEquip, new List<AbyssPluginItemInfo>(pluginItemListBySlotIndex), new object[]
		{
			dangoId
		});
	}

	// Token: 0x06009A01 RID: 39425 RVA: 0x002DA58C File Offset: 0x002D878C
	private void RefreshAttribute()
	{
		int dangoId = this.ViewModel.GetDangoId();
		if (DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId) == null)
		{
			base.GetItem(12).SetUIActive(true);
			base.GetUIDynScrollViewComponent(11).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetItem(12).SetUIActive(false);
		base.GetUIDynScrollViewComponent(11).RootUIComp.Get().SetUIActive(true);
		List<DangoAbyssDefine.EquipViewAttributeData> list = DangoAbyssModel.Instance.GetEquipViewAttributeDataById(dangoId);
		list = DangoAbyssModel.Instance.SetEquipViewAttributeType(this.AttributeScrollData, list);
		this.AttributeScrollData = list;
		this.AttributeScroll.RefreshByData(list.ToArray(), false, false);
	}

	// Token: 0x06009A02 RID: 39426 RVA: 0x002DA640 File Offset: 0x002D8840
	private void RefreshTipsComponent()
	{
		AbyssPluginItemInfo pluginItem = this.ViewModel.GetPluginItem();
		if (pluginItem == null)
		{
			this.TipsComponent.SetUiActive(false);
			return;
		}
		int configId = pluginItem.GetConfigId();
		int slotIndex = this.ViewModel.GetSlotIndex();
		int dangoId = this.ViewModel.GetDangoId();
		ItemTipsData tipsDataByPram = ItemTipsComponentUtilTool.GetTipsDataByPram(DangoAbyssModel.Instance.GetPluginItemTipsData(configId, pluginItem.GetUniqueId(), new int?(slotIndex), new int?(dangoId)));
		this.TipsComponent.Refresh(tipsDataByPram);
		this.TipsComponent.SetUiActive(true);
	}

	// Token: 0x06009A03 RID: 39427 RVA: 0x002DA6C8 File Offset: 0x002D88C8
	private void RefreshAfterFilterSort(bool keepPosition)
	{
		List<AbyssPluginItemInfo> dataAfterFilter = this.DataAfterFilter;
		base.GetItem(6).SetUIActive(dataAfterFilter.Count <= 0);
		int slotIndex = this.ViewModel.GetSlotIndex();
		int count = dataAfterFilter.Count;
		int num = DangoAbyssModel.Instance.GetAllPluginItemList().Length;
		string slotTypeTextIdBySlotIndex = DangoAbyssModel.Instance.GetSlotTypeTextIdBySlotIndex(slotIndex);
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), slotTypeTextIdBySlotIndex, new <>z__ReadOnlySingleElementList<object>(count));
		int pluginItemPackageCapacity = DangoAbyssModel.Instance.GetPluginItemPackageCapacity();
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(14), "Text_DangoPluginItemCapacity_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			pluginItemPackageCapacity
		}));
		this.ItemScroll.RefreshByData(dataAfterFilter, keepPosition, null, false);
	}

	// Token: 0x06009A04 RID: 39428 RVA: 0x002DA790 File Offset: 0x002D8990
	private void SelectAfterFilter(bool keepPosition)
	{
		List<AbyssPluginItemInfo> dataAfterFilter = this.DataAfterFilter;
		if (this.GetSelectIndex() < 0)
		{
			AbyssPluginItemInfo pluginItem = (dataAfterFilter.Count > 0) ? dataAfterFilter[0] : null;
			this.ViewModel.SetPluginItem(pluginItem, false);
		}
		this.ItemScroll.DeselectCurrentGridProxy(false);
		int selectIndex = this.GetSelectIndex();
		this.ItemScroll.SelectGridProxy(selectIndex, false);
		if (!keepPosition)
		{
			this.ScrollToSelect();
		}
	}

	// Token: 0x06009A05 RID: 39429 RVA: 0x002DA7F8 File Offset: 0x002D89F8
	private void ScrollToSelect()
	{
		int selectIndex = this.GetSelectIndex();
		if (selectIndex >= 0)
		{
			this.ItemScroll.ScrollToGridIndex(selectIndex, true);
		}
	}

	// Token: 0x06009A06 RID: 39430 RVA: 0x002DA81D File Offset: 0x002D8A1D
	private void OnFilterSortRefresh(List<AbyssPluginItemInfo> list, bool _1, EFilterSortType _2)
	{
		this.DataAfterFilter = list;
		this.RefreshTipsComponent();
		this.RefreshAfterFilterSort(false);
		this.SelectAfterFilter(false);
	}

	// Token: 0x06009A07 RID: 39431 RVA: 0x002DA83A File Offset: 0x002D8A3A
	private void OnDangoIdUpdate()
	{
		this.RefreshAll();
	}

	// Token: 0x06009A08 RID: 39432 RVA: 0x002DA844 File Offset: 0x002D8A44
	private void OnSlotIndexUpdate()
	{
		int slotIndex = this.ViewModel.GetSlotIndex();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.WDX;
		string message = "EquipView OnSlotIndexUpdate";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", slotIndex);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.RefreshPlugin();
		int dangoId = this.ViewModel.GetDangoId();
		int pluginItemIncIdBySlotIndex = DangoAbyssModel.Instance.GetPluginItemIncIdBySlotIndex(dangoId, slotIndex);
		if (pluginItemIncIdBySlotIndex > 0)
		{
			AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(pluginItemIncIdBySlotIndex);
			AbyssPluginItemInfo pluginItem = this.ViewModel.GetPluginItem();
			if (pluginItem != null && pluginItem.GetUniqueId() != pluginItemInfoById.GetUniqueId())
			{
				this.ItemScroll.DeselectCurrentGridProxy(false);
			}
			this.ViewModel.SetPluginItem(pluginItemInfoById, true);
		}
		if (DangoAbyssModel.Instance.GetIfSlotTypeChange(this.LastSlotIndexForList, slotIndex))
		{
			this.RefreshList();
		}
		else
		{
			this.RefreshAfterFilterSort(pluginItemIncIdBySlotIndex <= 0);
			this.SelectAfterFilter(pluginItemIncIdBySlotIndex <= 0);
		}
		this.LastSlotIndexForList = slotIndex;
		this.RefreshTipsComponent();
	}

	// Token: 0x06009A09 RID: 39433 RVA: 0x002DA93C File Offset: 0x002D8B3C
	private void OnPluginItemUpdate()
	{
		this.ItemScroll.DeselectCurrentGridProxy(false);
		int selectIndex = this.GetSelectIndex();
		this.ItemScroll.SelectGridProxy(selectIndex, false);
		this.ItemScroll.RefreshAllGridProxies();
		this.RefreshTipsComponent();
	}

	// Token: 0x06009A0A RID: 39434 RVA: 0x002DA97C File Offset: 0x002D8B7C
	private void OnEventRoleUpdate()
	{
		List<int> oldEquipList = this.CurEquipListForGuide;
		this.RefreshPlugin();
		this.ItemScroll.RefreshAllGridProxies();
		this.RefreshAttribute();
		this.RefreshTipsComponent();
		int dangoId = this.ViewModel.GetDangoId();
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
		this.CurEquipListForGuide = ((dangoAbyssRoleData == null) ? new List<int>() : new List<int>(dangoAbyssRoleData.GetEquipItems()));
		if (this.CurEquipListForGuide.Exists((int item) => !oldEquipList.Contains(item)) || oldEquipList.Exists((int item) => !this.CurEquipListForGuide.Contains(item)))
		{
			GuideController.Instance.TryFinishRunningGuides();
			this.GuideValidAttrIndexCache = this.GetValidAttrChangeIndex();
			this.GuideInvalidAttrIndexCache = this.GetInvalidAttrIndex();
			EventSystem.Instance.Emit<bool, bool>(EEventName.OnAbyssPluginEquipAttrRefresh, this.GuideInvalidAttrIndexCache > -1, this.GuideValidAttrIndexCache > -1);
		}
	}

	// Token: 0x06009A0B RID: 39435 RVA: 0x002DAA6C File Offset: 0x002D8C6C
	private void OnEventItemFuncValueChange(int uniqueId)
	{
		int indexById = this.GetIndexById(uniqueId, -1);
		if (indexById < 0)
		{
			return;
		}
		this.ItemScroll.RefreshGridProxy(indexById);
	}

	// Token: 0x06009A0C RID: 39436 RVA: 0x002DAA93 File Offset: 0x002D8C93
	private void OnClickClose()
	{
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
		base.CloseMe(null);
	}

	// Token: 0x06009A0D RID: 39437 RVA: 0x002DAAB3 File Offset: 0x002D8CB3
	private void OnClickBtnRecovery()
	{
		if (!DangoAbyssModel.Instance.GetRecoveryAvailable())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssPluginRecoveryView, this.ViewModel, null);
	}

	// Token: 0x06009A0E RID: 39438 RVA: 0x002DAAD8 File Offset: 0x002D8CD8
	private DangoAbyssAttributeParentItem OnCreateAttributeItem(DangoAbyssDefine.EquipViewAttributeData data, UUIItem uiItem, int index)
	{
		return new DangoAbyssAttributeParentItem();
	}

	// Token: 0x06009A0F RID: 39439 RVA: 0x002DAAE0 File Offset: 0x002D8CE0
	private int GetSelectIndex()
	{
		AbyssPluginItemInfo pluginItem = this.ViewModel.GetPluginItem();
		if (pluginItem == null)
		{
			return -1;
		}
		return this.GetIndexById(pluginItem.GetUniqueId(), pluginItem.GetConfigId());
	}

	// Token: 0x06009A10 RID: 39440 RVA: 0x002DAB10 File Offset: 0x002D8D10
	private int GetIndexById(int incId, int itemId)
	{
		if (incId > 0 || itemId > 0)
		{
			for (int i = 0; i < this.DataAfterFilter.Count; i++)
			{
				AbyssPluginItemInfo abyssPluginItemInfo = this.DataAfterFilter[i];
				if (incId > 0)
				{
					if (abyssPluginItemInfo.GetUniqueId() == incId)
					{
						return i;
					}
				}
				else if (abyssPluginItemInfo.GetConfigId() == itemId)
				{
					return i;
				}
			}
		}
		return -1;
	}

	// Token: 0x06009A11 RID: 39441 RVA: 0x002DAB64 File Offset: 0x002D8D64
	private void OnClickItem(MediumItemGridExtendCallback gridData)
	{
		AbyssPluginItemInfo abyssPluginItemInfo = (AbyssPluginItemInfo)gridData.Data;
		AbyssPluginItemInfo pluginItem = this.ViewModel.GetPluginItem();
		int uniqueId = abyssPluginItemInfo.GetUniqueId();
		int? num = (pluginItem != null) ? new int?(pluginItem.GetUniqueId()) : null;
		if (uniqueId == num.GetValueOrDefault() & num != null)
		{
			return;
		}
		if (gridData.State == EToggleState.ETT_Checked)
		{
			AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(abyssPluginItemInfo.GetUniqueId());
			this.ViewModel.SetPluginItem(pluginItemInfoById, false);
		}
	}

	// Token: 0x06009A12 RID: 39442 RVA: 0x002DABE8 File Offset: 0x002D8DE8
	protected bool OnCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		AbyssPluginItemInfo abyssPluginItemInfo = (AbyssPluginItemInfo)data;
		AbyssPluginItemInfo pluginItem = this.ViewModel.GetPluginItem();
		int uniqueId = abyssPluginItemInfo.GetUniqueId();
		int? num = (pluginItem != null) ? new int?(pluginItem.GetUniqueId()) : null;
		bool flag = uniqueId == num.GetValueOrDefault() & num != null;
		bool flag2 = state == EToggleState.ETT_Checked;
		return !flag || !flag2;
	}

	// Token: 0x06009A13 RID: 39443 RVA: 0x002DAC48 File Offset: 0x002D8E48
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "PluginSelect")
		{
			if (configParams.Length < 2)
			{
				return null;
			}
			int displayIndex;
			if (!int.TryParse(configParams[1], out displayIndex))
			{
				return null;
			}
			LoopScrollView<DangoAbyssItemMediumItemGrid, AbyssPluginItemInfo> itemScroll = this.ItemScroll;
			UUIItem uuiitem = (itemScroll != null) ? itemScroll.GetGridByDisplayIndex(displayIndex) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else if (a == "InvalidAttr")
		{
			int guideInvalidAttrIndexCache = this.GuideInvalidAttrIndexCache;
			DynamicScrollView<DangoAbyssAttributeParentItem, DangoAbyssAttributeBaseItem, DangoAbyssDefine.EquipViewAttributeData> attributeScroll = this.AttributeScroll;
			UUIItem uuiitem2 = (attributeScroll != null) ? attributeScroll.GetGridByDisplayIndex(guideInvalidAttrIndexCache) : null;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
		else if (a == "ValidAttr")
		{
			int guideValidAttrIndexCache = this.GuideValidAttrIndexCache;
			DynamicScrollView<DangoAbyssAttributeParentItem, DangoAbyssAttributeBaseItem, DangoAbyssDefine.EquipViewAttributeData> attributeScroll2 = this.AttributeScroll;
			UUIItem uuiitem3 = (attributeScroll2 != null) ? attributeScroll2.GetGridByDisplayIndex(guideValidAttrIndexCache) : null;
			if (uuiitem3 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem3,
				uuiitem3
			};
		}
		else
		{
			if (!(a == "DangoPlugin"))
			{
				return null;
			}
			ItemTipsComponentContentComponent tipsComponent = this.TipsComponent;
			if (tipsComponent == null)
			{
				return null;
			}
			return tipsComponent.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x06009A14 RID: 39444 RVA: 0x002DAD4D File Offset: 0x002D8F4D
	private int GetInvalidAttrIndex()
	{
		return this.AttributeScrollData.FindIndex((DangoAbyssDefine.EquipViewAttributeData data) => !data.IsValid && data.Tag != null);
	}

	// Token: 0x06009A15 RID: 39445 RVA: 0x002DAD79 File Offset: 0x002D8F79
	private int GetValidAttrChangeIndex()
	{
		return this.AttributeScrollData.FindIndex((DangoAbyssDefine.EquipViewAttributeData data) => data.IsChange && data.IsValid);
	}

	// Token: 0x04005BFD RID: 23549
	[Nullable(2)]
	private PluginPanel PluginPanel;

	// Token: 0x04005BFE RID: 23550
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<DangoAbyssItemMediumItemGrid, AbyssPluginItemInfo> ItemScroll;

	// Token: 0x04005BFF RID: 23551
	[Nullable(2)]
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04005C00 RID: 23552
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<AbyssPluginItemInfo> FilterSortEntrance;

	// Token: 0x04005C01 RID: 23553
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<DangoAbyssAttributeParentItem, DangoAbyssAttributeBaseItem, DangoAbyssDefine.EquipViewAttributeData> AttributeScroll;

	// Token: 0x04005C02 RID: 23554
	[Nullable(2)]
	private PluginEquipViewModel ViewModel;

	// Token: 0x04005C03 RID: 23555
	private List<DangoAbyssDefine.EquipViewAttributeData> AttributeScrollData = new List<DangoAbyssDefine.EquipViewAttributeData>();

	// Token: 0x04005C04 RID: 23556
	private List<AbyssPluginItemInfo> DataAfterFilter = new List<AbyssPluginItemInfo>();

	// Token: 0x04005C05 RID: 23557
	private int LastSlotIndexForList = -1;

	// Token: 0x04005C06 RID: 23558
	private List<int> CurEquipListForGuide = new List<int>();

	// Token: 0x04005C07 RID: 23559
	private int GuideValidAttrIndexCache = -1;

	// Token: 0x04005C08 RID: 23560
	private int GuideInvalidAttrIndexCache = -1;

	// Token: 0x02007119 RID: 28953
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024D7B RID: 150907
		BtnClose,
		// Token: 0x04024D7C RID: 150908
		TextTypeCount,
		// Token: 0x04024D7D RID: 150909
		BtnRecovery,
		// Token: 0x04024D7E RID: 150910
		ItemTipsItem,
		// Token: 0x04024D7F RID: 150911
		PluginScrollView,
		// Token: 0x04024D80 RID: 150912
		PluginItem,
		// Token: 0x04024D81 RID: 150913
		EmptyItem,
		// Token: 0x04024D82 RID: 150914
		FilterSortEntrance,
		// Token: 0x04024D83 RID: 150915
		PluginItemPanel,
		// Token: 0x04024D84 RID: 150916
		AttributeContent,
		// Token: 0x04024D85 RID: 150917
		AttributeItem,
		// Token: 0x04024D86 RID: 150918
		AttributeScroller,
		// Token: 0x04024D87 RID: 150919
		AttributeEmptyItem,
		// Token: 0x04024D88 RID: 150920
		BtnMask,
		// Token: 0x04024D89 RID: 150921
		TextMax
	}
}
