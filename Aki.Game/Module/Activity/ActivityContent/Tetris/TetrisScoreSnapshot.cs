using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB5 RID: 12213
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisScoreSnapshot : IEquatable<TetrisScoreSnapshot>
	{
		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0601CFCA RID: 118730 RVA: 0x008DA910 File Offset: 0x008D8B10
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TetrisScoreSnapshot);
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0601CFCB RID: 118731 RVA: 0x008DA91C File Offset: 0x008D8B1C
		// (set) Token: 0x0601CFCC RID: 118732 RVA: 0x008DA924 File Offset: 0x008D8B24
		public int CurrentScore { get; set; }

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0601CFCD RID: 118733 RVA: 0x008DA92D File Offset: 0x008D8B2D
		// (set) Token: 0x0601CFCE RID: 118734 RVA: 0x008DA935 File Offset: 0x008D8B35
		public int LastClearTurn { get; set; }

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0601CFCF RID: 118735 RVA: 0x008DA93E File Offset: 0x008D8B3E
		// (set) Token: 0x0601CFD0 RID: 118736 RVA: 0x008DA946 File Offset: 0x008D8B46
		public int ComboCount { get; set; }

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0601CFD1 RID: 118737 RVA: 0x008DA94F File Offset: 0x008D8B4F
		// (set) Token: 0x0601CFD2 RID: 118738 RVA: 0x008DA957 File Offset: 0x008D8B57
		public int MaxComboCount { get; set; }

		// Token: 0x0601CFD3 RID: 118739 RVA: 0x008DA960 File Offset: 0x008D8B60
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisScoreSnapshot");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CFD4 RID: 118740 RVA: 0x008DA9AC File Offset: 0x008D8BAC
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("CurrentScore = ");
			builder.Append(this.CurrentScore.ToString());
			builder.Append(", LastClearTurn = ");
			builder.Append(this.LastClearTurn.ToString());
			builder.Append(", ComboCount = ");
			builder.Append(this.ComboCount.ToString());
			builder.Append(", MaxComboCount = ");
			builder.Append(this.MaxComboCount.ToString());
			return true;
		}

		// Token: 0x0601CFD5 RID: 118741 RVA: 0x008DAA5B File Offset: 0x008D8C5B
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TetrisScoreSnapshot left, TetrisScoreSnapshot right)
		{
			return !(left == right);
		}

		// Token: 0x0601CFD6 RID: 118742 RVA: 0x008DAA67 File Offset: 0x008D8C67
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TetrisScoreSnapshot left, TetrisScoreSnapshot right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601CFD7 RID: 118743 RVA: 0x008DAA7C File Offset: 0x008D8C7C
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<CurrentScore>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<LastClearTurn>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<ComboCount>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<MaxComboCount>k__BackingField);
		}

		// Token: 0x0601CFD8 RID: 118744 RVA: 0x008DAAF5 File Offset: 0x008D8CF5
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TetrisScoreSnapshot);
		}

		// Token: 0x0601CFD9 RID: 118745 RVA: 0x008DAB04 File Offset: 0x008D8D04
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TetrisScoreSnapshot other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<CurrentScore>k__BackingField, other.<CurrentScore>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<LastClearTurn>k__BackingField, other.<LastClearTurn>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<ComboCount>k__BackingField, other.<ComboCount>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<MaxComboCount>k__BackingField, other.<MaxComboCount>k__BackingField));
		}

		// Token: 0x0601CFDB RID: 118747 RVA: 0x008DAB95 File Offset: 0x008D8D95
		[CompilerGenerated]
		protected TetrisScoreSnapshot(TetrisScoreSnapshot original)
		{
			this.CurrentScore = original.<CurrentScore>k__BackingField;
			this.LastClearTurn = original.<LastClearTurn>k__BackingField;
			this.ComboCount = original.<ComboCount>k__BackingField;
			this.MaxComboCount = original.<MaxComboCount>k__BackingField;
		}

		// Token: 0x0601CFDC RID: 118748 RVA: 0x008DABCD File Offset: 0x008D8DCD
		public TetrisScoreSnapshot()
		{
		}
	}
}
