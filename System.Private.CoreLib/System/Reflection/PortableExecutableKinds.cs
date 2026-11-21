using System;

namespace System.Reflection
{
	// Token: 0x0200076E RID: 1902
	[Flags]
	public enum PortableExecutableKinds
	{
		// Token: 0x040016FD RID: 5885
		NotAPortableExecutableImage = 0,
		// Token: 0x040016FE RID: 5886
		ILOnly = 1,
		// Token: 0x040016FF RID: 5887
		Required32Bit = 2,
		// Token: 0x04001700 RID: 5888
		PE32Plus = 4,
		// Token: 0x04001701 RID: 5889
		Unmanaged32Bit = 8,
		// Token: 0x04001702 RID: 5890
		Preferred32Bit = 16
	}
}
