using System;

namespace System
{
	// Token: 0x020000D1 RID: 209
	internal abstract class SZGenericArrayEnumeratorBase : IDisposable
	{
		// Token: 0x06000A06 RID: 2566 RVA: 0x0001EA5A File Offset: 0x0001CC5A
		protected SZGenericArrayEnumeratorBase(int endIndex)
		{
			this._index = -1;
			this._endIndex = endIndex;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001EA70 File Offset: 0x0001CC70
		public bool MoveNext()
		{
			int num = this._index + 1;
			if (num < this._endIndex)
			{
				this._index = num;
				return true;
			}
			this._index = this._endIndex;
			return false;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0001EAA5 File Offset: 0x0001CCA5
		public void Reset()
		{
			this._index = -1;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void Dispose()
		{
		}

		// Token: 0x040002DB RID: 731
		protected int _index;

		// Token: 0x040002DC RID: 732
		protected readonly int _endIndex;
	}
}
