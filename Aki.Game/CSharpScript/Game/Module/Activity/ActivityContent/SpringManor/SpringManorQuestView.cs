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
	// Token: 0x02006067 RID: 24679
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorQuestView : UiTickViewBase
	{
		// Token: 0x0603E6BE RID: 255678 RVA: 0x00F1407D File Offset: 0x00F1227D
		[NullableContext(1)]
		public SpringManorQuestView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E6BF RID: 255679 RVA: 0x00F14088 File Offset: 0x00F12288
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

		// Token: 0x0603E6C0 RID: 255680 RVA: 0x00F14350 File Offset: 0x00F12550
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorQuestView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorQuestView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E6C1 RID: 255681 RVA: 0x00F14394 File Offset: 0x00F12594
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

		// Token: 0x0603E6C2 RID: 255682 RVA: 0x00F14464 File Offset: 0x00F12664
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			SpringManorQuestView.<OnBeforeShowAsyncImplementImplement>d__15 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<SpringManorQuestView.<OnBeforeShowAsyncImplementImplement>d__15>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603E6C3 RID: 255683 RVA: 0x00F144A8 File Offset: 0x00F126A8
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

		// Token: 0x0603E6C4 RID: 255684 RVA: 0x00F144F4 File Offset: 0x00F126F4
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

		// Token: 0x0603E6C5 RID: 255685 RVA: 0x00F1454B File Offset: 0x00F1274B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnLogicTreeTrackUpdate));
			EventSystem.Instance.Add(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603E6C6 RID: 255686 RVA: 0x00F14585 File Offset: 0x00F12785
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnLogicTreeTrackUpdate));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603E6C7 RID: 255687 RVA: 0x00F145BF File Offset: 0x00F127BF
		private void RefreshView()
		{
			this.RefreshQuestScroll(false);
		}

		// Token: 0x0603E6C8 RID: 255688 RVA: 0x00F145CC File Offset: 0x00F127CC
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

		// Token: 0x0603E6C9 RID: 255689 RVA: 0x00F14628 File Offset: 0x00F12828
		private void RefreshEmpty()
		{
			bool flag = SpringManorModel.Instance.HasAnyQuest();
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(2).SetUIActive(flag);
		}

		// Token: 0x0603E6CA RID: 255690 RVA: 0x00F1465D File Offset: 0x00F1285D
		[NullableContext(1)]
		private SpringManorQuestItem CreateMainQuestItem()
		{
			return new SpringManorQuestItem
			{
				ToggleClickCallback = new Action<int, int>(this.OnClickMainQuestToggle)
			};
		}

		// Token: 0x0603E6CB RID: 255691 RVA: 0x00F14676 File Offset: 0x00F12876
		[NullableContext(1)]
		private SpringManorQuestItem CreateSubQuestItem()
		{
			return new SpringManorQuestItem
			{
				ToggleClickCallback = new Action<int, int>(this.OnClickSubQuestToggle)
			};
		}

		// Token: 0x0603E6CC RID: 255692 RVA: 0x00F1468F File Offset: 0x00F1288F
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

		// Token: 0x0603E6CD RID: 255693 RVA: 0x00F146BD File Offset: 0x00F128BD
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

		// Token: 0x0603E6CE RID: 255694 RVA: 0x00F146EC File Offset: 0x00F128EC
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

		// Token: 0x0603E6CF RID: 255695 RVA: 0x00F14794 File Offset: 0x00F12994
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

		// Token: 0x0603E6D0 RID: 255696 RVA: 0x00F14884 File Offset: 0x00F12A84
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

		// Token: 0x0603E6D1 RID: 255697 RVA: 0x00F148C8 File Offset: 0x00F12AC8
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

		// Token: 0x0603E6D2 RID: 255698 RVA: 0x00F14900 File Offset: 0x00F12B00
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

		// Token: 0x0603E6D3 RID: 255699 RVA: 0x00F14A04 File Offset: 0x00F12C04
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

		// Token: 0x0603E6D4 RID: 255700 RVA: 0x00F14A50 File Offset: 0x00F12C50
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

		// Token: 0x0603E6D5 RID: 255701 RVA: 0x00F14B60 File Offset: 0x00F12D60
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603E6D6 RID: 255702 RVA: 0x00F14B69 File Offset: 0x00F12D69
		private void OnClickLeft(int __)
		{
			SpringManorController.Instance.RequestTrackQuest(this.CurrentSelectQuestId, false);
			this.RefreshQuestScroll(false);
		}

		// Token: 0x0603E6D7 RID: 255703 RVA: 0x00F14B84 File Offset: 0x00F12D84
		private void OnClickRight(int __)
		{
			if (this.CurrentSpringManorQuestState == ESpringManorQuestState.UnTrack)
			{
				SpringManorController.Instance.RequestTrackQuest(this.CurrentSelectQuestId, true);
			}
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x0603E6D8 RID: 255704 RVA: 0x00F14BAB File Offset: 0x00F12DAB
		private void OnLogicTreeTrackUpdate(BtType btType, long? treeIncId)
		{
			this.RefreshView();
		}

		// Token: 0x0603E6D9 RID: 255705 RVA: 0x00F14BB3 File Offset: 0x00F12DB3
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			this.RefreshView();
		}

		// Token: 0x04020A0C RID: 133644
		private int CurrentSelectQuestId;

		// Token: 0x04020A0D RID: 133645
		private ESpringManorQuestState CurrentSpringManorQuestState;

		// Token: 0x04020A0E RID: 133646
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020A0F RID: 133647
		private StepBaseItem QuestStepItem;

		// Token: 0x04020A10 RID: 133648
		private FunctionalPanelConditionLock WarningTipsItem;

		// Token: 0x04020A11 RID: 133649
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardPreviewScroll;

		// Token: 0x04020A12 RID: 133650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SpringManorQuestItem, int> MainQuestLayout;

		// Token: 0x04020A13 RID: 133651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SpringManorQuestItem, int> SubQuestLayout;

		// Token: 0x04020A14 RID: 133652
		private ButtonItem ButtonLeft;

		// Token: 0x04020A15 RID: 133653
		private ButtonItem ButtonRight;

		// Token: 0x04020A16 RID: 133654
		private double TickTimer;
	}
}
