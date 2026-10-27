using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A4 RID: 26020
	public class IDestroySummonedEntitiesTypeT
	{
		// Token: 0x1700C13A RID: 49466
		// (get) Token: 0x0602D237 RID: 184887 RVA: 0x00630C77 File Offset: 0x0062EE77
		// (set) Token: 0x0602D238 RID: 184888 RVA: 0x00630C7F File Offset: 0x0062EE7F
		public ESummonEntityType Type { get; set; }

		// Token: 0x1700C13B RID: 49467
		// (get) Token: 0x0602D239 RID: 184889 RVA: 0x00630C88 File Offset: 0x0062EE88
		// (set) Token: 0x0602D23A RID: 184890 RVA: 0x00630C90 File Offset: 0x0062EE90
		public string TemplateId { get; set; }

		// Token: 0x0602D23B RID: 184891 RVA: 0x00630C99 File Offset: 0x0062EE99
		public IDestroySummonedEntitiesTypeT()
		{
			this.Type = ESummonEntityType.Vehicle;
			this.TemplateId = null;
		}
	}
}
