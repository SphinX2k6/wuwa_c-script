using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E2B RID: 15915
	public class IFavoriteBtNodeInfoT
	{
		// Token: 0x17006E0A RID: 28170
		// (get) Token: 0x060164DD RID: 91357 RVA: 0x003385AB File Offset: 0x003367AB
		// (set) Token: 0x060164DE RID: 91358 RVA: 0x003385B3 File Offset: 0x003367B3
		public int Id { get; set; }

		// Token: 0x17006E0B RID: 28171
		// (get) Token: 0x060164DF RID: 91359 RVA: 0x003385BC File Offset: 0x003367BC
		// (set) Token: 0x060164E0 RID: 91360 RVA: 0x003385C4 File Offset: 0x003367C4
		public string Desc { get; set; }

		// Token: 0x060164E1 RID: 91361 RVA: 0x003385CD File Offset: 0x003367CD
		public IFavoriteBtNodeInfoT()
		{
			this.Id = 0;
			this.Desc = null;
		}
	}
}
