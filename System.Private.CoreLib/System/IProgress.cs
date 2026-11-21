using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000156 RID: 342
	[NullableContext(1)]
	public interface IProgress<[Nullable(2)] in T>
	{
		// Token: 0x06001700 RID: 5888
		void Report(T value);
	}
}
