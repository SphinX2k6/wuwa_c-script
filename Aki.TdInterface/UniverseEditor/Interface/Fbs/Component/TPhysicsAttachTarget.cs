using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B5 RID: 25269
	public enum TPhysicsAttachTarget : byte
	{
		// Token: 0x0401023A RID: 66106
		NONE,
		// Token: 0x0401023B RID: 66107
		IActorAttachTarget,
		// Token: 0x0401023C RID: 66108
		IEntityAttachTarget,
		// Token: 0x0401023D RID: 66109
		IPointAttachTarget,
		// Token: 0x0401023E RID: 66110
		IDynamicAttachTarget,
		// Token: 0x0401023F RID: 66111
		IPlayerAttachTarget
	}
}
