using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004266 RID: 16998
	public class IFavoriteBtNodeInfoT
	{
		// Token: 0x170073F0 RID: 29680
		// (get) Token: 0x06017B0A RID: 97034 RVA: 0x003611A3 File Offset: 0x0035F3A3
		// (set) Token: 0x06017B0B RID: 97035 RVA: 0x003611AB File Offset: 0x0035F3AB
		public int Id { get; set; }

		// Token: 0x170073F1 RID: 29681
		// (get) Token: 0x06017B0C RID: 97036 RVA: 0x003611B4 File Offset: 0x0035F3B4
		// (set) Token: 0x06017B0D RID: 97037 RVA: 0x003611BC File Offset: 0x0035F3BC
		public string Desc { get; set; }

		// Token: 0x06017B0E RID: 97038 RVA: 0x003611C5 File Offset: 0x0035F3C5
		public IFavoriteBtNodeInfoT()
		{
			this.Id = 0;
			this.Desc = null;
		}
	}
}
