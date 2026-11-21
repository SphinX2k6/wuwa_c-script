using System;

namespace System.Reflection
{
	// Token: 0x02000775 RID: 1909
	[Flags]
	public enum ResourceLocation
	{
		// Token: 0x04001719 RID: 5913
		ContainedInAnotherAssembly = 2,
		// Token: 0x0400171A RID: 5914
		ContainedInManifestFile = 4,
		// Token: 0x0400171B RID: 5915
		Embedded = 1
	}
}
