using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001025 RID: 4133
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchHandBookView : UiViewBase
{
	// Token: 0x0600A478 RID: 42104 RVA: 0x00304836 File Offset: 0x00302A36
	public FloroRanchHandBookView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A479 RID: 42105 RVA: 0x00304840 File Offset: 0x00302A40
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnPhantomBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToyBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A47A RID: 42106 RVA: 0x00304A58 File Offset: 0x00302C58
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchHandBookView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchHandBookView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A47B RID: 42107 RVA: 0x00304A9B File Offset: 0x00302C9B
	private FloroRanchActivityData GetHandBookActivityData()
	{
		return FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true);
	}

	// Token: 0x0600A47C RID: 42108 RVA: 0x00304AB0 File Offset: 0x00302CB0
	private UniTask RefreshView()
	{
		FloroRanchHandBookView.<RefreshView>d__10 <RefreshView>d__;
		<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshView>d__.<>4__this = this;
		<RefreshView>d__.<>1__state = -1;
		<RefreshView>d__.<>t__builder.Start<FloroRanchHandBookView.<RefreshView>d__10>(ref <RefreshView>d__);
		return <RefreshView>d__.<>t__builder.Task;
	}

	// Token: 0x0600A47D RID: 42109 RVA: 0x00304AF4 File Offset: 0x00302CF4
	private void RefreshTabRedDot()
	{
		FloroRanchActivityData handBookActivityData = this.GetHandBookActivityData();
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(handBookActivityData.IsCardHasRedDot());
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(handBookActivityData.IsToyHasRedDot());
	}

	// Token: 0x0600A47E RID: 42110 RVA: 0x00304B39 File Offset: 0x00302D39
	private bool IsSelectedItem()
	{
		return this.CurrentSelectedItem != null;
	}

	// Token: 0x0600A47F RID: 42111 RVA: 0x00304B44 File Offset: 0x00302D44
	private void OnItemClick(FloroRanchHandBookSmallSlotItem item)
	{
		FloroRanchHandBookSmallSlotItem currentSelectedItem = this.CurrentSelectedItem;
		if (currentSelectedItem != null)
		{
			currentSelectedItem.OnDeselected(true);
		}
		this.CurrentSelectedItem = item;
		item.OnSelected(true);
		this.RefreshTabRedDot();
		this.RefreshCardItem(item.Data);
	}

	// Token: 0x0600A480 RID: 42112 RVA: 0x00304B78 File Offset: 0x00302D78
	private void RefreshCardItem(FloroRanchUnlockDataBase data)
	{
		this.CardItem.CardType = this.CurrentType;
		this.CardItem.Refresh(data.Id, false, 0);
		this.CardItem.SetItemAlpha(1f);
		this.CardItem.HideNewLabel();
		if (!data.IsUnLock)
		{
			this.CardItem.SetLock();
		}
	}

	// Token: 0x0600A481 RID: 42113 RVA: 0x00304BD7 File Offset: 0x00302DD7
	private bool OnPhantomCanExecuteChange()
	{
		return this.CurrentType > EFloroRanchCardType.Phantom;
	}

	// Token: 0x0600A482 RID: 42114 RVA: 0x00304BE2 File Offset: 0x00302DE2
	private bool OnToyCanExecuteChange()
	{
		return this.CurrentType != EFloroRanchCardType.Toy;
	}

	// Token: 0x0600A483 RID: 42115 RVA: 0x00304BF0 File Offset: 0x00302DF0
	private void OnPhantomBtnClick(EToggleState state)
	{
		this.CurrentType = EFloroRanchCardType.Phantom;
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.RefreshView();
	}

	// Token: 0x0600A484 RID: 42116 RVA: 0x00304C16 File Offset: 0x00302E16
	private void OnToyBtnClick(EToggleState state)
	{
		this.CurrentType = EFloroRanchCardType.Toy;
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.RefreshView();
	}

	// Token: 0x0600A485 RID: 42117 RVA: 0x00304C3C File Offset: 0x00302E3C
	private void OnCloseBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.FloroRanchDataRedDot);
		base.CloseMe(null);
	}

	// Token: 0x0600A486 RID: 42118 RVA: 0x00304C55 File Offset: 0x00302E55
	private FloroRanchHandBookItem CreateHandBookItem()
	{
		return new FloroRanchHandBookItem
		{
			ActivityDataType = this.ActivityDataType,
			OnClickCallback = new Action<FloroRanchHandBookSmallSlotItem>(this.OnItemClick),
			IsSelectedItem = new Func<bool>(this.IsSelectedItem)
		};
	}

	// Token: 0x04006081 RID: 24705
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04006082 RID: 24706
	private EFloroRanchCardType CurrentType;

	// Token: 0x04006083 RID: 24707
	[Nullable(2)]
	private FloroRanchHandBookSmallSlotItem CurrentSelectedItem;

	// Token: 0x04006084 RID: 24708
	private GenericScrollViewNew<FloroRanchHandBookItem, int> ItemScrollLayout;

	// Token: 0x04006085 RID: 24709
	private FloroRanchCardItem CardItem;

	// Token: 0x02007261 RID: 29281
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040253A8 RID: 152488
		public const int BtnClose = 0;

		// Token: 0x040253A9 RID: 152489
		public const int LayoutTab = 1;

		// Token: 0x040253AA RID: 152490
		public const int TogglePhantom = 2;

		// Token: 0x040253AB RID: 152491
		public const int ToggleToy = 3;

		// Token: 0x040253AC RID: 152492
		public const int ScrollList = 4;

		// Token: 0x040253AD RID: 152493
		public const int LayoutHandBook = 5;

		// Token: 0x040253AE RID: 152494
		public const int ItemHandBook = 6;

		// Token: 0x040253AF RID: 152495
		public const int ItemCardDetail = 7;

		// Token: 0x040253B0 RID: 152496
		public const int TextProgress = 8;

		// Token: 0x040253B1 RID: 152497
		public const int ItemPhantomRedDot = 9;

		// Token: 0x040253B2 RID: 152498
		public const int ItemToyRedDot = 10;
	}
}
