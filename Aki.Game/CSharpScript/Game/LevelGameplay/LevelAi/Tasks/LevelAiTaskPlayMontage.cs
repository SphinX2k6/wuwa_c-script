using System;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F40 RID: 24384
	public class LevelAiTaskPlayMontage : LevelAiTask
	{
		// Token: 0x0603AA2A RID: 240170 RVA: 0x01091CBC File Offset: 0x0108FEBC
		protected override ELevelAiNodeResult ExecuteTask()
		{
			PlayRegisteredMontage @params = this.Params as PlayRegisteredMontage;
			if (@params == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			this.LoopDuration = @params.LoopDuration.GetValueOrDefault();
			this.RepeatTimes = @params.RepeatTimes.GetValueOrDefault();
			Entity entity = base.CreatureDataComponent.Entity;
			BasePerformComponent component = entity.GetComponent<BasePerformComponent>();
			IMontageId montage2 = new IMontageId
			{
				IsAbp = @params.IsAbpMontage,
				MontageId = @params.MontageId
			};
			IAnimStateParam montageStateParam = component.GetMontageStateParam(montage2);
			string montagePath = component.GetMontagePath(montage2);
			if (montagePath == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			bool hasProgress = false;
			this.MontagePlayId = component.VolatileMontagePlayByLoad(EPerformMode.Ecology, montagePath, montageStateParam, delegate(UAnimMontage montage)
			{
				if (montage != null && @params.FaceExpressionId != null)
				{
					Entity entity = entity;
					CommonNpcPerformComponent commonNpcPerformComponent = (entity != null) ? entity.GetComponent<CommonNpcPerformComponent>() : null;
					if (commonNpcPerformComponent == null)
					{
						return;
					}
					NpcFacialExpressionController expressionController = commonNpcPerformComponent.ExpressionController;
					if (expressionController == null)
					{
						return;
					}
					expressionController.ChangeFaceForExpression(montage, new int?(@params.FaceExpressionId.Value));
				}
			}, delegate(UAnimMontage montage, bool _)
			{
				if (hasProgress)
				{
					this.FinishLatentTask(ELevelAiNodeResult.Succeeded);
					return;
				}
				hasProgress = true;
			}, new float?(this.LoopDuration), new float?((float)this.RepeatTimes), new bool?(false), new bool?(false), new bool?(false));
			if (hasProgress)
			{
				return ELevelAiNodeResult.Succeeded;
			}
			hasProgress = true;
			return ELevelAiNodeResult.InProgress;
		}

		// Token: 0x0603AA2B RID: 240171 RVA: 0x01091DEB File Offset: 0x0108FFEB
		protected override ELevelAiNodeResult AbortTask()
		{
			base.CreatureDataComponent.Entity.GetComponent<BasePerformComponent>().VolatileMontageStopByLoad(EPerformMode.Ecology, this.MontagePlayId, EStopMethod.BlendOut);
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x0401ECFD RID: 126205
		private float LoopDuration;

		// Token: 0x0401ECFE RID: 126206
		private int RepeatTimes;

		// Token: 0x0401ECFF RID: 126207
		private int MontagePlayId = -1;
	}
}
