using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B5F RID: 15199
	public enum TVarRef : byte
	{
		// Token: 0x0400B077 RID: 45175
		NONE,
		// Token: 0x0400B078 RID: 45176
		IConstVarRef,
		// Token: 0x0400B079 RID: 45177
		IGlobalVarRef,
		// Token: 0x0400B07A RID: 45178
		IOtherVarRef,
		// Token: 0x0400B07B RID: 45179
		ISelfVarRef,
		// Token: 0x0400B07C RID: 45180
		ISystemVarRef
	}
}
