using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B75 RID: 7029
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopTipView : UiViewBase
{
	// Token: 0x0600D10E RID: 53518 RVA: 0x002FD124 File Offset: 0x002FB324
	public FloroRanchShopTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D10F RID: 53519 RVA: 0x002FD194 File Offset: 0x002FB394
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D110 RID: 53520 RVA: 0x002FD27C File Offset: 0x002FB47C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchShopTipView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchShopTipView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D111 RID: 53521 RVA: 0x002FD2C0 File Offset: 0x002FB4C0
	protected override void OnBeforeShow()
	{
		if (this.OpenParam == null)
		{
			return;
		}
		FloroRanchShopTipViewParam floroRanchShopTipViewParam = (FloroRanchShopTipViewParam)this.OpenParam;
		int toyPoint = floroRanchShopTipViewParam.ToyPoint;
		this.SellCallback = floroRanchShopTipViewParam.SellCallback;
		this.ShowToyListCallback = floroRanchShopTipViewParam.ShowToyListCallback;
		if (this.SellCallback == null || this.ShowToyListCallback == null)
		{
			return;
		}
		this.ShowToyListCallback(false);
		this.RefreshToyView();
		this.ShowToyTip(toyPoint);
	}

	// Token: 0x0600D112 RID: 53522 RVA: 0x002FD32B File Offset: 0x002FB52B
	protected override void OnBeforeHide()
	{
		this.ShowToyListCallback(true);
	}

	// Token: 0x0600D113 RID: 53523 RVA: 0x002FD33C File Offset: 0x002FB53C
	private UniTask CreateToyItem()
	{
		FloroRanchShopTipView.<CreateToyItem>d__11 <CreateToyItem>d__;
		<CreateToyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateToyItem>d__.<>4__this = this;
		<CreateToyItem>d__.<>1__state = -1;
		<CreateToyItem>d__.<>t__builder.Start<FloroRanchShopTipView.<CreateToyItem>d__11>(ref <CreateToyItem>d__);
		return <CreateToyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D114 RID: 53524 RVA: 0x002FD380 File Offset: 0x002FB580
	private void RefreshToyView()
	{
		int enableToyCount = FloroRanchGamePlayModel.Instance.EnableToyCount;
		List<FloroRanchEntityBase> list = new List<FloroRanchEntityBase>();
		for (int i = 0; i < enableToyCount; i++)
		{
			FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(i);
			if (toyEntityByPoint != null)
			{
				list.Add(toyEntityByPoint);
			}
			else
			{
				list.Add(null);
			}
		}
		for (int j = 0; j < this.ToyItemList.Count; j++)
		{
			FloroRanchToyGridItem floroRanchToyGridItem = this.ToyItemList[j];
			if (list[j] != null)
			{
				floroRanchToyGridItem.RefreshItemGrid(list[j]);
			}
			else
			{
				floroRanchToyGridItem.RefreshItemGrid(null);
			}
		}
	}

	// Token: 0x0600D115 RID: 53525 RVA: 0x002FD415 File Offset: 0x002FB615
	private void OnSellCallback(FloroRanchEntityBase entity)
	{
		base.CloseMe(null);
		Action<int> sellCallback = this.SellCallback;
		if (sellCallback == null)
		{
			return;
		}
		sellCallback(this.CurSelectToyPoint);
	}

	// Token: 0x0600D116 RID: 53526 RVA: 0x002FD434 File Offset: 0x002FB634
	private void OnClickToyItem(int point)
	{
		this.ShowToyTip(point);
	}

	// Token: 0x0600D117 RID: 53527 RVA: 0x002FD440 File Offset: 0x002FB640
	private void HideToyTip()
	{
		if (this.CurSelectToyPoint == -1)
		{
			return;
		}
		FloroRanchToyGridItem floroRanchToyGridItem = this.ToyItemList[this.CurSelectToyPoint];
		if (floroRanchToyGridItem != null)
		{
			floroRanchToyGridItem.SetSelectState(false);
		}
	}

	// Token: 0x0600D118 RID: 53528 RVA: 0x002FD474 File Offset: 0x002FB674
	private void ShowToyTip(int point)
	{
		this.HideToyTip();
		if (this.CurSelectToyPoint != point)
		{
			this.CurSelectToyPoint = point;
		}
		FloroRanchToyGridItem floroRanchToyGridItem = this.ToyItemList[this.CurSelectToyPoint];
		if (floroRanchToyGridItem != null)
		{
			floroRanchToyGridItem.SetSelectState(true);
		}
		FloroRanchEntityBase toyEntityByPoint = FloroRanchGamePlayModel.Instance.GetToyEntityByPoint(point);
		if (toyEntityByPoint != null)
		{
			this.ToyTipItem.RefreshInfoTipByParam(new FloroRanchCommonTipParam
			{
				TipType = EFloroRanchCommonTipType.Entity,
				EntityData = toyEntityByPoint,
				RemoveCallback = new Action<FloroRanchEntityBase>(this.OnSellCallback)
			});
		}
	}

	// Token: 0x0600D119 RID: 53529 RVA: 0x002FD4F2 File Offset: 0x002FB6F2
	private void ClearData()
	{
		this.CurSelectToyPoint = -1;
	}

	// Token: 0x0600D11A RID: 53530 RVA: 0x002FD4FB File Offset: 0x002FB6FB
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
		this.ClearData();
	}

	// Token: 0x04005FF4 RID: 24564
	private readonly List<FloroRanchToyGridItem> ToyItemList = new List<FloroRanchToyGridItem>();

	// Token: 0x04005FF5 RID: 24565
	private int CurSelectToyPoint = -1;

	// Token: 0x04005FF6 RID: 24566
	private Action<int> SellCallback = delegate(int point)
	{
	};

	// Token: 0x04005FF7 RID: 24567
	private Action<bool> ShowToyListCallback = delegate(bool isActive)
	{
	};

	// Token: 0x04005FF8 RID: 24568
	private FloroRanchCommonTipItem ToyTipItem;

	// Token: 0x020080EE RID: 33006
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A114 RID: 172308
		public const int CloseButton = 0;

		// Token: 0x0402A115 RID: 172309
		public const int ToyTipItem = 1;

		// Token: 0x0402A116 RID: 172310
		public const int ToyLayout = 2;

		// Token: 0x0402A117 RID: 172311
		public const int ToyItemTemplate = 3;
	}
}
