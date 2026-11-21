using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals
{
	// Token: 0x020054A0 RID: 21664
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LevelGoal : ISolvedSequencesConsumer
	{
		// Token: 0x17006882 RID: 26754
		// (get) Token: 0x06035B95 RID: 220053 RVA: 0x00F02BFB File Offset: 0x00F00DFB
		// (set) Token: 0x06035B96 RID: 220054 RVA: 0x00F02C03 File Offset: 0x00F00E03
		public bool IsAchieved { get; protected set; }

		// Token: 0x17006883 RID: 26755
		// (get) Token: 0x06035B97 RID: 220055 RVA: 0x00F02C0C File Offset: 0x00F00E0C
		public EGoalCondType CondType { get; }

		// Token: 0x06035B98 RID: 220056
		public abstract void OnSequencesSolved(SolvedData solved);

		// Token: 0x17006884 RID: 26756
		// (get) Token: 0x06035B99 RID: 220057 RVA: 0x00F02C14 File Offset: 0x00F00E14
		// (set) Token: 0x06035B9A RID: 220058 RVA: 0x00F02C1C File Offset: 0x00F00E1C
		public int TierIndex { get; private set; }

		// Token: 0x17006885 RID: 26757
		// (get) Token: 0x06035B9B RID: 220059 RVA: 0x00F02C25 File Offset: 0x00F00E25
		// (set) Token: 0x06035B9C RID: 220060 RVA: 0x00F02C2D File Offset: 0x00F00E2D
		public int Current { get; protected set; }

		// Token: 0x17006886 RID: 26758
		// (get) Token: 0x06035B9D RID: 220061 RVA: 0x00F02C36 File Offset: 0x00F00E36
		public int Target
		{
			get
			{
				if (this.TargetTiers.Length == 0)
				{
					return 0;
				}
				return this.TargetTiers[this.TierIndex];
			}
		}

		// Token: 0x06035B9E RID: 220062 RVA: 0x00F02C50 File Offset: 0x00F00E50
		protected LevelGoal(EGoalCondType condType, int[] targetTiers)
		{
			this.CondType = condType;
			this.TargetTiers = targetTiers;
		}

		// Token: 0x17006887 RID: 26759
		// (get) Token: 0x06035B9F RID: 220063 RVA: 0x00F02C66 File Offset: 0x00F00E66
		public bool CanLowerDifficulty
		{
			get
			{
				return this.TierIndex + 1 < this.TargetTiers.Length;
			}
		}

		// Token: 0x06035BA0 RID: 220064 RVA: 0x00F02C7C File Offset: 0x00F00E7C
		public void LowerDifficulty()
		{
			if (!this.CanLowerDifficulty)
			{
				return;
			}
			int tierIndex = this.TierIndex;
			this.TierIndex = tierIndex + 1;
		}

		// Token: 0x06035BA1 RID: 220065 RVA: 0x00F02CA2 File Offset: 0x00F00EA2
		protected void MarkAchieved()
		{
			if (this.IsAchieved)
			{
				return;
			}
			this.IsAchieved = true;
			Action<LevelGoal> achieved = this.Achieved;
			if (achieved == null)
			{
				return;
			}
			achieved(this);
		}

		// Token: 0x06035BA2 RID: 220066 RVA: 0x00F02CC5 File Offset: 0x00F00EC5
		public virtual void Reset()
		{
			this.IsAchieved = false;
			this.Current = 0;
		}

		// Token: 0x0401C714 RID: 116500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<LevelGoal> Achieved;

		// Token: 0x0401C716 RID: 116502
		private readonly int[] TargetTiers;
	}
}
