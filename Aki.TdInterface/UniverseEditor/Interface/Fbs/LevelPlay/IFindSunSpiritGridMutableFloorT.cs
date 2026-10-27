using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C2 RID: 17602
	public class IFindSunSpiritGridMutableFloorT
	{
		// Token: 0x17007C38 RID: 31800
		// (get) Token: 0x0601A4D4 RID: 107732 RVA: 0x003C18DC File Offset: 0x003BFADC
		// (set) Token: 0x0601A4D5 RID: 107733 RVA: 0x003C18E4 File Offset: 0x003BFAE4
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x17007C39 RID: 31801
		// (get) Token: 0x0601A4D6 RID: 107734 RVA: 0x003C18ED File Offset: 0x003BFAED
		// (set) Token: 0x0601A4D7 RID: 107735 RVA: 0x003C18F5 File Offset: 0x003BFAF5
		public EFindSunSpiritGridState State { get; set; }

		// Token: 0x17007C3A RID: 31802
		// (get) Token: 0x0601A4D8 RID: 107736 RVA: 0x003C18FE File Offset: 0x003BFAFE
		// (set) Token: 0x0601A4D9 RID: 107737 RVA: 0x003C1906 File Offset: 0x003BFB06
		public bool SpreadDevice { get; set; }

		// Token: 0x17007C3B RID: 31803
		// (get) Token: 0x0601A4DA RID: 107738 RVA: 0x003C190F File Offset: 0x003BFB0F
		// (set) Token: 0x0601A4DB RID: 107739 RVA: 0x003C1917 File Offset: 0x003BFB17
		public byte NullMask { get; set; }

		// Token: 0x0601A4DC RID: 107740 RVA: 0x003C1920 File Offset: 0x003BFB20
		public IFindSunSpiritGridMutableFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
			this.State = EFindSunSpiritGridState.Virtual;
			this.SpreadDevice = false;
			this.NullMask = 0;
		}
	}
}
