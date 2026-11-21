using System;
using System.Runtime.CompilerServices;

namespace Mono
{
	// Token: 0x020009EE RID: 2542
	internal struct RuntimeGPtrArrayHandle
	{
		// Token: 0x0600942A RID: 37930 RVA: 0x00171A3B File Offset: 0x0016FC3B
		internal RuntimeGPtrArrayHandle(IntPtr ptr)
		{
			this.value = ptr;
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600942B RID: 37931 RVA: 0x00171A44 File Offset: 0x0016FC44
		internal unsafe int Length
		{
			get
			{
				return this.value->len;
			}
		}

		// Token: 0x17001434 RID: 5172
		internal IntPtr this[int i]
		{
			get
			{
				return this.Lookup(i);
			}
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x00171A5A File Offset: 0x0016FC5A
		internal unsafe IntPtr Lookup(int i)
		{
			if (i >= 0 && i < this.Length)
			{
				return this.value->data[(IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)];
			}
			throw new IndexOutOfRangeException();
		}

		// Token: 0x0600942E RID: 37934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void GPtrArrayFree(RuntimeStructs.GPtrArray* value);

		// Token: 0x0600942F RID: 37935 RVA: 0x00171A84 File Offset: 0x0016FC84
		internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
		{
			RuntimeGPtrArrayHandle.GPtrArrayFree(h.value);
			h.value = null;
		}

		// Token: 0x040022BF RID: 8895
		private unsafe RuntimeStructs.GPtrArray* value;
	}
}
