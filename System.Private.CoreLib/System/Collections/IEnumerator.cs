using System;

namespace System.Collections
{
	// Token: 0x0200097A RID: 2426
	public interface IEnumerator
	{
		// Token: 0x0600908D RID: 37005
		bool MoveNext();

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600908E RID: 37006
		object Current { get; }

		// Token: 0x0600908F RID: 37007
		void Reset();
	}
}
