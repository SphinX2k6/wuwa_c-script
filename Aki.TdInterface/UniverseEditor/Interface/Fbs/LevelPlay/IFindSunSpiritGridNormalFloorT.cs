using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C5 RID: 17605
	public class IFindSunSpiritGridNormalFloorT
	{
		// Token: 0x17007C40 RID: 31808
		// (get) Token: 0x0601A4F0 RID: 107760 RVA: 0x003C1B96 File Offset: 0x003BFD96
		// (set) Token: 0x0601A4F1 RID: 107761 RVA: 0x003C1B9E File Offset: 0x003BFD9E
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x17007C41 RID: 31809
		// (get) Token: 0x0601A4F2 RID: 107762 RVA: 0x003C1BA7 File Offset: 0x003BFDA7
		// (set) Token: 0x0601A4F3 RID: 107763 RVA: 0x003C1BAF File Offset: 0x003BFDAF
		public bool SpreadDevice { get; set; }

		// Token: 0x17007C42 RID: 31810
		// (get) Token: 0x0601A4F4 RID: 107764 RVA: 0x003C1BB8 File Offset: 0x003BFDB8
		// (set) Token: 0x0601A4F5 RID: 107765 RVA: 0x003C1BC0 File Offset: 0x003BFDC0
		public byte NullMask { get; set; }

		// Token: 0x0601A4F6 RID: 107766 RVA: 0x003C1BC9 File Offset: 0x003BFDC9
		public IFindSunSpiritGridNormalFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
			this.SpreadDevice = false;
			this.NullMask = 0;
		}
	}
}
