using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC1 RID: 27329
	public enum IModifyMaterialConfig_Union : byte
	{
		// Token: 0x04011302 RID: 70402
		NONE,
		// Token: 0x04011303 RID: 70403
		IModifyMaterialConfig,
		// Token: 0x04011304 RID: 70404
		IChangeActorMaterialData,
		// Token: 0x04011305 RID: 70405
		IChangeActorMPC
	}
}
