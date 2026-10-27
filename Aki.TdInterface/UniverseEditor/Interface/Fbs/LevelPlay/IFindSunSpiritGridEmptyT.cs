using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044BC RID: 17596
	public class IFindSunSpiritGridEmptyT
	{
		// Token: 0x17007C2D RID: 31789
		// (get) Token: 0x0601A4A6 RID: 107686 RVA: 0x003C146E File Offset: 0x003BF66E
		// (set) Token: 0x0601A4A7 RID: 107687 RVA: 0x003C1476 File Offset: 0x003BF676
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x17007C2E RID: 31790
		// (get) Token: 0x0601A4A8 RID: 107688 RVA: 0x003C147F File Offset: 0x003BF67F
		// (set) Token: 0x0601A4A9 RID: 107689 RVA: 0x003C1487 File Offset: 0x003BF687
		public bool SpreadDevice { get; set; }

		// Token: 0x17007C2F RID: 31791
		// (get) Token: 0x0601A4AA RID: 107690 RVA: 0x003C1490 File Offset: 0x003BF690
		// (set) Token: 0x0601A4AB RID: 107691 RVA: 0x003C1498 File Offset: 0x003BF698
		public byte NullMask { get; set; }

		// Token: 0x0601A4AC RID: 107692 RVA: 0x003C14A1 File Offset: 0x003BF6A1
		public IFindSunSpiritGridEmptyT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
			this.SpreadDevice = false;
			this.NullMask = 0;
		}
	}
}
