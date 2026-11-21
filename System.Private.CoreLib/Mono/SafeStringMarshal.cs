using System;
using System.Runtime.CompilerServices;

namespace Mono
{
	// Token: 0x02000A05 RID: 2565
	internal struct SafeStringMarshal : IDisposable
	{
		// Token: 0x06009430 RID: 37936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr StringToUtf8_icall(ref string str);

		// Token: 0x06009431 RID: 37937 RVA: 0x00171A99 File Offset: 0x0016FC99
		public static IntPtr StringToUtf8(string str)
		{
			return SafeStringMarshal.StringToUtf8_icall(ref str);
		}

		// Token: 0x06009432 RID: 37938
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GFree(IntPtr ptr);

		// Token: 0x06009433 RID: 37939 RVA: 0x00171AA2 File Offset: 0x0016FCA2
		public SafeStringMarshal(string str)
		{
			this.str = str;
			this.marshaled_string = IntPtr.Zero;
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06009434 RID: 37940 RVA: 0x00171AB6 File Offset: 0x0016FCB6
		public IntPtr Value
		{
			get
			{
				if (this.marshaled_string == IntPtr.Zero && this.str != null)
				{
					this.marshaled_string = SafeStringMarshal.StringToUtf8(this.str);
				}
				return this.marshaled_string;
			}
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x00171AE4 File Offset: 0x0016FCE4
		public void Dispose()
		{
			if (this.marshaled_string != IntPtr.Zero)
			{
				SafeStringMarshal.GFree(this.marshaled_string);
				this.marshaled_string = IntPtr.Zero;
			}
		}

		// Token: 0x040022F9 RID: 8953
		private readonly string str;

		// Token: 0x040022FA RID: 8954
		private IntPtr marshaled_string;
	}
}
