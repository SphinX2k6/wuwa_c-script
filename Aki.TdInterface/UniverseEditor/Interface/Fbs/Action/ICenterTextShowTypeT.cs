using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062BB RID: 25275
	public class ICenterTextShowTypeT
	{
		// Token: 0x1700BCB3 RID: 48307
		// (get) Token: 0x0602BAEB RID: 178923 RVA: 0x006032BE File Offset: 0x006014BE
		// (set) Token: 0x0602BAEC RID: 178924 RVA: 0x006032C6 File Offset: 0x006014C6
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x0602BAED RID: 178925 RVA: 0x006032CF File Offset: 0x006014CF
		public ICenterTextShowTypeT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
		}
	}
}
