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

// Token: 0x02001B66 RID: 7014
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchHandBookView : UiViewBase
{
	// Token: 0x0600D067 RID: 53351 RVA: 0x002F975E File Offset: 0x002F795E
	public FloroRanchHandBookView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D068 RID: 53352 RVA: 0x002F9768 File Offset: 0x002F7968
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

	// Token: 0x0600D069 RID: 53353 RVA: 0x002F9980 File Offset: 0x002F7B80
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchHandBookView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchHandBookView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D06A RID: 53354 RVA: 0x002F99C3 File Offset: 0x002F7BC3
	private FloroRanchActivityData GetHandBookActivityData()
	{
		return FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true);
	}

	// Token: 0x0600D06B RID: 53355 RVA: 0x002F99D8 File Offset: 0x002F7BD8
	private UniTask RefreshView()
	{
		FloroRanchHandBookView.<RefreshView>d__10 <RefreshView>d__;
		<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshView>d__.<>4__this = this;
		<RefreshView>d__.<>1__state = -1;
		<RefreshView>d__.<>t__builder.Start<FloroRanchHandBookView.<RefreshView>d__10>(ref <RefreshView>d__);
		return <RefreshView>d__.<>t__builder.Task;
	}

	// Token: 0x0600D06C RID: 53356 RVA: 0x002F9A1C File Offset: 0x002F7C1C
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

	// Token: 0x0600D06D RID: 53357 RVA: 0x002F9A61 File Offset: 0x002F7C61
	private bool IsSelectedItem()
	{
		return this.CurrentSelectedItem != null;
	}

	// Token: 0x0600D06E RID: 53358 RVA: 0x002F9A6C File Offset: 0x002F7C6C
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

	// Token: 0x0600D06F RID: 53359 RVA: 0x002F9AA0 File Offset: 0x002F7CA0
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

	// Token: 0x0600D070 RID: 53360 RVA: 0x002F9AFF File Offset: 0x002F7CFF
	private bool OnPhantomCanExecuteChange()
	{
		return this.CurrentType > EFloroRanchCardType.Phantom;
	}

	// Token: 0x0600D071 RID: 53361 RVA: 0x002F9B0A File Offset: 0x002F7D0A
	private bool OnToyCanExecuteChange()
	{
		return this.CurrentType != EFloroRanchCardType.Toy;
	}

	// Token: 0x0600D072 RID: 53362 RVA: 0x002F9B18 File Offset: 0x002F7D18
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

	// Token: 0x0600D073 RID: 53363 RVA: 0x002F9B3E File Offset: 0x002F7D3E
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

	// Token: 0x0600D074 RID: 53364 RVA: 0x002F9B64 File Offset: 0x002F7D64
	private void OnCloseBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.FloroRanchDataRedDot);
		base.CloseMe(null);
	}

	// Token: 0x0600D075 RID: 53365 RVA: 0x002F9B7D File Offset: 0x002F7D7D
	private FloroRanchHandBookItem CreateHandBookItem()
	{
		return new FloroRanchHandBookItem
		{
			ActivityDataType = this.ActivityDataType,
			OnClickCallback = new Action<FloroRanchHandBookSmallSlotItem>(this.OnItemClick),
			IsSelectedItem = new Func<bool>(this.IsSelectedItem)
		};
	}

	// Token: 0x04005FB2 RID: 24498
	private EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04005FB3 RID: 24499
	private EFloroRanchCardType CurrentType;

	// Token: 0x04005FB4 RID: 24500
	[Nullable(2)]
	private FloroRanchHandBookSmallSlotItem CurrentSelectedItem;

	// Token: 0x04005FB5 RID: 24501
	private GenericScrollViewNew<FloroRanchHandBookItem, int> ItemScrollLayout;

	// Token: 0x04005FB6 RID: 24502
	private FloroRanchCardItem CardItem;

	// Token: 0x020080D3 RID: 32979
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A074 RID: 172148
		public const int BtnClose = 0;

		// Token: 0x0402A075 RID: 172149
		public const int LayoutTab = 1;

		// Token: 0x0402A076 RID: 172150
		public const int TogglePhantom = 2;

		// Token: 0x0402A077 RID: 172151
		public const int ToggleToy = 3;

		// Token: 0x0402A078 RID: 172152
		public const int ScrollList = 4;

		// Token: 0x0402A079 RID: 172153
		public const int LayoutHandBook = 5;

		// Token: 0x0402A07A RID: 172154
		public const int ItemHandBook = 6;

		// Token: 0x0402A07B RID: 172155
		public const int ItemCardDetail = 7;

		// Token: 0x0402A07C RID: 172156
		public const int TextProgress = 8;

		// Token: 0x0402A07D RID: 172157
		public const int ItemPhantomRedDot = 9;

		// Token: 0x0402A07E RID: 172158
		public const int ItemToyRedDot = 10;
	}
}
