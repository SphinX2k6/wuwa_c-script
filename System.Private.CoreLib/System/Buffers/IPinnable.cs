using System;

namespace System.Buffers
{
	// Token: 0x02000345 RID: 837
	public interface IPinnable
	{
		// Token: 0x06003AA9 RID: 15017
		MemoryHandle Pin(int elementIndex);

		// Token: 0x06003AAA RID: 15018
		void Unpin();
	}
}
