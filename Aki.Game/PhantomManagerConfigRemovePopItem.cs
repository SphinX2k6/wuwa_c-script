using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001914 RID: 6420
public class PhantomManagerConfigRemovePopItem : UiViewBase
{
	// Token: 0x0600FDEE RID: 65006 RVA: 0x004A1C47 File Offset: 0x0049FE47
	[NullableContext(1)]
	public PhantomManagerConfigRemovePopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FDEF RID: 65007 RVA: 0x004A1C5C File Offset: 0x0049FE5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedToggleL));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickedToggleR));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickedClose));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickedConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FDF0 RID: 65008 RVA: 0x004A1E78 File Offset: 0x004A0078
	protected override void OnStart()
	{
		this.CurData = ((this.OpenParam as IPhantomManagerApplySettingDetailInfo) ?? new PhantomManagerApplySettingDetailInfo());
		this.LoopScrollView = new LoopScrollView<PhantomConfigRemoveItemGrid, PhantomItemData>(base.GetLoopScrollViewComponent(5), base.GetItem(6).GetOwner() as AUIBaseActor, new Func<PhantomConfigRemoveItemGrid>(this.OnCreateItem), false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomProject_Reorganize_Des_1", new <>z__ReadOnlySingleElementList<object>(PhantomStackUtil.GetStackUnitCountByDataList(this.CurData.DiscardList)));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "PhantomProject_Reorganize_Des_2", new <>z__ReadOnlySingleElementList<object>(PhantomStackUtil.GetStackUnitCountByDataList(this.CurData.LockList)));
		if (this.CurData.DiscardList.Count != 0)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			this.OnClickedToggleL(EToggleState.ETT_Checked);
			return;
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
		if (extendToggle2 != null)
		{
			extendToggle2.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		this.OnClickedToggleR(EToggleState.ETT_Checked);
	}

	// Token: 0x0600FDF1 RID: 65009 RVA: 0x004A1F80 File Offset: 0x004A0180
	private void OnClickedToggleL(EToggleState state)
	{
		if (this.CurrentSelected == PhantomManagerConfigRemovePopItem.EPhantomRemovePopState.Left)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PhantomProject_Reorganize_Des_3", new <>z__ReadOnlySingleElementList<object>(PhantomStackUtil.GetStackUnitCountByDataList(this.CurData.DiscardList)));
		this.CurrentSelected = PhantomManagerConfigRemovePopItem.EPhantomRemovePopState.Left;
		this.LoopScrollView.RefreshByData(this.CurData.DiscardList, false, null, true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.CurData.DiscardList.Count == 0);
	}

	// Token: 0x0600FDF2 RID: 65010 RVA: 0x004A2024 File Offset: 0x004A0224
	private void OnClickedToggleR(EToggleState state)
	{
		if (this.CurrentSelected == PhantomManagerConfigRemovePopItem.EPhantomRemovePopState.Right)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PhantomProject_Reorganize_Des_4", new <>z__ReadOnlySingleElementList<object>(PhantomStackUtil.GetStackUnitCountByDataList(this.CurData.LockList)));
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelected = PhantomManagerConfigRemovePopItem.EPhantomRemovePopState.Right;
		this.LoopScrollView.RefreshByData(this.CurData.LockList, false, null, true);
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.CurData.LockList.Count == 0);
	}

	// Token: 0x0600FDF3 RID: 65011 RVA: 0x004A20C7 File Offset: 0x004A02C7
	private void OnClickedClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FDF4 RID: 65012 RVA: 0x004A20D0 File Offset: 0x004A02D0
	private void OnClickedConfirm()
	{
		PhantomBattleModel.Instance.GetPhantomConfigData().DoApplyOpera(this.CurData).ContinueWith(delegate(bool value)
		{
			if (value)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Reorganize_Des_6", Array.Empty<object>());
				base.CloseMe(null);
			}
		}).Forget();
	}

	// Token: 0x0600FDF5 RID: 65013 RVA: 0x004A20FD File Offset: 0x004A02FD
	[NullableContext(1)]
	private PhantomConfigRemoveItemGrid OnCreateItem()
	{
		return new PhantomConfigRemoveItemGrid();
	}

	// Token: 0x04008D46 RID: 36166
	private PhantomManagerConfigRemovePopItem.EPhantomRemovePopState CurrentSelected;

	// Token: 0x04008D47 RID: 36167
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhantomConfigRemoveItemGrid, PhantomItemData> LoopScrollView;

	// Token: 0x04008D48 RID: 36168
	[Nullable(1)]
	private IPhantomManagerApplySettingDetailInfo CurData = new PhantomManagerApplySettingDetailInfo();

	// Token: 0x02007B38 RID: 31544
	private enum EDefine
	{
		// Token: 0x04027EEF RID: 163567
		ToggleTopLeft,
		// Token: 0x04027EF0 RID: 163568
		TxtToggleLeft,
		// Token: 0x04027EF1 RID: 163569
		ToggleTopRight,
		// Token: 0x04027EF2 RID: 163570
		TxtToggleRight,
		// Token: 0x04027EF3 RID: 163571
		TxtEchoNumber,
		// Token: 0x04027EF4 RID: 163572
		ScrollEcho,
		// Token: 0x04027EF5 RID: 163573
		ItemBase,
		// Token: 0x04027EF6 RID: 163574
		BtnLeft,
		// Token: 0x04027EF7 RID: 163575
		BtnRight,
		// Token: 0x04027EF8 RID: 163576
		PanelEmpty
	}

	// Token: 0x02007B39 RID: 31545
	private enum EPhantomRemovePopState
	{
		// Token: 0x04027EFA RID: 163578
		Default,
		// Token: 0x04027EFB RID: 163579
		Left = -1,
		// Token: 0x04027EFC RID: 163580
		Right = 1
	}
}
