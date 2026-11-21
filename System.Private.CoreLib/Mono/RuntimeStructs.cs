using System;

namespace Mono
{
	// Token: 0x020009EF RID: 2543
	internal static class RuntimeStructs
	{
		// Token: 0x020009F0 RID: 2544
		internal struct MonoClass
		{
		}

		// Token: 0x020009F1 RID: 2545
		internal struct GenericParamInfo
		{
			// Token: 0x040022C0 RID: 8896
			internal unsafe RuntimeStructs.MonoClass* pklass;

			// Token: 0x040022C1 RID: 8897
			internal IntPtr name;

			// Token: 0x040022C2 RID: 8898
			internal ushort flags;

			// Token: 0x040022C3 RID: 8899
			internal uint token;

			// Token: 0x040022C4 RID: 8900
			internal unsafe RuntimeStructs.MonoClass** constraints;
		}

		// Token: 0x020009F2 RID: 2546
		internal struct GPtrArray
		{
			// Token: 0x040022C5 RID: 8901
			internal unsafe IntPtr* data;

			// Token: 0x040022C6 RID: 8902
			internal int len;
		}
	}
}
