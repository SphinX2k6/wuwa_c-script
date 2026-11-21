using System;
using System.Runtime.InteropServices;

namespace System.IO
{
	// Token: 0x02000809 RID: 2057
	internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
	{
		// Token: 0x060083B5 RID: 33717 RVA: 0x0013B514 File Offset: 0x00139714
		internal unsafe PinnedBufferMemoryStream(byte[] array)
		{
			this._array = array;
			this._pinningHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			int num = array.Length;
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(array))
			{
				byte* pointer = reference;
				base.Initialize(pointer, (long)num, (long)num, FileAccess.Read);
			}
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x0013B55D File Offset: 0x0013975D
		public override int Read(Span<byte> buffer)
		{
			return base.ReadCore(buffer);
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x0013B566 File Offset: 0x00139766
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			base.WriteCore(buffer);
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x0013B570 File Offset: 0x00139770
		~PinnedBufferMemoryStream()
		{
			this.Dispose(false);
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x0013B5A0 File Offset: 0x001397A0
		protected override void Dispose(bool disposing)
		{
			if (this._pinningHandle.IsAllocated)
			{
				this._pinningHandle.Free();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04001BE3 RID: 7139
		private readonly byte[] _array;

		// Token: 0x04001BE4 RID: 7140
		private GCHandle _pinningHandle;
	}
}
