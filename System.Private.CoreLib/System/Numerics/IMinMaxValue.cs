using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002AE RID: 686
	[NullableContext(1)]
	public interface IMinMaxValue<[Nullable(0)] TSelf> where TSelf : IMinMaxValue<TSelf>
	{
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600332F RID: 13103
		TSelf MinValue { get; }

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06003330 RID: 13104
		TSelf MaxValue { get; }
	}
}
