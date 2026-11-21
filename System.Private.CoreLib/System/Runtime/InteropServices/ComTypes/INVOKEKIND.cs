using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000651 RID: 1617
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Flags]
	public enum INVOKEKIND
	{
		// Token: 0x04001436 RID: 5174
		INVOKE_FUNC = 1,
		// Token: 0x04001437 RID: 5175
		INVOKE_PROPERTYGET = 2,
		// Token: 0x04001438 RID: 5176
		INVOKE_PROPERTYPUT = 4,
		// Token: 0x04001439 RID: 5177
		INVOKE_PROPERTYPUTREF = 8
	}
}
