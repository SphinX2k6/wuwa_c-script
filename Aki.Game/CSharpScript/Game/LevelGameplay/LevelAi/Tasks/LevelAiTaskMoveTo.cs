using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F3E RID: 24382
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelAiTaskMoveTo : LevelAiTask
	{
		// Token: 0x0603AA22 RID: 240162 RVA: 0x0109199C File Offset: 0x0108FB9C
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

		// Token: 0x0603AA23 RID: 240163 RVA: 0x01091A69 File Offset: 0x0108FC69
		protected override ELevelAiNodeResult AbortTask()
		{
			this.MoveComp.StopMoveNew("LevelAiTaskMoveTo.AbortTask");
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x0603AA24 RID: 240164 RVA: 0x01091A7C File Offset: 0x0108FC7C
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

		// Token: 0x0401ECF9 RID: 126201
		public Vector Target;

		// Token: 0x0401ECFA RID: 126202
		public EMoveSpeed MoveState = EMoveSpeed.Run;

		// Token: 0x0401ECFB RID: 126203
		public float MoveSpeed;

		// Token: 0x0401ECFC RID: 126204
		private BaseMoveComponent MoveComp;
	}
}
