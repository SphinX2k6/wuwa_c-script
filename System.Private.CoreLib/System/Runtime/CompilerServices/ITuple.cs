using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006AF RID: 1711
	[NullableContext(2)]
	public interface ITuple
	{
		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06007435 RID: 29749
		int Length { get; }

		// Token: 0x17000E47 RID: 3655
		object this[int index]
		{
			get;
		}
	}
}
