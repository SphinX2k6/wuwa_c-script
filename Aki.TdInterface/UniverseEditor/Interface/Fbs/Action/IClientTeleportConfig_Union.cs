using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063FA RID: 25594
	public enum IClientTeleportConfig_Union : byte
	{
		// Token: 0x040109E2 RID: 68066
		NONE,
		// Token: 0x040109E3 RID: 68067
		IClientTeleportConfig,
		// Token: 0x040109E4 RID: 68068
		IClientTpRelativeEntityPos,
		// Token: 0x040109E5 RID: 68069
		IClientTpToStreamingTargetPoint
	}
}
