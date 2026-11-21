using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049AB RID: 18859
	public class FinishArcadeGameplayNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3C7 RID: 193479 RVA: 0x00D2C03F File Offset: 0x00D2A23F
		public FinishArcadeGameplayNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F3C8 RID: 193480 RVA: 0x00D2C048 File Offset: 0x00D2A248
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			IFinishArcadeGameplay finishArcadeGameplay = childQuestBtNode.Condition as IFinishArcadeGameplay;
			if (finishArcadeGameplay == null)
			{
				return false;
			}
			this.GameplayType = new EArcadeGameplayType?(finishArcadeGameplay.ArcadeGameplay.Type);
			IArcadeGameplayBase arcadeGameplay = finishArcadeGameplay.ArcadeGameplay;
			IArcadeGameplayDropCatch arcadeGameplayDropCatch = arcadeGameplay as IArcadeGameplayDropCatch;
			int levelId;
			if (arcadeGameplayDropCatch == null)
			{
				IArcadeGameplayTetrisBoardGame arcadeGameplayTetrisBoardGame = arcadeGameplay as IArcadeGameplayTetrisBoardGame;
				if (arcadeGameplayTetrisBoardGame == null)
				{
					levelId = 0;
				}
				else
				{
					levelId = arcadeGameplayTetrisBoardGame.LevelId;
				}
			}
			else
			{
				levelId = arcadeGameplayDropCatch.LevelId;
			}
			this.LevelId = levelId;
			return true;
		}

		// Token: 0x0602F3C9 RID: 193481 RVA: 0x00D2C0D3 File Offset: 0x00D2A2D3
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.GameplayType = null;
			this.LevelId = 0;
		}

		// Token: 0x0602F3CA RID: 193482 RVA: 0x00D2C0EE File Offset: 0x00D2A2EE
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<EArcadeGameplayType, int>(EEventName.OnArcadeGameplayFinish, new Action<EArcadeGameplayType, int>(this.OnGameplayFinish));
		}

		// Token: 0x0602F3CB RID: 193483 RVA: 0x00D2C112 File Offset: 0x00D2A312
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<EArcadeGameplayType, int>(EEventName.OnArcadeGameplayFinish, new Action<EArcadeGameplayType, int>(this.OnGameplayFinish));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0602F3CC RID: 193484 RVA: 0x00D2C138 File Offset: 0x00D2A338
		private void OnGameplayFinish(EArcadeGameplayType type, int levelId)
		{
			if (this.GameplayType == null)
			{
				return;
			}
			EArcadeGameplayType? gameplayType = this.GameplayType;
			if (!(gameplayType.GetValueOrDefault() == type & gameplayType != null))
			{
				return;
			}
			if (this.LevelId == 0 || levelId == this.LevelId)
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0602F3CD RID: 193485 RVA: 0x00D2C189 File Offset: 0x00D2A389
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.GameplayType = null;
				this.LevelId = 0;
			}
		}

		// Token: 0x040190D8 RID: 102616
		private EArcadeGameplayType? GameplayType;

		// Token: 0x040190D9 RID: 102617
		private int LevelId;
	}
}
