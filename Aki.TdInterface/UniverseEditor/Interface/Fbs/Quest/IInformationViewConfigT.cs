using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EA RID: 17130
	public class IInformationViewConfigT
	{
		// Token: 0x1700754F RID: 30031
		// (get) Token: 0x060180DC RID: 98524 RVA: 0x0036EA65 File Offset: 0x0036CC65
		// (set) Token: 0x060180DD RID: 98525 RVA: 0x0036EA6D File Offset: 0x0036CC6D
		public TInformationViewUnion InformationView { get; set; }

		// Token: 0x060180DE RID: 98526 RVA: 0x0036EA76 File Offset: 0x0036CC76
		public IInformationViewConfigT()
		{
			this.InformationView = null;
		}
	}
}
