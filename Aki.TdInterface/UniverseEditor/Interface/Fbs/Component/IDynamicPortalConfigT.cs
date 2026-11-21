using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005653 RID: 22099
	public class IDynamicPortalConfigT
	{
		// Token: 0x17009ECD RID: 40653
		// (get) Token: 0x0602351B RID: 144667 RVA: 0x004DBFBB File Offset: 0x004DA1BB
		// (set) Token: 0x0602351C RID: 144668 RVA: 0x004DBFC3 File Offset: 0x004DA1C3
		public EPortalModel PortalModel { get; set; }

		// Token: 0x17009ECE RID: 40654
		// (get) Token: 0x0602351D RID: 144669 RVA: 0x004DBFCC File Offset: 0x004DA1CC
		// (set) Token: 0x0602351E RID: 144670 RVA: 0x004DBFD4 File Offset: 0x004DA1D4
		public string TemplateId { get; set; }

		// Token: 0x0602351F RID: 144671 RVA: 0x004DBFDD File Offset: 0x004DA1DD
		public IDynamicPortalConfigT()
		{
			this.PortalModel = EPortalModel.A;
			this.TemplateId = null;
		}
	}
}
