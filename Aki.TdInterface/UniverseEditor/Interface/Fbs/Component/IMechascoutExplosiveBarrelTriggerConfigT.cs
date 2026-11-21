using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABD RID: 23229
	public class IMechascoutExplosiveBarrelTriggerConfigT
	{
		// Token: 0x1700A94A RID: 43338
		// (get) Token: 0x06026171 RID: 156017 RVA: 0x00537DD6 File Offset: 0x00535FD6
		// (set) Token: 0x06026172 RID: 156018 RVA: 0x00537DDE File Offset: 0x00535FDE
		public ETeleCtrlTriggerType Type { get; set; }

		// Token: 0x06026173 RID: 156019 RVA: 0x00537DE7 File Offset: 0x00535FE7
		public IMechascoutExplosiveBarrelTriggerConfigT()
		{
			this.Type = ETeleCtrlTriggerType.MechascoutJavelin;
		}
	}
}
