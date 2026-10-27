using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals
{
	// Token: 0x02006522 RID: 25890
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LevelGoal : ISolvedSequencesConsumer
	{
		// Token: 0x17009520 RID: 38176
		// (get) Token: 0x06040ED1 RID: 265937 RVA: 0x00FBBBCB File Offset: 0x00FB9DCB
		// (set) Token: 0x06040ED2 RID: 265938 RVA: 0x00FBBBD3 File Offset: 0x00FB9DD3
		public bool IsAchieved { get; protected set; }

		// Token: 0x17009521 RID: 38177
		// (get) Token: 0x06040ED3 RID: 265939 RVA: 0x00FBBBDC File Offset: 0x00FB9DDC
		public EGoalCondType CondType { get; }

		// Token: 0x06040ED4 RID: 265940
		public abstract void OnSequencesSolved(SolvedData solved);

		// Token: 0x17009522 RID: 38178
		// (get) Token: 0x06040ED5 RID: 265941 RVA: 0x00FBBBE4 File Offset: 0x00FB9DE4
		// (set) Token: 0x06040ED6 RID: 265942 RVA: 0x00FBBBEC File Offset: 0x00FB9DEC
		public int TierIndex { get; private set; }

		// Token: 0x17009523 RID: 38179
		// (get) Token: 0x06040ED7 RID: 265943 RVA: 0x00FBBBF5 File Offset: 0x00FB9DF5
		// (set) Token: 0x06040ED8 RID: 265944 RVA: 0x00FBBBFD File Offset: 0x00FB9DFD
		public int Current { get; protected set; }

		// Token: 0x17009524 RID: 38180
		// (get) Token: 0x06040ED9 RID: 265945 RVA: 0x00FBBC06 File Offset: 0x00FB9E06
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

		// Token: 0x06040EDA RID: 265946 RVA: 0x00FBBC20 File Offset: 0x00FB9E20
		protected LevelGoal(EGoalCondType condType, int[] targetTiers)
		{
			this.CondType = condType;
			this.TargetTiers = targetTiers;
		}

		// Token: 0x17009525 RID: 38181
		// (get) Token: 0x06040EDB RID: 265947 RVA: 0x00FBBC36 File Offset: 0x00FB9E36
		public bool CanLowerDifficulty
		{
			get
			{
				return this.TierIndex + 1 < this.TargetTiers.Length;
			}
		}

		// Token: 0x06040EDC RID: 265948 RVA: 0x00FBBC4C File Offset: 0x00FB9E4C
		public void LowerDifficulty()
		{
			if (!this.CanLowerDifficulty)
			{
				return;
			}
			int tierIndex = this.TierIndex;
			this.TierIndex = tierIndex + 1;
		}

		// Token: 0x06040EDD RID: 265949 RVA: 0x00FBBC72 File Offset: 0x00FB9E72
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

		// Token: 0x06040EDE RID: 265950 RVA: 0x00FBBC95 File Offset: 0x00FB9E95
		public virtual void Reset()
		{
			this.IsAchieved = false;
			this.Current = 0;
		}

		// Token: 0x04021DE3 RID: 138723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<LevelGoal> Achieved;

		// Token: 0x04021DE5 RID: 138725
		private readonly int[] TargetTiers;
	}
}
