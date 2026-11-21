using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7A RID: 27258
	public enum IClientTeleportConfig_Union : byte
	{
		// Token: 0x04011808 RID: 71688
		NONE,
		// Token: 0x04011809 RID: 71689
		IClientTeleportConfig,
		// Token: 0x0401180A RID: 71690
		IClientTpRelativeEntityPos,
		// Token: 0x0401180B RID: 71691
		IClientTpToStreamingTargetPoint
	}
}
