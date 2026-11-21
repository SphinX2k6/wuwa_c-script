using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562C RID: 22060
	public class IDurabilityStateT
	{
		// Token: 0x17009E69 RID: 40553
		// (get) Token: 0x0602338B RID: 144267 RVA: 0x004D8DE3 File Offset: 0x004D6FE3
		// (set) Token: 0x0602338C RID: 144268 RVA: 0x004D8DEB File Offset: 0x004D6FEB
		public int Durability { get; set; }

		// Token: 0x17009E6A RID: 40554
		// (get) Token: 0x0602338D RID: 144269 RVA: 0x004D8DF4 File Offset: 0x004D6FF4
		// (set) Token: 0x0602338E RID: 144270 RVA: 0x004D8DFC File Offset: 0x004D6FFC
		public string State { get; set; }

		// Token: 0x0602338F RID: 144271 RVA: 0x004D8E05 File Offset: 0x004D7005
		public IDurabilityStateT()
		{
			this.Durability = 0;
			this.State = null;
		}
	}
}
