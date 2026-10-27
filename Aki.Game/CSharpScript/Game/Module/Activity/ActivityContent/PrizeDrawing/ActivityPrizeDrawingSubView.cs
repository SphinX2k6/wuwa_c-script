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
	// Token: 0x0200629F RID: 25247
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityPrizeDrawingSubView : ActivitySubViewBase
	{
		// Token: 0x1700926E RID: 37486
		// (get) Token: 0x0603F843 RID: 260163 RVA: 0x00F5B9C3 File Offset: 0x00F59BC3
		[Nullable(1)]
		private ActivityPrizeDrawingData ActivityPrizeDrawingData
		{
			[NullableContext(1)]
			get
			{
				return (ActivityPrizeDrawingData)this.ActivityBaseData;
			}
		}

		// Token: 0x0603F844 RID: 260164 RVA: 0x00F5B9D0 File Offset: 0x00F59BD0
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

		// Token: 0x0603F845 RID: 260165 RVA: 0x00F5BBC4 File Offset: 0x00F59DC4
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPrizeDrawingSubView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPrizeDrawingSubView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F846 RID: 260166 RVA: 0x00F5BC08 File Offset: 0x00F59E08
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

		// Token: 0x0603F847 RID: 260167 RVA: 0x00F5BCD9 File Offset: 0x00F59ED9
		protected override void OnRefreshView()
		{
			this.RefreshRewardComponent();
			this.RefreshPageState();
			this.RefreshTimerText();
			this.RefreshProgress();
			this.RefreshQuest();
		}

		// Token: 0x0603F848 RID: 260168 RVA: 0x00F5BCF9 File Offset: 0x00F59EF9
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x0603F849 RID: 260169 RVA: 0x00F5BD04 File Offset: 0x00F59F04
		protected override UniTask OnBeforeHideSelfAsync()
		{
			ActivityPrizeDrawingSubView.<OnBeforeHideSelfAsync>d__16 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivityPrizeDrawingSubView.<OnBeforeHideSelfAsync>d__16>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F84A RID: 260170 RVA: 0x00F5BD47 File Offset: 0x00F59F47
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603F84B RID: 260171 RVA: 0x00F5BD59 File Offset: 0x00F59F59
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnQuestUpdated));
		}

		// Token: 0x0603F84C RID: 260172 RVA: 0x00F5BD77 File Offset: 0x00F59F77
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnQuestUpdated));
		}

		// Token: 0x0603F84D RID: 260173 RVA: 0x00F5BD95 File Offset: 0x00F59F95
		private void OnQuestUpdated()
		{
			this.OnRefreshView();
		}

		// Token: 0x0603F84E RID: 260174 RVA: 0x00F5BDA0 File Offset: 0x00F59FA0
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

		// Token: 0x0603F84F RID: 260175 RVA: 0x00F5BE18 File Offset: 0x00F5A018
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

		// Token: 0x0603F850 RID: 260176 RVA: 0x00F5BEE0 File Offset: 0x00F5A0E0
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

		// Token: 0x0603F851 RID: 260177 RVA: 0x00F5BF1C File Offset: 0x00F5A11C
		private void RefreshRewardComponent()
		{
			List<TItem> previewReward = this.ActivityPrizeDrawingData.GetPreviewReward(null);
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x0603F852 RID: 260178 RVA: 0x00F5BF68 File Offset: 0x00F5A168
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

		// Token: 0x0603F853 RID: 260179 RVA: 0x00F5BFE0 File Offset: 0x00F5A1E0
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

		// Token: 0x0603F854 RID: 260180 RVA: 0x00F5C12E File Offset: 0x00F5A32E
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

		// Token: 0x04021342 RID: 136002
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04021343 RID: 136003
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04021344 RID: 136004
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04021345 RID: 136005
		private FunctionalPanelConditionLock TipsLock;

		// Token: 0x04021346 RID: 136006
		private ActivityButtonItem SkipBtn;

		// Token: 0x04021347 RID: 136007
		private PrizeDrawingQuestItem QuestItem;

		// Token: 0x04021348 RID: 136008
		private bool IsGoToMainView;

		// Token: 0x0200C477 RID: 50295
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403B469 RID: 242793
			PnlLock,
			// Token: 0x0403B46A RID: 242794
			PnlUnlock,
			// Token: 0x0403B46B RID: 242795
			TitleItem,
			// Token: 0x0403B46C RID: 242796
			DescItem,
			// Token: 0x0403B46D RID: 242797
			TxtProgress,
			// Token: 0x0403B46E RID: 242798
			PnlProgressGot,
			// Token: 0x0403B46F RID: 242799
			RewardPreviewComp,
			// Token: 0x0403B470 RID: 242800
			TipsLock,
			// Token: 0x0403B471 RID: 242801
			BtnFinish,
			// Token: 0x0403B472 RID: 242802
			SkipBtn,
			// Token: 0x0403B473 RID: 242803
			QuestItem,
			// Token: 0x0403B474 RID: 242804
			PnlProgress
		}

		// Token: 0x0200C478 RID: 50296
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403B476 RID: 242806
			Lock,
			// Token: 0x0403B477 RID: 242807
			Guide,
			// Token: 0x0403B478 RID: 242808
			Normal,
			// Token: 0x0403B479 RID: 242809
			Finish
		}
	}
}
