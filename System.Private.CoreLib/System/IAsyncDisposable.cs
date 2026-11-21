using System;
using System.Threading.Tasks;

namespace System
{
	// Token: 0x02000139 RID: 313
	public interface IAsyncDisposable
	{
		// Token: 0x060013B7 RID: 5047
		ValueTask DisposeAsync();
	}
}
