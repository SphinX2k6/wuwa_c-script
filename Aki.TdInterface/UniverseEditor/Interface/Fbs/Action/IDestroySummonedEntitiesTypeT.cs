using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0C RID: 27660
	public class IDestroySummonedEntitiesTypeT
	{
		// Token: 0x1700CAC9 RID: 51913
		// (get) Token: 0x0602F9BB RID: 195003 RVA: 0x0067CE3B File Offset: 0x0067B03B
		// (set) Token: 0x0602F9BC RID: 195004 RVA: 0x0067CE43 File Offset: 0x0067B043
		public ESummonEntityType Type { get; set; }

		// Token: 0x1700CACA RID: 51914
		// (get) Token: 0x0602F9BD RID: 195005 RVA: 0x0067CE4C File Offset: 0x0067B04C
		// (set) Token: 0x0602F9BE RID: 195006 RVA: 0x0067CE54 File Offset: 0x0067B054
		public string TemplateId { get; set; }

		// Token: 0x0602F9BF RID: 195007 RVA: 0x0067CE5D File Offset: 0x0067B05D
		public IDestroySummonedEntitiesTypeT()
		{
			this.Type = ESummonEntityType.Vehicle;
			this.TemplateId = null;
		}
	}
}
