using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A3 RID: 2211
	[Flags]
	public enum DynamicallyAccessedMemberTypes
	{
		// Token: 0x04001E68 RID: 7784
		None = 0,
		// Token: 0x04001E69 RID: 7785
		PublicParameterlessConstructor = 1,
		// Token: 0x04001E6A RID: 7786
		PublicConstructors = 3,
		// Token: 0x04001E6B RID: 7787
		NonPublicConstructors = 4,
		// Token: 0x04001E6C RID: 7788
		PublicMethods = 8,
		// Token: 0x04001E6D RID: 7789
		NonPublicMethods = 16,
		// Token: 0x04001E6E RID: 7790
		PublicFields = 32,
		// Token: 0x04001E6F RID: 7791
		NonPublicFields = 64,
		// Token: 0x04001E70 RID: 7792
		PublicNestedTypes = 128,
		// Token: 0x04001E71 RID: 7793
		NonPublicNestedTypes = 256,
		// Token: 0x04001E72 RID: 7794
		PublicProperties = 512,
		// Token: 0x04001E73 RID: 7795
		NonPublicProperties = 1024,
		// Token: 0x04001E74 RID: 7796
		PublicEvents = 2048,
		// Token: 0x04001E75 RID: 7797
		NonPublicEvents = 4096,
		// Token: 0x04001E76 RID: 7798
		Interfaces = 8192,
		// Token: 0x04001E77 RID: 7799
		All = -1
	}
}
