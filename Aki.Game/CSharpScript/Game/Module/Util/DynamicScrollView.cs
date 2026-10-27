using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048D7 RID: 18647
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicScrollView<T, TBase, [Nullable(2)] TData> : IGridPreserver where T : class, IDynamicScrollItem<TData> where TBase : class, IDynamicScrollBaseItem<TData>
	{
		// Token: 0x06030BAA RID: 199594 RVA: 0x00B50C10 File Offset: 0x00B4EE10
		public DynamicScrollView(UUIDynScrollViewComponent scrollView, UUIItem templateActor, TBase templateContent, TDynamicScrollViewCreate<T, TData> createFunction)
		{
			this.CreateFunction = createFunction;
			this.TemplateContent = templateContent;
			templateActor.SetUIParent(scrollView.RootUIComp, false);
			this.InitedActorMap.Clear();
			this.TemplateActor = templateActor;
			this.DynamicScroll = scrollView;
			this.DynamicScroll.OnItemUpdate.Bind(new Func<int, AUIBaseActor, AUIBaseActor>(this.OnItemUpdate));
			this.DynamicScroll.OnItemClear.Bind(new Action<int, AUIBaseActor>(this.OnItemClear));
			this.DynamicScroll.ItemSizeDelegate.Bind(new Func<int, FVector2D>(this.GetItemSize));
			this.DynamicScroll.OnDestroyCallBack.Bind(new Action(this.OnItemDestroy));
			this.GridsController = new InTurnGridAppearAnimation(this);
			this.GridsController.RegisterAnimController();
		}

		// Token: 0x06030BAB RID: 199595 RVA: 0x00B50D1C File Offset: 0x00B4EF1C
		public UniTask Init()
		{
			DynamicScrollView<T, TBase, TData>.<Init>d__14 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<DynamicScrollView<T, TBase, TData>.<Init>d__14>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06030BAC RID: 199596 RVA: 0x00B50D5F File Offset: 0x00B4EF5F
		public int GetDisplayGridNum()
		{
			return this.DynamicScroll.DisplayItemArray.Num();
		}

		// Token: 0x06030BAD RID: 199597 RVA: 0x00B50D71 File Offset: 0x00B4EF71
		public int GetPreservedGridNum()
		{
			return this.DynamicScroll.DisplayItemArray.Num() + this.DynamicScroll.IdleItemArray.Num();
		}

		// Token: 0x06030BAE RID: 199598 RVA: 0x00B50D94 File Offset: 0x00B4EF94
		public int GetDisplayGridStartIndex()
		{
			int result = 0;
			this.DynamicScroll.GetItemIndex(0, ref result);
			return result;
		}

		// Token: 0x06030BAF RID: 199599 RVA: 0x00B50DB4 File Offset: 0x00B4EFB4
		public int GetDisplayGridEndIndex()
		{
			int num = this.DynamicScroll.DisplayItemArray.Num() - 1;
			if (num < 0)
			{
				return 0;
			}
			int result = 0;
			this.DynamicScroll.GetItemIndex(num, ref result);
			return result;
		}

		// Token: 0x06030BB0 RID: 199600 RVA: 0x00B50DEC File Offset: 0x00B4EFEC
		[NullableContext(2)]
		public UUIItem GetGrid(int gridIndex)
		{
			AUIBaseActor item = this.DynamicScroll.GetItem(gridIndex);
			if (item == null)
			{
				return null;
			}
			return item.GetUIItem();
		}

		// Token: 0x06030BB1 RID: 199601 RVA: 0x00B50E08 File Offset: 0x00B4F008
		public void LateScrollTo(int index)
		{
			this.BindLateUpdate(delegate(float delta)
			{
				this.ScrollToItemIndex(index, true, false).Forget();
				this.UnBindLateUpdate();
			});
		}

		// Token: 0x06030BB2 RID: 199602 RVA: 0x00B50E3C File Offset: 0x00B4F03C
		[NullableContext(2)]
		public UUIItem GetGridByDisplayIndex(int gridIndex)
		{
			int index = 0;
			this.DynamicScroll.GetItemDisplayIndex(gridIndex, ref index);
			return this.DynamicScroll.DisplayItemArray.Get(index).Get().GetUIItem();
		}

		// Token: 0x06030BB3 RID: 199603 RVA: 0x00B50E78 File Offset: 0x00B4F078
		public float GetGridAnimationInterval()
		{
			return this.DynamicScroll.GetGridAnimationInterval();
		}

		// Token: 0x06030BB4 RID: 199604 RVA: 0x00B50E85 File Offset: 0x00B4F085
		public float GetGridAnimationStartTime()
		{
			return this.DynamicScroll.GetGridAnimationStartTime();
		}

		// Token: 0x06030BB5 RID: 199605 RVA: 0x00B50E92 File Offset: 0x00B4F092
		public void NotifyAnimationStart()
		{
			this.DynamicScroll.SetInAnimation(true);
		}

		// Token: 0x06030BB6 RID: 199606 RVA: 0x00B50EA0 File Offset: 0x00B4F0A0
		public void NotifyAnimationEnd()
		{
			this.DynamicScroll.SetInAnimation(false);
		}

		// Token: 0x06030BB7 RID: 199607 RVA: 0x00B50EB0 File Offset: 0x00B4F0B0
		public void RefreshByData(IReadOnlyList<TData> data, bool keepContentPosition = false, bool skipGridAnim = false)
		{
			this.DataArray = data;
			this.ScrollItemMap.Clear();
			this.ScrollItemClearActionsMap.Clear();
			AUIBaseActor item = this.TemplateActor.GetOwner() as AUIBaseActor;
			this.TemplateActor.SetUIActive(true);
			this._tempActorCache.Clear();
			this.Refreshing = true;
			this.DynamicScroll.RefreshByData(item, data.Count, keepContentPosition);
			this.Refreshing = false;
			this.TemplateActor.SetUIActive(false);
			this.DynamicScroll.SetInAnimation(true);
			if (!skipGridAnim)
			{
				this.PlayGridAnimate();
			}
		}

		// Token: 0x06030BB8 RID: 199608 RVA: 0x00B50F44 File Offset: 0x00B4F144
		public bool CheckIfAllRefreshFinished()
		{
			UUIDynScrollViewComponent dynamicScroll = this.DynamicScroll;
			TMap<int, EScrollItemState> tmap = (dynamicScroll != null) ? dynamicScroll.ItemStateMap : null;
			if (tmap == null)
			{
				return true;
			}
			foreach (KeyValuePair<int, EScrollItemState> keyValuePair in tmap)
			{
				if (keyValuePair.Value == EScrollItemState.Updating)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06030BB9 RID: 199609 RVA: 0x00B50FB0 File Offset: 0x00B4F1B0
		private void CheckUnBindDynScollLateUpdate()
		{
			if (this.LateUpdateBindState)
			{
				this.DynamicScroll.OnLateUpdate.Unbind();
				this.LateUpdateBindState = false;
			}
		}

		// Token: 0x06030BBA RID: 199610 RVA: 0x00B50FD1 File Offset: 0x00B4F1D1
		private void CheckBindDynScrollLateUpdateStateAndBind()
		{
			if (!this.LateUpdateBindState)
			{
				this.DynamicScroll.OnLateUpdate.Bind(new Action<float>(this.OnLateUpdate));
				this.LateUpdateBindState = true;
			}
		}

		// Token: 0x06030BBB RID: 199611 RVA: 0x00B51000 File Offset: 0x00B4F200
		[NullableContext(2)]
		private AUIBaseActor OnItemUpdate(int index, AUIBaseActor actor)
		{
			TData data = this.DataArray[index];
			T tempItem;
			T tempItem2;
			if (this.InitedActorMap.TryGetValue(actor, out tempItem2))
			{
				tempItem = tempItem2;
				this.WaitForUpdateItem(data, index, actor).Forget();
			}
			else
			{
				tempItem = this.CreateFunction(data, actor.GetUIItem(), index);
				UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
				tempItem.Init(actor.GetUIItem()).Finally(delegate()
				{
					tempItem.Update(data, index);
					if (this.DynamicScroll != null && this.DynamicScroll.IsValid())
					{
						this.DynamicScroll.SetScrollItemState(index, EScrollItemState.Completed);
					}
					uniTaskCompletionSource.TrySetResult();
				}).Forget();
				this.InitedActorMap[actor] = tempItem;
				this.ActorInitPromise[actor] = uniTaskCompletionSource.Task;
			}
			this.CheckIfNeedSetItemActiveWhenInit(tempItem, index);
			tempItem.SkipDestroyActor = true;
			this.ScrollItemMap[index] = tempItem;
			return tempItem.GetUsingItem(data);
		}

		// Token: 0x06030BBC RID: 199612 RVA: 0x00B51140 File Offset: 0x00B4F340
		private UniTask WaitForUpdateItem(TData data, int index, AUIBaseActor actor)
		{
			DynamicScrollView<T, TBase, TData>.<WaitForUpdateItem>d__33 <WaitForUpdateItem>d__;
			<WaitForUpdateItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForUpdateItem>d__.<>4__this = this;
			<WaitForUpdateItem>d__.data = data;
			<WaitForUpdateItem>d__.index = index;
			<WaitForUpdateItem>d__.actor = actor;
			<WaitForUpdateItem>d__.<>1__state = -1;
			<WaitForUpdateItem>d__.<>t__builder.Start<DynamicScrollView<T, TBase, TData>.<WaitForUpdateItem>d__33>(ref <WaitForUpdateItem>d__);
			return <WaitForUpdateItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030BBD RID: 199613 RVA: 0x00B5119B File Offset: 0x00B4F39B
		private void CheckIfNeedSetItemActiveWhenInit(T item, int index)
		{
			item.SetUiActive(true);
		}

		// Token: 0x06030BBE RID: 199614 RVA: 0x00B511AC File Offset: 0x00B4F3AC
		[NullableContext(2)]
		private void OnItemClear(int index, AUIBaseActor actor)
		{
			UUIItem grid = this.GetGrid(index);
			EventSystem.Instance.Emit<UUIItem>(EEventName.OnDynamicScrollViewClearItem, grid);
			this.ScrollItemMap.Remove(index);
			Action action;
			if (this.ScrollItemClearActionsMap.TryGetValue(index, out action))
			{
				action();
				this.ScrollItemClearActionsMap.Remove(index);
			}
		}

		// Token: 0x06030BBF RID: 199615 RVA: 0x00B511FF File Offset: 0x00B4F3FF
		private void OnItemDestroy()
		{
			this.CheckUnBindDynScollLateUpdate();
		}

		// Token: 0x06030BC0 RID: 199616 RVA: 0x00B51208 File Offset: 0x00B4F408
		private FVector2D GetItemSize(int index)
		{
			TData data = this.DataArray[index];
			return this.TemplateContent.GetItemSize(data);
		}

		// Token: 0x06030BC1 RID: 199617 RVA: 0x00B51233 File Offset: 0x00B4F433
		public FVector2D GetItemSizeFromData(TData data)
		{
			return this.TemplateContent.GetItemSize(data);
		}

		// Token: 0x06030BC2 RID: 199618 RVA: 0x00B51248 File Offset: 0x00B4F448
		[NullableContext(2)]
		public T GetScrollItemFromIndex(int index)
		{
			T result;
			this.ScrollItemMap.TryGetValue(index, out result);
			return result;
		}

		// Token: 0x06030BC3 RID: 199619 RVA: 0x00B51265 File Offset: 0x00B4F465
		public int GetScrollItemCount()
		{
			return this.ScrollItemMap.Count;
		}

		// Token: 0x06030BC4 RID: 199620 RVA: 0x00B51272 File Offset: 0x00B4F472
		public T[] GetScrollItemItems()
		{
			return this.ScrollItemMap.Values.ToArray<T>();
		}

		// Token: 0x06030BC5 RID: 199621 RVA: 0x00B51284 File Offset: 0x00B4F484
		private void OnLateUpdate(float deltaTime)
		{
			Action<float> lateUpdateCallBack = this.LateUpdateCallBack;
			if (lateUpdateCallBack != null)
			{
				lateUpdateCallBack(deltaTime);
			}
			Action<float> reloadLateUpdateCallBack = this.ReloadLateUpdateCallBack;
			if (reloadLateUpdateCallBack != null)
			{
				reloadLateUpdateCallBack(deltaTime);
			}
			this.CheckAndUnbindLateUpdate();
		}

		// Token: 0x06030BC6 RID: 199622 RVA: 0x00B512B0 File Offset: 0x00B4F4B0
		private void PlayGridAnimate()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.DynamicScroll.DisplayItemArray.Num(), true);
			}
		}

		// Token: 0x06030BC7 RID: 199623 RVA: 0x00B512D6 File Offset: 0x00B4F4D6
		private void CheckAndUnbindLateUpdate()
		{
			if (this.LateUpdateCallBack == null && this.ReloadLateUpdateCallBack == null)
			{
				this.CheckUnBindDynScollLateUpdate();
			}
		}

		// Token: 0x06030BC8 RID: 199624 RVA: 0x00B512EE File Offset: 0x00B4F4EE
		private void BindReloadLateUpdate(Action<float> callback)
		{
			this.ReloadLateUpdateCallBack = callback;
			this.CheckBindDynScrollLateUpdateStateAndBind();
		}

		// Token: 0x06030BC9 RID: 199625 RVA: 0x00B512FD File Offset: 0x00B4F4FD
		public void UnBindReloadLateUpdate()
		{
			this.ReloadLateUpdateCallBack = null;
		}

		// Token: 0x06030BCA RID: 199626 RVA: 0x00B51306 File Offset: 0x00B4F506
		public void BindLateUpdate(Action<float> callback)
		{
			this.LateUpdateCallBack = callback;
			this.CheckBindDynScrollLateUpdateStateAndBind();
		}

		// Token: 0x06030BCB RID: 199627 RVA: 0x00B51315 File Offset: 0x00B4F515
		public void UnBindLateUpdate()
		{
			this.LateUpdateCallBack = null;
		}

		// Token: 0x06030BCC RID: 199628 RVA: 0x00B5131E File Offset: 0x00B4F51E
		public void AddListenerOnItemClear(int index, Action action)
		{
			if (this.ScrollItemClearActionsMap.ContainsKey(index))
			{
				this.ScrollItemClearActionsMap[index] = action;
				return;
			}
			this.ScrollItemClearActionsMap.Add(index, action);
		}

		// Token: 0x06030BCD RID: 199629 RVA: 0x00B5134C File Offset: 0x00B4F54C
		public void ClearChildren()
		{
			this.ScrollItemMap.Clear();
			this.ScrollItemClearActionsMap.Clear();
			this.CheckUnBindDynScollLateUpdate();
			this.DynamicScroll.OnItemUpdate.Unbind();
			this.DynamicScroll.OnItemClear.Unbind();
			this.DynamicScroll.ItemSizeDelegate.Unbind();
			this.DynamicScroll.OnDestroyCallBack.Unbind();
			GridAppearAnimationBase gridsController = this.GridsController;
			if (gridsController == null)
			{
				return;
			}
			gridsController.Clear();
		}

		// Token: 0x06030BCE RID: 199630 RVA: 0x00B513C8 File Offset: 0x00B4F5C8
		public UniTask ScrollToItemIndex(int index, bool playGridAnim = true, bool resetAlpha = false)
		{
			DynamicScrollView<T, TBase, TData>.<ScrollToItemIndex>d__51 <ScrollToItemIndex>d__;
			<ScrollToItemIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ScrollToItemIndex>d__.<>4__this = this;
			<ScrollToItemIndex>d__.index = index;
			<ScrollToItemIndex>d__.playGridAnim = playGridAnim;
			<ScrollToItemIndex>d__.resetAlpha = resetAlpha;
			<ScrollToItemIndex>d__.<>1__state = -1;
			<ScrollToItemIndex>d__.<>t__builder.Start<DynamicScrollView<T, TBase, TData>.<ScrollToItemIndex>d__51>(ref <ScrollToItemIndex>d__);
			return <ScrollToItemIndex>d__.<>t__builder.Task;
		}

		// Token: 0x06030BCF RID: 199631 RVA: 0x00B51423 File Offset: 0x00B4F623
		public bool IsValid()
		{
			UUIDynScrollViewComponent dynamicScroll = this.DynamicScroll;
			return dynamicScroll != null && dynamicScroll.IsValid();
		}

		// Token: 0x06030BD0 RID: 199632 RVA: 0x00B51438 File Offset: 0x00B4F638
		public void ScrollToItemIndexByOffset(int index)
		{
			float num = this.DynamicScroll.PaddingVertical;
			int num2 = 0;
			int i = 0;
			while (i < index)
			{
				AUIBaseActor item = this.DynamicScroll.GetItem(i);
				float? num3;
				if (item == null)
				{
					num3 = null;
				}
				else
				{
					UUIItem uiitem = item.GetUIItem();
					num3 = ((uiitem != null) ? new float?(uiitem.GetHeight()) : null);
				}
				float? num4 = num3;
				if (num4 == null)
				{
					goto IL_95;
				}
				float? num5 = num4;
				float num6 = 0f;
				if (!(num5.GetValueOrDefault() > num6 & num5 != null))
				{
					goto IL_95;
				}
				num += num4.Value + this.DynamicScroll.SpacingVertical;
				IL_D2:
				i++;
				continue;
				IL_95:
				TData data = this.DataArray[i];
				FVector2D itemSize = this.TemplateContent.GetItemSize(data);
				num += itemSize.Y + this.DynamicScroll.SpacingVertical;
				num2++;
				goto IL_D2;
			}
			UUIItem uuiitem = this.DynamicScroll.ContentUIItem.Get();
			float num7 = (uuiitem != null) ? uuiitem.GetHeight() : 0f;
			UUIItem uuiitem2 = this.DynamicScroll.ContentParentUIItem.Get();
			float num8 = (uuiitem2 != null) ? uuiitem2.GetHeight() : 0f;
			float num9 = num7 - num8;
			if (num9 > 0f)
			{
				this.DynamicScroll.SetScrollProgress(Math.Min(num / num9, 1f));
			}
		}

		// Token: 0x06030BD1 RID: 199633 RVA: 0x00B51598 File Offset: 0x00B4F798
		public UniTask WaitForInit()
		{
			DynamicScrollView<T, TBase, TData>.<WaitForInit>d__54 <WaitForInit>d__;
			<WaitForInit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForInit>d__.<>4__this = this;
			<WaitForInit>d__.<>1__state = -1;
			<WaitForInit>d__.<>t__builder.Start<DynamicScrollView<T, TBase, TData>.<WaitForInit>d__54>(ref <WaitForInit>d__);
			return <WaitForInit>d__.<>t__builder.Task;
		}

		// Token: 0x06030BD2 RID: 199634 RVA: 0x00B515DC File Offset: 0x00B4F7DC
		public void ScrollToBottom(UUIItem uiItem)
		{
			FVector relativeLocation = this.DynamicScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.DynamicScroll.ScrollToBottom(ref fvector2D, uiItem, false);
		}

		// Token: 0x06030BD3 RID: 199635 RVA: 0x00B51624 File Offset: 0x00B4F824
		private UniTask WaitInitThenScrollToIndex(int index, bool playGridAnim = true, bool resetAlpha = false)
		{
			DynamicScrollView<T, TBase, TData>.<WaitInitThenScrollToIndex>d__56 <WaitInitThenScrollToIndex>d__;
			<WaitInitThenScrollToIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitInitThenScrollToIndex>d__.<>4__this = this;
			<WaitInitThenScrollToIndex>d__.index = index;
			<WaitInitThenScrollToIndex>d__.playGridAnim = playGridAnim;
			<WaitInitThenScrollToIndex>d__.resetAlpha = resetAlpha;
			<WaitInitThenScrollToIndex>d__.<>1__state = -1;
			<WaitInitThenScrollToIndex>d__.<>t__builder.Start<DynamicScrollView<T, TBase, TData>.<WaitInitThenScrollToIndex>d__56>(ref <WaitInitThenScrollToIndex>d__);
			return <WaitInitThenScrollToIndex>d__.<>t__builder.Task;
		}

		// Token: 0x06030BD4 RID: 199636 RVA: 0x00B5167F File Offset: 0x00B4F87F
		public void ResetGridController()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.GetDisplayGridNum(), true);
			}
		}

		// Token: 0x06030BD5 RID: 199637 RVA: 0x00B5169B File Offset: 0x00B4F89B
		[NullableContext(2)]
		public UUIInturnAnimController GetUiAnimController()
		{
			UUIDynScrollViewComponent dynamicScroll = this.DynamicScroll;
			AUIBaseActor auibaseActor = (dynamicScroll != null) ? dynamicScroll.GetContent() : null;
			return ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController;
		}

		// Token: 0x0401A2CD RID: 107213
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly TDynamicScrollViewCreate<T, TData> CreateFunction;

		// Token: 0x0401A2CE RID: 107214
		[Nullable(2)]
		private readonly UUIDynScrollViewComponent DynamicScroll;

		// Token: 0x0401A2CF RID: 107215
		[Nullable(2)]
		private readonly TBase TemplateContent;

		// Token: 0x0401A2D0 RID: 107216
		private readonly Dictionary<int, T> ScrollItemMap = new Dictionary<int, T>();

		// Token: 0x0401A2D1 RID: 107217
		private readonly Dictionary<int, Action> ScrollItemClearActionsMap = new Dictionary<int, Action>();

		// Token: 0x0401A2D2 RID: 107218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<TData> DataArray;

		// Token: 0x0401A2D3 RID: 107219
		[Nullable(2)]
		private readonly UUIItem TemplateActor;

		// Token: 0x0401A2D4 RID: 107220
		[Nullable(2)]
		private readonly GridAppearAnimationBase GridsController;

		// Token: 0x0401A2D5 RID: 107221
		private readonly Dictionary<AUIBaseActor, T> InitedActorMap = new Dictionary<AUIBaseActor, T>();

		// Token: 0x0401A2D6 RID: 107222
		[Nullable(2)]
		public Action<float> LateUpdateCallBack;

		// Token: 0x0401A2D7 RID: 107223
		[Nullable(2)]
		private Action<float> ReloadLateUpdateCallBack;

		// Token: 0x0401A2D8 RID: 107224
		private readonly Dictionary<AUIBaseActor, UniTask> ActorInitPromise = new Dictionary<AUIBaseActor, UniTask>();

		// Token: 0x0401A2D9 RID: 107225
		private bool LateUpdateBindState;

		// Token: 0x0401A2DA RID: 107226
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private Dictionary<int, AUIBaseActor> _tempActorCache = new Dictionary<int, AUIBaseActor>();

		// Token: 0x0401A2DB RID: 107227
		private bool Refreshing;
	}
}
