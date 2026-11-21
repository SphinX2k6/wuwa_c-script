using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020000E0 RID: 224
	[CompilerFeatureRequired("RefStructs")]
	[NonVersionable]
	internal readonly ref struct ByReference
	{
		// Token: 0x06000AC9 RID: 2761 RVA: 0x0001FD76 File Offset: 0x0001DF76
		public ByReference(ref byte value)
		{
			this.Value = ref value;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001FD7F File Offset: 0x0001DF7F
		public static ByReference Create<T>(ref T p)
		{
			return new ByReference(Unsafe.As<T, byte>(ref p));
		}

		// Token: 0x04000303 RID: 771
		public unsafe readonly byte* Value;
	}
}
