using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020046A6 RID: 18086
	[NullableContext(2)]
	[Nullable(0)]
	public class LetterPanel : UiPanelBase
	{
		// Token: 0x0602D76A RID: 186218 RVA: 0x00CBB570 File Offset: 0x00CB9770
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

		// Token: 0x0602D76B RID: 186219 RVA: 0x00CBB6BC File Offset: 0x00CB98BC
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

		// Token: 0x0602D76C RID: 186220 RVA: 0x00CBB72C File Offset: 0x00CB992C
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

		// Token: 0x0602D76D RID: 186221 RVA: 0x00CBB769 File Offset: 0x00CB9969
		public void SetOnCurrentTalkChanged([Nullable(new byte[]
		{
			1,
			2
		})] Action<ITalkItem> callback)
		{
			this.OnCurrentTalkChangedCallback = callback;
		}

		// Token: 0x0602D76E RID: 186222 RVA: 0x00CBB772 File Offset: 0x00CB9972
		[NullableContext(1)]
		public void SetOnLastShowTalkFinished(Action callback)
		{
			this.OnLastShowTalkFinishedCallback = callback;
		}

		// Token: 0x0602D76F RID: 186223 RVA: 0x00CBB77C File Offset: 0x00CB997C
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

		// Token: 0x0602D770 RID: 186224 RVA: 0x00CBB7AD File Offset: 0x00CB99AD
		public void Advance()
		{
			this.OnClickNext();
		}

		// Token: 0x0602D771 RID: 186225 RVA: 0x00CBB7B8 File Offset: 0x00CB99B8
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

		// Token: 0x0602D772 RID: 186226 RVA: 0x00CBB84C File Offset: 0x00CB9A4C
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

		// Token: 0x0602D773 RID: 186227 RVA: 0x00CBB8BC File Offset: 0x00CB9ABC
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
			this.TalkItems = new List<ITalkItem>(items);
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

		// Token: 0x0602D774 RID: 186228 RVA: 0x00CBB9E4 File Offset: 0x00CB9BE4
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

		// Token: 0x0602D775 RID: 186229 RVA: 0x00CBBA48 File Offset: 0x00CB9C48
		public ITalkItem GetCurrentTalkItem()
		{
			return this.CurrentTalkItem;
		}

		// Token: 0x0602D776 RID: 186230 RVA: 0x00CBBA50 File Offset: 0x00CB9C50
		public bool IsLastShowTalkCompleted()
		{
			if (this.CurrentTalkItem == null)
			{
				return false;
			}
			List<ITalkOption> options = this.CurrentTalkItem.Options;
			return ((options != null) ? options.Count : 0) <= 0 && (this.HasFinishTalkAction(this.CurrentTalkItem) || this.GetNextTalkItemByActionOrOrder(this.CurrentTalkItem) == null);
		}

		// Token: 0x0602D777 RID: 186231 RVA: 0x00CBBAA2 File Offset: 0x00CB9CA2
		public bool IsAllShowTalkExhausted()
		{
			return this.IsLastShowTalkCompleted();
		}

		// Token: 0x0602D778 RID: 186232 RVA: 0x00CBBAAC File Offset: 0x00CB9CAC
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

		// Token: 0x0602D779 RID: 186233 RVA: 0x00CBBB9F File Offset: 0x00CB9D9F
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

		// Token: 0x0602D77A RID: 186234 RVA: 0x00CBBBCC File Offset: 0x00CB9DCC
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

		// Token: 0x0602D77B RID: 186235 RVA: 0x00CBBCC4 File Offset: 0x00CB9EC4
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

		// Token: 0x0602D77C RID: 186236 RVA: 0x00CBBD84 File Offset: 0x00CB9F84
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

		// Token: 0x0602D77D RID: 186237 RVA: 0x00CBBDFC File Offset: 0x00CB9FFC
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

		// Token: 0x0602D77E RID: 186238 RVA: 0x00CBBEA0 File Offset: 0x00CBA0A0
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

		// Token: 0x0602D77F RID: 186239 RVA: 0x00CBBF09 File Offset: 0x00CBA109
		private void NotifyCurrentTalkChanged(ITalkItem talkItem)
		{
			Action<ITalkItem> onCurrentTalkChangedCallback = this.OnCurrentTalkChangedCallback;
			if (onCurrentTalkChangedCallback == null)
			{
				return;
			}
			onCurrentTalkChangedCallback(talkItem);
		}

		// Token: 0x0602D780 RID: 186240 RVA: 0x00CBBF1C File Offset: 0x00CBA11C
		[NullableContext(1)]
		private LetterContentItem CreateLetterContentItem()
		{
			return new LetterContentItem();
		}

		// Token: 0x0602D781 RID: 186241 RVA: 0x00CBBF24 File Offset: 0x00CBA124
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

		// Token: 0x0602D782 RID: 186242 RVA: 0x00CBBFF8 File Offset: 0x00CBA1F8
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

		// Token: 0x0602D783 RID: 186243 RVA: 0x00CBC048 File Offset: 0x00CBA248
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

		// Token: 0x0602D784 RID: 186244 RVA: 0x00CBC184 File Offset: 0x00CBA384
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

		// Token: 0x0602D785 RID: 186245 RVA: 0x00CBC253 File Offset: 0x00CBA453
		private void OnNextBeginDrag(ULGUIPointerEventData eventData)
		{
			this.IsDraggingOnNextButton = false;
		}

		// Token: 0x0602D786 RID: 186246 RVA: 0x00CBC25C File Offset: 0x00CBA45C
		private void OnNextDrag(ULGUIPointerEventData eventData)
		{
			this.IsDraggingOnNextButton = true;
		}

		// Token: 0x0602D787 RID: 186247 RVA: 0x00CBC265 File Offset: 0x00CBA465
		private void OnNextEndDrag(ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x0602D788 RID: 186248 RVA: 0x00CBC267 File Offset: 0x00CBA467
		private void ClearHintRefreshTimer()
		{
			if (this.HintRefreshTimer == null)
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Remove(this.HintRefreshTimer);
			this.HintRefreshTimer = null;
		}

		// Token: 0x0602D789 RID: 186249 RVA: 0x00CBC28C File Offset: 0x00CBA48C
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

		// Token: 0x0602D78A RID: 186250 RVA: 0x00CBC308 File Offset: 0x00CBA508
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

		// Token: 0x0602D78B RID: 186251 RVA: 0x00CBC3CC File Offset: 0x00CBA5CC
		private bool HasFinishTalkAction(ITalkItem talkItem)
		{
			List<ActionInfo> list = (talkItem != null) ? talkItem.Actions : null;
			if (list == null)
			{
				return false;
			}
			using (List<ActionInfo>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Name == EAction.FinishTalk)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040185A1 RID: 99745
		[Nullable(1)]
		private List<ITalkItem> TalkItems = new List<ITalkItem>();

		// Token: 0x040185A2 RID: 99746
		[Nullable(1)]
		private readonly HashSet<int> LastShowTalkTalkIdSet = new HashSet<int>();

		// Token: 0x040185A3 RID: 99747
		[Nullable(1)]
		private readonly List<ITalkItem> DisplayedTalkItems = new List<ITalkItem>();

		// Token: 0x040185A4 RID: 99748
		[Nullable(1)]
		private readonly HashSet<int> DisplayedTalkIdSet = new HashSet<int>();

		// Token: 0x040185A5 RID: 99749
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<LetterContentItem, ITalkItem> LetterScrollView;

		// Token: 0x040185A6 RID: 99750
		private ITalkItem CurrentTalkItem;

		// Token: 0x040185A7 RID: 99751
		private LetterContentItem CurrentContentItem;

		// Token: 0x040185A8 RID: 99752
		private TimerHandle HintRefreshTimer;

		// Token: 0x040185A9 RID: 99753
		private UUIDraggableComponent NextButtonDragComponent;

		// Token: 0x040185AA RID: 99754
		private bool IsDraggingOnNextButton;

		// Token: 0x040185AB RID: 99755
		private Action<ITalkItem> OnCurrentTalkChangedCallback;

		// Token: 0x040185AC RID: 99756
		private Action OnLastShowTalkFinishedCallback;

		// Token: 0x040185AD RID: 99757
		private bool LastFinishedFired;

		// Token: 0x0200A2CF RID: 41679
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403281E RID: 206878
			SvLetterContent,
			// Token: 0x0403281F RID: 206879
			TxtLetterContent,
			// Token: 0x04032820 RID: 206880
			ItemLetterDecorationA,
			// Token: 0x04032821 RID: 206881
			ItemLetterDecorationB,
			// Token: 0x04032822 RID: 206882
			BtnNext,
			// Token: 0x04032823 RID: 206883
			TxtTypingHint,
			// Token: 0x04032824 RID: 206884
			TxtNextHint
		}
	}
}
