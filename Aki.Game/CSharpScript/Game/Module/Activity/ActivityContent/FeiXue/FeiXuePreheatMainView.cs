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
	// Token: 0x02006645 RID: 26181
	[NullableContext(2)]
	[Nullable(0)]
	public class FeiXuePreheatMainView : UiViewBase
	{
		// Token: 0x060419BE RID: 268734 RVA: 0x00FE98C4 File Offset: 0x00FE7AC4
		[NullableContext(1)]
		public FeiXuePreheatMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060419BF RID: 268735 RVA: 0x00FE9954 File Offset: 0x00FE7B54
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

		// Token: 0x060419C0 RID: 268736 RVA: 0x00FE9C69 File Offset: 0x00FE7E69
		protected override void OnBeforeShow()
		{
			this.UiViewSequence.HideSequenceName = "HideView_01";
		}

		// Token: 0x060419C1 RID: 268737 RVA: 0x00FE9C7C File Offset: 0x00FE7E7C
		protected override UniTask OnBeforeStartAsync()
		{
			FeiXuePreheatMainView.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FeiXuePreheatMainView.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060419C2 RID: 268738 RVA: 0x00FE9CC0 File Offset: 0x00FE7EC0
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

		// Token: 0x060419C3 RID: 268739 RVA: 0x00FE9D6C File Offset: 0x00FE7F6C
		protected override void OnAfterPlayStartSequence()
		{
			this.PlayQuestSequence();
		}

		// Token: 0x060419C4 RID: 268740 RVA: 0x00FE9D78 File Offset: 0x00FE7F78
		private UniTask PlayQuestSequence()
		{
			FeiXuePreheatMainView.<PlayQuestSequence>d__29 <PlayQuestSequence>d__;
			<PlayQuestSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayQuestSequence>d__.<>4__this = this;
			<PlayQuestSequence>d__.<>1__state = -1;
			<PlayQuestSequence>d__.<>t__builder.Start<FeiXuePreheatMainView.<PlayQuestSequence>d__29>(ref <PlayQuestSequence>d__);
			return <PlayQuestSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060419C5 RID: 268741 RVA: 0x00FE9DBB File Offset: 0x00FE7FBB
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
		}

		// Token: 0x060419C6 RID: 268742 RVA: 0x00FE9DC0 File Offset: 0x00FE7FC0
		private UniTask PlayAllDoneAnimation()
		{
			FeiXuePreheatMainView.<PlayAllDoneAnimation>d__31 <PlayAllDoneAnimation>d__;
			<PlayAllDoneAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAllDoneAnimation>d__.<>4__this = this;
			<PlayAllDoneAnimation>d__.<>1__state = -1;
			<PlayAllDoneAnimation>d__.<>t__builder.Start<FeiXuePreheatMainView.<PlayAllDoneAnimation>d__31>(ref <PlayAllDoneAnimation>d__);
			return <PlayAllDoneAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x060419C7 RID: 268743 RVA: 0x00FE9E03 File Offset: 0x00FE8003
		[NullableContext(1)]
		private string GetSequenceTypeByIndex(int index)
		{
			if (index >= this.SequenceTypeMapping.Count)
			{
				return "Done_1";
			}
			return this.SequenceTypeMapping[index];
		}

		// Token: 0x060419C8 RID: 268744 RVA: 0x00FE9E28 File Offset: 0x00FE8028
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

		// Token: 0x060419C9 RID: 268745 RVA: 0x00FE9E74 File Offset: 0x00FE8074
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

		// Token: 0x060419CA RID: 268746 RVA: 0x00FE9EC0 File Offset: 0x00FE80C0
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

		// Token: 0x060419CB RID: 268747 RVA: 0x00FE9F0B File Offset: 0x00FE810B
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x060419CC RID: 268748 RVA: 0x00FE9F29 File Offset: 0x00FE8129
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

		// Token: 0x060419CD RID: 268749 RVA: 0x00FE9F50 File Offset: 0x00FE8150
		private void RefreshTaskItemView()
		{
			List<FeiXuePreheatTaskData> taskDataList = this.ActivityData.GetTaskDataList();
			this.RefreshLeftShow(taskDataList);
			this.RefreshMiddleShow(taskDataList);
			this.RefreshRightShow(taskDataList);
		}

		// Token: 0x060419CE RID: 268750 RVA: 0x00FE9F80 File Offset: 0x00FE8180
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

		// Token: 0x060419CF RID: 268751 RVA: 0x00FEA088 File Offset: 0x00FE8288
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

		// Token: 0x060419D0 RID: 268752 RVA: 0x00FEA11C File Offset: 0x00FE831C
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

		// Token: 0x060419D1 RID: 268753 RVA: 0x00FEA1D4 File Offset: 0x00FE83D4
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

		// Token: 0x060419D2 RID: 268754 RVA: 0x00FEA2F9 File Offset: 0x00FE84F9
		private void OnClickRewardButton()
		{
			UiManager.Instance.OpenView(EUiViewName.FeiXuePreheatRewardView, this.ActivityData, null);
		}

		// Token: 0x060419D3 RID: 268755 RVA: 0x00FEA311 File Offset: 0x00FE8511
		private void OnCloseButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x060419D4 RID: 268756 RVA: 0x00FEA31C File Offset: 0x00FE851C
		private void OnBtnHelpBtn()
		{
			int helpId = this.ActivityData.GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x060419D5 RID: 268757 RVA: 0x00FEA340 File Offset: 0x00FE8540
		private void OnClickCheckDetailButton()
		{
			this.UiViewSequence.HideSequenceName = "HideView_02";
			InfoDisplayController.Instance.OpenInfoDisplay(71600010, null, null, false, null);
		}

		// Token: 0x0402224B RID: 139851
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402224C RID: 139852
		private FeiXueGoBtnItem BtnGo;

		// Token: 0x0402224D RID: 139853
		private FeiXueCheckDetailItem FeiXueCheckDetailItem;

		// Token: 0x0402224E RID: 139854
		private FeiXueDayLeftPanel PanelDay1L;

		// Token: 0x0402224F RID: 139855
		private FeiXueDayLeftPanel PanelDay2L;

		// Token: 0x04022250 RID: 139856
		private FeiXueDayLeftPanel PanelDay3L;

		// Token: 0x04022251 RID: 139857
		private FeiXueDayLeftPanel PanelDay4L;

		// Token: 0x04022252 RID: 139858
		private FeiXueDayLeftPanel PanelDay5L;

		// Token: 0x04022253 RID: 139859
		private FeiXueDayLeftPanel PanelDay6L;

		// Token: 0x04022254 RID: 139860
		private FeiXueDayLeftPanel PanelDay7L;

		// Token: 0x04022255 RID: 139861
		private FeiXueDayRightPanel PanelDay1R;

		// Token: 0x04022256 RID: 139862
		private FeiXueDayRightPanel PanelDay2R;

		// Token: 0x04022257 RID: 139863
		private FeiXueDayRightPanel PanelDay3R;

		// Token: 0x04022258 RID: 139864
		private FeiXueDayRightPanel PanelDay4R;

		// Token: 0x04022259 RID: 139865
		private FeiXueDayRightPanel PanelDay5R;

		// Token: 0x0402225A RID: 139866
		private FeiXueDayRightPanel PanelDay6R;

		// Token: 0x0402225B RID: 139867
		private FeiXueDayRightPanel PanelDay7R;

		// Token: 0x0402225C RID: 139868
		[Nullable(1)]
		private List<FeiXueDayLeftPanel> PanelDayLeftList = new List<FeiXueDayLeftPanel>();

		// Token: 0x0402225D RID: 139869
		[Nullable(1)]
		private List<UUISprite> PanelDayMiddleList = new List<UUISprite>();

		// Token: 0x0402225E RID: 139870
		[Nullable(1)]
		private List<FeiXueDayRightPanel> PanelDayRightList = new List<FeiXueDayRightPanel>();

		// Token: 0x0402225F RID: 139871
		private ActivityFeiXuePreheatData ActivityData;

		// Token: 0x04022260 RID: 139872
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04022261 RID: 139873
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
