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

// Token: 0x0200185E RID: 6238
[NullableContext(2)]
[Nullable(0)]
public class PhantomBatchConfirmPopupView : UiViewBase
{
	// Token: 0x0600B6EC RID: 46828 RVA: 0x00295305 File Offset: 0x00293505
	[NullableContext(1)]
	public PhantomBatchConfirmPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B6ED RID: 46829 RVA: 0x00295310 File Offset: 0x00293510
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

	// Token: 0x0600B6EE RID: 46830 RVA: 0x00295440 File Offset: 0x00293640
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomBatchConfirmPopupView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomBatchConfirmPopupView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6EF RID: 46831 RVA: 0x00295484 File Offset: 0x00293684
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

	// Token: 0x0600B6F0 RID: 46832 RVA: 0x00295631 File Offset: 0x00293831
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
	}

	// Token: 0x0600B6F1 RID: 46833 RVA: 0x0029566B File Offset: 0x0029386B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
	}

	// Token: 0x0600B6F2 RID: 46834 RVA: 0x002956A8 File Offset: 0x002938A8
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

	// Token: 0x0600B6F3 RID: 46835 RVA: 0x00295749 File Offset: 0x00293949
	[NullableContext(1)]
	private PhantomConfirmMediumItemGrid CreateGridItem()
	{
		PhantomConfirmMediumItemGrid phantomConfirmMediumItemGrid = new PhantomConfirmMediumItemGrid();
		phantomConfirmMediumItemGrid.SetUseFixedAsync(true);
		return phantomConfirmMediumItemGrid;
	}

	// Token: 0x0600B6F4 RID: 46836 RVA: 0x00295757 File Offset: 0x00293957
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

	// Token: 0x0600B6F5 RID: 46837 RVA: 0x0029577C File Offset: 0x0029397C
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

	// Token: 0x0600B6F6 RID: 46838 RVA: 0x002957A1 File Offset: 0x002939A1
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

	// Token: 0x0600B6F7 RID: 46839 RVA: 0x002957C8 File Offset: 0x002939C8
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

	// Token: 0x0600B6F8 RID: 46840 RVA: 0x00295818 File Offset: 0x00293A18
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

	// Token: 0x0400529B RID: 21147
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhantomConfirmMediumItemGrid, int> LoopScrollView;

	// Token: 0x0400529C RID: 21148
	private ButtonItem LeftButton;

	// Token: 0x0400529D RID: 21149
	private ButtonItem MiddleButton;

	// Token: 0x0400529E RID: 21150
	private ButtonItem RightButton;

	// Token: 0x0400529F RID: 21151
	private IPhantomConfirmPopupViewData ViewData;

	// Token: 0x02007E1E RID: 32286
	[NullableContext(0)]
	private class EPhantomBatchConfirmComp
	{
		// Token: 0x04029476 RID: 169078
		public const int TxtTitle = 0;

		// Token: 0x04029477 RID: 169079
		public const int TxtCount = 1;

		// Token: 0x04029478 RID: 169080
		public const int Scroller = 2;

		// Token: 0x04029479 RID: 169081
		public const int LoopItem = 3;

		// Token: 0x0402947A RID: 169082
		public const int BtnLeft = 4;

		// Token: 0x0402947B RID: 169083
		public const int BtnMiddle = 5;

		// Token: 0x0402947C RID: 169084
		public const int TxtSubTitle = 6;

		// Token: 0x0402947D RID: 169085
		public const int BtnRight = 7;
	}
}
