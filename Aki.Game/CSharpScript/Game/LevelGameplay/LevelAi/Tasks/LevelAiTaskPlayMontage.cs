using System;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC1 RID: 28097
	public class LevelAiTaskPlayMontage : LevelAiTask
	{
		// Token: 0x060448C6 RID: 280774 RVA: 0x010E7A7C File Offset: 0x010E5C7C
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

		// Token: 0x060448C7 RID: 280775 RVA: 0x010E7BAB File Offset: 0x010E5DAB
		protected override ELevelAiNodeResult AbortTask()
		{
			base.CreatureDataComponent.Entity.GetComponent<BasePerformComponent>().VolatileMontageStopByLoad(EPerformMode.Ecology, this.MontagePlayId, EStopMethod.BlendOut);
			return ELevelAiNodeResult.Aborted;
		}

		// Token: 0x04023A5B RID: 146011
		private float LoopDuration;

		// Token: 0x04023A5C RID: 146012
		private int RepeatTimes;

		// Token: 0x04023A5D RID: 146013
		private int MontagePlayId = -1;
	}
}
