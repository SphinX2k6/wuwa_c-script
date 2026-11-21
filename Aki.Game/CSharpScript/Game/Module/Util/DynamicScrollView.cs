using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200384E RID: 14414
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicScrollView<T, TBase, [Nullable(2)] TData> : IGridPreserver where T : class, IDynamicScrollItem<TData> where TBase : class, IDynamicScrollBaseItem<TData>
	{
		// Token: 0x060256D6 RID: 153302 RVA: 0x00A8BA18 File Offset: 0x00A89C18
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

		// Token: 0x060256D7 RID: 153303 RVA: 0x00A8BB24 File Offset: 0x00A89D24
		public UniTask Init()
		{
			DynamicScrollView<T, TBase, TData>.<Init>d__14 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<DynamicScrollView<T, TBase, TData>.<Init>d__14>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060256D8 RID: 153304 RVA: 0x00A8BB67 File Offset: 0x00A89D67
		public int GetDisplayGridNum()
		{
			return this.DynamicScroll.DisplayItemArray.Num();
		}

		// Token: 0x060256D9 RID: 153305 RVA: 0x00A8BB79 File Offset: 0x00A89D79
		public int GetPreservedGridNum()
		{
			return this.DynamicScroll.DisplayItemArray.Num() + this.DynamicScroll.IdleItemArray.Num();
		}

		// Token: 0x060256DA RID: 153306 RVA: 0x00A8BB9C File Offset: 0x00A89D9C
		public int GetDisplayGridStartIndex()
		{
			int result = 0;
			this.DynamicScroll.GetItemIndex(0, ref result);
			return result;
		}

		// Token: 0x060256DB RID: 153307 RVA: 0x00A8BBBC File Offset: 0x00A89DBC
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

		// Token: 0x060256DC RID: 153308 RVA: 0x00A8BBF4 File Offset: 0x00A89DF4
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

		// Token: 0x060256DD RID: 153309 RVA: 0x00A8BC10 File Offset: 0x00A89E10
		public void LateScrollTo(int index)
		{
			this.BindLateUpdate(delegate(float delta)
			{
				this.ScrollToItemIndex(index, true, false).Forget();
				this.UnBindLateUpdate();
			});
		}

		// Token: 0x060256DE RID: 153310 RVA: 0x00A8BC44 File Offset: 0x00A89E44
		[NullableContext(2)]
		public UUIItem GetGridByDisplayIndex(int gridIndex)
		{
			int index = 0;
			this.DynamicScroll.GetItemDisplayIndex(gridIndex, ref index);
			return this.DynamicScroll.DisplayItemArray.Get(index).Get().GetUIItem();
		}

		// Token: 0x060256DF RID: 153311 RVA: 0x00A8BC80 File Offset: 0x00A89E80
		public float GetGridAnimationInterval()
		{
			return this.DynamicScroll.GetGridAnimationInterval();
		}

		// Token: 0x060256E0 RID: 153312 RVA: 0x00A8BC8D File Offset: 0x00A89E8D
		public float GetGridAnimationStartTime()
		{
			return this.DynamicScroll.GetGridAnimationStartTime();
		}

		// Token: 0x060256E1 RID: 153313 RVA: 0x00A8BC9A File Offset: 0x00A89E9A
		public void NotifyAnimationStart()
		{
			this.DynamicScroll.SetInAnimation(true);
		}

		// Token: 0x060256E2 RID: 153314 RVA: 0x00A8BCA8 File Offset: 0x00A89EA8
		public void NotifyAnimationEnd()
		{
			this.DynamicScroll.SetInAnimation(false);
		}

		// Token: 0x060256E3 RID: 153315 RVA: 0x00A8BCB8 File Offset: 0x00A89EB8
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

		// Token: 0x060256E4 RID: 153316 RVA: 0x00A8BD4C File Offset: 0x00A89F4C
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

		// Token: 0x060256E5 RID: 153317 RVA: 0x00A8BDBC File Offset: 0x00A89FBC
		private void CheckUnBindDynScollLateUpdate()
		{
			if (this.LateUpdateBindState)
			{
				this.DynamicScroll.OnLateUpdate.Unbind();
				this.LateUpdateBindState = false;
			}
		}

		// Token: 0x060256E6 RID: 153318 RVA: 0x00A8BDDD File Offset: 0x00A89FDD
		private void CheckBindDynScrollLateUpdateStateAndBind()
		{
			if (!this.LateUpdateBindState)
			{
				this.DynamicScroll.OnLateUpdate.Bind(new Action<float>(this.OnLateUpdate));
				this.LateUpdateBindState = true;
			}
		}

		// Token: 0x060256E7 RID: 153319 RVA: 0x00A8BE0C File Offset: 0x00A8A00C
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

		// Token: 0x060256E8 RID: 153320 RVA: 0x00A8BF4C File Offset: 0x00A8A14C
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

		// Token: 0x060256E9 RID: 153321 RVA: 0x00A8BFA7 File Offset: 0x00A8A1A7
		private void CheckIfNeedSetItemActiveWhenInit(T item, int index)
		{
			item.SetUiActive(true);
		}

		// Token: 0x060256EA RID: 153322 RVA: 0x00A8BFB8 File Offset: 0x00A8A1B8
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

		// Token: 0x060256EB RID: 153323 RVA: 0x00A8C00B File Offset: 0x00A8A20B
		private void OnItemDestroy()
		{
			this.CheckUnBindDynScollLateUpdate();
		}

		// Token: 0x060256EC RID: 153324 RVA: 0x00A8C014 File Offset: 0x00A8A214
		private FVector2D GetItemSize(int index)
		{
			TData data = this.DataArray[index];
			return this.TemplateContent.GetItemSize(data);
		}

		// Token: 0x060256ED RID: 153325 RVA: 0x00A8C03F File Offset: 0x00A8A23F
		public FVector2D GetItemSizeFromData(TData data)
		{
			return this.TemplateContent.GetItemSize(data);
		}

		// Token: 0x060256EE RID: 153326 RVA: 0x00A8C054 File Offset: 0x00A8A254
		[NullableContext(2)]
		public T GetScrollItemFromIndex(int index)
		{
			T result;
			this.ScrollItemMap.TryGetValue(index, out result);
			return result;
		}

		// Token: 0x060256EF RID: 153327 RVA: 0x00A8C071 File Offset: 0x00A8A271
		public int GetScrollItemCount()
		{
			return this.ScrollItemMap.Count;
		}

		// Token: 0x060256F0 RID: 153328 RVA: 0x00A8C080 File Offset: 0x00A8A280
		public T[] GetScrollItemItems()
		{
			T[] array = new T[this.ScrollItemMap.Count];
			this.ScrollItemMap.Values.CopyTo(array, 0);
			return array;
		}

		// Token: 0x060256F1 RID: 153329 RVA: 0x00A8C0B1 File Offset: 0x00A8A2B1
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

		// Token: 0x060256F2 RID: 153330 RVA: 0x00A8C0DD File Offset: 0x00A8A2DD
		private void PlayGridAnimate()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.DynamicScroll.DisplayItemArray.Num(), true);
			}
		}

		// Token: 0x060256F3 RID: 153331 RVA: 0x00A8C103 File Offset: 0x00A8A303
		private void CheckAndUnbindLateUpdate()
		{
			if (this.LateUpdateCallBack == null && this.ReloadLateUpdateCallBack == null)
			{
				this.CheckUnBindDynScollLateUpdate();
			}
		}

		// Token: 0x060256F4 RID: 153332 RVA: 0x00A8C11B File Offset: 0x00A8A31B
		private void BindReloadLateUpdate(Action<float> callback)
		{
			this.ReloadLateUpdateCallBack = callback;
			this.CheckBindDynScrollLateUpdateStateAndBind();
		}

		// Token: 0x060256F5 RID: 153333 RVA: 0x00A8C12A File Offset: 0x00A8A32A
		public void UnBindReloadLateUpdate()
		{
			this.ReloadLateUpdateCallBack = null;
		}

		// Token: 0x060256F6 RID: 153334 RVA: 0x00A8C133 File Offset: 0x00A8A333
		public void BindLateUpdate(Action<float> callback)
		{
			this.LateUpdateCallBack = callback;
			this.CheckBindDynScrollLateUpdateStateAndBind();
		}

		// Token: 0x060256F7 RID: 153335 RVA: 0x00A8C142 File Offset: 0x00A8A342
		public void UnBindLateUpdate()
		{
			this.LateUpdateCallBack = null;
		}

		// Token: 0x060256F8 RID: 153336 RVA: 0x00A8C14B File Offset: 0x00A8A34B
		public void AddListenerOnItemClear(int index, Action action)
		{
			if (this.ScrollItemClearActionsMap.ContainsKey(index))
			{
				this.ScrollItemClearActionsMap[index] = action;
				return;
			}
			this.ScrollItemClearActionsMap.Add(index, action);
		}

		// Token: 0x060256F9 RID: 153337 RVA: 0x00A8C178 File Offset: 0x00A8A378
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

		// Token: 0x060256FA RID: 153338 RVA: 0x00A8C1F4 File Offset: 0x00A8A3F4
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

		// Token: 0x060256FB RID: 153339 RVA: 0x00A8C24F File Offset: 0x00A8A44F
		public bool IsValid()
		{
			UUIDynScrollViewComponent dynamicScroll = this.DynamicScroll;
			return dynamicScroll != null && dynamicScroll.IsValid();
		}

		// Token: 0x060256FC RID: 153340 RVA: 0x00A8C264 File Offset: 0x00A8A464
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

		// Token: 0x060256FD RID: 153341 RVA: 0x00A8C3C4 File Offset: 0x00A8A5C4
		public UniTask WaitForInit()
		{
			DynamicScrollView<T, TBase, TData>.<WaitForInit>d__54 <WaitForInit>d__;
			<WaitForInit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForInit>d__.<>4__this = this;
			<WaitForInit>d__.<>1__state = -1;
			<WaitForInit>d__.<>t__builder.Start<DynamicScrollView<T, TBase, TData>.<WaitForInit>d__54>(ref <WaitForInit>d__);
			return <WaitForInit>d__.<>t__builder.Task;
		}

		// Token: 0x060256FE RID: 153342 RVA: 0x00A8C408 File Offset: 0x00A8A608
		public void ScrollToBottom(UUIItem uiItem)
		{
			FVector relativeLocation = this.DynamicScroll.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(relativeLocation.X, relativeLocation.Y);
			this.DynamicScroll.ScrollToBottom(ref fvector2D, uiItem, false);
		}

		// Token: 0x060256FF RID: 153343 RVA: 0x00A8C450 File Offset: 0x00A8A650
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

		// Token: 0x06025700 RID: 153344 RVA: 0x00A8C4AB File Offset: 0x00A8A6AB
		public void ResetGridController()
		{
			if (this.GridsController != null)
			{
				this.GridsController.PlayGridAnim(this.GetDisplayGridNum(), true);
			}
		}

		// Token: 0x06025701 RID: 153345 RVA: 0x00A8C4C7 File Offset: 0x00A8A6C7
		[NullableContext(2)]
		public UUIInturnAnimController GetUiAnimController()
		{
			UUIDynScrollViewComponent dynamicScroll = this.DynamicScroll;
			AUIBaseActor auibaseActor = (dynamicScroll != null) ? dynamicScroll.GetContent() : null;
			return ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController;
		}

		// Token: 0x04014B40 RID: 84800
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly TDynamicScrollViewCreate<T, TData> CreateFunction;

		// Token: 0x04014B41 RID: 84801
		[Nullable(2)]
		private readonly UUIDynScrollViewComponent DynamicScroll;

		// Token: 0x04014B42 RID: 84802
		[Nullable(2)]
		private readonly TBase TemplateContent;

		// Token: 0x04014B43 RID: 84803
		private readonly Dictionary<int, T> ScrollItemMap = new Dictionary<int, T>();

		// Token: 0x04014B44 RID: 84804
		private readonly Dictionary<int, Action> ScrollItemClearActionsMap = new Dictionary<int, Action>();

		// Token: 0x04014B45 RID: 84805
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<TData> DataArray;

		// Token: 0x04014B46 RID: 84806
		[Nullable(2)]
		private readonly UUIItem TemplateActor;

		// Token: 0x04014B47 RID: 84807
		[Nullable(2)]
		private readonly GridAppearAnimationBase GridsController;

		// Token: 0x04014B48 RID: 84808
		private readonly Dictionary<AUIBaseActor, T> InitedActorMap = new Dictionary<AUIBaseActor, T>();

		// Token: 0x04014B49 RID: 84809
		[Nullable(2)]
		public Action<float> LateUpdateCallBack;

		// Token: 0x04014B4A RID: 84810
		[Nullable(2)]
		private Action<float> ReloadLateUpdateCallBack;

		// Token: 0x04014B4B RID: 84811
		private readonly Dictionary<AUIBaseActor, UniTask> ActorInitPromise = new Dictionary<AUIBaseActor, UniTask>();

		// Token: 0x04014B4C RID: 84812
		private bool LateUpdateBindState;

		// Token: 0x04014B4D RID: 84813
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private Dictionary<int, AUIBaseActor> _tempActorCache = new Dictionary<int, AUIBaseActor>();

		// Token: 0x04014B4E RID: 84814
		private bool Refreshing;
	}
}
