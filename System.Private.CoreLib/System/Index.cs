using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000144 RID: 324
	public readonly struct Index : IEquatable<Index>
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x0003EA3E File Offset: 0x0003CC3E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Index(int value, bool fromEnd = false)
		{
			if (value < 0)
			{
				Index.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			if (fromEnd)
			{
				this._value = ~value;
				return;
			}
			this._value = value;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0003EA5C File Offset: 0x0003CC5C
		private Index(int value)
		{
			this._value = value;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0003EA65 File Offset: 0x0003CC65
		public static Index Start
		{
			get
			{
				return new Index(0);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0003EA6D File Offset: 0x0003CC6D
		public static Index End
		{
			get
			{
				return new Index(-1);
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0003EA75 File Offset: 0x0003CC75
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Index FromStart(int value)
		{
			if (value < 0)
			{
				Index.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			return new Index(value);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0003EA86 File Offset: 0x0003CC86
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Index FromEnd(int value)
		{
			if (value < 0)
			{
				Index.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			return new Index(~value);
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0003EA98 File Offset: 0x0003CC98
		public int Value
		{
			get
			{
				if (this._value < 0)
				{
					return ~this._value;
				}
				return this._value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0003EAB1 File Offset: 0x0003CCB1
		public bool IsFromEnd
		{
			get
			{
				return this._value < 0;
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0003EABC File Offset: 0x0003CCBC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetOffset(int length)
		{
			int num = this._value;
			if (this.IsFromEnd)
			{
				num += length + 1;
			}
			return num;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0003EADF File Offset: 0x0003CCDF
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			return value is Index && this._value == ((Index)value)._value;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0003EAFE File Offset: 0x0003CCFE
		public bool Equals(Index other)
		{
			return this._value == other._value;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0003EB0E File Offset: 0x0003CD0E
		public override int GetHashCode()
		{
			return this._value;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0003EB16 File Offset: 0x0003CD16
		public static implicit operator Index(int value)
		{
			return Index.FromStart(value);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0003EB20 File Offset: 0x0003CD20
		[NullableContext(1)]
		public override string ToString()
		{
			if (this.IsFromEnd)
			{
				return this.ToStringFromEnd();
			}
			return ((uint)this.Value).ToString();
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0003EB4A File Offset: 0x0003CD4A
		private static void ThrowValueArgumentOutOfRange_NeedNonNegNumException()
		{
			throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_NeedNonNegNum);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0003EB5C File Offset: 0x0003CD5C
		private unsafe string ToStringFromEnd()
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)22], 11);
			int num;
			((uint)this.Value).TryFormat(span.Slice(1), out num, default(ReadOnlySpan<char>), null);
			*span[0] = '^';
			return new string(span.Slice(0, num + 1));
		}

		// Token: 0x040004B8 RID: 1208
		private readonly int _value;
	}
}
