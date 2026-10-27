using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DBF RID: 28095
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelAiTaskMoveTo : LevelAiTask
	{
		// Token: 0x060448BE RID: 280766 RVA: 0x010E7774 File Offset: 0x010E5974
		protected override ELevelAiNodeResult ExecuteTask()
		{
			this.MoveComp = base.CreatureDataComponent.Entity.GetComponent<BaseMoveComponent>();
			if (this.MoveComp == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
			{
				Index = 0,
				Position = this.Target,
				MoveSpeed = new float?(this.MoveSpeed),
				MoveState = new EPatrolMoveState?((EPatrolMoveState)this.MoveState)
			};
			MoveCharacterConfig config = new MoveCharacterConfig
			{
				Points = new MoveCharacterPoint[]
				{
					moveCharacterPoint
				},
				Navigation = true,
				IsFly = false,
				DebugMode = true,
				Loop = false,
				Callback = new Action<ELevelEventState>(this.TaskFinishCallBack),
				ReturnFalseWhenNavigationFailed = false
			};
			this.MoveComp.MoveAlongPath(config, "LevelAiTaskMoveTo.ExecuteTask");
			return ELevelAiNodeResult.InProgress;
		}

		// Token: 0x060448BF RID: 280767 RVA: 0x010E7841 File Offset: 0x010E5A41
		protected override ELevelAiNodeResult AbortTask()
		{
			this.MoveComp.StopMoveNew("LevelAiTaskMoveTo.AbortTask");
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x060448C0 RID: 280768 RVA: 0x010E7854 File Offset: 0x010E5A54
		private void TaskFinishCallBack(ELevelEventState result)
		{
			this.MoveComp.StopMoveNew("LevelAiTaskMoveTo.TaskFinishCallBack");
			if (result == ELevelEventState.Success)
			{
				base.FinishLatentTask(ELevelAiNodeResult.Succeeded);
				return;
			}
			if (result - ELevelEventState.Failure > 1)
			{
				return;
			}
			base.FinishLatentTask(ELevelAiNodeResult.Failed);
		}

		// Token: 0x04023A57 RID: 146007
		public Vector Target;

		// Token: 0x04023A58 RID: 146008
		public EMoveSpeed MoveState = EMoveSpeed.Run;

		// Token: 0x04023A59 RID: 146009
		public float MoveSpeed;

		// Token: 0x04023A5A RID: 146010
		private BaseMoveComponent MoveComp;
	}
}
