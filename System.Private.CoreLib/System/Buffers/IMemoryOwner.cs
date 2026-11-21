using System;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000344 RID: 836
	public interface IMemoryOwner<[Nullable(2)] T> : IDisposable
	{
		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06003AA8 RID: 15016
		[Nullable(new byte[]
		{
			0,
			1
		})]
		Memory<T> Memory { [return: Nullable(new byte[]
		{
			0,
			1
		})] get; }
	}
}
