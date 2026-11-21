using System;

namespace System.Reflection
{
	// Token: 0x02000779 RID: 1913
	internal enum SignatureCallingConvention : byte
	{
		// Token: 0x0400171F RID: 5919
		Default,
		// Token: 0x04001720 RID: 5920
		Cdecl,
		// Token: 0x04001721 RID: 5921
		StdCall,
		// Token: 0x04001722 RID: 5922
		ThisCall,
		// Token: 0x04001723 RID: 5923
		FastCall,
		// Token: 0x04001724 RID: 5924
		Unmanaged = 9
	}
}
