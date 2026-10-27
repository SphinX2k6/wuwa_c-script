using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EBF RID: 20159
	public enum IAttachTarget_Union : byte
	{
		// Token: 0x0400DCAB RID: 56491
		NONE,
		// Token: 0x0400DCAC RID: 56492
		IAttachTarget,
		// Token: 0x0400DCAD RID: 56493
		IActorAttachTarget,
		// Token: 0x0400DCAE RID: 56494
		IEntityAttachTarget,
		// Token: 0x0400DCAF RID: 56495
		IDynamicAttachTarget,
		// Token: 0x0400DCB0 RID: 56496
		IPlayerAttachTarget,
		// Token: 0x0400DCB1 RID: 56497
		IPointAttachTarget
	}
}
