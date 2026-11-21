using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D6D RID: 19821
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestUpdateTipsController : MissionPanelControllerBase
	{
		// Token: 0x17006233 RID: 25139
		// (get) Token: 0x06031BC0 RID: 203712 RVA: 0x00DE7C85 File Offset: 0x00DE5E85
		protected override EMissionPanelControllerType ControllerType
		{
			get
			{
				return EMissionPanelControllerType.QuestUpdateTipsController;
			}
		}

		// Token: 0x06031BC1 RID: 203713 RVA: 0x00DE7C88 File Offset: 0x00DE5E88
		public QuestUpdateTipsController(LevelSequencePlayer sequencePlayer, BattleQuestUpdateTipsView questUpdateTipsView, Func<bool> checkMissionItemViewShowEmptyHandle, UUIItem missionItemViewRootNode)
		{
			this.SequencePlayer = sequencePlayer;
			this.QuestUpdateTipsView = questUpdateTipsView;
			this.CheckMissionItemViewShowEmptyHandle = checkMissionItemViewShowEmptyHandle;
			this.MissionItemViewRootNode = missionItemViewRootNode;
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x06031BC2 RID: 203714 RVA: 0x00DE7CC8 File Offset: 0x00DE5EC8
		public override void OnDestroy()
		{
			this.SequencePlayer.Clear();
			this.QuestUpdateTipsView.Destroy(null);
			if (this.StayTimer != null && TimerSystem.Instance.Has(this.StayTimer))
			{
				TimerHandle stayTimer = this.StayTimer;
				if (stayTimer == null)
				{
					return;
				}
				stayTimer.Remove();
			}
		}

		// Token: 0x06031BC3 RID: 203715 RVA: 0x00DE7D17 File Offset: 0x00DE5F17
		public override void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.QuestUpdateTipsClickTrack, new Action(this.OnQuestUpdateTipsClickTrack));
		}

		// Token: 0x06031BC4 RID: 203716 RVA: 0x00DE7D35 File Offset: 0x00DE5F35
		public override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.QuestUpdateTipsClickTrack, new Action(this.OnQuestUpdateTipsClickTrack));
		}

		// Token: 0x06031BC5 RID: 203717 RVA: 0x00DE7D54 File Offset: 0x00DE5F54
		public void OnPanelShow()
		{
			this.SequencePlayer.ResumeSequence();
			if (TimerSystem.Instance.Has(this.StayTimer) && TimerSystem.Instance.IsPause(this.StayTimer))
			{
				TimerSystem.Instance.Resume(this.StayTimer);
			}
		}

		// Token: 0x06031BC6 RID: 203718 RVA: 0x00DE7DA1 File Offset: 0x00DE5FA1
		public void OnPanelHide()
		{
			this.SequencePlayer.PauseSequence();
			if (TimerSystem.Instance.Has(this.StayTimer))
			{
				TimerSystem.Instance.Pause(this.StayTimer, null);
			}
		}

		// Token: 0x06031BC7 RID: 203719 RVA: 0x00DE7DD4 File Offset: 0x00DE5FD4
		[NullableContext(0)]
		public UniTask<bool> ShowQuestUpdateTipsHandle([Nullable(1)] ShowQuestUpdateTipsProcess process)
		{
			QuestUpdateTipsController.<ShowQuestUpdateTipsHandle>d__20 <ShowQuestUpdateTipsHandle>d__;
			<ShowQuestUpdateTipsHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowQuestUpdateTipsHandle>d__.<>4__this = this;
			<ShowQuestUpdateTipsHandle>d__.process = process;
			<ShowQuestUpdateTipsHandle>d__.<>1__state = -1;
			<ShowQuestUpdateTipsHandle>d__.<>t__builder.Start<QuestUpdateTipsController.<ShowQuestUpdateTipsHandle>d__20>(ref <ShowQuestUpdateTipsHandle>d__);
			return <ShowQuestUpdateTipsHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06031BC8 RID: 203720 RVA: 0x00DE7E1F File Offset: 0x00DE601F
		private void SetQuestUpdateTipsViewVisible(bool bVisible)
		{
			this.QuestUpdateTipsView.SetUiActive(bVisible);
			this.MissionItemViewRootNode.SetUIActive(!bVisible);
		}

		// Token: 0x06031BC9 RID: 203721 RVA: 0x00DE7E3C File Offset: 0x00DE603C
		private float GetTimerStayTime(int questId)
		{
			Quest quest = QuestNewModel.Instance.GetQuest(questId);
			if (quest == null)
			{
				return 20f;
			}
			int? questUpdateShowTime = QuestNewConfig.Instance.GetQuestUpdateShowTime((int)quest.Type);
			if (questUpdateShowTime == null)
			{
				return 20f;
			}
			return (float)(questUpdateShowTime.Value * 1000);
		}

		// Token: 0x06031BCA RID: 203722 RVA: 0x00DE7E8C File Offset: 0x00DE608C
		private void OnSequenceClose(string sequenceName)
		{
			if (!(sequenceName == "MissionIn"))
			{
				if (!(sequenceName == "MissionOut"))
				{
					return;
				}
				if (this.MissionSequenceType == EQuestUpdateTipsStep.QuestUpdateStart)
				{
					CustomPromise<bool> questUpdateStartMissionOutPromise = this.QuestUpdateStartMissionOutPromise;
					if (questUpdateStartMissionOutPromise != null && questUpdateStartMissionOutPromise.IsPending)
					{
						this.QuestUpdateStartMissionOutPromise.SetResult(true);
						return;
					}
				}
				else if (this.MissionSequenceType == EQuestUpdateTipsStep.QuestUpdateEnd)
				{
					CustomPromise<bool> questUpdateEndMissionOutPromise = this.QuestUpdateEndMissionOutPromise;
					if (questUpdateEndMissionOutPromise != null && questUpdateEndMissionOutPromise.IsPending)
					{
						this.QuestUpdateEndMissionOutPromise.SetResult(true);
					}
				}
			}
			else if (this.MissionSequenceType == EQuestUpdateTipsStep.QuestUpdateStart)
			{
				CustomPromise<bool> questUpdateStartMissionInPromise = this.QuestUpdateStartMissionInPromise;
				if (questUpdateStartMissionInPromise != null && questUpdateStartMissionInPromise.IsPending)
				{
					this.QuestUpdateStartMissionInPromise.SetResult(true);
					return;
				}
			}
			else if (this.MissionSequenceType == EQuestUpdateTipsStep.QuestUpdateEnd)
			{
				CustomPromise<bool> questUpdateEndMissionInPromise = this.QuestUpdateEndMissionInPromise;
				if (questUpdateEndMissionInPromise != null && questUpdateEndMissionInPromise.IsPending)
				{
					this.QuestUpdateEndMissionInPromise.SetResult(true);
					return;
				}
			}
		}

		// Token: 0x06031BCB RID: 203723 RVA: 0x00DE7F60 File Offset: 0x00DE6160
		private void QuestUpdateTipsEnd(ShowQuestUpdateTipsProcess process)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "MissionPanel:QuestUpdateTipsEnd - AllOver";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("processId", process.Info.QuestId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.QuestUpdateTipsView.OnAfterPlayHideSequence();
			this.MissionSequenceType = EQuestUpdateTipsStep.None;
			this.QuestUpdateTipsTrackBtnClick = false;
		}

		// Token: 0x06031BCC RID: 203724 RVA: 0x00DE7FBC File Offset: 0x00DE61BC
		private void OnQuestUpdateTipsClickTrack()
		{
			Log.Instance.Info(ELogModule.Log, ELogAuthor.YSQ, "MissionPanel:Press Track", default(ReadOnlySpan<ValueTuple<string, object>>));
			switch (this.MissionSequenceType)
			{
			case EQuestUpdateTipsStep.QuestUpdateStart:
				this.SequencePlayer.StopCurrentSequence(true, true);
				break;
			case EQuestUpdateTipsStep.QuestUpdateStay:
			{
				if (TimerSystem.Instance.Has(this.StayTimer))
				{
					TimerSystem.Instance.Remove(this.StayTimer);
				}
				CustomPromise<bool> questUpdateStayPromise = this.QuestUpdateStayPromise;
				if (questUpdateStayPromise != null)
				{
					questUpdateStayPromise.SetResult(true);
				}
				break;
			}
			}
			this.QuestUpdateTipsTrackBtnClick = true;
		}

		// Token: 0x0401A53F RID: 107839
		private EQuestUpdateTipsStep MissionSequenceType;

		// Token: 0x0401A540 RID: 107840
		[Nullable(2)]
		private TimerHandle StayTimer;

		// Token: 0x0401A541 RID: 107841
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateStartMissionOutPromise;

		// Token: 0x0401A542 RID: 107842
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateStartMissionInPromise;

		// Token: 0x0401A543 RID: 107843
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateStayPromise;

		// Token: 0x0401A544 RID: 107844
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateEndMissionOutPromise;

		// Token: 0x0401A545 RID: 107845
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateEndMissionInPromise;

		// Token: 0x0401A546 RID: 107846
		private bool QuestUpdateTipsTrackBtnClick;

		// Token: 0x0401A547 RID: 107847
		private readonly LevelSequencePlayer SequencePlayer;

		// Token: 0x0401A548 RID: 107848
		private readonly BattleQuestUpdateTipsView QuestUpdateTipsView;

		// Token: 0x0401A549 RID: 107849
		private readonly Func<bool> CheckMissionItemViewShowEmptyHandle;

		// Token: 0x0401A54A RID: 107850
		private readonly UUIItem MissionItemViewRootNode;
	}
}
