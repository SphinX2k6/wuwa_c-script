using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001BA RID: 442
	[Serializable]
	internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, IAlternateEqualityComparer<ReadOnlySpan<char>, string>, ISerializable
	{
		// Token: 0x06002198 RID: 8600 RVA: 0x00066765 File Offset: 0x00064965
		private OrdinalIgnoreCaseComparer() : base(true)
		{
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0006676E File Offset: 0x0006496E
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
			return System.Globalization.Ordinal.CompareStringIgnoreCase(x.GetRawStringData(), x.Length, y.GetRawStringData(), y.Length);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0006679D File Offset: 0x0006499D
		public override bool Equals(string x, string y)
		{
			return x == y || (x != null && y != null && x.Length == y.Length && System.Globalization.Ordinal.EqualsIgnoreCase(x.GetRawStringData(), y.GetRawStringData(), x.Length));
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000667D4 File Offset: 0x000649D4
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.obj);
			}
			return obj.GetHashCodeOrdinalIgnoreCase();
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x000667E5 File Offset: 0x000649E5
		bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> span, string target)
		{
			return (!span.IsEmpty || target != null) && span.EqualsOrdinalIgnoreCase(target);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00066801 File Offset: 0x00064A01
		int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> span)
		{
			return string.GetHashCodeOrdinalIgnoreCase(span);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000664B5 File Offset: 0x000646B5
		string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
		{
			return span.ToString();
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00066809 File Offset: 0x00064A09
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(OrdinalComparer));
			info.AddValue("_ignoreCase", true);
		}

		// Token: 0x04000586 RID: 1414
		internal static readonly OrdinalIgnoreCaseComparer Instance = new OrdinalIgnoreCaseComparer();
	}
}
