using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mono
{
	// Token: 0x020009F3 RID: 2547
	internal struct MonoAssemblyName
	{
		// Token: 0x040022C7 RID: 8903
		internal IntPtr name;

		// Token: 0x040022C8 RID: 8904
		internal IntPtr culture;

		// Token: 0x040022C9 RID: 8905
		internal IntPtr hash_value;

		// Token: 0x040022CA RID: 8906
		internal IntPtr public_key;

		// Token: 0x040022CB RID: 8907
		[FixedBuffer(typeof(byte), 17)]
		internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token;

		// Token: 0x040022CC RID: 8908
		internal uint hash_alg;

		// Token: 0x040022CD RID: 8909
		internal uint hash_len;

		// Token: 0x040022CE RID: 8910
		internal uint flags;

		// Token: 0x040022CF RID: 8911
		internal int major;

		// Token: 0x040022D0 RID: 8912
		internal int minor;

		// Token: 0x040022D1 RID: 8913
		internal int build;

		// Token: 0x040022D2 RID: 8914
		internal int revision;

		// Token: 0x040022D3 RID: 8915
		internal int arch;

		// Token: 0x020009F4 RID: 2548
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 17)]
		public struct <public_key_token>e__FixedBuffer
		{
			// Token: 0x040022D4 RID: 8916
			public byte FixedElementField;
		}
	}
}
