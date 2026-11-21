using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F67 RID: 16231
	public enum TVarRef : byte
	{
		// Token: 0x0400B9F4 RID: 47604
		NONE,
		// Token: 0x0400B9F5 RID: 47605
		IConstVarRef,
		// Token: 0x0400B9F6 RID: 47606
		IGlobalVarRef,
		// Token: 0x0400B9F7 RID: 47607
		IOtherVarRef,
		// Token: 0x0400B9F8 RID: 47608
		ISelfVarRef,
		// Token: 0x0400B9F9 RID: 47609
		ISystemVarRef
	}
}
