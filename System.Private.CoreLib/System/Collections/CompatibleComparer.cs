using System;

namespace System.Collections
{
	// Token: 0x0200096B RID: 2411
	internal sealed class CompatibleComparer : IEqualityComparer
	{
		// Token: 0x06008FFF RID: 36863 RVA: 0x00163E6E File Offset: 0x0016206E
		internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer)
		{
			this._hcp = hashCodeProvider;
			this._comparer = comparer;
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06009000 RID: 36864 RVA: 0x00163E84 File Offset: 0x00162084
		internal IHashCodeProvider HashCodeProvider
		{
			get
			{
				return this._hcp;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06009001 RID: 36865 RVA: 0x00163E8C File Offset: 0x0016208C
		internal IComparer Comparer
		{
			get
			{
				return this._comparer;
			}
		}

		// Token: 0x06009002 RID: 36866 RVA: 0x00163E94 File Offset: 0x00162094
		public bool Equals(object a, object b)
		{
			return this.Compare(a, b) == 0;
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x00163EA4 File Offset: 0x001620A4
		public int Compare(object a, object b)
		{
			if (a == b)
			{
				return 0;
			}
			if (a == null)
			{
				return -1;
			}
			if (b == null)
			{
				return 1;
			}
			if (this._comparer != null)
			{
				return this._comparer.Compare(a, b);
			}
			IComparable comparable = a as IComparable;
			if (comparable != null)
			{
				return comparable.CompareTo(b);
			}
			throw new ArgumentException(SR.Argument_ImplementIComparable);
		}

		// Token: 0x06009004 RID: 36868 RVA: 0x00163EF3 File Offset: 0x001620F3
		public int GetHashCode(object obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			if (this._hcp == null)
			{
				return obj.GetHashCode();
			}
			return this._hcp.GetHashCode(obj);
		}

		// Token: 0x040021F3 RID: 8691
		private readonly IHashCodeProvider _hcp;

		// Token: 0x040021F4 RID: 8692
		private readonly IComparer _comparer;
	}
}
