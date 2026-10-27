using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F62 RID: 20322
	public class ICategoryMatchingConditionT
	{
		// Token: 0x170092B8 RID: 37560
		// (get) Token: 0x060203AB RID: 132011 RVA: 0x0047C03B File Offset: 0x0047A23B
		// (set) Token: 0x060203AC RID: 132012 RVA: 0x0047C043 File Offset: 0x0047A243
		public IDynamicEntityMatchT EntityMatch { get; set; }

		// Token: 0x170092B9 RID: 37561
		// (get) Token: 0x060203AD RID: 132013 RVA: 0x0047C04C File Offset: 0x0047A24C
		// (set) Token: 0x060203AE RID: 132014 RVA: 0x0047C054 File Offset: 0x0047A254
		public string SelfState { get; set; }

		// Token: 0x060203AF RID: 132015 RVA: 0x0047C05D File Offset: 0x0047A25D
		public ICategoryMatchingConditionT()
		{
			this.EntityMatch = null;
			this.SelfState = null;
		}
	}
}
