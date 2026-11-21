using System;

namespace System.Threading
{
	// Token: 0x020003E4 RID: 996
	internal interface IDeferredDisposable
	{
		// Token: 0x06003FF9 RID: 16377
		void OnFinalRelease(bool disposed);
	}
}
