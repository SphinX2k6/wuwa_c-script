using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005498 RID: 21656
	public class IItemFoundationTypeT
	{
		// Token: 0x17009F7B RID: 40827
		// (get) Token: 0x06023A54 RID: 146004 RVA: 0x004EDB1E File Offset: 0x004EBD1E
		// (set) Token: 0x06023A55 RID: 146005 RVA: 0x004EDB26 File Offset: 0x004EBD26
		public EItemFoundation Type { get; set; }

		// Token: 0x06023A56 RID: 146006 RVA: 0x004EDB2F File Offset: 0x004EBD2F
		public IItemFoundationTypeT()
		{
			this.Type = EItemFoundation.CategoryMatching;
		}
	}
}
