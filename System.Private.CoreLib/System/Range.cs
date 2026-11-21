using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200019A RID: 410
	public readonly struct Range : IEquatable<Range>
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x000565DA File Offset: 0x000547DA
		public Index Start { get; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x000565E2 File Offset: 0x000547E2
		public Index End { get; }

		// Token: 0x06001A7F RID: 6783 RVA: 0x000565EA File Offset: 0x000547EA
		public Range(Index start, Index end)
		{
			this.Start = start;
			this.End = end;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000565FC File Offset: 0x000547FC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			if (value is Range)
			{
				Range range = (Range)value;
				if (range.Start.Equals(this.Start))
				{
					return range.End.Equals(this.End);
				}
			}
			return false;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00056648 File Offset: 0x00054848
		public bool Equals(Range other)
		{
			return other.Start.Equals(this.Start) && other.End.Equals(this.End);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00056684 File Offset: 0x00054884
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Start.GetHashCode(), this.End.GetHashCode());
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000566C0 File Offset: 0x000548C0
		[NullableContext(1)]
		public unsafe override string ToString()
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)48], 24);
			int num = 0;
			if (this.Start.IsFromEnd)
			{
				*span[0] = '^';
				num = 1;
			}
			int num2;
			((uint)this.Start.Value).TryFormat(span.Slice(num), out num2, default(ReadOnlySpan<char>), null);
			num += num2;
			*span[num++] = '.';
			*span[num++] = '.';
			if (this.End.IsFromEnd)
			{
				*span[num++] = '^';
			}
			((uint)this.End.Value).TryFormat(span.Slice(num), out num2, default(ReadOnlySpan<char>), null);
			num += num2;
			return new string(span.Slice(0, num));
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000567AB File Offset: 0x000549AB
		public static Range StartAt(Index start)
		{
			return new Range(start, Index.End);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000567B8 File Offset: 0x000549B8
		public static Range EndAt(Index end)
		{
			return new Range(Index.Start, end);
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x000567C5 File Offset: 0x000549C5
		public static Range All
		{
			get
			{
				return new Range(Index.Start, Index.End);
			}
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000567D8 File Offset: 0x000549D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Offset",
			"Length"
		})]
		public ValueTuple<int, int> GetOffsetAndLength(int length)
		{
			int offset = this.Start.GetOffset(length);
			int offset2 = this.End.GetOffset(length);
			if (offset2 > length || offset > offset2)
			{
				Range.ThrowArgumentOutOfRangeException();
			}
			return new ValueTuple<int, int>(offset, offset2 - offset);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0005681B File Offset: 0x00054A1B
		private static void ThrowArgumentOutOfRangeException()
		{
			throw new ArgumentOutOfRangeException("length");
		}
	}
}
