using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048AF RID: 18607
	public class IChildDestroyRefreshT
	{
		// Token: 0x17008167 RID: 33127
		// (get) Token: 0x0601B7F1 RID: 112625 RVA: 0x003E3CCA File Offset: 0x003E1ECA
		// (set) Token: 0x0601B7F2 RID: 112626 RVA: 0x003E3CD2 File Offset: 0x003E1ED2
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17008168 RID: 33128
		// (get) Token: 0x0601B7F3 RID: 112627 RVA: 0x003E3CDB File Offset: 0x003E1EDB
		// (set) Token: 0x0601B7F4 RID: 112628 RVA: 0x003E3CE3 File Offset: 0x003E1EE3
		public int MinRefreshCd { get; set; }

		// Token: 0x17008169 RID: 33129
		// (get) Token: 0x0601B7F5 RID: 112629 RVA: 0x003E3CEC File Offset: 0x003E1EEC
		// (set) Token: 0x0601B7F6 RID: 112630 RVA: 0x003E3CF4 File Offset: 0x003E1EF4
		public int MaxRefreshCd { get; set; }

		// Token: 0x0601B7F7 RID: 112631 RVA: 0x003E3CFD File Offset: 0x003E1EFD
		public IChildDestroyRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.MinRefreshCd = 0;
			this.MaxRefreshCd = 0;
		}
	}
}
