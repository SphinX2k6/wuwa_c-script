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

// Token: 0x02000D17 RID: 3351
[NullableContext(2)]
[Nullable(0)]
public class PhantomBatchConfirmPopupView : UiViewBase
{
	// Token: 0x06008AD5 RID: 35541 RVA: 0x0029FA29 File Offset: 0x0029DC29
	[NullableContext(1)]
	public PhantomBatchConfirmPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008AD6 RID: 35542 RVA: 0x0029FA34 File Offset: 0x0029DC34
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008AD7 RID: 35543 RVA: 0x0029FB64 File Offset: 0x0029DD64
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomBatchConfirmPopupView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomBatchConfirmPopupView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008AD8 RID: 35544 RVA: 0x0029FBA8 File Offset: 0x0029DDA8
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as IPhantomConfirmPopupViewData);
		this.LoopScrollView = new LoopScrollView<PhantomConfirmMediumItemGrid, int>(base.GetLoopScrollViewComponent(2), base.GetItem(3).GetOwner() as AUIBaseActor, new Func<PhantomConfirmMediumItemGrid>(this.CreateGridItem), false);
		IPhantomConfirmPopupViewData viewData = this.ViewData;
		if (((viewData != null) ? viewData.OnLeft : null) != null)
		{
			ButtonItem leftButton = this.LeftButton;
			if (leftButton != null)
			{
				leftButton.SetUiActive(true);
			}
			ButtonItem leftButton2 = this.LeftButton;
			if (leftButton2 != null)
			{
				leftButton2.SetFunction(new Action<int>(this.OnClickLeft));
			}
			ButtonItem leftButton3 = this.LeftButton;
			if (leftButton3 != null)
			{
				leftButton3.SetShowText(this.ViewData.LeftTxtKey);
			}
		}
		else
		{
			ButtonItem leftButton4 = this.LeftButton;
			if (leftButton4 != null)
			{
				leftButton4.SetUiActive(false);
			}
		}
		IPhantomConfirmPopupViewData viewData2 = this.ViewData;
		if (((viewData2 != null) ? viewData2.OnMiddle : null) != null)
		{
			ButtonItem middleButton = this.MiddleButton;
			if (middleButton != null)
			{
				middleButton.SetUiActive(true);
			}
			ButtonItem middleButton2 = this.MiddleButton;
			if (middleButton2 != null)
			{
				middleButton2.SetFunction(new Action<int>(this.OnClickMiddle));
			}
			ButtonItem middleButton3 = this.MiddleButton;
			if (middleButton3 != null)
			{
				middleButton3.SetShowText(this.ViewData.MiddleTxtKey);
			}
		}
		else
		{
			ButtonItem middleButton4 = this.MiddleButton;
			if (middleButton4 != null)
			{
				middleButton4.SetUiActive(false);
			}
		}
		IPhantomConfirmPopupViewData viewData3 = this.ViewData;
		if (((viewData3 != null) ? viewData3.OnRight : null) != null)
		{
			ButtonItem rightButton = this.RightButton;
			if (rightButton != null)
			{
				rightButton.SetUiActive(true);
			}
			ButtonItem rightButton2 = this.RightButton;
			if (rightButton2 != null)
			{
				rightButton2.SetFunction(new Action<int>(this.OnClickRight));
			}
			ButtonItem rightButton3 = this.RightButton;
			if (rightButton3 != null)
			{
				rightButton3.SetShowText(this.ViewData.RightTxtKey);
			}
		}
		else
		{
			ButtonItem rightButton4 = this.RightButton;
			if (rightButton4 != null)
			{
				rightButton4.SetUiActive(false);
			}
		}
		this.RefreshView();
	}

	// Token: 0x06008AD9 RID: 35545 RVA: 0x0029FD55 File Offset: 0x0029DF55
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
	}

	// Token: 0x06008ADA RID: 35546 RVA: 0x0029FD8F File Offset: 0x0029DF8F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
	}

	// Token: 0x06008ADB RID: 35547 RVA: 0x0029FDCC File Offset: 0x0029DFCC
	private void RefreshView()
	{
		if (this.ViewData == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(this.ViewData.Title);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text2, "PhantomBatchConfirmCount", new <>z__ReadOnlySingleElementList<object>(PhantomStackUtil.GetStackUnitCountByIncIdList(this.ViewData.PhantomUniqueIdList)));
		}
		UUIText text3 = base.GetText(6);
		if (text3 != null)
		{
			text3.ShowTextNew(this.ViewData.SubTitle);
		}
		LoopScrollView<PhantomConfirmMediumItemGrid, int> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return;
		}
		loopScrollView.RefreshByData(this.ViewData.PhantomUniqueIdList, false, null, false);
	}

	// Token: 0x06008ADC RID: 35548 RVA: 0x0029FE6D File Offset: 0x0029E06D
	[NullableContext(1)]
	private PhantomConfirmMediumItemGrid CreateGridItem()
	{
		PhantomConfirmMediumItemGrid phantomConfirmMediumItemGrid = new PhantomConfirmMediumItemGrid();
		phantomConfirmMediumItemGrid.SetUseFixedAsync(true);
		return phantomConfirmMediumItemGrid;
	}

	// Token: 0x06008ADD RID: 35549 RVA: 0x0029FE7B File Offset: 0x0029E07B
	private void OnClickLeft(int _)
	{
		IPhantomConfirmPopupViewData viewData = this.ViewData;
		if (viewData != null)
		{
			Action onLeft = viewData.OnLeft;
			if (onLeft != null)
			{
				onLeft();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x06008ADE RID: 35550 RVA: 0x0029FEA0 File Offset: 0x0029E0A0
	private void OnClickMiddle(int _)
	{
		IPhantomConfirmPopupViewData viewData = this.ViewData;
		if (viewData != null)
		{
			Action onMiddle = viewData.OnMiddle;
			if (onMiddle != null)
			{
				onMiddle();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x06008ADF RID: 35551 RVA: 0x0029FEC5 File Offset: 0x0029E0C5
	private void OnClickRight(int _)
	{
		IPhantomConfirmPopupViewData viewData = this.ViewData;
		if (viewData != null)
		{
			Action onRight = viewData.OnRight;
			if (onRight != null)
			{
				onRight();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x06008AE0 RID: 35552 RVA: 0x0029FEEC File Offset: 0x0029E0EC
	private void OnItemFuncValueChange(int changeId)
	{
		int i = 0;
		while (i < this.ViewData.PhantomUniqueIdList.Count)
		{
			int num = this.ViewData.PhantomUniqueIdList[i];
			if (changeId == num)
			{
				LoopScrollView<PhantomConfirmMediumItemGrid, int> loopScrollView = this.LoopScrollView;
				if (loopScrollView == null)
				{
					return;
				}
				loopScrollView.RefreshGridProxy(i);
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x06008AE1 RID: 35553 RVA: 0x0029FF3C File Offset: 0x0029E13C
	[NullableContext(1)]
	private void OnItemFuncValueBatchChange(IReadOnlyList<int> uniqueIdList)
	{
		HashSet<int> hashSet = new HashSet<int>(uniqueIdList);
		for (int i = 0; i < this.ViewData.PhantomUniqueIdList.Count; i++)
		{
			int item = this.ViewData.PhantomUniqueIdList[i];
			if (hashSet.Contains(item))
			{
				LoopScrollView<PhantomConfirmMediumItemGrid, int> loopScrollView = this.LoopScrollView;
				if (loopScrollView != null)
				{
					loopScrollView.RefreshGridProxy(i);
				}
			}
		}
	}

	// Token: 0x04005346 RID: 21318
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhantomConfirmMediumItemGrid, int> LoopScrollView;

	// Token: 0x04005347 RID: 21319
	private ButtonItem LeftButton;

	// Token: 0x04005348 RID: 21320
	private ButtonItem MiddleButton;

	// Token: 0x04005349 RID: 21321
	private ButtonItem RightButton;

	// Token: 0x0400534A RID: 21322
	private IPhantomConfirmPopupViewData ViewData;

	// Token: 0x02006FA5 RID: 28581
	[NullableContext(0)]
	private class EPhantomBatchConfirmComp
	{
		// Token: 0x040247A3 RID: 149411
		public const int TxtTitle = 0;

		// Token: 0x040247A4 RID: 149412
		public const int TxtCount = 1;

		// Token: 0x040247A5 RID: 149413
		public const int Scroller = 2;

		// Token: 0x040247A6 RID: 149414
		public const int LoopItem = 3;

		// Token: 0x040247A7 RID: 149415
		public const int BtnLeft = 4;

		// Token: 0x040247A8 RID: 149416
		public const int BtnMiddle = 5;

		// Token: 0x040247A9 RID: 149417
		public const int TxtSubTitle = 6;

		// Token: 0x040247AA RID: 149418
		public const int BtnRight = 7;
	}
}
