using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003850 RID: 14416
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericScrollViewNew<TProxy, [Nullable(2)] TData> where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x06025719 RID: 153369 RVA: 0x00A8C880 File Offset: 0x00A8AA80
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

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x0602571A RID: 153370 RVA: 0x00A8C903 File Offset: 0x00A8AB03
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

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x0602571B RID: 153371 RVA: 0x00A8C918 File Offset: 0x00A8AB18
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

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x0602571C RID: 153372 RVA: 0x00A8C948 File Offset: 0x00A8AB48
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

		// Token: 0x0602571D RID: 153373 RVA: 0x00A8C978 File Offset: 0x00A8AB78
		public GenericScrollViewNew(UUIScrollViewWithScrollbarComponent scrollView, Func<TProxy> gridProxyCreateFunction, [Nullable(2)] AUIBaseActor gridActor = null, bool isRefreshAsync = false, [Nullable(2)] UUILayoutBase layout = null)
		{
			this.TargetScroll = scrollView;
			UUILayoutBase layout2 = layout ?? (this.TargetScroll.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase);
			this.GenericLayout = new GenericLayout<TProxy, TData>(layout2, gridProxyCreateFunction, gridActor, isRefreshAsync, true);
			this.GenericLayout.AnimControllerComponent = (((scrollView != null) ? scrollView.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController);
		}

		// Token: 0x0602571E RID: 153374 RVA: 0x00A8C9F4 File Offset: 0x00A8ABF4
		public void RefreshByData(IReadOnlyList<TData> data, [Nullable(2)] Action callBack = null, bool playGridAnim = false)
		{
			this.GenericLayout.RefreshByData(data, callBack, playGridAnim);
		}

		// Token: 0x0602571F RID: 153375 RVA: 0x00A8CA04 File Offset: 0x00A8AC04
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

		// Token: 0x06025720 RID: 153376 RVA: 0x00A8CA57 File Offset: 0x00A8AC57
		public void SetHorizontalScrollEnable(bool enable)
		{
			this.TargetScroll.SetHorizontal(enable);
		}

		// Token: 0x06025721 RID: 153377 RVA: 0x00A8CA65 File Offset: 0x00A8AC65
		public void SetVerticalScrollEnable(bool enable)
		{
			this.TargetScroll.SetVertical(enable);
		}

		// Token: 0x06025722 RID: 153378 RVA: 0x00A8CA73 File Offset: 0x00A8AC73
		[NullableContext(2)]
		public UUIItem GetItemByIndex(int index)
		{
			return this.GenericLayout.GetItemByIndex(index);
		}

		// Token: 0x06025723 RID: 153379 RVA: 0x00A8CA81 File Offset: 0x00A8AC81
		[return: Nullable(2)]
		public UUIItem GetItemByKey(object key)
		{
			return this.GenericLayout.GetItemByKey(key);
		}

		// Token: 0x06025724 RID: 153380 RVA: 0x00A8CA8F File Offset: 0x00A8AC8F
		[NullableContext(2)]
		public TProxy GetScrollItemByIndex(int index)
		{
			return this.GenericLayout.GetLayoutItemByIndex(index);
		}

		// Token: 0x06025725 RID: 153381 RVA: 0x00A8CA9D File Offset: 0x00A8AC9D
		[return: Nullable(2)]
		public TProxy GetScrollItemByKey(object key)
		{
			return this.GenericLayout.GetLayoutItemByKey(key);
		}

		// Token: 0x06025726 RID: 153382 RVA: 0x00A8CAAB File Offset: 0x00A8ACAB
		public Dictionary<object, TProxy> GetScrollItemMap()
		{
			return this.GenericLayout.GetLayoutItemMap();
		}

		// Token: 0x06025727 RID: 153383 RVA: 0x00A8CAB8 File Offset: 0x00A8ACB8
		public List<TProxy> GetScrollItemList()
		{
			return this.GenericLayout.GetLayoutItemList();
		}

		// Token: 0x06025728 RID: 153384 RVA: 0x00A8CAC5 File Offset: 0x00A8ACC5
		public void ScrollTo(UUIItem uiItem, bool bTweenAnim = false)
		{
			this.TargetScroll.ScrollTo(uiItem, bTweenAnim);
		}

		// Token: 0x06025729 RID: 153385 RVA: 0x00A8CAD4 File Offset: 0x00A8ACD4
		public void ScrollToItemByKey(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			if (itemByKey != null)
			{
				this.TargetScroll.ScrollTo(itemByKey, false);
			}
		}

		// Token: 0x0602572A RID: 153386 RVA: 0x00A8CB00 File Offset: 0x00A8AD00
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

		// Token: 0x0602572B RID: 153387 RVA: 0x00A8CB44 File Offset: 0x00A8AD44
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

		// Token: 0x0602572C RID: 153388 RVA: 0x00A8CB78 File Offset: 0x00A8AD78
		public UniTask WaitLateUpdate()
		{
			GenericScrollViewNew<TProxy, TData>.<WaitLateUpdate>d__25 <WaitLateUpdate>d__;
			<WaitLateUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitLateUpdate>d__.<>4__this = this;
			<WaitLateUpdate>d__.<>1__state = -1;
			<WaitLateUpdate>d__.<>t__builder.Start<GenericScrollViewNew<TProxy, TData>.<WaitLateUpdate>d__25>(ref <WaitLateUpdate>d__);
			return <WaitLateUpdate>d__.<>t__builder.Task;
		}

		// Token: 0x0602572D RID: 153389 RVA: 0x00A8CBBC File Offset: 0x00A8ADBC
		public void ScrollToLeft(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToLeft(ref fvector2D, itemByKey, false);
		}

		// Token: 0x0602572E RID: 153390 RVA: 0x00A8CC14 File Offset: 0x00A8AE14
		public void ScrollToLeftByItem(UUIItem scrollItem)
		{
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToLeft(ref fvector2D, scrollItem, false);
		}

		// Token: 0x0602572F RID: 153391 RVA: 0x00A8CC5C File Offset: 0x00A8AE5C
		public void ScrollToRight(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToRight(ref fvector2D, itemByKey, false);
		}

		// Token: 0x06025730 RID: 153392 RVA: 0x00A8CCB4 File Offset: 0x00A8AEB4
		public void ScrollToTop(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToTop(ref fvector2D, itemByKey, false);
		}

		// Token: 0x06025731 RID: 153393 RVA: 0x00A8CD0C File Offset: 0x00A8AF0C
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

		// Token: 0x06025732 RID: 153394 RVA: 0x00A8CD60 File Offset: 0x00A8AF60
		public void ScrollToBottom(object key)
		{
			UUIItem itemByKey = this.GenericLayout.GetItemByKey(key);
			FVector relativeLocation = this.TargetScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.TargetScroll.ScrollToBottom(ref fvector2D, itemByKey, false);
		}

		// Token: 0x06025733 RID: 153395 RVA: 0x00A8CDB8 File Offset: 0x00A8AFB8
		public void SetActive(bool bActive)
		{
			this.TargetScroll.RootUIComp.Get().SetUIActive(bActive);
		}

		// Token: 0x06025734 RID: 153396 RVA: 0x00A8CDDE File Offset: 0x00A8AFDE
		public void BindScrollValueChange(Action<FVector2D> callback)
		{
			this.TargetScroll.OnScrollValueChange.Bind(callback);
		}

		// Token: 0x06025735 RID: 153397 RVA: 0x00A8CDF1 File Offset: 0x00A8AFF1
		public void UnBindScrollValueChange()
		{
			this.TargetScroll.OnScrollValueChange.Unbind();
		}

		// Token: 0x06025736 RID: 153398 RVA: 0x00A8CE03 File Offset: 0x00A8B003
		public void BindLateUpdate(Action<float> callBack)
		{
			this.GenericLayout.BindLateUpdate(callBack);
		}

		// Token: 0x06025737 RID: 153399 RVA: 0x00A8CE11 File Offset: 0x00A8B011
		public void UnBindLateUpdate()
		{
			this.GenericLayout.UnBindLateUpdate();
		}

		// Token: 0x06025738 RID: 153400 RVA: 0x00A8CE1E File Offset: 0x00A8B01E
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

		// Token: 0x06025739 RID: 153401 RVA: 0x00A8CE26 File Offset: 0x00A8B026
		public void SelectGridProxy(int gridIndex = -1, bool fireEvent = false)
		{
			GenericLayout<TProxy, TData> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.SelectGridProxy(gridIndex, fireEvent);
		}

		// Token: 0x0602573A RID: 153402 RVA: 0x00A8CE3A File Offset: 0x00A8B03A
		public int GetSelectedIndex()
		{
			GenericLayout<TProxy, TData> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return -1;
			}
			return genericLayout.GetSelectedGridIndex();
		}

		// Token: 0x0602573B RID: 153403 RVA: 0x00A8CE4D File Offset: 0x00A8B04D
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

		// Token: 0x0602573C RID: 153404 RVA: 0x00A8CE70 File Offset: 0x00A8B070
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

		// Token: 0x0602573D RID: 153405 RVA: 0x00A8CEA4 File Offset: 0x00A8B0A4
		public EOutOfBoundsType IsItemFullyOutOfViewport(UUIItem item, float tolerance)
		{
			float num = this.TargetScroll.Vertical ? item.GetHeight() : item.GetWidth();
			float tolerance2 = tolerance + num;
			return this.IsItemInViewport(item, tolerance2);
		}

		// Token: 0x04014B51 RID: 84817
		[Nullable(2)]
		private readonly UUIScrollViewWithScrollbarComponent TargetScroll;

		// Token: 0x04014B52 RID: 84818
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly GenericLayout<TProxy, TData> GenericLayout;
	}
}
