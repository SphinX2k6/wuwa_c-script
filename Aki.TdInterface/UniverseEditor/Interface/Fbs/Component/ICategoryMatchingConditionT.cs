using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005491 RID: 21649
	public class ICategoryMatchingConditionT
	{
		// Token: 0x17009A31 RID: 39473
		// (get) Token: 0x060220FD RID: 139517 RVA: 0x004B202B File Offset: 0x004B022B
		// (set) Token: 0x060220FE RID: 139518 RVA: 0x004B2033 File Offset: 0x004B0233
		public IDynamicEntityMatchT EntityMatch { get; set; }

		// Token: 0x17009A32 RID: 39474
		// (get) Token: 0x060220FF RID: 139519 RVA: 0x004B203C File Offset: 0x004B023C
		// (set) Token: 0x06022100 RID: 139520 RVA: 0x004B2044 File Offset: 0x004B0244
		public string SelfState { get; set; }

		// Token: 0x06022101 RID: 139521 RVA: 0x004B204D File Offset: 0x004B024D
		public ICategoryMatchingConditionT()
		{
			this.EntityMatch = null;
			this.SelfState = null;
		}
	}
}
