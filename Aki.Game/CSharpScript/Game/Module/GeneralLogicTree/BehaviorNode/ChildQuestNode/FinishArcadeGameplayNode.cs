using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D2 RID: 22994
	public class FinishArcadeGameplayNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4A0 RID: 238752 RVA: 0x00DDC85F File Offset: 0x00DDAA5F
		public FinishArcadeGameplayNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4A1 RID: 238753 RVA: 0x00DDC868 File Offset: 0x00DDAA68
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

		// Token: 0x0603A4A2 RID: 238754 RVA: 0x00DDC8F3 File Offset: 0x00DDAAF3
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.GameplayType = null;
			this.LevelId = 0;
		}

		// Token: 0x0603A4A3 RID: 238755 RVA: 0x00DDC90E File Offset: 0x00DDAB0E
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<EArcadeGameplayType, int>(EEventName.OnArcadeGameplayFinish, new Action<EArcadeGameplayType, int>(this.OnGameplayFinish));
		}

		// Token: 0x0603A4A4 RID: 238756 RVA: 0x00DDC932 File Offset: 0x00DDAB32
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<EArcadeGameplayType, int>(EEventName.OnArcadeGameplayFinish, new Action<EArcadeGameplayType, int>(this.OnGameplayFinish));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0603A4A5 RID: 238757 RVA: 0x00DDC958 File Offset: 0x00DDAB58
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

		// Token: 0x0603A4A6 RID: 238758 RVA: 0x00DDC9A9 File Offset: 0x00DDABA9
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.GameplayType = null;
				this.LevelId = 0;
			}
		}

		// Token: 0x0401E639 RID: 124473
		private EArcadeGameplayType? GameplayType;

		// Token: 0x0401E63A RID: 124474
		private int LevelId;
	}
}
