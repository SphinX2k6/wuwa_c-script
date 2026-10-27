using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029C7 RID: 10695
public class ShipTowerReviewView : UiViewBase
{
	// Token: 0x17001DA3 RID: 7587
	// (get) Token: 0x060162A4 RID: 90788 RVA: 0x0059B1E2 File Offset: 0x005993E2
	[Nullable(2)]
	public new ShipTowerReviewViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as ShipTowerReviewViewParams;
		}
	}

	// Token: 0x060162A5 RID: 90789 RVA: 0x0059B1EF File Offset: 0x005993EF
	[NullableContext(1)]
	public ShipTowerReviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060162A6 RID: 90790 RVA: 0x0059B1F8 File Offset: 0x005993F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.CloseSelf))
		};
	}

	// Token: 0x060162A7 RID: 90791 RVA: 0x0059B2A2 File Offset: 0x005994A2
	private void InitDataParam()
	{
	}

	// Token: 0x060162A8 RID: 90792 RVA: 0x0059B2A4 File Offset: 0x005994A4
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerReviewView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerReviewView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162A9 RID: 90793 RVA: 0x0059B2E7 File Offset: 0x005994E7
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x060162AA RID: 90794 RVA: 0x0059B2EF File Offset: 0x005994EF
	protected override void OnBeforeDestroy()
	{
		ShipTowerReviewViewParams openParam = this.OpenParam;
		if (openParam == null)
		{
			return;
		}
		CustomPromise<bool> promise = openParam.Promise;
		if (promise == null)
		{
			return;
		}
		promise.SetResult(true);
	}

	// Token: 0x060162AB RID: 90795 RVA: 0x0059B30C File Offset: 0x0059950C
	[NullableContext(1)]
	private ShipTowerReviewItem CreateReviewItem()
	{
		return new ShipTowerReviewItem();
	}

	// Token: 0x060162AC RID: 90796 RVA: 0x0059B314 File Offset: 0x00599514
	public void UpdateData()
	{
		List<ShipTowerReviewItemData> reviewList = ShipTowerModel.Instance.ReviewList;
		LoopScrollView<ShipTowerReviewItem, ShipTowerReviewItemData> reviewLoopView = this.ReviewLoopView;
		if (reviewLoopView != null)
		{
			reviewLoopView.RefreshByData(reviewList, false, null, false);
		}
		bool uiactive = false;
		using (List<ShipTowerReviewItemData>.Enumerator enumerator = reviewList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsQuickPass)
				{
					uiactive = true;
					break;
				}
			}
		}
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetUIActive(uiactive);
		}
		List<int> reviewProgressList = ShipTowerModel.Instance.ReviewProgressList;
		string textStringId = "GhostShipLastReview_Text";
		UUIText text2 = base.GetText(3);
		if (reviewProgressList.Count >= 2)
		{
			LguiUtil.Instance.SetLocalTextNew(text2, textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				reviewProgressList[0],
				reviewProgressList[1]
			}));
		}
	}

	// Token: 0x0400A515 RID: 42261
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTowerReviewItem, ShipTowerReviewItemData> ReviewLoopView;

	// Token: 0x02008FE7 RID: 36839
	private static class EChildType
	{
		// Token: 0x0402E99B RID: 190875
		public const int LoopScrollRoot = 0;

		// Token: 0x0402E99C RID: 190876
		public const int BtnSure = 1;

		// Token: 0x0402E99D RID: 190877
		public const int ItemReview = 2;

		// Token: 0x0402E99E RID: 190878
		public const int TextLastReviewProgress = 3;

		// Token: 0x0402E99F RID: 190879
		public const int CanQuickPassTipText = 4;
	}
}
