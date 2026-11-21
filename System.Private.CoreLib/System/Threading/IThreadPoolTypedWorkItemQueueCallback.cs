using System;

namespace System.Threading
{
	// Token: 0x0200042B RID: 1067
	internal interface IThreadPoolTypedWorkItemQueueCallback<T>
	{
		// Token: 0x060041FD RID: 16893
		public abstract static void Invoke(T item);
	}
}
