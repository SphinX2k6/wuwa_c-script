using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A6B RID: 6763
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsAbyssDanngoComponent : TipsBaseSubComponent
{
	// Token: 0x0600C72C RID: 50988 RVA: 0x002D5940 File Offset: 0x002D3B40
	public ItemTipsAbyssDanngoComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsChipInfo", rootUiItem, false).Forget();
	}

	// Token: 0x0600C72D RID: 50989 RVA: 0x002D595C File Offset: 0x002D3B5C
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

	// Token: 0x0600C72E RID: 50990 RVA: 0x002D5A3A File Offset: 0x002D3C3A
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x0600C72F RID: 50991 RVA: 0x002D5A58 File Offset: 0x002D3C58
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x0600C730 RID: 50992 RVA: 0x002D5A76 File Offset: 0x002D3C76
	private void RefreshFuncState(int incId)
	{
		this.RefreshView(this.CurrentData);
	}

	// Token: 0x0600C731 RID: 50993 RVA: 0x002D5A84 File Offset: 0x002D3C84
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsAbyssDanngoComponent.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsAbyssDanngoComponent.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C732 RID: 50994 RVA: 0x002D5AC7 File Offset: 0x002D3CC7
	private void OnConfirmBtnClick(int _)
	{
	}

	// Token: 0x0600C733 RID: 50995 RVA: 0x002D5ACC File Offset: 0x002D3CCC
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<RoleAttributeItem, RoleAttributeSt>(base.GetVerticalLayout(1), new Func<RoleAttributeItem>(this.CreateItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		this.TagScroller = new GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData>(base.GetVerticalLayout(3), new Func<DangoAbyssTagItem>(this.CreateTagItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600C734 RID: 50996 RVA: 0x002D5B3B File Offset: 0x002D3D3B
	private DangoAbyssTagItem CreateTagItem()
	{
		return new DangoAbyssTagItem();
	}

	// Token: 0x0600C735 RID: 50997 RVA: 0x002D5B42 File Offset: 0x002D3D42
	private RoleAttributeItem CreateItem()
	{
		return new RoleAttributeItem();
	}

	// Token: 0x0600C736 RID: 50998 RVA: 0x002D5B4C File Offset: 0x002D3D4C
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

	// Token: 0x0600C737 RID: 50999 RVA: 0x002D5B98 File Offset: 0x002D3D98
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

	// Token: 0x0600C738 RID: 51000 RVA: 0x002D5C20 File Offset: 0x002D3E20
	private void RefreshLockToggle(TipsAbyssDangoData data)
	{
		EToggleState state = DangoAbyssModel.Instance.GetDangoItemLockState(data.IncId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600C739 RID: 51001 RVA: 0x002D5C58 File Offset: 0x002D3E58
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

	// Token: 0x0600C73A RID: 51002 RVA: 0x002D5C98 File Offset: 0x002D3E98
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

	// Token: 0x0600C73B RID: 51003 RVA: 0x002D5CEC File Offset: 0x002D3EEC
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

	// Token: 0x0600C73C RID: 51004 RVA: 0x002D5D43 File Offset: 0x002D3F43
	private void RefreshTag(DangoAbyssDefine.DangoAbyssTagData[] data)
	{
		this.TagScroller.RefreshByData(data.ToList<DangoAbyssDefine.DangoAbyssTagData>(), null, false);
	}

	// Token: 0x04005BBB RID: 23483
	[Nullable(2)]
	private TipsAbyssDangoData CurrentData;

	// Token: 0x04005BBC RID: 23484
	[Nullable(2)]
	private InActiveRedItem InActiveRedItem;

	// Token: 0x04005BBD RID: 23485
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04005BBE RID: 23486
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleAttributeItem, RoleAttributeSt> AttributeScroller;

	// Token: 0x04005BBF RID: 23487
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoAbyssTagItem, DangoAbyssDefine.DangoAbyssTagData> TagScroller;

	// Token: 0x02007FB9 RID: 32697
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029B42 RID: 170818
		LockToggle,
		// Token: 0x04029B43 RID: 170819
		BaseAttributeLayout,
		// Token: 0x04029B44 RID: 170820
		BaseAttributeItem,
		// Token: 0x04029B45 RID: 170821
		TagPropVertical,
		// Token: 0x04029B46 RID: 170822
		TagPropItem,
		// Token: 0x04029B47 RID: 170823
		DescItem,
		// Token: 0x04029B48 RID: 170824
		DescText,
		// Token: 0x04029B49 RID: 170825
		ConfirmBtnItem,
		// Token: 0x04029B4A RID: 170826
		InActiveRedItem
	}
}
