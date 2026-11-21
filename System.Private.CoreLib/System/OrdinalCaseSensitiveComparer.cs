using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001B9 RID: 441
	[Serializable]
	internal sealed class OrdinalCaseSensitiveComparer : OrdinalComparer, ISerializable, IAlternateEqualityComparer<ReadOnlySpan<char>, string>
	{
		// Token: 0x0600218F RID: 8591 RVA: 0x000666EB File Offset: 0x000648EB
		private OrdinalCaseSensitiveComparer() : base(false)
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x000666F4 File Offset: 0x000648F4
		public override int Compare(string x, string y)
		{
			return string.CompareOrdinal(x, y);
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x000666FD File Offset: 0x000648FD
		public override bool Equals(string x, string y)
		{
			return string.Equals(x, y);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00066706 File Offset: 0x00064906
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.obj);
			}
			return obj.GetHashCode();
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00066717 File Offset: 0x00064917
		bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> span, string target)
		{
			return (!span.IsEmpty || target != null) && span.SequenceEqual(target);
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00066733 File Offset: 0x00064933
		int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> span)
		{
			return string.GetHashCode(span);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000664B5 File Offset: 0x000646B5
		string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
		{
			return span.ToString();
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0006673B File Offset: 0x0006493B
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(OrdinalComparer));
			info.AddValue("_ignoreCase", false);
		}

		// Token: 0x04000585 RID: 1413
		internal static readonly OrdinalCaseSensitiveComparer Instance = new OrdinalCaseSensitiveComparer();
	}
}
