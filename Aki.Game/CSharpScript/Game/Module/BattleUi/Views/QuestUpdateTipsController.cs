using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D8B RID: 23947
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestUpdateTipsController : MissionPanelControllerBase
	{
		// Token: 0x17008E61 RID: 36449
		// (get) Token: 0x0603CC64 RID: 248932 RVA: 0x00E9743D File Offset: 0x00E9563D
		protected override EMissionPanelControllerType ControllerType
		{
			get
			{
				return EMissionPanelControllerType.QuestUpdateTipsController;
			}
		}

		// Token: 0x0603CC65 RID: 248933 RVA: 0x00E97440 File Offset: 0x00E95640
		public QuestUpdateTipsController(LevelSequencePlayer sequencePlayer, BattleQuestUpdateTipsView questUpdateTipsView, Func<bool> checkMissionItemViewShowEmptyHandle, UUIItem missionItemViewRootNode)
		{
			this.SequencePlayer = sequencePlayer;
			this.QuestUpdateTipsView = questUpdateTipsView;
			this.CheckMissionItemViewShowEmptyHandle = checkMissionItemViewShowEmptyHandle;
			this.MissionItemViewRootNode = missionItemViewRootNode;
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0603CC66 RID: 248934 RVA: 0x00E97480 File Offset: 0x00E95680
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

		// Token: 0x0603CC67 RID: 248935 RVA: 0x00E974CF File Offset: 0x00E956CF
		public override void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.QuestUpdateTipsClickTrack, new Action(this.OnQuestUpdateTipsClickTrack));
		}

		// Token: 0x0603CC68 RID: 248936 RVA: 0x00E974ED File Offset: 0x00E956ED
		public override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.QuestUpdateTipsClickTrack, new Action(this.OnQuestUpdateTipsClickTrack));
		}

		// Token: 0x0603CC69 RID: 248937 RVA: 0x00E9750C File Offset: 0x00E9570C
		public void OnPanelShow()
		{
			this.SequencePlayer.ResumeSequence();
			if (TimerSystem.Instance.Has(this.StayTimer) && TimerSystem.Instance.IsPause(this.StayTimer))
			{
				TimerSystem.Instance.Resume(this.StayTimer);
			}
		}

		// Token: 0x0603CC6A RID: 248938 RVA: 0x00E97559 File Offset: 0x00E95759
		public void OnPanelHide()
		{
			this.SequencePlayer.PauseSequence();
			if (TimerSystem.Instance.Has(this.StayTimer))
			{
				TimerSystem.Instance.Pause(this.StayTimer, null);
			}
		}

		// Token: 0x0603CC6B RID: 248939 RVA: 0x00E9758C File Offset: 0x00E9578C
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

		// Token: 0x0603CC6C RID: 248940 RVA: 0x00E975D7 File Offset: 0x00E957D7
		private void SetQuestUpdateTipsViewVisible(bool bVisible)
		{
			this.QuestUpdateTipsView.SetUiActive(bVisible);
			this.MissionItemViewRootNode.SetUIActive(!bVisible);
		}

		// Token: 0x0603CC6D RID: 248941 RVA: 0x00E975F4 File Offset: 0x00E957F4
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

		// Token: 0x0603CC6E RID: 248942 RVA: 0x00E97644 File Offset: 0x00E95844
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

		// Token: 0x0603CC6F RID: 248943 RVA: 0x00E97718 File Offset: 0x00E95918
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

		// Token: 0x0603CC70 RID: 248944 RVA: 0x00E97774 File Offset: 0x00E95974
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

		// Token: 0x0401FA87 RID: 129671
		private EQuestUpdateTipsStep MissionSequenceType;

		// Token: 0x0401FA88 RID: 129672
		[Nullable(2)]
		private TimerHandle StayTimer;

		// Token: 0x0401FA89 RID: 129673
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateStartMissionOutPromise;

		// Token: 0x0401FA8A RID: 129674
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateStartMissionInPromise;

		// Token: 0x0401FA8B RID: 129675
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateStayPromise;

		// Token: 0x0401FA8C RID: 129676
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateEndMissionOutPromise;

		// Token: 0x0401FA8D RID: 129677
		[Nullable(2)]
		private CustomPromise<bool> QuestUpdateEndMissionInPromise;

		// Token: 0x0401FA8E RID: 129678
		private bool QuestUpdateTipsTrackBtnClick;

		// Token: 0x0401FA8F RID: 129679
		private readonly LevelSequencePlayer SequencePlayer;

		// Token: 0x0401FA90 RID: 129680
		private readonly BattleQuestUpdateTipsView QuestUpdateTipsView;

		// Token: 0x0401FA91 RID: 129681
		private readonly Func<bool> CheckMissionItemViewShowEmptyHandle;

		// Token: 0x0401FA92 RID: 129682
		private readonly UUIItem MissionItemViewRootNode;
	}
}
