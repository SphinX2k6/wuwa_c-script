using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044BF RID: 17599
	public class IFindSunSpiritGridEndFloorT
	{
		// Token: 0x17007C32 RID: 31794
		// (get) Token: 0x0601A4BC RID: 107708 RVA: 0x003C163E File Offset: 0x003BF83E
		// (set) Token: 0x0601A4BD RID: 107709 RVA: 0x003C1646 File Offset: 0x003BF846
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x0601A4BE RID: 107710 RVA: 0x003C164F File Offset: 0x003BF84F
		public IFindSunSpiritGridEndFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
		}
	}
}
