using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FE5 RID: 20453
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorQuestView : UiTickViewBase
	{
		// Token: 0x06033382 RID: 209794 RVA: 0x00E5AE41 File Offset: 0x00E59041
		[NullableContext(1)]
		public SpringManorQuestView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033383 RID: 209795 RVA: 0x00E5AE4C File Offset: 0x00E5904C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUILayoutBase));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033384 RID: 209796 RVA: 0x00E5B114 File Offset: 0x00E59314
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorQuestView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorQuestView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033385 RID: 209797 RVA: 0x00E5B158 File Offset: 0x00E59358
		protected override void OnStart()
		{
			this.InitCaption();
			this.RewardPreviewScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(10), () => new CommonItemSmallItemGrid(), null, false, null);
			FunctionalPanelConditionLock warningTipsItem = this.WarningTipsItem;
			if (warningTipsItem != null)
			{
				warningTipsItem.SetButtonVisible(false);
			}
			this.MainQuestLayout = new GenericLayout<SpringManorQuestItem, int>(base.GetLayoutBase(19), new Func<SpringManorQuestItem>(this.CreateMainQuestItem), null, false, true);
			this.SubQuestLayout = new GenericLayout<SpringManorQuestItem, int>(base.GetLayoutBase(4), new Func<SpringManorQuestItem>(this.CreateSubQuestItem), null, false, true);
			int? num = this.OpenParam as int?;
			if (num != null && num.Value != 0)
			{
				this.CurrentSelectQuestId = num.Value;
			}
		}

		// Token: 0x06033386 RID: 209798 RVA: 0x00E5B228 File Offset: 0x00E59428
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			SpringManorQuestView.<OnBeforeShowAsyncImplementImplement>d__15 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<SpringManorQuestView.<OnBeforeShowAsyncImplementImplement>d__15>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06033387 RID: 209799 RVA: 0x00E5B26C File Offset: 0x00E5946C
		private UniTask RefreshQuestScroll(bool playScrollAnim = true)
		{
			SpringManorQuestView.<RefreshQuestScroll>d__16 <RefreshQuestScroll>d__;
			<RefreshQuestScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshQuestScroll>d__.<>4__this = this;
			<RefreshQuestScroll>d__.playScrollAnim = playScrollAnim;
			<RefreshQuestScroll>d__.<>1__state = -1;
			<RefreshQuestScroll>d__.<>t__builder.Start<SpringManorQuestView.<RefreshQuestScroll>d__16>(ref <RefreshQuestScroll>d__);
			return <RefreshQuestScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06033388 RID: 209800 RVA: 0x00E5B2B8 File Offset: 0x00E594B8
		protected override void OnTick(float delta)
		{
			if (this.TickTimer > 0.0)
			{
				this.TickTimer -= (double)delta;
				return;
			}
			this.TickTimer = 1000.0;
			FunctionalPanelConditionLock warningTipsItem = this.WarningTipsItem;
			if (warningTipsItem != null && warningTipsItem.IsUiActiveInHierarchy())
			{
				this.RefreshWarningTipsText();
			}
		}

		// Token: 0x06033389 RID: 209801 RVA: 0x00E5B30F File Offset: 0x00E5950F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnLogicTreeTrackUpdate));
			EventSystem.Instance.Add(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603338A RID: 209802 RVA: 0x00E5B349 File Offset: 0x00E59549
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnLogicTreeTrackUpdate));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603338B RID: 209803 RVA: 0x00E5B383 File Offset: 0x00E59583
		private void RefreshView()
		{
			this.RefreshQuestScroll(false);
		}

		// Token: 0x0603338C RID: 209804 RVA: 0x00E5B390 File Offset: 0x00E59590
		private void InitCaption()
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetCloseCallBack(new Action(this.OnClickClose));
			}
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 == null)
			{
				return;
			}
			captionItem2.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(515);
			});
		}

		// Token: 0x0603338D RID: 209805 RVA: 0x00E5B3EC File Offset: 0x00E595EC
		private void RefreshEmpty()
		{
			bool flag = SpringManorModel.Instance.HasAnyQuest();
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(2).SetUIActive(flag);
		}

		// Token: 0x0603338E RID: 209806 RVA: 0x00E5B421 File Offset: 0x00E59621
		[NullableContext(1)]
		private SpringManorQuestItem CreateMainQuestItem()
		{
			return new SpringManorQuestItem
			{
				ToggleClickCallback = new Action<int, int>(this.OnClickMainQuestToggle)
			};
		}

		// Token: 0x0603338F RID: 209807 RVA: 0x00E5B43A File Offset: 0x00E5963A
		[NullableContext(1)]
		private SpringManorQuestItem CreateSubQuestItem()
		{
			return new SpringManorQuestItem
			{
				ToggleClickCallback = new Action<int, int>(this.OnClickSubQuestToggle)
			};
		}

		// Token: 0x06033390 RID: 209808 RVA: 0x00E5B453 File Offset: 0x00E59653
		private void OnClickMainQuestToggle(int gridIndex, int questId)
		{
			GenericLayout<SpringManorQuestItem, int> mainQuestLayout = this.MainQuestLayout;
			if (mainQuestLayout != null)
			{
				mainQuestLayout.SelectGridProxy(gridIndex, false);
			}
			GenericLayout<SpringManorQuestItem, int> subQuestLayout = this.SubQuestLayout;
			if (subQuestLayout != null)
			{
				subQuestLayout.DeselectCurrentGridProxy();
			}
			this.UpdateQuestDetails(questId, true);
		}

		// Token: 0x06033391 RID: 209809 RVA: 0x00E5B481 File Offset: 0x00E59681
		private void OnClickSubQuestToggle(int gridIndex, int questId)
		{
			GenericLayout<SpringManorQuestItem, int> subQuestLayout = this.SubQuestLayout;
			if (subQuestLayout != null)
			{
				subQuestLayout.SelectGridProxy(gridIndex, false);
			}
			GenericLayout<SpringManorQuestItem, int> mainQuestLayout = this.MainQuestLayout;
			if (mainQuestLayout != null)
			{
				mainQuestLayout.DeselectCurrentGridProxy();
			}
			this.UpdateQuestDetails(questId, true);
		}

		// Token: 0x06033392 RID: 209810 RVA: 0x00E5B4B0 File Offset: 0x00E596B0
		private void UpdateQuestDetails(int questId, bool playAnim = false)
		{
			this.CurrentSelectQuestId = questId;
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance != null)
			{
				instance.ActivityData.ReadSubQuestRedDot(questId);
			}
			if (playAnim)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
				}
			}
			QuestNewModel instance2 = QuestNewModel.Instance;
			if (instance2.GetQuest(questId) == null)
			{
				this.RefreshLockState();
				return;
			}
			base.GetText(6).SetText(instance2.GetQuestName(questId), true);
			base.GetText(9).SetText(instance2.GetQuestDetails(questId), true);
			this.UpdateQuestSteps(questId);
			this.RefreshRewardPreview(questId);
			this.UpdateQuestState(questId);
			this.RefreshBottomByQuestState();
		}

		// Token: 0x06033393 RID: 209811 RVA: 0x00E5B558 File Offset: 0x00E59758
		private void RefreshLockState()
		{
			IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(this.CurrentSelectQuestId);
			base.GetText(6).ShowTextNew(questConfig.TidName);
			base.GetText(9).ShowTextNew(questConfig.TidDesc);
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(10);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(questConfig.RewardId != null);
			}
			if (questConfig.RewardId != null)
			{
				List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(questConfig.RewardId.Value);
				GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardPreviewScroll = this.RewardPreviewScroll;
				if (rewardPreviewScroll != null)
				{
					rewardPreviewScroll.RefreshByData(dropPackagePreviewItemList, null, false);
				}
			}
			UUIItem item2 = base.GetItem(17);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			FunctionalPanelConditionLock warningTipsItem = this.WarningTipsItem;
			if (warningTipsItem != null)
			{
				warningTipsItem.SetUiActive(true);
			}
			this.RefreshWarningTipsText();
		}

		// Token: 0x06033394 RID: 209812 RVA: 0x00E5B648 File Offset: 0x00E59848
		private void RefreshWarningTipsText()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance.IsMainQuest(this.CurrentSelectQuestId))
			{
				string mainQuestRemainTimeText = instance.GetMainQuestRemainTimeText(this.CurrentSelectQuestId, "Spring26_Quest_TimeLimit");
				FunctionalPanelConditionLock warningTipsItem = this.WarningTipsItem;
				if (warningTipsItem == null)
				{
					return;
				}
				warningTipsItem.SetTextByText(mainQuestRemainTimeText);
			}
		}

		// Token: 0x06033395 RID: 209813 RVA: 0x00E5B68C File Offset: 0x00E5988C
		private void UpdateQuestState(int questId)
		{
			if (!SpringManorModel.Instance.IsQuestUnlocked(questId))
			{
				this.CurrentSpringManorQuestState = ESpringManorQuestState.Lock;
				return;
			}
			if (SpringManorModel.Instance.IsCurrentTrackQuest(questId))
			{
				this.CurrentSpringManorQuestState = ESpringManorQuestState.Track;
				return;
			}
			this.CurrentSpringManorQuestState = ESpringManorQuestState.UnTrack;
		}

		// Token: 0x06033396 RID: 209814 RVA: 0x00E5B6C4 File Offset: 0x00E598C4
		private void RefreshBottomByQuestState()
		{
			ButtonItem buttonRight = this.ButtonRight;
			if (buttonRight != null)
			{
				buttonRight.SetUiActive(true);
			}
			SpringManorModel instance = SpringManorModel.Instance;
			bool? flag = (instance != null) ? new bool?(instance.IsMainQuest(this.CurrentSelectQuestId)) : null;
			ButtonItem buttonLeft = this.ButtonLeft;
			if (buttonLeft != null)
			{
				buttonLeft.SetUiActive(this.CurrentSpringManorQuestState == ESpringManorQuestState.Track && !flag.GetValueOrDefault());
			}
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetUIActive(this.CurrentSpringManorQuestState > ESpringManorQuestState.Lock);
			}
			FunctionalPanelConditionLock warningTipsItem = this.WarningTipsItem;
			if (warningTipsItem != null)
			{
				warningTipsItem.SetUiActive(this.CurrentSpringManorQuestState == ESpringManorQuestState.Lock);
			}
			if (this.CurrentSpringManorQuestState != ESpringManorQuestState.UnTrack)
			{
				if (this.CurrentSpringManorQuestState == ESpringManorQuestState.Track)
				{
					ButtonItem buttonRight2 = this.ButtonRight;
					if (buttonRight2 != null)
					{
						buttonRight2.SetLocalTextNew("Spring26_Quest_Skip", Array.Empty<object>());
					}
					ButtonItem buttonLeft2 = this.ButtonLeft;
					if (buttonLeft2 == null)
					{
						return;
					}
					buttonLeft2.SetLocalTextNew("Spring26_Quest_UnTrack", Array.Empty<object>());
				}
				return;
			}
			ButtonItem buttonRight3 = this.ButtonRight;
			if (buttonRight3 == null)
			{
				return;
			}
			buttonRight3.SetLocalTextNew("Spring26_Quest_Track", Array.Empty<object>());
		}

		// Token: 0x06033397 RID: 209815 RVA: 0x00E5B7C8 File Offset: 0x00E599C8
		private UniTask UpdateQuestSteps(int questId)
		{
			SpringManorQuestView.<UpdateQuestSteps>d__32 <UpdateQuestSteps>d__;
			<UpdateQuestSteps>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateQuestSteps>d__.<>4__this = this;
			<UpdateQuestSteps>d__.questId = questId;
			<UpdateQuestSteps>d__.<>1__state = -1;
			<UpdateQuestSteps>d__.<>t__builder.Start<SpringManorQuestView.<UpdateQuestSteps>d__32>(ref <UpdateQuestSteps>d__);
			return <UpdateQuestSteps>d__.<>t__builder.Task;
		}

		// Token: 0x06033398 RID: 209816 RVA: 0x00E5B814 File Offset: 0x00E59A14
		private void RefreshRewardPreview(int questId)
		{
			List<TItem> list = QuestNewModel.Instance.GetDisplayRewardCommonInfo(questId);
			if (list == null)
			{
				IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(questId);
				int? num = (questConfig != null) ? questConfig.RewardId : null;
				if (num == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SpringManor;
					ELogAuthor author = ELogAuthor.LJ;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("任务");
					defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
					defaultInterpolatedStringHandler.AppendLiteral("配置无效");
					instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				RewardConfig instance2 = RewardConfig.Instance;
				list = ((instance2 != null) ? instance2.GetDropPackagePreviewItemList(num.Value) : null);
			}
			if (list == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SpringManor;
				ELogAuthor author2 = ELogAuthor.LJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("任务");
				defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
				defaultInterpolatedStringHandler.AppendLiteral("没有任何奖励信息");
				instance3.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardPreviewScroll = this.RewardPreviewScroll;
			if (rewardPreviewScroll == null)
			{
				return;
			}
			rewardPreviewScroll.RefreshByData(list, null, false);
		}

		// Token: 0x06033399 RID: 209817 RVA: 0x00E5B924 File Offset: 0x00E59B24
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603339A RID: 209818 RVA: 0x00E5B92D File Offset: 0x00E59B2D
		private void OnClickLeft(int __)
		{
			SpringManorController.Instance.RequestTrackQuest(this.CurrentSelectQuestId, false);
			this.RefreshQuestScroll(false);
		}

		// Token: 0x0603339B RID: 209819 RVA: 0x00E5B948 File Offset: 0x00E59B48
		private void OnClickRight(int __)
		{
			if (this.CurrentSpringManorQuestState == ESpringManorQuestState.UnTrack)
			{
				SpringManorController.Instance.RequestTrackQuest(this.CurrentSelectQuestId, true);
			}
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x0603339C RID: 209820 RVA: 0x00E5B96F File Offset: 0x00E59B6F
		private void OnLogicTreeTrackUpdate(BtType btType, long? treeIncId)
		{
			this.RefreshView();
		}

		// Token: 0x0603339D RID: 209821 RVA: 0x00E5B977 File Offset: 0x00E59B77
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			this.RefreshView();
		}

		// Token: 0x0401B339 RID: 111417
		private int CurrentSelectQuestId;

		// Token: 0x0401B33A RID: 111418
		private ESpringManorQuestState CurrentSpringManorQuestState;

		// Token: 0x0401B33B RID: 111419
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B33C RID: 111420
		private StepBaseItem QuestStepItem;

		// Token: 0x0401B33D RID: 111421
		private FunctionalPanelConditionLock WarningTipsItem;

		// Token: 0x0401B33E RID: 111422
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardPreviewScroll;

		// Token: 0x0401B33F RID: 111423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SpringManorQuestItem, int> MainQuestLayout;

		// Token: 0x0401B340 RID: 111424
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SpringManorQuestItem, int> SubQuestLayout;

		// Token: 0x0401B341 RID: 111425
		private ButtonItem ButtonLeft;

		// Token: 0x0401B342 RID: 111426
		private ButtonItem ButtonRight;

		// Token: 0x0401B343 RID: 111427
		private double TickTimer;
	}
}
