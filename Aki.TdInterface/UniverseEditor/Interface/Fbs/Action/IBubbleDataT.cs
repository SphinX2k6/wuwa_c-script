using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689F RID: 26783
	public class IBubbleDataT
	{
		// Token: 0x1700C4CF RID: 50383
		// (get) Token: 0x0602DC95 RID: 187541 RVA: 0x006421F3 File Offset: 0x006403F3
		// (set) Token: 0x0602DC96 RID: 187542 RVA: 0x006421FB File Offset: 0x006403FB
		public IBubbleIndexT FlowIndex { get; set; }

		// Token: 0x1700C4D0 RID: 50384
		// (get) Token: 0x0602DC97 RID: 187543 RVA: 0x00642204 File Offset: 0x00640404
		// (set) Token: 0x0602DC98 RID: 187544 RVA: 0x0064220C File Offset: 0x0064040C
		public int WaitTime { get; set; }

		// Token: 0x0602DC99 RID: 187545 RVA: 0x00642215 File Offset: 0x00640415
		public IBubbleDataT()
		{
			this.FlowIndex = null;
			this.WaitTime = 0;
		}
	}
}
