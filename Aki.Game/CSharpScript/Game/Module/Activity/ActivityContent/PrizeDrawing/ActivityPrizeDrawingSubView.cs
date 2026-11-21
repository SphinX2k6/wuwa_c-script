using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing
{
	// Token: 0x0200521D RID: 21021
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityPrizeDrawingSubView : ActivitySubViewBase
	{
		// Token: 0x170065D0 RID: 26064
		// (get) Token: 0x06034504 RID: 214276 RVA: 0x00EA291F File Offset: 0x00EA0B1F
		[Nullable(1)]
		private ActivityPrizeDrawingData ActivityPrizeDrawingData
		{
			[NullableContext(1)]
			get
			{
				return (ActivityPrizeDrawingData)this.ActivityBaseData;
			}
		}

		// Token: 0x06034505 RID: 214277 RVA: 0x00EA292C File Offset: 0x00EA0B2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickSkipBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034506 RID: 214278 RVA: 0x00EA2B20 File Offset: 0x00EA0D20
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPrizeDrawingSubView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPrizeDrawingSubView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034507 RID: 214279 RVA: 0x00EA2B64 File Offset: 0x00EA0D64
		protected override void OnStart()
		{
			ActivityPrizeDrawingData activityData = this.ActivityPrizeDrawingData;
			activityData.ReadRedDot();
			this.TitleComponent.SetActivityBaseData(activityData);
			this.TitleComponent.SetTitleByText(activityData.GetTitle());
			this.DescriptionComponent.SetContentByTextId(activityData.LocalConfig.Value.Desc, Array.Empty<string>());
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(activityData.ConditionGroupId);
			if (!string.IsNullOrEmpty(conditionGroupHintText))
			{
				this.TipsLock.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
			}
			this.TipsLock.ButtonCallBack = delegate()
			{
				ActivityController.Instance.OpenActivityConditionView(activityData.Id);
			};
			this.SkipBtn.SetFunction(new Action(this.OnClickSkipBtn));
		}

		// Token: 0x06034508 RID: 214280 RVA: 0x00EA2C35 File Offset: 0x00EA0E35
		protected override void OnRefreshView()
		{
			this.RefreshRewardComponent();
			this.RefreshPageState();
			this.RefreshTimerText();
			this.RefreshProgress();
			this.RefreshQuest();
		}

		// Token: 0x06034509 RID: 214281 RVA: 0x00EA2C55 File Offset: 0x00EA0E55
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x0603450A RID: 214282 RVA: 0x00EA2C60 File Offset: 0x00EA0E60
		protected override UniTask OnBeforeHideSelfAsync()
		{
			ActivityPrizeDrawingSubView.<OnBeforeHideSelfAsync>d__16 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivityPrizeDrawingSubView.<OnBeforeHideSelfAsync>d__16>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603450B RID: 214283 RVA: 0x00EA2CA3 File Offset: 0x00EA0EA3
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603450C RID: 214284 RVA: 0x00EA2CB5 File Offset: 0x00EA0EB5
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnQuestUpdated));
		}

		// Token: 0x0603450D RID: 214285 RVA: 0x00EA2CD3 File Offset: 0x00EA0ED3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnQuestUpdated));
		}

		// Token: 0x0603450E RID: 214286 RVA: 0x00EA2CF1 File Offset: 0x00EA0EF1
		private void OnQuestUpdated()
		{
			this.OnRefreshView();
		}

		// Token: 0x0603450F RID: 214287 RVA: 0x00EA2CFC File Offset: 0x00EA0EFC
		private void RefreshProgress()
		{
			ActivityPrizeDrawingData activityPrizeDrawingData = this.ActivityPrizeDrawingData;
			int currentProgress = activityPrizeDrawingData.GetCurrentProgress();
			int totalProgress = activityPrizeDrawingData.GetTotalProgress();
			UUIText text = base.GetText(4);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentProgress);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(totalProgress);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(currentProgress >= totalProgress);
		}

		// Token: 0x06034510 RID: 214288 RVA: 0x00EA2D74 File Offset: 0x00EA0F74
		private void RefreshQuest()
		{
			if (!this.ActivityPrizeDrawingData.GetPreGuideQuestFinishState())
			{
				PrizeDrawingQuestItem questItem = this.QuestItem;
				if (questItem == null)
				{
					return;
				}
				questItem.GetRootItem().SetUIActive(false);
				return;
			}
			else
			{
				PrizeDrawingQuestItem questItem2 = this.QuestItem;
				if (questItem2 != null)
				{
					questItem2.GetRootItem().SetUIActive(true);
				}
				ActivityPrizeDrawingData activityPrizeDrawingData = this.ActivityPrizeDrawingData;
				if (!activityPrizeDrawingData.IsQuestAllCompleted())
				{
					PrizeDrawingQuestItem questItem3 = this.QuestItem;
					if (questItem3 != null)
					{
						questItem3.RefreshFinishState(false);
					}
					int? currentQuestId = activityPrizeDrawingData.GetCurrentQuestId();
					if (currentQuestId != null)
					{
						int? num = currentQuestId;
						int num2 = 0;
						if (!(num.GetValueOrDefault() == num2 & num != null))
						{
							PrizeDrawingQuestItem questItem4 = this.QuestItem;
							if (questItem4 == null)
							{
								return;
							}
							questItem4.RefreshByQuestId(currentQuestId.Value, activityPrizeDrawingData.GetQuestProgress(), activityPrizeDrawingData.GetQuestTotalProgress());
							return;
						}
					}
					return;
				}
				PrizeDrawingQuestItem questItem5 = this.QuestItem;
				if (questItem5 == null)
				{
					return;
				}
				questItem5.RefreshFinishState(true);
				return;
			}
		}

		// Token: 0x06034511 RID: 214289 RVA: 0x00EA2E3C File Offset: 0x00EA103C
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06034512 RID: 214290 RVA: 0x00EA2E78 File Offset: 0x00EA1078
		private void RefreshRewardComponent()
		{
			List<TItem> previewReward = this.ActivityPrizeDrawingData.GetPreviewReward(null);
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x06034513 RID: 214291 RVA: 0x00EA2EC4 File Offset: 0x00EA10C4
		private void RefreshPageState()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			bool? flag = (activityBaseData != null) ? new bool?(activityBaseData.IsUnLock()) : null;
			if (flag == null || !flag.Value)
			{
				this.RefreshByState(ActivityPrizeDrawingSubView.EState.Lock);
				return;
			}
			if (!this.ActivityPrizeDrawingData.GetPreGuideQuestFinishState())
			{
				this.RefreshByState(ActivityPrizeDrawingSubView.EState.Guide);
				return;
			}
			if (this.ActivityPrizeDrawingData.IsAllFinished())
			{
				this.RefreshByState(ActivityPrizeDrawingSubView.EState.Finish);
				return;
			}
			this.RefreshByState(ActivityPrizeDrawingSubView.EState.Normal);
		}

		// Token: 0x06034514 RID: 214292 RVA: 0x00EA2F3C File Offset: 0x00EA113C
		private void RefreshByState(ActivityPrizeDrawingSubView.EState state)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(state == ActivityPrizeDrawingSubView.EState.Lock);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(state > ActivityPrizeDrawingSubView.EState.Lock);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(state == ActivityPrizeDrawingSubView.EState.Normal || state == ActivityPrizeDrawingSubView.EState.Finish);
			}
			UUIItem item4 = base.GetItem(7);
			if (item4 != null)
			{
				item4.SetUIActive(state == ActivityPrizeDrawingSubView.EState.Lock);
			}
			UUIButtonComponent button = base.GetButton(8);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(state == ActivityPrizeDrawingSubView.EState.Finish);
			}
			UUIItem item5 = base.GetItem(9);
			if (item5 != null)
			{
				item5.SetUIActive(state == ActivityPrizeDrawingSubView.EState.Guide || state == ActivityPrizeDrawingSubView.EState.Normal);
			}
			switch (state)
			{
			case ActivityPrizeDrawingSubView.EState.Lock:
				break;
			case ActivityPrizeDrawingSubView.EState.Guide:
			{
				ActivityButtonItem skipBtn = this.SkipBtn;
				if (skipBtn != null)
				{
					skipBtn.SetShowText("Ichiban_Kuji_GuideQuestTips");
				}
				ActivityButtonItem skipBtn2 = this.SkipBtn;
				if (skipBtn2 == null)
				{
					return;
				}
				skipBtn2.SetRedDotVisible(this.ActivityPrizeDrawingData.NeedFinishGuideQuest());
				return;
			}
			case ActivityPrizeDrawingSubView.EState.Normal:
			case ActivityPrizeDrawingSubView.EState.Finish:
			{
				EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, new List<int>
				{
					this.ActivityPrizeDrawingData.GetCostCoinId()
				});
				ActivityButtonItem skipBtn3 = this.SkipBtn;
				if (skipBtn3 != null)
				{
					skipBtn3.SetShowText("Ichiban_Kuji_SkipMainViewTips");
				}
				ActivityButtonItem skipBtn4 = this.SkipBtn;
				if (skipBtn4 == null)
				{
					return;
				}
				skipBtn4.SetRedDotVisible(this.ActivityPrizeDrawingData.ShouldShowButtonRedDot());
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06034515 RID: 214293 RVA: 0x00EA308A File Offset: 0x00EA128A
		private void OnClickSkipBtn()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityPrizeDrawingData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityPrizeDrawingData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				this.IsGoToMainView = true;
				UiManager.Instance.OpenView(EUiViewName.PrizeDrawingMainView, null, null);
			});
		}

		// Token: 0x0401BC71 RID: 113777
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401BC72 RID: 113778
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401BC73 RID: 113779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401BC74 RID: 113780
		private FunctionalPanelConditionLock TipsLock;

		// Token: 0x0401BC75 RID: 113781
		private ActivityButtonItem SkipBtn;

		// Token: 0x0401BC76 RID: 113782
		private PrizeDrawingQuestItem QuestItem;

		// Token: 0x0401BC77 RID: 113783
		private bool IsGoToMainView;

		// Token: 0x0200AE5E RID: 44638
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035DCB RID: 220619
			PnlLock,
			// Token: 0x04035DCC RID: 220620
			PnlUnlock,
			// Token: 0x04035DCD RID: 220621
			TitleItem,
			// Token: 0x04035DCE RID: 220622
			DescItem,
			// Token: 0x04035DCF RID: 220623
			TxtProgress,
			// Token: 0x04035DD0 RID: 220624
			PnlProgressGot,
			// Token: 0x04035DD1 RID: 220625
			RewardPreviewComp,
			// Token: 0x04035DD2 RID: 220626
			TipsLock,
			// Token: 0x04035DD3 RID: 220627
			BtnFinish,
			// Token: 0x04035DD4 RID: 220628
			SkipBtn,
			// Token: 0x04035DD5 RID: 220629
			QuestItem,
			// Token: 0x04035DD6 RID: 220630
			PnlProgress
		}

		// Token: 0x0200AE5F RID: 44639
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04035DD8 RID: 220632
			Lock,
			// Token: 0x04035DD9 RID: 220633
			Guide,
			// Token: 0x04035DDA RID: 220634
			Normal,
			// Token: 0x04035DDB RID: 220635
			Finish
		}
	}
}
