using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020056CF RID: 22223
	[NullableContext(2)]
	[Nullable(0)]
	public class LetterPanel : UiPanelBase
	{
		// Token: 0x0603885A RID: 231514 RVA: 0x00D6CFB8 File Offset: 0x00D6B1B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickNext));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603885B RID: 231515 RVA: 0x00D6D104 File Offset: 0x00D6B304
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			UUIItem item = base.GetItem(1);
			if (scrollViewWithScrollbar == null || item == null)
			{
				global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.YZH, "[LetterPanel] 信件文本滚动区组件缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.LetterScrollView = new GenericScrollViewNew<LetterContentItem, ITalkItem>(scrollViewWithScrollbar, new Func<LetterContentItem>(this.CreateLetterContentItem), item.GetOwner() as AUIBaseActor, false, null);
			this.BindNextDragEvents();
			this.RefreshNextHints();
		}

		// Token: 0x0603885C RID: 231516 RVA: 0x00D6D174 File Offset: 0x00D6B374
		protected override void OnBeforeDestroy()
		{
			this.UnbindNextDragEvents();
			this.ClearHintRefreshTimer();
			this.LastShowTalkTalkIdSet.Clear();
			this.DisplayedTalkIdSet.Clear();
			this.DisplayedTalkItems.Clear();
			this.CurrentContentItem = null;
			this.CurrentTalkItem = null;
		}

		// Token: 0x0603885D RID: 231517 RVA: 0x00D6D1B1 File Offset: 0x00D6B3B1
		public void SetOnCurrentTalkChanged([Nullable(new byte[]
		{
			1,
			2
		})] Action<ITalkItem> callback)
		{
			this.OnCurrentTalkChangedCallback = callback;
		}

		// Token: 0x0603885E RID: 231518 RVA: 0x00D6D1BA File Offset: 0x00D6B3BA
		[NullableContext(1)]
		public void SetOnLastShowTalkFinished(Action callback)
		{
			this.OnLastShowTalkFinishedCallback = callback;
		}

		// Token: 0x0603885F RID: 231519 RVA: 0x00D6D1C4 File Offset: 0x00D6B3C4
		public void SetNextButtonVisible(bool visible)
		{
			UUIButtonComponent button = base.GetButton(4);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x06038860 RID: 231520 RVA: 0x00D6D1F5 File Offset: 0x00D6B3F5
		public void Advance()
		{
			this.OnClickNext();
		}

		// Token: 0x06038861 RID: 231521 RVA: 0x00D6D200 File Offset: 0x00D6B400
		[NullableContext(1)]
		public void Initialize(IWriteLetterViewOpenParam openParam)
		{
			this.ApplyStyle(openParam.LetterStyle);
			this.TalkItems = this.GetTalkItems(openParam);
			this.DisplayedTalkItems.Clear();
			this.DisplayedTalkIdSet.Clear();
			this.CurrentTalkItem = null;
			this.CurrentContentItem = null;
			this.LastFinishedFired = false;
			GenericScrollViewNew<LetterContentItem, ITalkItem> letterScrollView = this.LetterScrollView;
			if (letterScrollView != null)
			{
				letterScrollView.RefreshByData(this.DisplayedTalkItems, null, false);
			}
			if (this.TalkItems.Count > 0)
			{
				this.AppendTalkItem(this.TalkItems[0]);
				return;
			}
			this.NotifyCurrentTalkChanged(null);
		}

		// Token: 0x06038862 RID: 231522 RVA: 0x00D6D294 File Offset: 0x00D6B494
		public bool RevealTalkById(int talkId)
		{
			ITalkItem talkItem2 = this.TalkItems.Find((ITalkItem talkItem) => talkItem.Id == talkId);
			if (talkItem2 == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[LetterPanel] JumpTalk目标不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TalkId", talkId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.AppendTalkItem(talkItem2);
			return true;
		}

		// Token: 0x06038863 RID: 231523 RVA: 0x00D6D304 File Offset: 0x00D6B504
		[NullableContext(1)]
		public void ShowReadOnly(IReadOnlyList<ITalkItem> items, ELetterStyle? letterStyle = null)
		{
			this.ClearHintRefreshTimer();
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			if (letterStyle != null)
			{
				this.ApplyStyle(letterStyle.Value);
			}
			this.TalkItems = items.ToList<ITalkItem>();
			this.DisplayedTalkItems.Clear();
			this.DisplayedTalkIdSet.Clear();
			this.LastShowTalkTalkIdSet.Clear();
			foreach (ITalkItem talkItem in items)
			{
				this.DisplayedTalkItems.Add(talkItem);
				this.DisplayedTalkIdSet.Add(talkItem.Id);
			}
			this.CurrentTalkItem = null;
			this.CurrentContentItem = null;
			GenericScrollViewNew<LetterContentItem, ITalkItem> letterScrollView = this.LetterScrollView;
			if (letterScrollView == null)
			{
				return;
			}
			letterScrollView.RefreshByData(this.DisplayedTalkItems, delegate
			{
				this.ForceCompleteAllContentItems();
			}, false);
		}

		// Token: 0x06038864 RID: 231524 RVA: 0x00D6D42C File Offset: 0x00D6B62C
		private void ForceCompleteAllContentItems()
		{
			GenericScrollViewNew<LetterContentItem, ITalkItem> letterScrollView = this.LetterScrollView;
			List<LetterContentItem> list = (letterScrollView != null) ? letterScrollView.GetScrollItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (LetterContentItem letterContentItem in list)
			{
				letterContentItem.ForceComplete();
			}
		}

		// Token: 0x06038865 RID: 231525 RVA: 0x00D6D490 File Offset: 0x00D6B690
		public ITalkItem GetCurrentTalkItem()
		{
			return this.CurrentTalkItem;
		}

		// Token: 0x06038866 RID: 231526 RVA: 0x00D6D498 File Offset: 0x00D6B698
		public bool IsLastShowTalkCompleted()
		{
			if (this.CurrentTalkItem == null)
			{
				return false;
			}
			List<ITalkOption> options = this.CurrentTalkItem.Options;
			return ((options != null) ? options.Count : 0) <= 0 && (this.HasFinishTalkAction(this.CurrentTalkItem) || this.GetNextTalkItemByActionOrOrder(this.CurrentTalkItem) == null);
		}

		// Token: 0x06038867 RID: 231527 RVA: 0x00D6D4EA File Offset: 0x00D6B6EA
		public bool IsAllShowTalkExhausted()
		{
			return this.IsLastShowTalkCompleted();
		}

		// Token: 0x06038868 RID: 231528 RVA: 0x00D6D4F4 File Offset: 0x00D6B6F4
		public void SkipToFinish()
		{
			int num = this.TalkItems.Count * 2 + 4;
			int num2 = 0;
			while (num2++ < num)
			{
				ITalkItem currentTalkItem = this.CurrentTalkItem;
				if (currentTalkItem == null)
				{
					break;
				}
				LetterContentItem currentContentItem = this.CurrentContentItem;
				if (currentContentItem != null)
				{
					currentContentItem.ForceComplete();
				}
				if (this.HasFinishTalkAction(currentTalkItem))
				{
					break;
				}
				List<ITalkOption> list = currentTalkItem.Options ?? new List<ITalkOption>();
				if (list.Count > 0)
				{
					List<ActionInfo> actions = list[0].Actions;
					ActionInfo actionInfo;
					if (actions == null)
					{
						actionInfo = null;
					}
					else
					{
						actionInfo = actions.Find((ActionInfo action) => action.Name == EAction.JumpTalk);
					}
					ActionInfo actionInfo2 = actionInfo;
					if (actionInfo2 == null)
					{
						break;
					}
					JumpTalk jumpTalk = actionInfo2.Params as JumpTalk;
					if (!this.RevealTalkById(jumpTalk.TalkId))
					{
						break;
					}
				}
				else
				{
					ITalkItem nextTalkItemByActionOrOrder = this.GetNextTalkItemByActionOrOrder(currentTalkItem);
					if (nextTalkItemByActionOrOrder == null)
					{
						break;
					}
					this.AppendTalkItem(nextTalkItemByActionOrOrder);
				}
			}
			LetterContentItem currentContentItem2 = this.CurrentContentItem;
			if (currentContentItem2 == null)
			{
				return;
			}
			currentContentItem2.ForceComplete();
		}

		// Token: 0x06038869 RID: 231529 RVA: 0x00D6D5E7 File Offset: 0x00D6B7E7
		private void ApplyStyle(ELetterStyle letterStyle)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(letterStyle == ELetterStyle.A);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(letterStyle == ELetterStyle.B);
		}

		// Token: 0x0603886A RID: 231530 RVA: 0x00D6D614 File Offset: 0x00D6B814
		[NullableContext(1)]
		private List<ITalkItem> GetTalkItems(IWriteLetterViewOpenParam openParam)
		{
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(openParam.FlowListName, openParam.FlowId, openParam.StateId);
			this.LastShowTalkTalkIdSet.Clear();
			if (flowStateActions == null)
			{
				return new List<ITalkItem>();
			}
			ShowTalk showTalk = null;
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					showTalk = (actionInfo.Params as ShowTalk);
				}
			}
			if (showTalk == null)
			{
				return new List<ITalkItem>();
			}
			List<ITalkItem> list = showTalk.TalkItems ?? new List<ITalkItem>();
			foreach (ITalkItem talkItem in list)
			{
				this.LastShowTalkTalkIdSet.Add(talkItem.Id);
			}
			return list;
		}

		// Token: 0x0603886B RID: 231531 RVA: 0x00D6D70C File Offset: 0x00D6B90C
		[NullableContext(1)]
		private void AppendTalkItem(ITalkItem talkItem)
		{
			if (this.LetterScrollView == null)
			{
				return;
			}
			this.CurrentTalkItem = talkItem;
			this.CurrentContentItem = null;
			this.NotifyCurrentTalkChanged(talkItem);
			this.RefreshNextHints();
			if (!this.DisplayedTalkIdSet.Contains(talkItem.Id))
			{
				this.DisplayedTalkItems.Add(talkItem);
				this.DisplayedTalkIdSet.Add(talkItem.Id);
				this.LetterScrollView.RefreshByData(this.DisplayedTalkItems, delegate
				{
					this.TryFocusCurrentTalkItem(talkItem.Id);
				}, false);
				return;
			}
			this.TryFocusCurrentTalkItem(talkItem.Id);
		}

		// Token: 0x0603886C RID: 231532 RVA: 0x00D6D7CC File Offset: 0x00D6B9CC
		private void TryFocusCurrentTalkItem(int talkId)
		{
			if (this.LetterScrollView != null)
			{
				ITalkItem currentTalkItem = this.CurrentTalkItem;
				if (currentTalkItem != null && currentTalkItem.Id == talkId)
				{
					this.CurrentContentItem = this.LetterScrollView.GetScrollItemByKey(talkId);
					this.BindLastFinishedIfNeeded();
					this.RefreshNextHints();
					UUIItem itemByKey = this.LetterScrollView.GetItemByKey(talkId);
					if (itemByKey != null)
					{
						this.LetterScrollView.LateScrollTo(itemByKey, null, false);
					}
					return;
				}
			}
		}

		// Token: 0x0603886D RID: 231533 RVA: 0x00D6D844 File Offset: 0x00D6BA44
		private unsafe void BindLastFinishedIfNeeded()
		{
			if (this.LastFinishedFired)
			{
				return;
			}
			if (!this.IsLastShowTalkCompleted())
			{
				return;
			}
			LetterContentItem contentItem = this.CurrentContentItem;
			if (contentItem == null)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[WL-Finish] Panel.BindLastFinishedIfNeeded 末句注册";
			string item = "TalkId";
			ITalkItem currentTalkItem = this.CurrentTalkItem;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentTalkItem != null) ? new int?(currentTalkItem.Id) : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			contentItem.SetOnFinished(delegate
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "[WL-Finish] Panel SetOnFinished callback fired";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AlreadyFired", this.LastFinishedFired);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ContentItemMatch", this.CurrentContentItem == contentItem);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				if (this.LastFinishedFired)
				{
					return;
				}
				if (this.CurrentContentItem != contentItem)
				{
					return;
				}
				this.LastFinishedFired = true;
				Action onLastShowTalkFinishedCallback = this.OnLastShowTalkFinishedCallback;
				if (onLastShowTalkFinishedCallback == null)
				{
					return;
				}
				onLastShowTalkFinishedCallback();
			});
		}

		// Token: 0x0603886E RID: 231534 RVA: 0x00D6D8E8 File Offset: 0x00D6BAE8
		private void TryFireLastFinished()
		{
			if (this.LastFinishedFired)
			{
				return;
			}
			if (!this.IsLastShowTalkCompleted())
			{
				return;
			}
			LetterContentItem currentContentItem = this.CurrentContentItem;
			if (currentContentItem == null || !currentContentItem.IsFinished())
			{
				return;
			}
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "[WL-Finish] Panel.TryFireLastFinished 末句兜底触发", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.LastFinishedFired = true;
			Action onLastShowTalkFinishedCallback = this.OnLastShowTalkFinishedCallback;
			if (onLastShowTalkFinishedCallback == null)
			{
				return;
			}
			onLastShowTalkFinishedCallback();
		}

		// Token: 0x0603886F RID: 231535 RVA: 0x00D6D951 File Offset: 0x00D6BB51
		private void NotifyCurrentTalkChanged(ITalkItem talkItem)
		{
			Action<ITalkItem> onCurrentTalkChangedCallback = this.OnCurrentTalkChangedCallback;
			if (onCurrentTalkChangedCallback == null)
			{
				return;
			}
			onCurrentTalkChangedCallback(talkItem);
		}

		// Token: 0x06038870 RID: 231536 RVA: 0x00D6D964 File Offset: 0x00D6BB64
		[NullableContext(1)]
		private LetterContentItem CreateLetterContentItem()
		{
			return new LetterContentItem();
		}

		// Token: 0x06038871 RID: 231537 RVA: 0x00D6D96C File Offset: 0x00D6BB6C
		private void BindNextDragEvents()
		{
			UUIButtonComponent button = base.GetButton(4);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
			AActor aactor;
			if (tweakObjectPtr == null)
			{
				aactor = null;
			}
			else
			{
				UUIItem uuiitem = tweakObjectPtr.GetValueOrDefault().Get();
				aactor = ((uuiitem != null) ? uuiitem.GetOwner() : null);
			}
			AActor aactor2 = aactor;
			this.NextButtonDragComponent = (((aactor2 != null) ? aactor2.GetComponentByClass(UUIDraggableComponent.StaticClass()) : null) as UUIDraggableComponent);
			if (this.NextButtonDragComponent == null)
			{
				return;
			}
			this.NextButtonDragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnNextBeginDrag));
			this.NextButtonDragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnNextDrag));
			this.NextButtonDragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnNextEndDrag));
		}

		// Token: 0x06038872 RID: 231538 RVA: 0x00D6DA40 File Offset: 0x00D6BC40
		private void UnbindNextDragEvents()
		{
			if (this.NextButtonDragComponent == null)
			{
				return;
			}
			this.NextButtonDragComponent.OnPointerBeginDragCallBack.Unbind();
			this.NextButtonDragComponent.OnPointerDragCallBack.Unbind();
			this.NextButtonDragComponent.OnPointerEndDragCallBack.Unbind();
			this.NextButtonDragComponent = null;
		}

		// Token: 0x06038873 RID: 231539 RVA: 0x00D6DA90 File Offset: 0x00D6BC90
		private void RefreshNextHints()
		{
			this.ClearHintRefreshTimer();
			ITalkItem currentTalkItem = this.CurrentTalkItem;
			int? num;
			if (currentTalkItem == null)
			{
				num = null;
			}
			else
			{
				List<ITalkOption> options = currentTalkItem.Options;
				num = ((options != null) ? new int?(options.Count) : null);
			}
			int? num2 = num;
			if (num2.GetValueOrDefault() > 0)
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				if (!this.IsLastShowTalkCompleted())
				{
					LetterContentItem currentContentItem = this.CurrentContentItem;
					bool flag = currentContentItem != null && currentContentItem.IsInProtectTime();
					UUIItem item3 = base.GetItem(6);
					if (item3 != null)
					{
						item3.SetUIActive(!flag);
					}
					UUIItem item4 = base.GetItem(5);
					if (item4 != null)
					{
						item4.SetUIActive(flag);
					}
					if (flag)
					{
						LetterContentItem currentContentItem2 = this.CurrentContentItem;
						long num3 = (currentContentItem2 != null) ? currentContentItem2.GetProtectRemainingMs() : 0L;
						if (num3 > 0L)
						{
							long num4 = Math.Min(180000L, Math.Max(20L, num3));
							this.HintRefreshTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
							{
								this.HintRefreshTimer = null;
								this.RefreshNextHints();
							}, (float)num4, null, null, true, 1f);
						}
					}
					return;
				}
				UUIItem item5 = base.GetItem(6);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUIItem item6 = base.GetItem(5);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06038874 RID: 231540 RVA: 0x00D6DBCC File Offset: 0x00D6BDCC
		private void OnClickNext()
		{
			if (this.IsDraggingOnNextButton)
			{
				this.IsDraggingOnNextButton = false;
				return;
			}
			LetterContentItem currentContentItem = this.CurrentContentItem;
			if (currentContentItem != null && currentContentItem.IsInProtectTime())
			{
				this.RefreshNextHints();
				return;
			}
			ITalkItem currentTalkItem = this.CurrentTalkItem;
			int? num;
			if (currentTalkItem == null)
			{
				num = null;
			}
			else
			{
				List<ITalkOption> options = currentTalkItem.Options;
				num = ((options != null) ? new int?(options.Count) : null);
			}
			int? num2 = num;
			if (num2.GetValueOrDefault() > 0)
			{
				this.NotifyCurrentTalkChanged(this.CurrentTalkItem);
				this.RefreshNextHints();
				return;
			}
			ITalkItem nextTalkItemByActionOrOrder = this.GetNextTalkItemByActionOrOrder(this.CurrentTalkItem);
			if (nextTalkItemByActionOrOrder != null)
			{
				LetterContentItem currentContentItem2 = this.CurrentContentItem;
				if (currentContentItem2 != null)
				{
					currentContentItem2.ForceComplete();
				}
				this.AppendTalkItem(nextTalkItemByActionOrOrder);
				return;
			}
			LetterContentItem currentContentItem3 = this.CurrentContentItem;
			if (currentContentItem3 != null)
			{
				currentContentItem3.ForceComplete();
			}
			this.TryFireLastFinished();
			this.RefreshNextHints();
		}

		// Token: 0x06038875 RID: 231541 RVA: 0x00D6DC9B File Offset: 0x00D6BE9B
		private void OnNextBeginDrag(ULGUIPointerEventData eventData)
		{
			this.IsDraggingOnNextButton = false;
		}

		// Token: 0x06038876 RID: 231542 RVA: 0x00D6DCA4 File Offset: 0x00D6BEA4
		private void OnNextDrag(ULGUIPointerEventData eventData)
		{
			this.IsDraggingOnNextButton = true;
		}

		// Token: 0x06038877 RID: 231543 RVA: 0x00D6DCAD File Offset: 0x00D6BEAD
		private void OnNextEndDrag(ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x06038878 RID: 231544 RVA: 0x00D6DCAF File Offset: 0x00D6BEAF
		private void ClearHintRefreshTimer()
		{
			if (this.HintRefreshTimer == null)
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Remove(this.HintRefreshTimer);
			this.HintRefreshTimer = null;
		}

		// Token: 0x06038879 RID: 231545 RVA: 0x00D6DCD4 File Offset: 0x00D6BED4
		private ITalkItem GetNextTalkItem(ITalkItem currentTalkItem)
		{
			if (currentTalkItem == null)
			{
				if (this.TalkItems.Count <= 0)
				{
					return null;
				}
				return this.TalkItems[0];
			}
			else
			{
				int num = this.TalkItems.FindIndex((ITalkItem talkItem) => talkItem.Id == currentTalkItem.Id);
				if (num < 0 || num >= this.TalkItems.Count - 1)
				{
					return null;
				}
				return this.TalkItems[num + 1];
			}
		}

		// Token: 0x0603887A RID: 231546 RVA: 0x00D6DD50 File Offset: 0x00D6BF50
		private ITalkItem GetNextTalkItemByActionOrOrder(ITalkItem currentTalkItem)
		{
			if (currentTalkItem == null)
			{
				return null;
			}
			if (this.HasFinishTalkAction(currentTalkItem))
			{
				return null;
			}
			List<ActionInfo> actions = currentTalkItem.Actions;
			ActionInfo actionInfo;
			if (actions == null)
			{
				actionInfo = null;
			}
			else
			{
				actionInfo = actions.Find((ActionInfo action) => action.Name == EAction.JumpTalk);
			}
			ActionInfo actionInfo2 = actionInfo;
			if (actionInfo2 == null)
			{
				return this.GetNextTalkItem(currentTalkItem);
			}
			JumpTalk jumpTalk = actionInfo2.Params as JumpTalk;
			ITalkItem talkItem2 = this.TalkItems.Find((ITalkItem talkItem) => talkItem.Id == jumpTalk.TalkId);
			if (talkItem2 != null)
			{
				return talkItem2;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[LetterPanel] JumpTalk目标不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TalkId", jumpTalk.TalkId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x0603887B RID: 231547 RVA: 0x00D6DE14 File Offset: 0x00D6C014
		private bool HasFinishTalkAction(ITalkItem talkItem)
		{
			if (talkItem == null)
			{
				return false;
			}
			List<ActionInfo> actions = talkItem.Actions;
			bool? flag;
			if (actions == null)
			{
				flag = null;
			}
			else
			{
				flag = new bool?(actions.Any((ActionInfo action) => action.Name == EAction.FinishTalk));
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}

		// Token: 0x0401DB0B RID: 121611
		[Nullable(1)]
		private List<ITalkItem> TalkItems = new List<ITalkItem>();

		// Token: 0x0401DB0C RID: 121612
		[Nullable(1)]
		private readonly HashSet<int> LastShowTalkTalkIdSet = new HashSet<int>();

		// Token: 0x0401DB0D RID: 121613
		[Nullable(1)]
		private readonly List<ITalkItem> DisplayedTalkItems = new List<ITalkItem>();

		// Token: 0x0401DB0E RID: 121614
		[Nullable(1)]
		private readonly HashSet<int> DisplayedTalkIdSet = new HashSet<int>();

		// Token: 0x0401DB0F RID: 121615
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<LetterContentItem, ITalkItem> LetterScrollView;

		// Token: 0x0401DB10 RID: 121616
		private ITalkItem CurrentTalkItem;

		// Token: 0x0401DB11 RID: 121617
		private LetterContentItem CurrentContentItem;

		// Token: 0x0401DB12 RID: 121618
		private TimerHandle HintRefreshTimer;

		// Token: 0x0401DB13 RID: 121619
		private UUIDraggableComponent NextButtonDragComponent;

		// Token: 0x0401DB14 RID: 121620
		private bool IsDraggingOnNextButton;

		// Token: 0x0401DB15 RID: 121621
		private Action<ITalkItem> OnCurrentTalkChangedCallback;

		// Token: 0x0401DB16 RID: 121622
		private Action OnLastShowTalkFinishedCallback;

		// Token: 0x0401DB17 RID: 121623
		private bool LastFinishedFired;

		// Token: 0x0200B8A8 RID: 47272
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037E04 RID: 228868
			SvLetterContent,
			// Token: 0x04037E05 RID: 228869
			TxtLetterContent,
			// Token: 0x04037E06 RID: 228870
			ItemLetterDecorationA,
			// Token: 0x04037E07 RID: 228871
			ItemLetterDecorationB,
			// Token: 0x04037E08 RID: 228872
			BtnNext,
			// Token: 0x04037E09 RID: 228873
			TxtTypingHint,
			// Token: 0x04037E0A RID: 228874
			TxtNextHint
		}
	}
}
