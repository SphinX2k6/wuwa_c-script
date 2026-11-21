using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000652 RID: 1618
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum CALLCONV
	{
		// Token: 0x0400143B RID: 5179
		CC_CDECL = 1,
		// Token: 0x0400143C RID: 5180
		CC_MSCPASCAL,
		// Token: 0x0400143D RID: 5181
		CC_PASCAL = 2,
		// Token: 0x0400143E RID: 5182
		CC_MACPASCAL,
		// Token: 0x0400143F RID: 5183
		CC_STDCALL,
		// Token: 0x04001440 RID: 5184
		CC_RESERVED,
		// Token: 0x04001441 RID: 5185
		CC_SYSCALL,
		// Token: 0x04001442 RID: 5186
		CC_MPWCDECL,
		// Token: 0x04001443 RID: 5187
		CC_MPWPASCAL,
		// Token: 0x04001444 RID: 5188
		CC_MAX
	}
}
