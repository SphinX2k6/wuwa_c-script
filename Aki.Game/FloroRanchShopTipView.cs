using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001034 RID: 4148
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchShopTipView : UiViewBase
{
	// Token: 0x0600A51F RID: 42271 RVA: 0x003081FC File Offset: 0x003063FC
	public FloroRanchShopTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A520 RID: 42272 RVA: 0x0030826C File Offset: 0x0030646C
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

	// Token: 0x0600A521 RID: 42273 RVA: 0x00308354 File Offset: 0x00306554
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchShopTipView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchShopTipView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A522 RID: 42274 RVA: 0x00308398 File Offset: 0x00306598
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

	// Token: 0x0600A523 RID: 42275 RVA: 0x00308403 File Offset: 0x00306603
	protected override void OnBeforeHide()
	{
		this.ShowToyListCallback(true);
	}

	// Token: 0x0600A524 RID: 42276 RVA: 0x00308414 File Offset: 0x00306614
	private UniTask CreateToyItem()
	{
		FloroRanchShopTipView.<CreateToyItem>d__11 <CreateToyItem>d__;
		<CreateToyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateToyItem>d__.<>4__this = this;
		<CreateToyItem>d__.<>1__state = -1;
		<CreateToyItem>d__.<>t__builder.Start<FloroRanchShopTipView.<CreateToyItem>d__11>(ref <CreateToyItem>d__);
		return <CreateToyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A525 RID: 42277 RVA: 0x00308458 File Offset: 0x00306658
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

	// Token: 0x0600A526 RID: 42278 RVA: 0x003084ED File Offset: 0x003066ED
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

	// Token: 0x0600A527 RID: 42279 RVA: 0x0030850C File Offset: 0x0030670C
	private void OnClickToyItem(int point)
	{
		this.ShowToyTip(point);
	}

	// Token: 0x0600A528 RID: 42280 RVA: 0x00308518 File Offset: 0x00306718
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

	// Token: 0x0600A529 RID: 42281 RVA: 0x0030854C File Offset: 0x0030674C
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

	// Token: 0x0600A52A RID: 42282 RVA: 0x003085CA File Offset: 0x003067CA
	private void ClearData()
	{
		this.CurSelectToyPoint = -1;
	}

	// Token: 0x0600A52B RID: 42283 RVA: 0x003085D3 File Offset: 0x003067D3
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
		this.ClearData();
	}

	// Token: 0x040060C3 RID: 24771
	private readonly List<FloroRanchToyGridItem> ToyItemList = new List<FloroRanchToyGridItem>();

	// Token: 0x040060C4 RID: 24772
	private int CurSelectToyPoint = -1;

	// Token: 0x040060C5 RID: 24773
	private Action<int> SellCallback = delegate(int point)
	{
	};

	// Token: 0x040060C6 RID: 24774
	private Action<bool> ShowToyListCallback = delegate(bool isActive)
	{
	};

	// Token: 0x040060C7 RID: 24775
	private FloroRanchCommonTipItem ToyTipItem;

	// Token: 0x0200727C RID: 29308
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04025448 RID: 152648
		public const int CloseButton = 0;

		// Token: 0x04025449 RID: 152649
		public const int ToyTipItem = 1;

		// Token: 0x0402544A RID: 152650
		public const int ToyLayout = 2;

		// Token: 0x0402544B RID: 152651
		public const int ToyItemTemplate = 3;
	}
}
