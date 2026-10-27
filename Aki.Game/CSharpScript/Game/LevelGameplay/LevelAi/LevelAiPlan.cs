using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB1 RID: 28081
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlan
	{
		// Token: 0x0604482F RID: 280623 RVA: 0x010E4FFB File Offset: 0x010E31FB
		public LevelAiPlan(LevelAi asset, [Nullable(2)] LevelAiWorldState worldStateAtLevelStart)
		{
			this.LevelAiAsset = asset;
			if (worldStateAtLevelStart != null)
			{
				this.Levels.Add(new LevelAiPlanLevel(worldStateAtLevelStart, null));
			}
			this.Cost = 0;
		}

		// Token: 0x06044830 RID: 280624 RVA: 0x010E5031 File Offset: 0x010E3231
		public bool HasLevel(int levelIndex)
		{
			return levelIndex < this.Levels.Count && this.Levels[levelIndex] != null;
		}

		// Token: 0x06044831 RID: 280625 RVA: 0x010E5054 File Offset: 0x010E3254
		public bool HasStep(LevelAiPlanStepId stepId, int levelIndex = 0)
		{
			if (!this.HasLevel(stepId.LevelIndex) || !this.HasLevel(levelIndex))
			{
				return false;
			}
			if (stepId.LevelIndex == levelIndex)
			{
				LevelAiPlanLevel levelAiPlanLevel = this.Levels[levelIndex];
				return stepId.StepIndex < levelAiPlanLevel.Steps.Count && levelAiPlanLevel.Steps[stepId.StepIndex] != null;
			}
			return stepId.LevelIndex != 0 && this.HasStep(this.Levels[stepId.LevelIndex].ParentStepId, levelIndex);
		}

		// Token: 0x06044832 RID: 280626 RVA: 0x010E50E4 File Offset: 0x010E32E4
		[return: Nullable(2)]
		public LevelAiPlanStep GetStep(LevelAiPlanStepId stepId)
		{
			if (stepId == null)
			{
				return null;
			}
			if (stepId.LevelIndex >= this.Levels.Count)
			{
				return null;
			}
			LevelAiPlanLevel levelAiPlanLevel = this.Levels[stepId.LevelIndex];
			if (levelAiPlanLevel == null)
			{
				return null;
			}
			return levelAiPlanLevel.Steps[stepId.StepIndex];
		}

		// Token: 0x06044833 RID: 280627 RVA: 0x010E5134 File Offset: 0x010E3334
		public bool IsComplete()
		{
			for (int i = 0; i < this.Levels.Count; i++)
			{
				if (!this.IsLevelComplete(i))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06044834 RID: 280628 RVA: 0x010E5164 File Offset: 0x010E3364
		public bool IsLevelComplete(int levelIndex)
		{
			if (!this.HasLevel(levelIndex))
			{
				return false;
			}
			LevelAiPlanLevel levelAiPlanLevel = this.Levels[levelIndex];
			if (levelAiPlanLevel.Steps.Count == 0)
			{
				return false;
			}
			int index = levelAiPlanLevel.Steps.Count - 1;
			LevelAiPlanStep levelAiPlanStep = levelAiPlanLevel.Steps[index];
			bool flag = levelAiPlanStep.SubLevelIndex != -1;
			if (flag || (levelAiPlanStep.Node != null && !levelAiPlanStep.Node.PlanNextNodesAfterThis))
			{
				return !flag || this.IsLevelComplete(levelAiPlanStep.SubLevelIndex);
			}
			return levelAiPlanStep.Node.NextNodes.Count == 0;
		}

		// Token: 0x06044835 RID: 280629 RVA: 0x010E5200 File Offset: 0x010E3400
		public bool FindStepToAddAfter(LevelAiPlanStepId outPlanStepId)
		{
			for (int i = this.Levels.Count - 1; i >= 0; i--)
			{
				if (!this.IsLevelComplete(i))
				{
					LevelAiPlanLevel levelAiPlanLevel = this.Levels[i];
					outPlanStepId.LevelIndex = i;
					outPlanStepId.StepIndex = ((levelAiPlanLevel.Steps.Count > 0) ? (levelAiPlanLevel.Steps.Count - 1) : -1);
					return true;
				}
			}
			outPlanStepId.Reset();
			return false;
		}

		// Token: 0x06044836 RID: 280630 RVA: 0x010E5270 File Offset: 0x010E3470
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IEnumerable<LevelAiStandaloneNode> GetNextNodes(LevelAiPlanStepId stepId)
		{
			LevelAiPlanLevel levelAiPlanLevel = this.Levels[stepId.LevelIndex];
			if (stepId.StepIndex != -1)
			{
				return levelAiPlanLevel.Steps[stepId.StepIndex].Node.NextNodes;
			}
			if (levelAiPlanLevel.ParentStepId.Equal(LevelAiPlanStepId.None))
			{
				return this.LevelAiAsset.StartNodes;
			}
			LevelAiPlanStep step = this.GetStep(levelAiPlanLevel.ParentStepId);
			if (step == null)
			{
				Log.Instance.Error(ELogModule.LevelAi, ELogAuthor.CJH, "子层的父节点未定义", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return step.Node.NextNodes;
		}

		// Token: 0x06044837 RID: 280631 RVA: 0x010E530C File Offset: 0x010E350C
		public LevelAiWorldState GetWorldState(LevelAiPlanStepId stepId)
		{
			LevelAiPlanLevel levelAiPlanLevel = this.Levels[stepId.LevelIndex];
			if (stepId.StepIndex == -1)
			{
				return levelAiPlanLevel.WorldStateAtLevelStart;
			}
			return levelAiPlanLevel.Steps[stepId.StepIndex].WorldState;
		}

		// Token: 0x06044838 RID: 280632 RVA: 0x010E5354 File Offset: 0x010E3554
		public LevelAiPlan MakeCopy()
		{
			LevelAiPlan levelAiPlan = new LevelAiPlan(this.LevelAiAsset, null);
			levelAiPlan.Levels.Capacity = this.Levels.Count;
			for (int i = 0; i < this.Levels.Count; i++)
			{
				levelAiPlan.Levels.Add(this.Levels[i].MakeCopy());
			}
			levelAiPlan.Cost = this.Cost;
			return levelAiPlan;
		}

		// Token: 0x06044839 RID: 280633 RVA: 0x010E53C4 File Offset: 0x010E35C4
		public void GetSubNodesAtPlanStep(LevelAiPlanStepId stepId, List<SubNodesInfo> outSubNodesInfoGroup)
		{
			if (!this.HasStep(stepId, 0))
			{
				return;
			}
			LevelAiPlanStepId levelAiPlanStepId = stepId;
			for (;;)
			{
				LevelAiPlanLevel levelAiPlanLevel = this.Levels[levelAiPlanStepId.LevelIndex];
				LevelAiPlanStep levelAiPlanStep = levelAiPlanLevel.Steps[levelAiPlanStepId.StepIndex];
				outSubNodesInfoGroup.Add(levelAiPlanStep.SubNodesInfo);
				outSubNodesInfoGroup.Add(levelAiPlanLevel.RootSubNodesInfo);
				if (levelAiPlanStepId.LevelIndex <= 0)
				{
					break;
				}
				levelAiPlanStepId = levelAiPlanLevel.ParentStepId;
			}
		}

		// Token: 0x04023A1D RID: 145949
		private readonly LevelAi LevelAiAsset;

		// Token: 0x04023A1E RID: 145950
		public List<LevelAiPlanLevel> Levels = new List<LevelAiPlanLevel>();

		// Token: 0x04023A1F RID: 145951
		public int Cost;
	}
}
