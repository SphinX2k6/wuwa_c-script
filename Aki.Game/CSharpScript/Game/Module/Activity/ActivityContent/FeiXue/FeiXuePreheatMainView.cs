using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055C3 RID: 21955
	[NullableContext(2)]
	[Nullable(0)]
	public class FeiXuePreheatMainView : UiViewBase
	{
		// Token: 0x06036683 RID: 222851 RVA: 0x00F3097C File Offset: 0x00F2EB7C
		[NullableContext(1)]
		public FeiXuePreheatMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036684 RID: 222852 RVA: 0x00F30A0C File Offset: 0x00F2EC0C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUISprite)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUISprite)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUISprite)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUITexture)),
				new ValueTuple<int, Type>(23, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(24, typeof(UUIItem)),
				new ValueTuple<int, Type>(25, typeof(UUIText)),
				new ValueTuple<int, Type>(26, typeof(UUIItem)),
				new ValueTuple<int, Type>(27, typeof(UUIItem)),
				new ValueTuple<int, Type>(28, typeof(UUIItem)),
				new ValueTuple<int, Type>(29, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(30, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(23, new Action(this.OnClickRewardButton)),
				new ValueTuple<int, Delegate>(29, new Action(this.OnClickCheckDetailButton))
			};
		}

		// Token: 0x06036685 RID: 222853 RVA: 0x00F30D21 File Offset: 0x00F2EF21
		protected override void OnBeforeShow()
		{
			this.UiViewSequence.HideSequenceName = "HideView_01";
		}

		// Token: 0x06036686 RID: 222854 RVA: 0x00F30D34 File Offset: 0x00F2EF34
		protected override UniTask OnBeforeStartAsync()
		{
			FeiXuePreheatMainView.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FeiXuePreheatMainView.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036687 RID: 222855 RVA: 0x00F30D78 File Offset: 0x00F2EF78
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseButtonClicked));
			this.CaptionItem.SetHelpBtnActive(true);
			this.CaptionItem.SetHelpCallBack(new Action(this.OnBtnHelpBtn));
			this.ActivityData = (this.OpenParam as ActivityFeiXuePreheatData);
			if (this.ActivityData == null)
			{
				return;
			}
			this.RefreshTaskItemView();
			this.RefreshCompleteShow();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06036688 RID: 222856 RVA: 0x00F30E24 File Offset: 0x00F2F024
		protected override void OnAfterPlayStartSequence()
		{
			this.PlayQuestSequence();
		}

		// Token: 0x06036689 RID: 222857 RVA: 0x00F30E30 File Offset: 0x00F2F030
		private UniTask PlayQuestSequence()
		{
			FeiXuePreheatMainView.<PlayQuestSequence>d__29 <PlayQuestSequence>d__;
			<PlayQuestSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayQuestSequence>d__.<>4__this = this;
			<PlayQuestSequence>d__.<>1__state = -1;
			<PlayQuestSequence>d__.<>t__builder.Start<FeiXuePreheatMainView.<PlayQuestSequence>d__29>(ref <PlayQuestSequence>d__);
			return <PlayQuestSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603668A RID: 222858 RVA: 0x00F30E73 File Offset: 0x00F2F073
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
		}

		// Token: 0x0603668B RID: 222859 RVA: 0x00F30E78 File Offset: 0x00F2F078
		private UniTask PlayAllDoneAnimation()
		{
			FeiXuePreheatMainView.<PlayAllDoneAnimation>d__31 <PlayAllDoneAnimation>d__;
			<PlayAllDoneAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAllDoneAnimation>d__.<>4__this = this;
			<PlayAllDoneAnimation>d__.<>1__state = -1;
			<PlayAllDoneAnimation>d__.<>t__builder.Start<FeiXuePreheatMainView.<PlayAllDoneAnimation>d__31>(ref <PlayAllDoneAnimation>d__);
			return <PlayAllDoneAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x0603668C RID: 222860 RVA: 0x00F30EBB File Offset: 0x00F2F0BB
		[NullableContext(1)]
		private string GetSequenceTypeByIndex(int index)
		{
			if (index >= this.SequenceTypeMapping.Count)
			{
				return "Done_1";
			}
			return this.SequenceTypeMapping[index];
		}

		// Token: 0x0603668D RID: 222861 RVA: 0x00F30EE0 File Offset: 0x00F2F0E0
		private UniTask PlayDoneAnimationByIndex(int index)
		{
			FeiXuePreheatMainView.<PlayDoneAnimationByIndex>d__33 <PlayDoneAnimationByIndex>d__;
			<PlayDoneAnimationByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDoneAnimationByIndex>d__.<>4__this = this;
			<PlayDoneAnimationByIndex>d__.index = index;
			<PlayDoneAnimationByIndex>d__.<>1__state = -1;
			<PlayDoneAnimationByIndex>d__.<>t__builder.Start<FeiXuePreheatMainView.<PlayDoneAnimationByIndex>d__33>(ref <PlayDoneAnimationByIndex>d__);
			return <PlayDoneAnimationByIndex>d__.<>t__builder.Task;
		}

		// Token: 0x0603668E RID: 222862 RVA: 0x00F30F2C File Offset: 0x00F2F12C
		private UniTask PlaySearchInAnimationByIndex(int index)
		{
			FeiXuePreheatMainView.<PlaySearchInAnimationByIndex>d__34 <PlaySearchInAnimationByIndex>d__;
			<PlaySearchInAnimationByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySearchInAnimationByIndex>d__.<>4__this = this;
			<PlaySearchInAnimationByIndex>d__.index = index;
			<PlaySearchInAnimationByIndex>d__.<>1__state = -1;
			<PlaySearchInAnimationByIndex>d__.<>t__builder.Start<FeiXuePreheatMainView.<PlaySearchInAnimationByIndex>d__34>(ref <PlaySearchInAnimationByIndex>d__);
			return <PlaySearchInAnimationByIndex>d__.<>t__builder.Task;
		}

		// Token: 0x0603668F RID: 222863 RVA: 0x00F30F78 File Offset: 0x00F2F178
		private UniTask PlaySearchingLoopAnimationByIndex(int index)
		{
			FeiXuePreheatMainView.<PlaySearchingLoopAnimationByIndex>d__35 <PlaySearchingLoopAnimationByIndex>d__;
			<PlaySearchingLoopAnimationByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySearchingLoopAnimationByIndex>d__.<>4__this = this;
			<PlaySearchingLoopAnimationByIndex>d__.index = index;
			<PlaySearchingLoopAnimationByIndex>d__.<>1__state = -1;
			<PlaySearchingLoopAnimationByIndex>d__.<>t__builder.Start<FeiXuePreheatMainView.<PlaySearchingLoopAnimationByIndex>d__35>(ref <PlaySearchingLoopAnimationByIndex>d__);
			return <PlaySearchingLoopAnimationByIndex>d__.<>t__builder.Task;
		}

		// Token: 0x06036690 RID: 222864 RVA: 0x00F30FC3 File Offset: 0x00F2F1C3
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06036691 RID: 222865 RVA: 0x00F30FE1 File Offset: 0x00F2F1E1
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (this.ActivityData == null)
			{
				return;
			}
			if (id != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshTaskItemView();
			this.RefreshCompleteShow();
		}

		// Token: 0x06036692 RID: 222866 RVA: 0x00F31008 File Offset: 0x00F2F208
		private void RefreshTaskItemView()
		{
			List<FeiXuePreheatTaskData> taskDataList = this.ActivityData.GetTaskDataList();
			this.RefreshLeftShow(taskDataList);
			this.RefreshMiddleShow(taskDataList);
			this.RefreshRightShow(taskDataList);
		}

		// Token: 0x06036693 RID: 222867 RVA: 0x00F31038 File Offset: 0x00F2F238
		[NullableContext(1)]
		private void RefreshLeftShow(List<FeiXuePreheatTaskData> dataList)
		{
			if (dataList.Count != this.PanelDayLeftList.Count)
			{
				return;
			}
			int lastFinishedTaskIndex = this.ActivityData.GetLastFinishedTaskIndex();
			bool flag = lastFinishedTaskIndex >= 0 && !this.ActivityData.GetHasPlayFinishAnimation(lastFinishedTaskIndex);
			if (this.ActivityData.IsAllTaskDone() && !flag)
			{
				foreach (FeiXueDayLeftPanel feiXueDayLeftPanel in this.PanelDayLeftList)
				{
					feiXueDayLeftPanel.SetAllFinishState();
				}
				return;
			}
			for (int i = 0; i < dataList.Count; i++)
			{
				FeiXuePreheatTaskData feiXuePreheatTaskData = dataList[i];
				if (i == lastFinishedTaskIndex && !this.ActivityData.GetHasPlayFinishAnimation(lastFinishedTaskIndex))
				{
					this.PanelDayLeftList[i].SetPanelItemActive(false);
				}
				else
				{
					this.PanelDayLeftList[i].SetPanelItemActive(feiXuePreheatTaskData.IsUnclaimed || feiXuePreheatTaskData.IsFinished);
				}
			}
		}

		// Token: 0x06036694 RID: 222868 RVA: 0x00F31140 File Offset: 0x00F2F340
		[NullableContext(1)]
		private void RefreshMiddleShow(List<FeiXuePreheatTaskData> dataList)
		{
			if (dataList.Count != this.PanelDayMiddleList.Count)
			{
				return;
			}
			int lastFinishedTaskIndex = this.ActivityData.GetLastFinishedTaskIndex();
			for (int i = 0; i < dataList.Count; i++)
			{
				FeiXuePreheatTaskData feiXuePreheatTaskData = dataList[i];
				if (i == lastFinishedTaskIndex && !this.ActivityData.GetHasPlayFinishAnimation(lastFinishedTaskIndex))
				{
					this.PanelDayMiddleList[i].SetUIActive(false);
				}
				else
				{
					this.PanelDayMiddleList[i].SetUIActive(feiXuePreheatTaskData.IsUnclaimed || feiXuePreheatTaskData.IsFinished);
				}
			}
		}

		// Token: 0x06036695 RID: 222869 RVA: 0x00F311D4 File Offset: 0x00F2F3D4
		[NullableContext(1)]
		private void RefreshRightShow(List<FeiXuePreheatTaskData> dataList)
		{
			if (dataList.Count != this.PanelDayRightList.Count)
			{
				return;
			}
			int lastFinishedTaskIndex = this.ActivityData.GetLastFinishedTaskIndex();
			int firstDoingTaskIndex = this.ActivityData.GetFirstDoingTaskIndex();
			for (int i = 0; i < dataList.Count; i++)
			{
				FeiXuePreheatTaskData feiXuePreheatTaskData = dataList[i];
				EFeiXueQuestState efeiXueQuestState = feiXuePreheatTaskData.IsDoing ? EFeiXueQuestState.IsDoing : ((feiXuePreheatTaskData.IsUnclaimed || feiXuePreheatTaskData.IsFinished) ? EFeiXueQuestState.Finish : EFeiXueQuestState.Lock);
				if (i == lastFinishedTaskIndex && !this.ActivityData.GetHasPlayFinishAnimation(lastFinishedTaskIndex))
				{
					efeiXueQuestState--;
				}
				else if (i == firstDoingTaskIndex && !this.ActivityData.GetHasPlaySearchInAnimation(firstDoingTaskIndex))
				{
					efeiXueQuestState--;
				}
				this.PanelDayRightList[i].SetPanelItemActive(efeiXueQuestState);
			}
		}

		// Token: 0x06036696 RID: 222870 RVA: 0x00F3128C File Offset: 0x00F2F48C
		private void RefreshCompleteShow()
		{
			bool flag = this.ActivityData.IsAllTaskDone();
			base.GetItem(24).SetUIActive(this.ActivityData.IsExistClaimableTask());
			UUIText text = base.GetText(25);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActivityData.GetFinishedTaskNum());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActivityData.GetTotalTaskNum());
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			bool flag2 = flag && this.ActivityData.GetHasPlayAllDoneAnimation();
			if (flag2)
			{
				base.GetItem(26).SetUIActive(false);
			}
			else
			{
				base.GetItem(26).SetUIActive(true);
				FeiXuePreheatTaskData feiXuePreheatTaskData = flag ? this.ActivityData.GetLastTaskData() : this.ActivityData.GetBtnGoShowTaskData();
				if (feiXuePreheatTaskData != null)
				{
					this.BtnGo.RefreshBtnView(feiXuePreheatTaskData, this.ActivityData);
				}
			}
			FeiXueCheckDetailItem feiXueCheckDetailItem = this.FeiXueCheckDetailItem;
			if (feiXueCheckDetailItem != null)
			{
				feiXueCheckDetailItem.SetUiActive(flag2);
			}
			base.GetItem(30).SetUIActive(!flag2);
			base.GetItem(27).SetUIActive(flag2);
			base.GetItem(28).SetUIActive(!flag2);
		}

		// Token: 0x06036697 RID: 222871 RVA: 0x00F313B1 File Offset: 0x00F2F5B1
		private void OnClickRewardButton()
		{
			UiManager.Instance.OpenView(EUiViewName.FeiXuePreheatRewardView, this.ActivityData, null);
		}

		// Token: 0x06036698 RID: 222872 RVA: 0x00F313C9 File Offset: 0x00F2F5C9
		private void OnCloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036699 RID: 222873 RVA: 0x00F313D4 File Offset: 0x00F2F5D4
		private void OnBtnHelpBtn()
		{
			int helpId = this.ActivityData.GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x0603669A RID: 222874 RVA: 0x00F313F8 File Offset: 0x00F2F5F8
		private void OnClickCheckDetailButton()
		{
			this.UiViewSequence.HideSequenceName = "HideView_02";
			InfoDisplayController.Instance.OpenInfoDisplay(71600010, null, null, false, null, null);
		}

		// Token: 0x0401CB7C RID: 117628
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CB7D RID: 117629
		private FeiXueGoBtnItem BtnGo;

		// Token: 0x0401CB7E RID: 117630
		private FeiXueCheckDetailItem FeiXueCheckDetailItem;

		// Token: 0x0401CB7F RID: 117631
		private FeiXueDayLeftPanel PanelDay1L;

		// Token: 0x0401CB80 RID: 117632
		private FeiXueDayLeftPanel PanelDay2L;

		// Token: 0x0401CB81 RID: 117633
		private FeiXueDayLeftPanel PanelDay3L;

		// Token: 0x0401CB82 RID: 117634
		private FeiXueDayLeftPanel PanelDay4L;

		// Token: 0x0401CB83 RID: 117635
		private FeiXueDayLeftPanel PanelDay5L;

		// Token: 0x0401CB84 RID: 117636
		private FeiXueDayLeftPanel PanelDay6L;

		// Token: 0x0401CB85 RID: 117637
		private FeiXueDayLeftPanel PanelDay7L;

		// Token: 0x0401CB86 RID: 117638
		private FeiXueDayRightPanel PanelDay1R;

		// Token: 0x0401CB87 RID: 117639
		private FeiXueDayRightPanel PanelDay2R;

		// Token: 0x0401CB88 RID: 117640
		private FeiXueDayRightPanel PanelDay3R;

		// Token: 0x0401CB89 RID: 117641
		private FeiXueDayRightPanel PanelDay4R;

		// Token: 0x0401CB8A RID: 117642
		private FeiXueDayRightPanel PanelDay5R;

		// Token: 0x0401CB8B RID: 117643
		private FeiXueDayRightPanel PanelDay6R;

		// Token: 0x0401CB8C RID: 117644
		private FeiXueDayRightPanel PanelDay7R;

		// Token: 0x0401CB8D RID: 117645
		[Nullable(1)]
		private List<FeiXueDayLeftPanel> PanelDayLeftList = new List<FeiXueDayLeftPanel>();

		// Token: 0x0401CB8E RID: 117646
		[Nullable(1)]
		private List<UUISprite> PanelDayMiddleList = new List<UUISprite>();

		// Token: 0x0401CB8F RID: 117647
		[Nullable(1)]
		private List<FeiXueDayRightPanel> PanelDayRightList = new List<FeiXueDayRightPanel>();

		// Token: 0x0401CB90 RID: 117648
		private ActivityFeiXuePreheatData ActivityData;

		// Token: 0x0401CB91 RID: 117649
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401CB92 RID: 117650
		[Nullable(1)]
		private readonly List<string> SequenceTypeMapping = new List<string>
		{
			"Done_1",
			"Done_2",
			"Done_3",
			"Done_4",
			"Done_5",
			"Done_6",
			"Done_7"
		};
	}
}
