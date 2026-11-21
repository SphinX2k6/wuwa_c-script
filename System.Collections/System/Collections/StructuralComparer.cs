using System;
using System.Collections.Generic;

namespace System.Collections
{
	// Token: 0x02000009 RID: 9
	internal sealed class StructuralComparer : IComparer
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003B74 File Offset: 0x00001D74
		public int Compare(object x, object y)
		{
			if (x == null)
			{
				if (y != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (y == null)
				{
					return 1;
				}
				IStructuralComparable structuralComparable = x as IStructuralComparable;
				if (structuralComparable != null)
				{
					return structuralComparable.CompareTo(y, this);
				}
				return Comparer<object>.Default.Compare(x, y);
			}
		}

		// Token: 0x0400000B RID: 11
		internal static readonly StructuralComparer s_instance = new StructuralComparer();
	}
}
