using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E8 RID: 16872
	public class ITrackAreaTextT
	{
		// Token: 0x170077B3 RID: 30643
		// (get) Token: 0x06018E0C RID: 101900 RVA: 0x003944FB File Offset: 0x003926FB
		// (set) Token: 0x06018E0D RID: 101901 RVA: 0x00394503 File Offset: 0x00392703
		public bool Show { get; set; }

		// Token: 0x170077B4 RID: 30644
		// (get) Token: 0x06018E0E RID: 101902 RVA: 0x0039450C File Offset: 0x0039270C
		// (set) Token: 0x06018E0F RID: 101903 RVA: 0x00394514 File Offset: 0x00392714
		public string Tid { get; set; }

		// Token: 0x06018E10 RID: 101904 RVA: 0x0039451D File Offset: 0x0039271D
		public ITrackAreaTextT()
		{
			this.Show = false;
			this.Tid = null;
		}
	}
}
