using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F3D RID: 24381
	public class LevelAiTaskMoveAlong : LevelAiTask
	{
		// Token: 0x0603AA1E RID: 240158 RVA: 0x01091894 File Offset: 0x0108FA94
		protected override ELevelAiNodeResult ExecuteTask()
		{
			this.MoveComp = base.CreatureDataComponent.Entity.GetComponent<BaseMoveComponent>();
			if (this.MoveComp == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			MoveCharacterConfig config = new MoveCharacterConfig
			{
				Points = this.PathPoint,
				Navigation = this.Navigation,
				IsFly = false,
				DebugMode = true,
				Loop = false,
				Callback = new Action<ELevelEventState>(this.TaskFinishCallBack),
				UsePreviousIndex = new bool?(true),
				UseNearestPoint = new bool?(true),
				ReturnFalseWhenNavigationFailed = false,
				ResetAllPoints = new bool?(this.ResetAllPoints)
			};
			this.MoveComp.MoveAlongPath(config, "LevelAiTaskMoveAlong.ExecuteTask");
			return ELevelAiNodeResult.InProgress;
		}

		// Token: 0x0603AA1F RID: 240159 RVA: 0x0109194E File Offset: 0x0108FB4E
		protected override ELevelAiNodeResult AbortTask()
		{
			this.MoveComp.StopMoveNew("LevelAiTaskMoveAlong.AbortTask");
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x0603AA20 RID: 240160 RVA: 0x01091961 File Offset: 0x0108FB61
		private void TaskFinishCallBack(ELevelEventState result)
		{
			this.MoveComp.StopMoveNew("LevelAiTaskMoveAlong.TaskFinishCallBack");
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

		// Token: 0x0401ECF5 RID: 126197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MoveCharacterPoint> PathPoint;

		// Token: 0x0401ECF6 RID: 126198
		public bool Navigation = true;

		// Token: 0x0401ECF7 RID: 126199
		public bool ResetAllPoints;

		// Token: 0x0401ECF8 RID: 126200
		[Nullable(2)]
		private BaseMoveComponent MoveComp;
	}
}
