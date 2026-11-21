using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B2C RID: 19244
	public class ITeleportToPosT
	{
		// Token: 0x170086FA RID: 34554
		// (get) Token: 0x0601D07A RID: 118906 RVA: 0x004148B3 File Offset: 0x00412AB3
		// (set) Token: 0x0601D07B RID: 118907 RVA: 0x004148BB File Offset: 0x00412ABB
		public EGmCommand Type { get; set; }

		// Token: 0x170086FB RID: 34555
		// (get) Token: 0x0601D07C RID: 118908 RVA: 0x004148C4 File Offset: 0x00412AC4
		// (set) Token: 0x0601D07D RID: 118909 RVA: 0x004148CC File Offset: 0x00412ACC
		public IPosAT Pos { get; set; }

		// Token: 0x0601D07E RID: 118910 RVA: 0x004148D5 File Offset: 0x00412AD5
		public ITeleportToPosT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Pos = null;
		}
	}
}
