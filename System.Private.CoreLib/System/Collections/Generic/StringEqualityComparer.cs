using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009BC RID: 2492
	[Serializable]
	internal sealed class StringEqualityComparer : EqualityComparer<string>, IAlternateEqualityComparer<ReadOnlySpan<char>, string>, ISerializable
	{
		// Token: 0x060092BA RID: 37562 RVA: 0x0016D714 File Offset: 0x0016B914
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(GenericEqualityComparer<string>));
		}

		// Token: 0x060092BB RID: 37563 RVA: 0x000666FD File Offset: 0x000648FD
		public override bool Equals(string x, string y)
		{
			return string.Equals(x, y);
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x0016D726 File Offset: 0x0016B926
		public override int GetHashCode([DisallowNull] string obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x00066717 File Offset: 0x00064917
		public bool Equals(ReadOnlySpan<char> span, string target)
		{
			return (!span.IsEmpty || target != null) && span.SequenceEqual(target);
		}

		// Token: 0x060092BE RID: 37566 RVA: 0x00066733 File Offset: 0x00064933
		public int GetHashCode(ReadOnlySpan<char> span)
		{
			return string.GetHashCode(span);
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x000664B5 File Offset: 0x000646B5
		public string Create(ReadOnlySpan<char> span)
		{
			return span.ToString();
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x0016D733 File Offset: 0x0016B933
		public override bool Equals(object obj)
		{
			return obj is StringEqualityComparer;
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
