using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x020009B7 RID: 2487
	internal sealed class DelegateEqualityComparer<T> : EqualityComparer<T>
	{
		// Token: 0x0600929F RID: 37535 RVA: 0x0016D537 File Offset: 0x0016B737
		public DelegateEqualityComparer(Func<T, T, bool> equals, Func<T, int> getHashCode)
		{
			this._equals = equals;
			this._getHashCode = getHashCode;
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x0016D54D File Offset: 0x0016B74D
		public override bool Equals(T x, T y)
		{
			return this._equals(x, y);
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x0016D55C File Offset: 0x0016B75C
		public override int GetHashCode([DisallowNull] T obj)
		{
			return this._getHashCode(obj);
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x0016D56C File Offset: 0x0016B76C
		public override bool Equals(object obj)
		{
			DelegateEqualityComparer<T> delegateEqualityComparer = obj as DelegateEqualityComparer<T>;
			return delegateEqualityComparer != null && this._equals == delegateEqualityComparer._equals && this._getHashCode == delegateEqualityComparer._getHashCode;
		}

		// Token: 0x060092A3 RID: 37539 RVA: 0x0016D5A9 File Offset: 0x0016B7A9
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this._equals.GetHashCode(), this._getHashCode.GetHashCode());
		}

		// Token: 0x04002280 RID: 8832
		private readonly Func<T, T, bool> _equals;

		// Token: 0x04002281 RID: 8833
		private readonly Func<T, int> _getHashCode;
	}
}
