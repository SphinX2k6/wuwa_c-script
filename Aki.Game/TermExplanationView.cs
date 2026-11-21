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

// Token: 0x02002124 RID: 8484
public class TermExplanationView : UiViewBase
{
	// Token: 0x06014C9C RID: 85148 RVA: 0x0060AFE2 File Offset: 0x006091E2
	[NullableContext(1)]
	public TermExplanationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014C9D RID: 85149 RVA: 0x0060AFEC File Offset: 0x006091EC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnBtnCloseClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnCloseClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014C9E RID: 85150 RVA: 0x0060B17C File Offset: 0x0060937C
	protected override UniTask OnBeforeStartAsync()
	{
		TermExplanationView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TermExplanationView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014C9F RID: 85151 RVA: 0x0060B1BF File Offset: 0x006093BF
	protected override void OnBeforeShow()
	{
		this.OnTweenStart();
	}

	// Token: 0x06014CA0 RID: 85152 RVA: 0x0060B1C8 File Offset: 0x006093C8
	protected override void OnAfterShow()
	{
		TermExplanationViewParam termExplanationViewParam = this.OpenParam as TermExplanationViewParam;
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		if (termExplanationViewParam == null || termExplanationViewParam.FocusedHyperLink == null)
		{
			return;
		}
		UUIItem itemByIndex = this.ScrollView.GetItemByIndex(termExplanationViewParam.HyperLinkList.IndexOf(termExplanationViewParam.FocusedHyperLink));
		FVector relativeLocation = scrollViewWithScrollbar.ContentUIItem.Get().RelativeLocation;
		FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
		scrollViewWithScrollbar.ScrollToTop(ref fvector2D, itemByIndex, true);
		ULTweener tweener = scrollViewWithScrollbar.Tweener;
		if (tweener != null)
		{
			tweener.OnStartCallBack.Bind(new Action(this.OnTweenStart));
		}
		ULTweener tweener2 = scrollViewWithScrollbar.Tweener;
		if (tweener2 != null)
		{
			tweener2.OnCompleteCallBack.Bind(new Action(this.OnTweenComplete));
		}
		if (scrollViewWithScrollbar.Tweener == null)
		{
			this.OnTweenComplete();
		}
	}

	// Token: 0x06014CA1 RID: 85153 RVA: 0x0060B298 File Offset: 0x00609498
	protected override void OnBeforeDestroy()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		if (scrollViewWithScrollbar != null)
		{
			ULTweener tweener = scrollViewWithScrollbar.Tweener;
			if (tweener == null)
			{
				return;
			}
			tweener.OnCompleteCallBack.Unbind();
		}
	}

	// Token: 0x06014CA2 RID: 85154 RVA: 0x0060B2C5 File Offset: 0x006094C5
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Emit(EEventName.OnTermExplanationViewClosed);
	}

	// Token: 0x06014CA3 RID: 85155 RVA: 0x0060B2D7 File Offset: 0x006094D7
	[NullableContext(2)]
	public UUIItem GetTipItem()
	{
		return base.GetItem(7);
	}

	// Token: 0x06014CA4 RID: 85156 RVA: 0x0060B2E0 File Offset: 0x006094E0
	[NullableContext(1)]
	private ExplanationItem GetGrid()
	{
		return new ExplanationItem();
	}

	// Token: 0x06014CA5 RID: 85157 RVA: 0x0060B2E7 File Offset: 0x006094E7
	private void OnBtnCloseClick()
	{
		if (this.IsClosing)
		{
			return;
		}
		this.IsClosing = true;
		base.CloseMe(null);
	}

	// Token: 0x06014CA6 RID: 85158 RVA: 0x0060B300 File Offset: 0x00609500
	private void OnTweenStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		scrollViewWithScrollbar.ContentUIItem.Get().SetBubbleUpToParent(false);
		scrollViewWithScrollbar.SetRayCastTargetForScrollView(false);
	}

	// Token: 0x06014CA7 RID: 85159 RVA: 0x0060B330 File Offset: 0x00609530
	private void OnTweenComplete()
	{
		TermExplanationViewParam termExplanationViewParam = this.OpenParam as TermExplanationViewParam;
		int gridIndex = termExplanationViewParam.HyperLinkList.IndexOf(termExplanationViewParam.FocusedHyperLink);
		this.ScrollView.SelectGridProxy(gridIndex, false);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		scrollViewWithScrollbar.ContentUIItem.Get().SetBubbleUpToParent(true);
		scrollViewWithScrollbar.SetRayCastTargetForScrollView(true);
	}

	// Token: 0x0400B14F RID: 45391
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ExplanationItem, string> ScrollView;

	// Token: 0x0400B150 RID: 45392
	private bool IsClosing;

	// Token: 0x020083A8 RID: 33704
	private class EComponentDefine
	{
		// Token: 0x0402A7FF RID: 174079
		public const int SpriteLight = 0;

		// Token: 0x0402A800 RID: 174080
		public const int TextTitle = 1;

		// Token: 0x0402A801 RID: 174081
		public const int ScrollItemList = 2;

		// Token: 0x0402A802 RID: 174082
		public const int LayoutContent = 3;

		// Token: 0x0402A803 RID: 174083
		public const int ItemExplanation = 4;

		// Token: 0x0402A804 RID: 174084
		public const int BtnClose = 5;

		// Token: 0x0402A805 RID: 174085
		public const int ItemBtnClose = 6;

		// Token: 0x0402A806 RID: 174086
		public const int ItemTip = 7;
	}
}
