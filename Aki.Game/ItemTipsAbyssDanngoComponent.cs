using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F2A RID: 3882
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsAbyssDanngoComponent : TipsBaseSubComponent
{
	// Token: 0x06009B3C RID: 39740 RVA: 0x002E0A2C File Offset: 0x002DEC2C
	public ItemTipsAbyssDanngoComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsChipInfo", rootUiItem, false).Forget();
	}

	// Token: 0x06009B3D RID: 39741 RVA: 0x002E0A48 File Offset: 0x002DEC48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06009B3E RID: 39742 RVA: 0x002E0B26 File Offset: 0x002DED26
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x06009B3F RID: 39743 RVA: 0x002E0B44 File Offset: 0x002DED44
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x06009B40 RID: 39744 RVA: 0x002E0B62 File Offset: 0x002DED62
	private void RefreshFuncState(int incId)
	{
		this.RefreshView(this.CurrentData);
	}

	// Token: 0x06009B41 RID: 39745 RVA: 0x002E0B70 File Offset: 0x002DED70
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsAbyssDanngoComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsAbyssDanngoComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009B42 RID: 39746 RVA: 0x002E0BB3 File Offset: 0x002DEDB3
	private void OnConfirmBtnClick(int _)
	{
	}

	// Token: 0x06009B43 RID: 39747 RVA: 0x002E0BB8 File Offset: 0x002DEDB8
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<RoleAttributeItem, RoleAttributeSt>(base.GetVerticalLayout(1), new Func<RoleAttributeItem>(this.CreateItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		this.TagScroller = new GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetVerticalLayout(3), new Func<DangoAbyssTagItem>(this.CreateTagItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06009B44 RID: 39748 RVA: 0x002E0C27 File Offset: 0x002DEE27
	private DangoAbyssTagItem CreateTagItem()
	{
		return new DangoAbyssTagItem();
	}

	// Token: 0x06009B45 RID: 39749 RVA: 0x002E0C2E File Offset: 0x002DEE2E
	private RoleAttributeItem CreateItem()
	{
		return new RoleAttributeItem();
	}

	// Token: 0x06009B46 RID: 39750 RVA: 0x002E0C38 File Offset: 0x002DEE38
	public override void Refresh(ItemTipsData data)
	{
		Action action = delegate()
		{
			this.RefreshView((TipsAbyssDangoData)data);
		};
		if (base.InAsyncLoading())
		{
			this.OperationMap["Refresh"] = action;
			return;
		}
		action();
	}

	// Token: 0x06009B47 RID: 39751 RVA: 0x002E0C84 File Offset: 0x002DEE84
	private void RefreshView(TipsAbyssDangoData data)
	{
		this.CurrentData = data;
		AttrListScrollData[] pluginShowAttributeList = DangoAbyssModel.Instance.GetPluginShowAttributeList(data.ConfigId);
		this.RefreshAttribute(pluginShowAttributeList);
		DangoAbyssDefine.DangoAbyssTagData[] pluginShowTagDataList = DangoAbyssModel.Instance.GetPluginShowTagDataList(data.ConfigId);
		this.RefreshTag(pluginShowTagDataList);
		ItemConfig dangoItemConfig = DangoAbyssModel.Instance.GetDangoItemConfig(data.ConfigId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), dangoItemConfig.BgDescription, Array.Empty<object>());
		this.RefreshInActiveRedItem(data);
		this.RefreshConfirmBtn(data);
		this.RefreshLockToggle(data);
	}

	// Token: 0x06009B48 RID: 39752 RVA: 0x002E0D0C File Offset: 0x002DEF0C
	private void RefreshLockToggle(TipsAbyssDangoData data)
	{
		EToggleState state = DangoAbyssModel.Instance.GetDangoItemLockState(data.IncId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06009B49 RID: 39753 RVA: 0x002E0D44 File Offset: 0x002DEF44
	private void RefreshConfirmBtn(TipsAbyssDangoData data)
	{
		int dangoItemBelongId = DangoAbyssModel.Instance.GetDangoItemBelongId(data.IncId);
		bool buttonAllowEventBubbleUp = dangoItemBelongId == 0 || data.DangoId == dangoItemBelongId;
		ButtonItem confirmBtnItem = this.ConfirmBtnItem;
		if (confirmBtnItem == null)
		{
			return;
		}
		confirmBtnItem.SetButtonAllowEventBubbleUp(buttonAllowEventBubbleUp);
	}

	// Token: 0x06009B4A RID: 39754 RVA: 0x002E0D84 File Offset: 0x002DEF84
	private void RefreshInActiveRedItem(TipsAbyssDangoData data)
	{
		int dangoItemBelongId = DangoAbyssModel.Instance.GetDangoItemBelongId(data.IncId);
		if (dangoItemBelongId != 0)
		{
			bool active = data.DangoId != dangoItemBelongId;
			InActiveRedItem inActiveRedItem = this.InActiveRedItem;
			if (inActiveRedItem != null)
			{
				inActiveRedItem.SetActive(active);
			}
			return;
		}
		InActiveRedItem inActiveRedItem2 = this.InActiveRedItem;
		if (inActiveRedItem2 == null)
		{
			return;
		}
		inActiveRedItem2.SetActive(false);
	}

	// Token: 0x06009B4B RID: 39755 RVA: 0x002E0DD8 File Offset: 0x002DEFD8
	private void RefreshAttribute(AttrListScrollData[] data)
	{
		List<RoleAttributeSt> list = new List<RoleAttributeSt>();
		if (data != null)
		{
			foreach (AttrListScrollData data2 in data)
			{
				list.Add(new RoleAttributeSt
				{
					Data = data2,
					NeedCheckBg = false
				});
			}
		}
		this.AttributeScroller.RefreshByData(list, null, false);
	}

	// Token: 0x06009B4C RID: 39756 RVA: 0x002E0E2F File Offset: 0x002DF02F
	private void RefreshTag(DangoAbyssDefine.DangoAbyssTagData[] data)
	{
		this.TagScroller.RefreshByData(data, null, false);
	}

	// Token: 0x04005C8A RID: 23690
	[Nullable(2)]
	private TipsAbyssDangoData CurrentData;

	// Token: 0x04005C8B RID: 23691
	[Nullable(2)]
	private InActiveRedItem InActiveRedItem;

	// Token: 0x04005C8C RID: 23692
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04005C8D RID: 23693
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleAttributeItem, RoleAttributeSt> AttributeScroller;

	// Token: 0x04005C8E RID: 23694
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;

	// Token: 0x02007148 RID: 29000
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024E7F RID: 151167
		LockToggle,
		// Token: 0x04024E80 RID: 151168
		BaseAttributeLayout,
		// Token: 0x04024E81 RID: 151169
		BaseAttributeItem,
		// Token: 0x04024E82 RID: 151170
		TagPropVertical,
		// Token: 0x04024E83 RID: 151171
		TagPropItem,
		// Token: 0x04024E84 RID: 151172
		DescItem,
		// Token: 0x04024E85 RID: 151173
		DescText,
		// Token: 0x04024E86 RID: 151174
		ConfirmBtnItem,
		// Token: 0x04024E87 RID: 151175
		InActiveRedItem
	}
}
