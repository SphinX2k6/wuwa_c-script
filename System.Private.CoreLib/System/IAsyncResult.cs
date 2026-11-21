using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x0200013A RID: 314
	[NullableContext(1)]
	public interface IAsyncResult
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060013B8 RID: 5048
		bool IsCompleted { get; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060013B9 RID: 5049
		WaitHandle AsyncWaitHandle { get; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060013BA RID: 5050
		[Nullable(2)]
		object AsyncState { [NullableContext(2)] get; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060013BB RID: 5051
		bool CompletedSynchronously { get; }
	}
}
