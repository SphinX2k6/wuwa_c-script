using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000346 RID: 838
	public struct MemoryHandle : IDisposable
	{
		// Token: 0x06003AAB RID: 15019 RVA: 0x000C352C File Offset: 0x000C172C
		[CLSCompliant(false)]
		public unsafe MemoryHandle(void* pointer, GCHandle handle = default(GCHandle), [Nullable(2)] IPinnable pinnable = null)
		{
			this._pointer = pointer;
			this._handle = handle;
			this._pinnable = pinnable;
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x000C3543 File Offset: 0x000C1743
		[CLSCompliant(false)]
		public unsafe void* Pointer
		{
			get
			{
				return this._pointer;
			}
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x000C354B File Offset: 0x000C174B
		public void Dispose()
		{
			if (this._handle.IsAllocated)
			{
				this._handle.Free();
			}
			if (this._pinnable != null)
			{
				this._pinnable.Unpin();
				this._pinnable = null;
			}
			this._pointer = null;
		}

		// Token: 0x04000C41 RID: 3137
		private unsafe void* _pointer;

		// Token: 0x04000C42 RID: 3138
		private GCHandle _handle;

		// Token: 0x04000C43 RID: 3139
		private IPinnable _pinnable;
	}
}
