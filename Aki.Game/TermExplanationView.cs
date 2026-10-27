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

// Token: 0x02002BA8 RID: 11176
public class TermExplanationView : UiViewBase
{
	// Token: 0x0601726B RID: 94827 RVA: 0x005DE40E File Offset: 0x005DC60E
	[NullableContext(1)]
	public TermExplanationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601726C RID: 94828 RVA: 0x005DE418 File Offset: 0x005DC618
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

	// Token: 0x0601726D RID: 94829 RVA: 0x005DE5A8 File Offset: 0x005DC7A8
	protected override UniTask OnBeforeStartAsync()
	{
		TermExplanationView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TermExplanationView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601726E RID: 94830 RVA: 0x005DE5EB File Offset: 0x005DC7EB
	protected override void OnBeforeShow()
	{
		this.OnTweenStart();
	}

	// Token: 0x0601726F RID: 94831 RVA: 0x005DE5F4 File Offset: 0x005DC7F4
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

	// Token: 0x06017270 RID: 94832 RVA: 0x005DE6C4 File Offset: 0x005DC8C4
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

	// Token: 0x06017271 RID: 94833 RVA: 0x005DE6F1 File Offset: 0x005DC8F1
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Emit(EEventName.OnTermExplanationViewClosed);
	}

	// Token: 0x06017272 RID: 94834 RVA: 0x005DE703 File Offset: 0x005DC903
	[NullableContext(2)]
	public UUIItem GetTipItem()
	{
		return base.GetItem(7);
	}

	// Token: 0x06017273 RID: 94835 RVA: 0x005DE70C File Offset: 0x005DC90C
	[NullableContext(1)]
	private ExplanationItem GetGrid()
	{
		return new ExplanationItem();
	}

	// Token: 0x06017274 RID: 94836 RVA: 0x005DE713 File Offset: 0x005DC913
	private void OnBtnCloseClick()
	{
		if (this.IsClosing)
		{
			return;
		}
		this.IsClosing = true;
		base.CloseMe(null);
	}

	// Token: 0x06017275 RID: 94837 RVA: 0x005DE72C File Offset: 0x005DC92C
	private void OnTweenStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		scrollViewWithScrollbar.ContentUIItem.Get().SetBubbleUpToParent(false);
		scrollViewWithScrollbar.SetRayCastTargetForScrollView(false);
	}

	// Token: 0x06017276 RID: 94838 RVA: 0x005DE75C File Offset: 0x005DC95C
	private void OnTweenComplete()
	{
		TermExplanationViewParam termExplanationViewParam = this.OpenParam as TermExplanationViewParam;
		int gridIndex = termExplanationViewParam.HyperLinkList.IndexOf(termExplanationViewParam.FocusedHyperLink);
		this.ScrollView.SelectGridProxy(gridIndex, false);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
		scrollViewWithScrollbar.ContentUIItem.Get().SetBubbleUpToParent(true);
		scrollViewWithScrollbar.SetRayCastTargetForScrollView(true);
	}

	// Token: 0x0400AD48 RID: 44360
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ExplanationItem, string> ScrollView;

	// Token: 0x0400AD49 RID: 44361
	private bool IsClosing;

	// Token: 0x02009165 RID: 37221
	private class EComponentDefine
	{
		// Token: 0x0402F0FA RID: 192762
		public const int SpriteLight = 0;

		// Token: 0x0402F0FB RID: 192763
		public const int TextTitle = 1;

		// Token: 0x0402F0FC RID: 192764
		public const int ScrollItemList = 2;

		// Token: 0x0402F0FD RID: 192765
		public const int LayoutContent = 3;

		// Token: 0x0402F0FE RID: 192766
		public const int ItemExplanation = 4;

		// Token: 0x0402F0FF RID: 192767
		public const int BtnClose = 5;

		// Token: 0x0402F100 RID: 192768
		public const int ItemBtnClose = 6;

		// Token: 0x0402F101 RID: 192769
		public const int ItemTip = 7;
	}
}
