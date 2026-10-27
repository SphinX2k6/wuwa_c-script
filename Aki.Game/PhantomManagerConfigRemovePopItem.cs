using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200242F RID: 9263
public class PhantomManagerConfigRemovePopItem : UiViewBase
{
	// Token: 0x06012938 RID: 76088 RVA: 0x0049467B File Offset: 0x0049287B
	[NullableContext(1)]
	public PhantomManagerConfigRemovePopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012939 RID: 76089 RVA: 0x00494690 File Offset: 0x00492890
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

	// Token: 0x0601293A RID: 76090 RVA: 0x004948AC File Offset: 0x00492AAC
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

	// Token: 0x0601293B RID: 76091 RVA: 0x004949B4 File Offset: 0x00492BB4
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

	// Token: 0x0601293C RID: 76092 RVA: 0x00494A58 File Offset: 0x00492C58
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

	// Token: 0x0601293D RID: 76093 RVA: 0x00494AFB File Offset: 0x00492CFB
	private void OnClickedClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601293E RID: 76094 RVA: 0x00494B04 File Offset: 0x00492D04
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

	// Token: 0x0601293F RID: 76095 RVA: 0x00494B31 File Offset: 0x00492D31
	[NullableContext(1)]
	private PhantomConfigRemoveItemGrid OnCreateItem()
	{
		return new PhantomConfigRemoveItemGrid();
	}

	// Token: 0x04008BFF RID: 35839
	private PhantomManagerConfigRemovePopItem.EPhantomRemovePopState CurrentSelected;

	// Token: 0x04008C00 RID: 35840
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhantomConfigRemoveItemGrid, PhantomItemData> LoopScrollView;

	// Token: 0x04008C01 RID: 35841
	[Nullable(1)]
	private IPhantomManagerApplySettingDetailInfo CurData = new PhantomManagerApplySettingDetailInfo();

	// Token: 0x020089B1 RID: 35249
	private enum EDefine
	{
		// Token: 0x0402CBD9 RID: 183257
		ToggleTopLeft,
		// Token: 0x0402CBDA RID: 183258
		TxtToggleLeft,
		// Token: 0x0402CBDB RID: 183259
		ToggleTopRight,
		// Token: 0x0402CBDC RID: 183260
		TxtToggleRight,
		// Token: 0x0402CBDD RID: 183261
		TxtEchoNumber,
		// Token: 0x0402CBDE RID: 183262
		ScrollEcho,
		// Token: 0x0402CBDF RID: 183263
		ItemBase,
		// Token: 0x0402CBE0 RID: 183264
		BtnLeft,
		// Token: 0x0402CBE1 RID: 183265
		BtnRight,
		// Token: 0x0402CBE2 RID: 183266
		PanelEmpty
	}

	// Token: 0x020089B2 RID: 35250
	private enum EPhantomRemovePopState
	{
		// Token: 0x0402CBE4 RID: 183268
		Default,
		// Token: 0x0402CBE5 RID: 183269
		Left = -1,
		// Token: 0x0402CBE6 RID: 183270
		Right = 1
	}
}
