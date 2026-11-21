using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020004F4 RID: 1268
	[NullableContext(2)]
	public interface IValueTaskSource
	{
		// Token: 0x060047F8 RID: 18424
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x060047F9 RID: 18425
		void OnCompleted([Nullable(new byte[]
		{
			1,
			2
		})] Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x060047FA RID: 18426
		void GetResult(short token);
	}
}
