using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001B8 RID: 440
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class OrdinalComparer : StringComparer, IAlternateEqualityComparer<ReadOnlySpan<char>, string>
	{
		// Token: 0x06002185 RID: 8581 RVA: 0x0006658A File Offset: 0x0006478A
		internal OrdinalComparer(bool ignoreCase)
		{
			this._ignoreCase = ignoreCase;
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00066599 File Offset: 0x00064799
		public override int Compare(string x, string y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			if (this._ignoreCase)
			{
				return System.Globalization.Ordinal.CompareStringIgnoreCase(x.GetRawStringData(), x.Length, y.GetRawStringData(), y.Length);
			}
			return string.CompareOrdinal(x, y);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x000665D8 File Offset: 0x000647D8
		public override bool Equals(string x, string y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			if (this._ignoreCase)
			{
				return x.Length == y.Length && System.Globalization.Ordinal.EqualsIgnoreCase(x.GetRawStringData(), y.GetRawStringData(), x.Length);
			}
			return x.Equals(y);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0006662A File Offset: 0x0006482A
		[NullableContext(1)]
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.obj);
			}
			if (this._ignoreCase)
			{
				return obj.GetHashCodeOrdinalIgnoreCase();
			}
			return obj.GetHashCode();
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0006664A File Offset: 0x0006484A
		bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> span, string target)
		{
			if (span.IsEmpty && target == null)
			{
				return false;
			}
			if (!this._ignoreCase)
			{
				return span.SequenceEqual(target);
			}
			return span.EqualsOrdinalIgnoreCase(target);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0006667B File Offset: 0x0006487B
		int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> span)
		{
			if (!this._ignoreCase)
			{
				return string.GetHashCode(span);
			}
			return string.GetHashCodeOrdinalIgnoreCase(span);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x000664B5 File Offset: 0x000646B5
		string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
		{
			return span.ToString();
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00066694 File Offset: 0x00064894
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			OrdinalComparer ordinalComparer = obj as OrdinalComparer;
			return ordinalComparer != null && this._ignoreCase == ordinalComparer._ignoreCase;
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x000666BC File Offset: 0x000648BC
		public override int GetHashCode()
		{
			int hashCode = "OrdinalComparer".GetHashCode();
			if (!this._ignoreCase)
			{
				return hashCode;
			}
			return ~hashCode;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x000666E0 File Offset: 0x000648E0
		private protected override bool IsWellKnownOrdinalComparerCore(out bool ignoreCase)
		{
			ignoreCase = this._ignoreCase;
			return true;
		}

		// Token: 0x04000584 RID: 1412
		private readonly bool _ignoreCase;
	}
}
