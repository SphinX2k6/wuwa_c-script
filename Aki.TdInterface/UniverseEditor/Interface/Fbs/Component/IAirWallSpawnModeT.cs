using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AA RID: 21418
	public class IAirWallSpawnModeT
	{
		// Token: 0x1700978C RID: 38796
		// (get) Token: 0x060216FB RID: 136955 RVA: 0x0049CF5A File Offset: 0x0049B15A
		// (set) Token: 0x060216FC RID: 136956 RVA: 0x0049CF62 File Offset: 0x0049B162
		public EAirWallSpawnMode Type { get; set; }

		// Token: 0x060216FD RID: 136957 RVA: 0x0049CF6B File Offset: 0x0049B16B
		public IAirWallSpawnModeT()
		{
			this.Type = EAirWallSpawnMode.Whole;
		}
	}
}
