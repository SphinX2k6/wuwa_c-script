using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FAD RID: 12205
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct TetrisClearInfo : IEquatable<TetrisClearInfo>
	{
		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0601CF1A RID: 118554 RVA: 0x008D6261 File Offset: 0x008D4461
		// (set) Token: 0x0601CF1B RID: 118555 RVA: 0x008D6269 File Offset: 0x008D4469
		public int[] ClearedRows { get; set; }

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0601CF1C RID: 118556 RVA: 0x008D6272 File Offset: 0x008D4472
		// (set) Token: 0x0601CF1D RID: 118557 RVA: 0x008D627A File Offset: 0x008D447A
		public int[] ClearedCols { get; set; }

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0601CF1E RID: 118558 RVA: 0x008D6283 File Offset: 0x008D4483
		// (set) Token: 0x0601CF1F RID: 118559 RVA: 0x008D628B File Offset: 0x008D448B
		public Dictionary<EGemType, int> CollectedGems { get; set; }

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0601CF20 RID: 118560 RVA: 0x008D6294 File Offset: 0x008D4494
		// (set) Token: 0x0601CF21 RID: 118561 RVA: 0x008D629C File Offset: 0x008D449C
		[TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public ValueTuple<int, int, int>[] ClearedPositions { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0601CF22 RID: 118562 RVA: 0x008D62A5 File Offset: 0x008D44A5
		// (set) Token: 0x0601CF23 RID: 118563 RVA: 0x008D62AD File Offset: 0x008D44AD
		[TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public ValueTuple<int, int, int>[] SealChangePositions { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0601CF24 RID: 118564 RVA: 0x008D62B6 File Offset: 0x008D44B6
		// (set) Token: 0x0601CF25 RID: 118565 RVA: 0x008D62BE File Offset: 0x008D44BE
		[TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public ValueTuple<int, int, int>[] Bombs { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0601CF26 RID: 118566 RVA: 0x008D62C7 File Offset: 0x008D44C7
		// (set) Token: 0x0601CF27 RID: 118567 RVA: 0x008D62CF File Offset: 0x008D44CF
		[TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public ValueTuple<int, int, int>[] SuperBombs { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0601CF28 RID: 118568 RVA: 0x008D62D8 File Offset: 0x008D44D8
		// (set) Token: 0x0601CF29 RID: 118569 RVA: 0x008D62E0 File Offset: 0x008D44E0
		[TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public ValueTuple<int, int, int>[] TriggeredBombs { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0601CF2A RID: 118570 RVA: 0x008D62E9 File Offset: 0x008D44E9
		// (set) Token: 0x0601CF2B RID: 118571 RVA: 0x008D62F1 File Offset: 0x008D44F1
		[TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public ValueTuple<int, int, int>[] TriggeredSuperBombs { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0601CF2C RID: 118572 RVA: 0x008D62FA File Offset: 0x008D44FA
		// (set) Token: 0x0601CF2D RID: 118573 RVA: 0x008D6302 File Offset: 0x008D4502
		public int CumulateBombCount { get; set; }

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0601CF2E RID: 118574 RVA: 0x008D630B File Offset: 0x008D450B
		// (set) Token: 0x0601CF2F RID: 118575 RVA: 0x008D6313 File Offset: 0x008D4513
		public bool IsBoardAllCleared { get; set; }

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0601CF30 RID: 118576 RVA: 0x008D631C File Offset: 0x008D451C
		public bool HasRemoveAnimation
		{
			get
			{
				return this.ClearedPositions.Length != 0 || this.SealChangePositions.Length != 0;
			}
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0601CF31 RID: 118577 RVA: 0x008D6333 File Offset: 0x008D4533
		public int Lines
		{
			get
			{
				return this.ClearedRows.Length + this.ClearedCols.Length;
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0601CF32 RID: 118578 RVA: 0x008D6346 File Offset: 0x008D4546
		public int BombCount
		{
			get
			{
				return this.Bombs.Length + this.SuperBombs.Length;
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0601CF33 RID: 118579 RVA: 0x008D6359 File Offset: 0x008D4559
		public bool IsBombExplosion
		{
			get
			{
				return this.BombCount > 0;
			}
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0601CF34 RID: 118580 RVA: 0x008D6364 File Offset: 0x008D4564
		public int TriggeredBombCount
		{
			get
			{
				return this.TriggeredBombs.Length + this.TriggeredSuperBombs.Length;
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0601CF35 RID: 118581 RVA: 0x008D6377 File Offset: 0x008D4577
		public bool HasTriggeredBombs
		{
			get
			{
				return this.TriggeredBombCount > 0;
			}
		}

		// Token: 0x0601CF36 RID: 118582 RVA: 0x008D6384 File Offset: 0x008D4584
		[NullableContext(0)]
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisClearInfo");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601CF37 RID: 118583 RVA: 0x008D63D0 File Offset: 0x008D45D0
		[NullableContext(0)]
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("ClearedRows = ");
			builder.Append(this.ClearedRows);
			builder.Append(", ClearedCols = ");
			builder.Append(this.ClearedCols);
			builder.Append(", CollectedGems = ");
			builder.Append(this.CollectedGems);
			builder.Append(", ClearedPositions = ");
			builder.Append(this.ClearedPositions);
			builder.Append(", SealChangePositions = ");
			builder.Append(this.SealChangePositions);
			builder.Append(", Bombs = ");
			builder.Append(this.Bombs);
			builder.Append(", SuperBombs = ");
			builder.Append(this.SuperBombs);
			builder.Append(", TriggeredBombs = ");
			builder.Append(this.TriggeredBombs);
			builder.Append(", TriggeredSuperBombs = ");
			builder.Append(this.TriggeredSuperBombs);
			builder.Append(", CumulateBombCount = ");
			builder.Append(this.CumulateBombCount.ToString());
			builder.Append(", IsBoardAllCleared = ");
			builder.Append(this.IsBoardAllCleared.ToString());
			builder.Append(", HasRemoveAnimation = ");
			builder.Append(this.HasRemoveAnimation.ToString());
			builder.Append(", Lines = ");
			builder.Append(this.Lines.ToString());
			builder.Append(", BombCount = ");
			builder.Append(this.BombCount.ToString());
			builder.Append(", IsBombExplosion = ");
			builder.Append(this.IsBombExplosion.ToString());
			builder.Append(", TriggeredBombCount = ");
			builder.Append(this.TriggeredBombCount.ToString());
			builder.Append(", HasTriggeredBombs = ");
			builder.Append(this.HasTriggeredBombs.ToString());
			return true;
		}

		// Token: 0x0601CF38 RID: 118584 RVA: 0x008D65F7 File Offset: 0x008D47F7
		[CompilerGenerated]
		public static bool operator !=(TetrisClearInfo left, TetrisClearInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0601CF39 RID: 118585 RVA: 0x008D6603 File Offset: 0x008D4803
		[CompilerGenerated]
		public static bool operator ==(TetrisClearInfo left, TetrisClearInfo right)
		{
			return left.Equals(right);
		}

		// Token: 0x0601CF3A RID: 118586 RVA: 0x008D6610 File Offset: 0x008D4810
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((EqualityComparer<int[]>.Default.GetHashCode(this.<ClearedRows>k__BackingField) * -1521134295 + EqualityComparer<int[]>.Default.GetHashCode(this.<ClearedCols>k__BackingField)) * -1521134295 + EqualityComparer<Dictionary<EGemType, int>>.Default.GetHashCode(this.<CollectedGems>k__BackingField)) * -1521134295 + EqualityComparer<ValueTuple<int, int, int>[]>.Default.GetHashCode(this.<ClearedPositions>k__BackingField)) * -1521134295 + EqualityComparer<ValueTuple<int, int, int>[]>.Default.GetHashCode(this.<SealChangePositions>k__BackingField)) * -1521134295 + EqualityComparer<ValueTuple<int, int, int>[]>.Default.GetHashCode(this.<Bombs>k__BackingField)) * -1521134295 + EqualityComparer<ValueTuple<int, int, int>[]>.Default.GetHashCode(this.<SuperBombs>k__BackingField)) * -1521134295 + EqualityComparer<ValueTuple<int, int, int>[]>.Default.GetHashCode(this.<TriggeredBombs>k__BackingField)) * -1521134295 + EqualityComparer<ValueTuple<int, int, int>[]>.Default.GetHashCode(this.<TriggeredSuperBombs>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<CumulateBombCount>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsBoardAllCleared>k__BackingField);
		}

		// Token: 0x0601CF3B RID: 118587 RVA: 0x008D6713 File Offset: 0x008D4913
		[NullableContext(0)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return obj is TetrisClearInfo && this.Equals((TetrisClearInfo)obj);
		}

		// Token: 0x0601CF3C RID: 118588 RVA: 0x008D672C File Offset: 0x008D492C
		[CompilerGenerated]
		public bool Equals(TetrisClearInfo other)
		{
			return EqualityComparer<int[]>.Default.Equals(this.<ClearedRows>k__BackingField, other.<ClearedRows>k__BackingField) && EqualityComparer<int[]>.Default.Equals(this.<ClearedCols>k__BackingField, other.<ClearedCols>k__BackingField) && EqualityComparer<Dictionary<EGemType, int>>.Default.Equals(this.<CollectedGems>k__BackingField, other.<CollectedGems>k__BackingField) && EqualityComparer<ValueTuple<int, int, int>[]>.Default.Equals(this.<ClearedPositions>k__BackingField, other.<ClearedPositions>k__BackingField) && EqualityComparer<ValueTuple<int, int, int>[]>.Default.Equals(this.<SealChangePositions>k__BackingField, other.<SealChangePositions>k__BackingField) && EqualityComparer<ValueTuple<int, int, int>[]>.Default.Equals(this.<Bombs>k__BackingField, other.<Bombs>k__BackingField) && EqualityComparer<ValueTuple<int, int, int>[]>.Default.Equals(this.<SuperBombs>k__BackingField, other.<SuperBombs>k__BackingField) && EqualityComparer<ValueTuple<int, int, int>[]>.Default.Equals(this.<TriggeredBombs>k__BackingField, other.<TriggeredBombs>k__BackingField) && EqualityComparer<ValueTuple<int, int, int>[]>.Default.Equals(this.<TriggeredSuperBombs>k__BackingField, other.<TriggeredSuperBombs>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<CumulateBombCount>k__BackingField, other.<CumulateBombCount>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsBoardAllCleared>k__BackingField, other.<IsBoardAllCleared>k__BackingField);
		}
	}
}
