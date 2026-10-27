using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048D9 RID: 18649
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericScrollViewNew<TProxy, [Nullable(2)] TData> where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x1700798F RID: 31119
		// (get) Token: 0x06030BED RID: 199661 RVA: 0x00B51A54 File Offset: 0x00B4FC54
		public bool IsExpand
		{
			get
			{
				if (this.TargetScroll.Horizontal)
				{
					float width = this.TargetScroll.RootUIComp.Get().Width;
					return this.TargetScroll.ContentUIItem.Get().Width > width;
				}
				float height = this.TargetScroll.RootUIComp.Get().Height;
				return this.TargetScroll.ContentUIItem.Get().Height > height;
			}
		}

		// Token: 0x17007990 RID: 31120
		// (get) Token: 0x06030BEE RID: 199662 RVA: 0x00B51AD7 File Offset: 0x00B4FCD7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public TWeakObjectPtr<UUIItem>? ContentItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return new TWeakObjectPtr<UUIItem>?(this.TargetScroll.ContentUIItem);
			}
		}

		// Token: 0x17007991 RID: 31121
		// (get) Token: 0x06030BEF RID: 199663 RVA: 0x00B51AEC File Offset: 0x00B4FCEC
		public float ScrollWidth
		{
			get
			{
				UUIItem uuiitem = this.TargetScroll.RootUIComp.Get();
				if (uuiitem == null)
				{
					return 0f;
				}
				return uuiitem.Width;
			}
		}

		// Token: 0x17007992 RID: 31122
		// (get) Token: 0x06030BF0 RID: 199664 RVA: 0x00B51B1C File Offset: 0x00B4FD1C
		public float ScrollHeight
		{
			get
			{
				UUIItem uuiitem = this.TargetScroll.RootUIComp.Get();
				if (uuiitem == null)
				{
					return 0f;
				}
				return uuiitem.Height;
			}
		}

		// Token: 0x06030BF1 RID: 199665 RVA: 0x00B51B4C File Offset: 0x00B4FD4C
		public GenericScrollViewNew(UUIScrollViewWithScrollbarComponent scrollView, Func<TProxy> gridProxyCreateFunction, [Nullable(2)] AUIBaseActor gridActor = null, bool isRefreshAsync = false, [Nullable(2)] UUILayoutBase layout = null)
		{
			this.TargetScroll = scrollView;
			UUILayoutBase layout2 = layout ?? (this.TargetScroll.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase);
			this.GenericLayout = new GenericLayout<TProxy, TData>(layout2, gridProxyCreateFunction, gridActor, isRefreshAsync, true);
			this.GenericLayout.AnimControllerComponent = (((scrollView != null) ? scrollView.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController);
		}

		// Token: 0x06030BF2 RID: 199666 RVA: 0x00B51BC8 File Offset: 0x00B4FDC8
		public void RefreshByData(IReadOnlyList<TData> data, [Nullable(2)] Action callBack = null, bool playGridAnim = false)
		{
			this.GenericLayout.RefreshByData(data, callBack, playGridAnim);
		}

		// Token: 0x06030BF3 RID: 199667 RVA: 0x00B51BD8 File Offset: 0x00B4FDD8
		public UniTask RefreshByDataAsync(IReadOnlyList<TData> data, bool playGridAnim = false)
		{
			GenericScrollViewNew<TProxy, TData>.<RefreshByDataAsync>d__12 <RefreshByDataAsync>d__;
			<RefreshByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshByDataAsync>d__.<>4__this = this;
			<RefreshByDataAsync>d__.data = data;
			<RefreshByDataAsync>d__.playGridAnim = playGridAnim;
			<RefreshByDataAsync>d__.<>1__state = -1;
			<RefreshByDataAsync>d__.<>t__builder.Start<GenericScrollViewNew<TProxy, TData>.<RefreshByDataAsync>d__12>(ref <RefreshByDataAsync>d__);
			return <RefreshByDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030BF4 RID: 199668 RVA: 0x00B51C2B File Offset: 0x00B4FE2B
		public void SetHorizontalScrollEnable(bool enable)
		{
			this.TargetScroll.SetHorizontal(enable);
		}

		// Token: 0x06030BF5 RID: 199669 RVA: 0x00B51C39 File Offset: 0x00B4FE39
		public void SetVerticalScrollEnable(bool enable)
		{
			this.TargetScroll.SetVertical(enable);
		}

		// Token: 0x06030BF6 RID: 199670 RVA: 0x00B51C47 File Offset: 0x00B4FE47
		[NullableContext(2)]
		public UUIItem GetItemByIndex(int index)
		{
			return this.GenericLayout.GetItemByIndex(index);
		}

		// Token: 0x06030BF7 RID: 199671 RVA: 0x00B51C55 File Offset: 0x00B4FE55
		[return: Nullable(2)]
		public UUIItem GetItemByKey(object key)
		{
			return this.GenericLayout.GetItemByKey(key);
		}

		// Token: 0x06030BF8 RID: 199672 RVA: 0x00B51C63 File Offset: 0x00B4FE63
		[NullableContext(2)]
		public TProxy GetScrollItemByIndex(int index)
		{
			return this.GenericLayout.GetLayoutItemByIndex(index);
		}

		// Token: 0x06030BF9 RID: 199673 RVA: 0x00B51C71 File Offset: 0x00B4FE71
		[return: Nullable(2)]
		public TProxy GetScrollItemByKey(object key)
		{
			return this.GenericLayout.GetLayoutItemByKey(key);
		}

		// Token: 0x06030BFA RID: 199674 RVA: 0x00B51C7F File Offset: 0x00B4FE7F
		public Dictionary<object, TProxy> GetScrollItemMap()
		{
			return this.GenericLayout.GetLayoutItemMap();
		}

		// Token: 0x06030BFB RID: 199675 RVA: 0x00B51C8C File Offset: 0x00B4FE8C
		public List<TProxy> GetScrollItemList()
		{
			return this.GenericLayout.GetLayoutItemList();
		}

		// Token: 0x06030BFC RID: 199676 RVA: 0x00B51C99 File Offset: 0x00B4FE99
		public void ScrollTo(UUIItem uiItem, bool bTweenAnim = false)
		{
			this.TargetScroll.ScrollTo(uiItem, bTweenAnim);
		}

		// Token: 0x06030BFD RID: 199677 RVA: 0x00B51CA8 File Offset: 0x00B4FEA8
		public void ScrollToItemByKey(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			if (itemByKey != null)
			{
				this.TargetScroll.ScrollTo(itemByKey, false);
			}
		}

		// Token: 0x06030BFE RID: 199678 RVA: 0x00B51CD4 File Offset: 0x00B4FED4
		public void LateScrollTo(UUIItem uiItem, [Nullable(2)] Action callBack = null, bool bTweenAnim = false)
		{
			TTimerAction <>9__1;
			this.BindLateUpdate(delegate(float delta)
			{
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate(float _)
					{
						this.ScrollTo(uiItem, bTweenAnim);
						Action callBack2 = callBack;
						if (callBack2 == null)
						{
							return;
						}
						callBack2();
					});
				}
				gameplayTimeInstance.Next(action, null, null);
				this.UnBindLateUpdate();
			});
		}

		// Token: 0x06030BFF RID: 199679 RVA: 0x00B51D18 File Offset: 0x00B4FF18
		public void LateScrollToLeft(object key)
		{
			TTimerAction <>9__1;
			this.BindLateUpdate(delegate(float delta)
			{
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate(float _)
					{
						this.ScrollToLeft(key);
					});
				}
				gameplayTimeInstance.Next(action, null, null);
				this.UnBindLateUpdate();
			});
		}

		// Token: 0x06030C00 RID: 199680 RVA: 0x00B51D4C File Offset: 0x00B4FF4C
		public void ScrollToLeft(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToLeft(ref fvector2D, itemByKey, false);
		}

		// Token: 0x06030C01 RID: 199681 RVA: 0x00B51DA4 File Offset: 0x00B4FFA4
		public void ScrollToLeftByItem(UUIItem scrollItem)
		{
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToLeft(ref fvector2D, scrollItem, false);
		}

		// Token: 0x06030C02 RID: 199682 RVA: 0x00B51DEC File Offset: 0x00B4FFEC
		public void ScrollToRight(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToRight(ref fvector2D, itemByKey, false);
		}

		// Token: 0x06030C03 RID: 199683 RVA: 0x00B51E44 File Offset: 0x00B50044
		public void ScrollToTop(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToTop(ref fvector2D, itemByKey, false);
		}

		// Token: 0x06030C04 RID: 199684 RVA: 0x00B51E9C File Offset: 0x00B5009C
		public void ScrollToTopByIndex(int index)
		{
			UUIItem itemByIndex = this.GetItemByIndex(index);
			if (itemByIndex != null)
			{
				FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
				FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
				this.TargetScroll.ScrollToTop(ref fvector2D, itemByIndex, false);
			}
		}

		// Token: 0x06030C05 RID: 199685 RVA: 0x00B51EF0 File Offset: 0x00B500F0
		public void ScrollToBottom(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToBottom(ref fvector2D, itemByKey, false);
		}

		// Token: 0x06030C06 RID: 199686 RVA: 0x00B51F48 File Offset: 0x00B50148
		public void SetActive(bool bActive)
		{
			this.TargetScroll.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x06030C07 RID: 199687 RVA: 0x00B51F6E File Offset: 0x00B5016E
		public void BindScrollValueChange(Action<FVector2D> callback)
		{
			this.TargetScroll.OnScrollValueChange.Bind(callback);
		}

		// Token: 0x06030C08 RID: 199688 RVA: 0x00B51F81 File Offset: 0x00B50181
		public void UnBindScrollValueChange()
		{
			this.TargetScroll.OnScrollValueChange.Unbind();
		}

		// Token: 0x06030C09 RID: 199689 RVA: 0x00B51F93 File Offset: 0x00B50193
		public void BindLateUpdate(Action<float> callBack)
		{
			this.GenericLayout.BindLateUpdate(callBack);
		}

		// Token: 0x06030C0A RID: 199690 RVA: 0x00B51FA1 File Offset: 0x00B501A1
		public void UnBindLateUpdate()
		{
			this.GenericLayout.UnBindLateUpdate();
		}

		// Token: 0x06030C0B RID: 199691 RVA: 0x00B51FAE File Offset: 0x00B501AE
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<TProxy, TData> GetGenericLayout()
		{
			return this.GenericLayout;
		}

		// Token: 0x06030C0C RID: 199692 RVA: 0x00B51FB6 File Offset: 0x00B501B6
		public void SelectGridProxy(int gridIndex = -1, bool fireEvent = false)
		{
			GenericLayout<TProxy, TData> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.SelectGridProxy(gridIndex, fireEvent);
		}

		// Token: 0x06030C0D RID: 199693 RVA: 0x00B51FCA File Offset: 0x00B501CA
		public int GetSelectedIndex()
		{
			GenericLayout<TProxy, TData> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return -1;
			}
			return genericLayout.GetSelectedGridIndex();
		}

		// Token: 0x06030C0E RID: 199694 RVA: 0x00B51FDD File Offset: 0x00B501DD
		public void PlayTurnAnimation()
		{
			GenericLayout<TProxy, TData> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			UUIInturnAnimController uiAnimController = genericLayout.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play("", -1, false);
		}

		// Token: 0x06030C0F RID: 199695 RVA: 0x00B52000 File Offset: 0x00B50200
		public EOutOfBoundsType IsItemInViewport(UUIItem item, float tolerance)
		{
			EOutOfBoundsType result = EOutOfBoundsType.NotOut;
			EOutOfBoundsType result2 = EOutOfBoundsType.NotOut;
			this.TargetScroll.GetOutOfBottomBoundsType(item, ref result, ref result2, tolerance);
			if (this.TargetScroll.Vertical)
			{
				return result;
			}
			return result2;
		}

		// Token: 0x06030C10 RID: 199696 RVA: 0x00B52034 File Offset: 0x00B50234
		public EOutOfBoundsType IsItemFullyOutOfViewport(UUIItem item, float tolerance)
		{
			float num = this.TargetScroll.Vertical ? item.GetHeight() : item.GetWidth();
			float tolerance2 = tolerance + num;
			return this.IsItemInViewport(item, tolerance2);
		}

		// Token: 0x0401A2DE RID: 107230
		[Nullable(2)]
		private readonly UUIScrollViewWithScrollbarComponent TargetScroll;

		// Token: 0x0401A2DF RID: 107231
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly GenericLayout<TProxy, TData> GenericLayout;
	}
}
