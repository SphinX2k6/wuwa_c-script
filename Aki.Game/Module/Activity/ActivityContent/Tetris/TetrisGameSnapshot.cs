using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB9 RID: 12217
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TetrisGameSnapshot : IEquatable<TetrisGameSnapshot>
	{
		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0601D003 RID: 118787 RVA: 0x008DB341 File Offset: 0x008D9541
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TetrisGameSnapshot);
			}
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0601D004 RID: 118788 RVA: 0x008DB34D File Offset: 0x008D954D
		// (set) Token: 0x0601D005 RID: 118789 RVA: 0x008DB355 File Offset: 0x008D9555
		[RequiredMember]
		public TetrisCellData[,] BoardCells { get; set; }

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0601D006 RID: 118790 RVA: 0x008DB35E File Offset: 0x008D955E
		// (set) Token: 0x0601D007 RID: 118791 RVA: 0x008DB366 File Offset: 0x008D9566
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[RequiredMember]
		public List<BlockInstance> HandShapes { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0601D008 RID: 118792 RVA: 0x008DB36F File Offset: 0x008D956F
		// (set) Token: 0x0601D009 RID: 118793 RVA: 0x008DB377 File Offset: 0x008D9577
		public TetrisScoreSnapshot ScoreSnapshot { get; set; }

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0601D00A RID: 118794 RVA: 0x008DB380 File Offset: 0x008D9580
		// (set) Token: 0x0601D00B RID: 118795 RVA: 0x008DB388 File Offset: 0x008D9588
		public TetrisGemSnapshot GemSnapshot { get; set; }

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0601D00C RID: 118796 RVA: 0x008DB391 File Offset: 0x008D9591
		// (set) Token: 0x0601D00D RID: 118797 RVA: 0x008DB399 File Offset: 0x008D9599
		public int CurrentRoundIndex { get; set; }

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0601D00E RID: 118798 RVA: 0x008DB3A2 File Offset: 0x008D95A2
		// (set) Token: 0x0601D00F RID: 118799 RVA: 0x008DB3AA File Offset: 0x008D95AA
		public int CurrentStageIndex { get; set; }

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0601D010 RID: 118800 RVA: 0x008DB3B3 File Offset: 0x008D95B3
		// (set) Token: 0x0601D011 RID: 118801 RVA: 0x008DB3BB File Offset: 0x008D95BB
		public int PlaceCount { get; set; }

		// Token: 0x0601D012 RID: 118802 RVA: 0x008DB3C4 File Offset: 0x008D95C4
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisGameSnapshot");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601D013 RID: 118803 RVA: 0x008DB410 File Offset: 0x008D9610
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("BoardCells = ");
			builder.Append(this.BoardCells);
			builder.Append(", HandShapes = ");
			builder.Append(this.HandShapes);
			builder.Append(", ScoreSnapshot = ");
			builder.Append(this.ScoreSnapshot);
			builder.Append(", GemSnapshot = ");
			builder.Append(this.GemSnapshot);
			builder.Append(", CurrentRoundIndex = ");
			builder.Append(this.CurrentRoundIndex.ToString());
			builder.Append(", CurrentStageIndex = ");
			builder.Append(this.CurrentStageIndex.ToString());
			builder.Append(", PlaceCount = ");
			builder.Append(this.PlaceCount.ToString());
			return true;
		}

		// Token: 0x0601D014 RID: 118804 RVA: 0x008DB4FC File Offset: 0x008D96FC
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(TetrisGameSnapshot left, TetrisGameSnapshot right)
		{
			return !(left == right);
		}

		// Token: 0x0601D015 RID: 118805 RVA: 0x008DB508 File Offset: 0x008D9708
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(TetrisGameSnapshot left, TetrisGameSnapshot right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601D016 RID: 118806 RVA: 0x008DB51C File Offset: 0x008D971C
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<TetrisCellData[,]>.Default.GetHashCode(this.<BoardCells>k__BackingField)) * -1521134295 + EqualityComparer<List<BlockInstance>>.Default.GetHashCode(this.<HandShapes>k__BackingField)) * -1521134295 + EqualityComparer<TetrisScoreSnapshot>.Default.GetHashCode(this.<ScoreSnapshot>k__BackingField)) * -1521134295 + EqualityComparer<TetrisGemSnapshot>.Default.GetHashCode(this.<GemSnapshot>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<CurrentRoundIndex>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<CurrentStageIndex>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<PlaceCount>k__BackingField);
		}

		// Token: 0x0601D017 RID: 118807 RVA: 0x008DB5DA File Offset: 0x008D97DA
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as TetrisGameSnapshot);
		}

		// Token: 0x0601D018 RID: 118808 RVA: 0x008DB5E8 File Offset: 0x008D97E8
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(TetrisGameSnapshot other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<TetrisCellData[,]>.Default.Equals(this.<BoardCells>k__BackingField, other.<BoardCells>k__BackingField) && EqualityComparer<List<BlockInstance>>.Default.Equals(this.<HandShapes>k__BackingField, other.<HandShapes>k__BackingField) && EqualityComparer<TetrisScoreSnapshot>.Default.Equals(this.<ScoreSnapshot>k__BackingField, other.<ScoreSnapshot>k__BackingField) && EqualityComparer<TetrisGemSnapshot>.Default.Equals(this.<GemSnapshot>k__BackingField, other.<GemSnapshot>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<CurrentRoundIndex>k__BackingField, other.<CurrentRoundIndex>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<CurrentStageIndex>k__BackingField, other.<CurrentStageIndex>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<PlaceCount>k__BackingField, other.<PlaceCount>k__BackingField));
		}

		// Token: 0x0601D01A RID: 118810 RVA: 0x008DB6D0 File Offset: 0x008D98D0
		[CompilerGenerated]
		[SetsRequiredMembers]
		protected TetrisGameSnapshot(TetrisGameSnapshot original)
		{
			this.BoardCells = original.<BoardCells>k__BackingField;
			this.HandShapes = original.<HandShapes>k__BackingField;
			this.ScoreSnapshot = original.<ScoreSnapshot>k__BackingField;
			this.GemSnapshot = original.<GemSnapshot>k__BackingField;
			this.CurrentRoundIndex = original.<CurrentRoundIndex>k__BackingField;
			this.CurrentStageIndex = original.<CurrentStageIndex>k__BackingField;
			this.PlaceCount = original.<PlaceCount>k__BackingField;
		}

		// Token: 0x0601D01B RID: 118811 RVA: 0x008DB737 File Offset: 0x008D9937
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TetrisGameSnapshot()
		{
		}
	}
}
