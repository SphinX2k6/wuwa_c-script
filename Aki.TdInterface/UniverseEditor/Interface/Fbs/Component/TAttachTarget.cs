using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE8 RID: 23528
	public enum TAttachTarget : byte
	{
		// Token: 0x0400F377 RID: 62327
		NONE,
		// Token: 0x0400F378 RID: 62328
		IActorAttachTarget,
		// Token: 0x0400F379 RID: 62329
		IDynamicAttachTarget,
		// Token: 0x0400F37A RID: 62330
		IEntityAttachTarget,
		// Token: 0x0400F37B RID: 62331
		IPlayerAttachTarget,
		// Token: 0x0400F37C RID: 62332
		IPointAttachTarget
	}
}
