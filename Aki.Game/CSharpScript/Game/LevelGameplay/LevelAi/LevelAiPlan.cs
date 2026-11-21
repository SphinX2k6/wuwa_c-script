using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F30 RID: 24368
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlan
	{
		// Token: 0x0603A993 RID: 240019 RVA: 0x0108F223 File Offset: 0x0108D423
		public LevelAiPlan(LevelAi asset, [Nullable(2)] LevelAiWorldState worldStateAtLevelStart)
		{
			this.LevelAiAsset = asset;
			if (worldStateAtLevelStart != null)
			{
				this.Levels.Add(new LevelAiPlanLevel(worldStateAtLevelStart, null));
			}
			this.Cost = 0;
		}

		// Token: 0x0603A994 RID: 240020 RVA: 0x0108F259 File Offset: 0x0108D459
		public bool HasLevel(int levelIndex)
		{
			return levelIndex < this.Levels.Count && this.Levels[levelIndex] != null;
		}

		// Token: 0x0603A995 RID: 240021 RVA: 0x0108F27C File Offset: 0x0108D47C
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

		// Token: 0x0603A996 RID: 240022 RVA: 0x0108F30C File Offset: 0x0108D50C
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

		// Token: 0x0603A997 RID: 240023 RVA: 0x0108F35C File Offset: 0x0108D55C
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

		// Token: 0x0603A998 RID: 240024 RVA: 0x0108F38C File Offset: 0x0108D58C
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

		// Token: 0x0603A999 RID: 240025 RVA: 0x0108F428 File Offset: 0x0108D628
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

		// Token: 0x0603A99A RID: 240026 RVA: 0x0108F498 File Offset: 0x0108D698
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

		// Token: 0x0603A99B RID: 240027 RVA: 0x0108F534 File Offset: 0x0108D734
		public LevelAiWorldState GetWorldState(LevelAiPlanStepId stepId)
		{
			LevelAiPlanLevel levelAiPlanLevel = this.Levels[stepId.LevelIndex];
			if (stepId.StepIndex == -1)
			{
				return levelAiPlanLevel.WorldStateAtLevelStart;
			}
			return levelAiPlanLevel.Steps[stepId.StepIndex].WorldState;
		}

		// Token: 0x0603A99C RID: 240028 RVA: 0x0108F57C File Offset: 0x0108D77C
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

		// Token: 0x0603A99D RID: 240029 RVA: 0x0108F5EC File Offset: 0x0108D7EC
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

		// Token: 0x0401ECBF RID: 126143
		private readonly LevelAi LevelAiAsset;

		// Token: 0x0401ECC0 RID: 126144
		public List<LevelAiPlanLevel> Levels = new List<LevelAiPlanLevel>();

		// Token: 0x0401ECC1 RID: 126145
		public int Cost;
	}
}
