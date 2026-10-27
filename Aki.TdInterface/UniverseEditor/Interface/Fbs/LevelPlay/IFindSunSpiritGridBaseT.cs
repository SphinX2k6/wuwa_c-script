using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B0 RID: 17584
	public class IFindSunSpiritGridBaseT
	{
		// Token: 0x17007C1D RID: 31773
		// (get) Token: 0x0601A444 RID: 107588 RVA: 0x003C079E File Offset: 0x003BE99E
		// (set) Token: 0x0601A445 RID: 107589 RVA: 0x003C07A6 File Offset: 0x003BE9A6
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x0601A446 RID: 107590 RVA: 0x003C07AF File Offset: 0x003BE9AF
		public IFindSunSpiritGridBaseT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
		}
	}
}
