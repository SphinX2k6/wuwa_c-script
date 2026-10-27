using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DE RID: 22238
	public class IPasserbyNpcSpawnCountOverrideT
	{
		// Token: 0x1700A587 RID: 42375
		// (get) Token: 0x0602527C RID: 152188 RVA: 0x00520F96 File Offset: 0x0051F196
		// (set) Token: 0x0602527D RID: 152189 RVA: 0x00520F9E File Offset: 0x0051F19E
		public int PcSpawnCount { get; set; }

		// Token: 0x1700A588 RID: 42376
		// (get) Token: 0x0602527E RID: 152190 RVA: 0x00520FA7 File Offset: 0x0051F1A7
		// (set) Token: 0x0602527F RID: 152191 RVA: 0x00520FAF File Offset: 0x0051F1AF
		public int MobileSpawnCount { get; set; }

		// Token: 0x1700A589 RID: 42377
		// (get) Token: 0x06025280 RID: 152192 RVA: 0x00520FB8 File Offset: 0x0051F1B8
		// (set) Token: 0x06025281 RID: 152193 RVA: 0x00520FC0 File Offset: 0x0051F1C0
		public byte NullMask { get; set; }

		// Token: 0x06025282 RID: 152194 RVA: 0x00520FC9 File Offset: 0x0051F1C9
		public IPasserbyNpcSpawnCountOverrideT()
		{
			this.PcSpawnCount = 0;
			this.MobileSpawnCount = 0;
			this.NullMask = 0;
		}
	}
}
