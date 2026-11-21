using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005D2 RID: 1490
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct HandleRef
	{
		// Token: 0x06007029 RID: 28713 RVA: 0x0010DBDA File Offset: 0x0010BDDA
		public HandleRef(object wrapper, IntPtr handle)
		{
			this._wrapper = wrapper;
			this._handle = handle;
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x0600702A RID: 28714 RVA: 0x0010DBEA File Offset: 0x0010BDEA
		public object Wrapper
		{
			get
			{
				return this._wrapper;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x0010DBF2 File Offset: 0x0010BDF2
		public IntPtr Handle
		{
			get
			{
				return this._handle;
			}
		}

		// Token: 0x0600702C RID: 28716 RVA: 0x0010DBF2 File Offset: 0x0010BDF2
		public static explicit operator IntPtr(HandleRef value)
		{
			return value._handle;
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x0010DBF2 File Offset: 0x0010BDF2
		public static IntPtr ToIntPtr(HandleRef value)
		{
			return value._handle;
		}

		// Token: 0x040012A4 RID: 4772
		private readonly object _wrapper;

		// Token: 0x040012A5 RID: 4773
		private readonly IntPtr _handle;
	}
}
