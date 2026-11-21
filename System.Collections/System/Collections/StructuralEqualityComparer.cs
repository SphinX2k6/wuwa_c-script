using System;

namespace System.Collections
{
	// Token: 0x02000008 RID: 8
	internal sealed class StructuralEqualityComparer : IEqualityComparer
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00003AFC File Offset: 0x00001CFC
		public bool Equals(object x, object y)
		{
			if (x == null)
			{
				return y == null;
			}
			IStructuralEquatable structuralEquatable = x as IStructuralEquatable;
			if (structuralEquatable != null)
			{
				return structuralEquatable.Equals(y, this);
			}
			return y != null && x.Equals(y);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003B34 File Offset: 0x00001D34
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			IStructuralEquatable structuralEquatable = obj as IStructuralEquatable;
			if (structuralEquatable != null)
			{
				return structuralEquatable.GetHashCode(this);
			}
			return obj.GetHashCode();
		}

		// Token: 0x0400000A RID: 10
		internal static readonly StructuralEqualityComparer s_instance = new StructuralEqualityComparer();
	}
}
