using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692C RID: 26924
	public class ICenterTextShowTypeT
	{
		// Token: 0x1700C63D RID: 50749
		// (get) Token: 0x0602E254 RID: 189012 RVA: 0x0064E2CA File Offset: 0x0064C4CA
		// (set) Token: 0x0602E255 RID: 189013 RVA: 0x0064E2D2 File Offset: 0x0064C4D2
		public ECenterTextShowAnim Type { get; set; }

		// Token: 0x0602E256 RID: 189014 RVA: 0x0064E2DB File Offset: 0x0064C4DB
		public ICenterTextShowTypeT()
		{
			this.Type = ECenterTextShowAnim.ShowAll;
		}
	}
}
