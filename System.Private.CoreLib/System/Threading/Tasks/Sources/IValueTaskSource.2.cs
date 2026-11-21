using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020004F5 RID: 1269
	[NullableContext(2)]
	public interface IValueTaskSource<out TResult>
	{
		// Token: 0x060047FB RID: 18427
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x060047FC RID: 18428
		void OnCompleted([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x060047FD RID: 18429
		[NullableContext(1)]
		TResult GetResult(short token);
	}
}
