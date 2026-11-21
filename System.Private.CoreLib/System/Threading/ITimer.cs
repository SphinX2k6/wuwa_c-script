using System;

namespace System.Threading
{
	// Token: 0x02000463 RID: 1123
	public interface ITimer : IDisposable, IAsyncDisposable
	{
		// Token: 0x0600432F RID: 17199
		bool Change(TimeSpan dueTime, TimeSpan period);
	}
}
