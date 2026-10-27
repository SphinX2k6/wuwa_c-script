using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B6 RID: 17590
	public class IFindSunSpiritGridBeginFloorT
	{
		// Token: 0x17007C22 RID: 31778
		// (get) Token: 0x0601A46A RID: 107626 RVA: 0x003C0B26 File Offset: 0x003BED26
		// (set) Token: 0x0601A46B RID: 107627 RVA: 0x003C0B2E File Offset: 0x003BED2E
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x0601A46C RID: 107628 RVA: 0x003C0B37 File Offset: 0x003BED37
		public IFindSunSpiritGridBeginFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
		}
	}
}
