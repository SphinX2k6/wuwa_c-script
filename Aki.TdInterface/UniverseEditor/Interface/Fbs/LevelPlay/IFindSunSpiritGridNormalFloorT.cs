using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200492D RID: 18733
	public class IFindSunSpiritGridNormalFloorT
	{
		// Token: 0x1700827F RID: 33407
		// (get) Token: 0x0601BCC1 RID: 113857 RVA: 0x003EDDA2 File Offset: 0x003EBFA2
		// (set) Token: 0x0601BCC2 RID: 113858 RVA: 0x003EDDAA File Offset: 0x003EBFAA
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x17008280 RID: 33408
		// (get) Token: 0x0601BCC3 RID: 113859 RVA: 0x003EDDB3 File Offset: 0x003EBFB3
		// (set) Token: 0x0601BCC4 RID: 113860 RVA: 0x003EDDBB File Offset: 0x003EBFBB
		public bool SpreadDevice { get; set; }

		// Token: 0x17008281 RID: 33409
		// (get) Token: 0x0601BCC5 RID: 113861 RVA: 0x003EDDC4 File Offset: 0x003EBFC4
		// (set) Token: 0x0601BCC6 RID: 113862 RVA: 0x003EDDCC File Offset: 0x003EBFCC
		public byte NullMask { get; set; }

		// Token: 0x0601BCC7 RID: 113863 RVA: 0x003EDDD5 File Offset: 0x003EBFD5
		public IFindSunSpiritGridNormalFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
			this.SpreadDevice = false;
			this.NullMask = 0;
		}
	}
}
