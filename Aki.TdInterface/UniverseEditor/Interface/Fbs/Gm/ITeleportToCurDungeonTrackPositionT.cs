using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B1D RID: 19229
	public class ITeleportToCurDungeonTrackPositionT
	{
		// Token: 0x170086D1 RID: 34513
		// (get) Token: 0x0601CFEC RID: 118764 RVA: 0x00413A08 File Offset: 0x00411C08
		// (set) Token: 0x0601CFED RID: 118765 RVA: 0x00413A10 File Offset: 0x00411C10
		public EGmCommand Type { get; set; }

		// Token: 0x170086D2 RID: 34514
		// (get) Token: 0x0601CFEE RID: 118766 RVA: 0x00413A19 File Offset: 0x00411C19
		// (set) Token: 0x0601CFEF RID: 118767 RVA: 0x00413A21 File Offset: 0x00411C21
		public int NodeId { get; set; }

		// Token: 0x170086D3 RID: 34515
		// (get) Token: 0x0601CFF0 RID: 118768 RVA: 0x00413A2A File Offset: 0x00411C2A
		// (set) Token: 0x0601CFF1 RID: 118769 RVA: 0x00413A32 File Offset: 0x00411C32
		public int NodeIndex { get; set; }

		// Token: 0x170086D4 RID: 34516
		// (get) Token: 0x0601CFF2 RID: 118770 RVA: 0x00413A3B File Offset: 0x00411C3B
		// (set) Token: 0x0601CFF3 RID: 118771 RVA: 0x00413A43 File Offset: 0x00411C43
		public byte NullMask { get; set; }

		// Token: 0x0601CFF4 RID: 118772 RVA: 0x00413A4C File Offset: 0x00411C4C
		public ITeleportToCurDungeonTrackPositionT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.NullMask = 0;
		}
	}
}
