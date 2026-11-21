using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x02000163 RID: 355
	public sealed class LocalDataStoreSlot
	{
		// Token: 0x06001749 RID: 5961 RVA: 0x00046684 File Offset: 0x00044884
		internal LocalDataStoreSlot(ThreadLocal<object> data)
		{
			this.Data = data;
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00046699 File Offset: 0x00044899
		[Nullable(new byte[]
		{
			1,
			2
		})]
		internal ThreadLocal<object> Data { get; }

		// Token: 0x0600174B RID: 5963 RVA: 0x000466A4 File Offset: 0x000448A4
		~LocalDataStoreSlot()
		{
		}
	}
}
