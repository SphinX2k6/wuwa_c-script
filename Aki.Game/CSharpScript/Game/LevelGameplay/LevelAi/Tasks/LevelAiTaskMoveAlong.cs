using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DBE RID: 28094
	public class LevelAiTaskMoveAlong : LevelAiTask
	{
		// Token: 0x060448BA RID: 280762 RVA: 0x010E766C File Offset: 0x010E586C
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

		// Token: 0x060448BB RID: 280763 RVA: 0x010E7726 File Offset: 0x010E5926
		protected override ELevelAiNodeResult AbortTask()
		{
			this.MoveComp.StopMoveNew("LevelAiTaskMoveAlong.AbortTask");
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x060448BC RID: 280764 RVA: 0x010E7739 File Offset: 0x010E5939
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

		// Token: 0x04023A53 RID: 146003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MoveCharacterPoint> PathPoint;

		// Token: 0x04023A54 RID: 146004
		public bool Navigation = true;

		// Token: 0x04023A55 RID: 146005
		public bool ResetAllPoints;

		// Token: 0x04023A56 RID: 146006
		[Nullable(2)]
		private BaseMoveComponent MoveComp;
	}
}
