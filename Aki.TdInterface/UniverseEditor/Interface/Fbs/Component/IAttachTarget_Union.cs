using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E8 RID: 21480
	public enum IAttachTarget_Union : byte
	{
		// Token: 0x0400E847 RID: 59463
		NONE,
		// Token: 0x0400E848 RID: 59464
		IAttachTarget,
		// Token: 0x0400E849 RID: 59465
		IActorAttachTarget,
		// Token: 0x0400E84A RID: 59466
		IEntityAttachTarget,
		// Token: 0x0400E84B RID: 59467
		IDynamicAttachTarget,
		// Token: 0x0400E84C RID: 59468
		IPlayerAttachTarget,
		// Token: 0x0400E84D RID: 59469
		IPointAttachTarget
	}
}
