using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EA RID: 26602
	public class IFloorSettingsT
	{
		// Token: 0x1700C570 RID: 50544
		// (get) Token: 0x0602E509 RID: 189705 RVA: 0x00652B2E File Offset: 0x00650D2E
		// (set) Token: 0x0602E50A RID: 189706 RVA: 0x00652B36 File Offset: 0x00650D36
		public string MeshPath { get; set; }

		// Token: 0x1700C571 RID: 50545
		// (get) Token: 0x0602E50B RID: 189707 RVA: 0x00652B3F File Offset: 0x00650D3F
		// (set) Token: 0x0602E50C RID: 189708 RVA: 0x00652B47 File Offset: 0x00650D47
		public string MaterialPath { get; set; }

		// Token: 0x1700C572 RID: 50546
		// (get) Token: 0x0602E50D RID: 189709 RVA: 0x00652B50 File Offset: 0x00650D50
		// (set) Token: 0x0602E50E RID: 189710 RVA: 0x00652B58 File Offset: 0x00650D58
		public IVector2T Scale { get; set; }

		// Token: 0x1700C573 RID: 50547
		// (get) Token: 0x0602E50F RID: 189711 RVA: 0x00652B61 File Offset: 0x00650D61
		// (set) Token: 0x0602E510 RID: 189712 RVA: 0x00652B69 File Offset: 0x00650D69
		public float ShowTime { get; set; }

		// Token: 0x1700C574 RID: 50548
		// (get) Token: 0x0602E511 RID: 189713 RVA: 0x00652B72 File Offset: 0x00650D72
		// (set) Token: 0x0602E512 RID: 189714 RVA: 0x00652B7A File Offset: 0x00650D7A
		public float DisappearTime { get; set; }

		// Token: 0x0602E513 RID: 189715 RVA: 0x00652B83 File Offset: 0x00650D83
		public IFloorSettingsT()
		{
			this.MeshPath = null;
			this.MaterialPath = null;
			this.Scale = null;
			this.ShowTime = 0f;
			this.DisappearTime = 0f;
		}
	}
}
