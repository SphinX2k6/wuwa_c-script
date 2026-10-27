using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A46 RID: 6726
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginEquipView : UiViewBase
{
	// Token: 0x0600C5E4 RID: 50660 RVA: 0x002CEFF2 File Offset: 0x002CD1F2
	public DangoAbyssPluginEquipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C5E5 RID: 50661 RVA: 0x002CF034 File Offset: 0x002CD234
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

	// Token: 0x0600C5E6 RID: 50662 RVA: 0x002CF1D7 File Offset: 0x002CD3D7
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C5E7 RID: 50663 RVA: 0x002CF1E8 File Offset: 0x002CD3E8
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssPluginEquipView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssPluginEquipView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5E8 RID: 50664 RVA: 0x002CF22B File Offset: 0x002CD42B
	private DangoAbyssItemMediumItemGrid CreateGridItem()
	{
		DangoAbyssItemMediumItemGrid dangoAbyssItemMediumItemGrid = new DangoAbyssItemMediumItemGrid();
		dangoAbyssItemMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickItem));
		dangoAbyssItemMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteChange));
		return dangoAbyssItemMediumItemGrid;
	}

	// Token: 0x0600C5E9 RID: 50665 RVA: 0x002CF258 File Offset: 0x002CD458
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
		this.CurEquipListForGuide = (((dangoAbyssRoleData != null) ? dangoAbyssRoleData.GetEquipItems().ToList<int>() : null) ?? new List<int>());
	}

	// Token: 0x0600C5EA RID: 50666 RVA: 0x002CF341 File Offset: 0x002CD541
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

	// Token: 0x0600C5EB RID: 50667 RVA: 0x002CF36A File Offset: 0x002CD56A
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.SetSlotIndex(-1, true);
		this.ViewModel.SetPluginItem(null, true);
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x0600C5EC RID: 50668 RVA: 0x002CF39D File Offset: 0x002CD59D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnEventRoleUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
	}

	// Token: 0x0600C5ED RID: 50669 RVA: 0x002CF3D7 File Offset: 0x002CD5D7
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnEventRoleUpdate));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnEventItemFuncValueChange));
	}

	// Token: 0x0600C5EE RID: 50670 RVA: 0x002CF411 File Offset: 0x002CD611
	private void RefreshAll()
	{
		this.RefreshPlugin();
		this.RefreshList();
		this.RefreshAttribute();
		this.RefreshTipsComponent();
	}

	// Token: 0x0600C5EF RID: 50671 RVA: 0x002CF42B File Offset: 0x002CD62B
	private void RefreshPlugin()
	{
		this.PluginPanel.Refresh();
	}

	// Token: 0x0600C5F0 RID: 50672 RVA: 0x002CF438 File Offset: 0x002CD638
	private void RefreshList()
	{
		int slotIndex = this.ViewModel.GetSlotIndex();
		AbyssPluginItemInfo[] pluginItemListBySlotIndex = DangoAbyssModel.Instance.GetPluginItemListBySlotIndex(slotIndex);
		int dangoId = this.ViewModel.GetDangoId();
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.DangoAbyssPluginEquip, pluginItemListBySlotIndex.ToList<AbyssPluginItemInfo>(), new object[]
		{
			dangoId
		});
	}

	// Token: 0x0600C5F1 RID: 50673 RVA: 0x002CF48C File Offset: 0x002CD68C
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

	// Token: 0x0600C5F2 RID: 50674 RVA: 0x002CF540 File Offset: 0x002CD740
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

	// Token: 0x0600C5F3 RID: 50675 RVA: 0x002CF5C8 File Offset: 0x002CD7C8
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

	// Token: 0x0600C5F4 RID: 50676 RVA: 0x002CF690 File Offset: 0x002CD890
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

	// Token: 0x0600C5F5 RID: 50677 RVA: 0x002CF6F8 File Offset: 0x002CD8F8
	private void ScrollToSelect()
	{
		int selectIndex = this.GetSelectIndex();
		if (selectIndex >= 0)
		{
			this.ItemScroll.ScrollToGridIndex(selectIndex, true);
		}
	}

	// Token: 0x0600C5F6 RID: 50678 RVA: 0x002CF71D File Offset: 0x002CD91D
	private void OnFilterSortRefresh(List<AbyssPluginItemInfo> list, bool _1, EFilterSortType _2)
	{
		this.DataAfterFilter = list;
		this.RefreshTipsComponent();
		this.RefreshAfterFilterSort(false);
		this.SelectAfterFilter(false);
	}

	// Token: 0x0600C5F7 RID: 50679 RVA: 0x002CF73A File Offset: 0x002CD93A
	private void OnDangoIdUpdate()
	{
		this.RefreshAll();
	}

	// Token: 0x0600C5F8 RID: 50680 RVA: 0x002CF744 File Offset: 0x002CD944
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

	// Token: 0x0600C5F9 RID: 50681 RVA: 0x002CF83C File Offset: 0x002CDA3C
	private void OnPluginItemUpdate()
	{
		this.ItemScroll.DeselectCurrentGridProxy(false);
		int selectIndex = this.GetSelectIndex();
		this.ItemScroll.SelectGridProxy(selectIndex, false);
		this.ItemScroll.RefreshAllGridProxies();
		this.RefreshTipsComponent();
	}

	// Token: 0x0600C5FA RID: 50682 RVA: 0x002CF87C File Offset: 0x002CDA7C
	private void OnEventRoleUpdate()
	{
		List<int> oldEquipList = this.CurEquipListForGuide;
		this.RefreshPlugin();
		this.ItemScroll.RefreshAllGridProxies();
		this.RefreshAttribute();
		this.RefreshTipsComponent();
		int dangoId = this.ViewModel.GetDangoId();
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
		this.CurEquipListForGuide = (((dangoAbyssRoleData != null) ? dangoAbyssRoleData.GetEquipItems().ToList<int>() : null) ?? new List<int>());
		if (this.CurEquipListForGuide.Exists((int item) => !oldEquipList.Contains(item)) || oldEquipList.Exists((int item) => !this.CurEquipListForGuide.Contains(item)))
		{
			GuideController.Instance.TryFinishRunningGuides();
			this.GuideValidAttrIndexCache = this.GetValidAttrChangeIndex();
			this.GuideInvalidAttrIndexCache = this.GetInvalidAttrIndex();
			EventSystem.Instance.Emit<bool, bool>(EEventName.OnAbyssPluginEquipAttrRefresh, this.GuideInvalidAttrIndexCache > -1, this.GuideValidAttrIndexCache > -1);
		}
	}

	// Token: 0x0600C5FB RID: 50683 RVA: 0x002CF970 File Offset: 0x002CDB70
	private void OnEventItemFuncValueChange(int uniqueId)
	{
		int indexById = this.GetIndexById(uniqueId, -1);
		if (indexById < 0)
		{
			return;
		}
		this.ItemScroll.RefreshGridProxy(indexById);
	}

	// Token: 0x0600C5FC RID: 50684 RVA: 0x002CF997 File Offset: 0x002CDB97
	private void OnClickClose()
	{
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
		base.CloseMe(null);
	}

	// Token: 0x0600C5FD RID: 50685 RVA: 0x002CF9B7 File Offset: 0x002CDBB7
	private void OnClickBtnRecovery()
	{
		if (!DangoAbyssModel.Instance.GetRecoveryAvailable())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssPluginRecoveryView, this.ViewModel, null);
	}

	// Token: 0x0600C5FE RID: 50686 RVA: 0x002CF9DC File Offset: 0x002CDBDC
	private DangoAbyssAttributeParentItem OnCreateAttributeItem(DangoAbyssDefine.EquipViewAttributeData data, UUIItem uiItem, int index)
	{
		return new DangoAbyssAttributeParentItem();
	}

	// Token: 0x0600C5FF RID: 50687 RVA: 0x002CF9E4 File Offset: 0x002CDBE4
	private int GetSelectIndex()
	{
		AbyssPluginItemInfo pluginItem = this.ViewModel.GetPluginItem();
		if (pluginItem == null)
		{
			return -1;
		}
		return this.GetIndexById(pluginItem.GetUniqueId(), pluginItem.GetConfigId());
	}

	// Token: 0x0600C600 RID: 50688 RVA: 0x002CFA14 File Offset: 0x002CDC14
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

	// Token: 0x0600C601 RID: 50689 RVA: 0x002CFA68 File Offset: 0x002CDC68
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

	// Token: 0x0600C602 RID: 50690 RVA: 0x002CFAEC File Offset: 0x002CDCEC
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

	// Token: 0x0600C603 RID: 50691 RVA: 0x002CFB4C File Offset: 0x002CDD4C
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

	// Token: 0x0600C604 RID: 50692 RVA: 0x002CFC51 File Offset: 0x002CDE51
	private int GetInvalidAttrIndex()
	{
		return this.AttributeScrollData.FindIndex((DangoAbyssDefine.EquipViewAttributeData data) => !data.IsValid && data.Tag != null);
	}

	// Token: 0x0600C605 RID: 50693 RVA: 0x002CFC7D File Offset: 0x002CDE7D
	private int GetValidAttrChangeIndex()
	{
		return this.AttributeScrollData.FindIndex((DangoAbyssDefine.EquipViewAttributeData data) => data.IsChange && data.IsValid);
	}

	// Token: 0x04005B2E RID: 23342
	[Nullable(2)]
	private PluginPanel PluginPanel;

	// Token: 0x04005B2F RID: 23343
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<DangoAbyssItemMediumItemGrid, AbyssPluginItemInfo> ItemScroll;

	// Token: 0x04005B30 RID: 23344
	[Nullable(2)]
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04005B31 RID: 23345
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<AbyssPluginItemInfo> FilterSortEntrance;

	// Token: 0x04005B32 RID: 23346
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<DangoAbyssAttributeParentItem, DangoAbyssAttributeBaseItem, DangoAbyssDefine.EquipViewAttributeData> AttributeScroll;

	// Token: 0x04005B33 RID: 23347
	[Nullable(2)]
	private PluginEquipViewModel ViewModel;

	// Token: 0x04005B34 RID: 23348
	private List<DangoAbyssDefine.EquipViewAttributeData> AttributeScrollData = new List<DangoAbyssDefine.EquipViewAttributeData>();

	// Token: 0x04005B35 RID: 23349
	private List<AbyssPluginItemInfo> DataAfterFilter = new List<AbyssPluginItemInfo>();

	// Token: 0x04005B36 RID: 23350
	private int LastSlotIndexForList = -1;

	// Token: 0x04005B37 RID: 23351
	private List<int> CurEquipListForGuide = new List<int>();

	// Token: 0x04005B38 RID: 23352
	private int GuideValidAttrIndexCache = -1;

	// Token: 0x04005B39 RID: 23353
	private int GuideInvalidAttrIndexCache = -1;

	// Token: 0x02007F8A RID: 32650
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A3E RID: 170558
		BtnClose,
		// Token: 0x04029A3F RID: 170559
		TextTypeCount,
		// Token: 0x04029A40 RID: 170560
		BtnRecovery,
		// Token: 0x04029A41 RID: 170561
		ItemTipsItem,
		// Token: 0x04029A42 RID: 170562
		PluginScrollView,
		// Token: 0x04029A43 RID: 170563
		PluginItem,
		// Token: 0x04029A44 RID: 170564
		EmptyItem,
		// Token: 0x04029A45 RID: 170565
		FilterSortEntrance,
		// Token: 0x04029A46 RID: 170566
		PluginItemPanel,
		// Token: 0x04029A47 RID: 170567
		AttributeContent,
		// Token: 0x04029A48 RID: 170568
		AttributeItem,
		// Token: 0x04029A49 RID: 170569
		AttributeScroller,
		// Token: 0x04029A4A RID: 170570
		AttributeEmptyItem,
		// Token: 0x04029A4B RID: 170571
		BtnMask,
		// Token: 0x04029A4C RID: 170572
		TextMax
	}
}
