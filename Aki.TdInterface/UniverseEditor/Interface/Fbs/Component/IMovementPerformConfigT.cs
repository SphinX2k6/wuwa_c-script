using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D9 RID: 21977
	public class IMovementPerformConfigT
	{
		// Token: 0x1700A296 RID: 41622
		// (get) Token: 0x06024723 RID: 149283 RVA: 0x00507FD0 File Offset: 0x005061D0
		// (set) Token: 0x06024724 RID: 149284 RVA: 0x00507FD8 File Offset: 0x005061D8
		public List<IVehicleMontagePlayConfigT> VehicleMontagePlayConfigs { get; set; }

		// Token: 0x1700A297 RID: 41623
		// (get) Token: 0x06024725 RID: 149285 RVA: 0x00507FE1 File Offset: 0x005061E1
		// (set) Token: 0x06024726 RID: 149286 RVA: 0x00507FE9 File Offset: 0x005061E9
		public List<ISpeedEffectConfigT> PlayerSpeedEffectConfigs { get; set; }

		// Token: 0x1700A298 RID: 41624
		// (get) Token: 0x06024727 RID: 149287 RVA: 0x00507FF2 File Offset: 0x005061F2
		// (set) Token: 0x06024728 RID: 149288 RVA: 0x00507FFA File Offset: 0x005061FA
		public byte NullMask { get; set; }

		// Token: 0x06024729 RID: 149289 RVA: 0x00508003 File Offset: 0x00506203
		public IMovementPerformConfigT()
		{
			this.VehicleMontagePlayConfigs = null;
			this.PlayerSpeedEffectConfigs = null;
			this.NullMask = 0;
		}
	}
}
