using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005172 RID: 20850
	public class IEntityCategoryWeightT
	{
		// Token: 0x17009849 RID: 38985
		// (get) Token: 0x06021B24 RID: 138020 RVA: 0x004ACF63 File Offset: 0x004AB163
		// (set) Token: 0x06021B25 RID: 138021 RVA: 0x004ACF6B File Offset: 0x004AB16B
		public IStaticEntitiyMatchT EntitiyMatch { get; set; }

		// Token: 0x1700984A RID: 38986
		// (get) Token: 0x06021B26 RID: 138022 RVA: 0x004ACF74 File Offset: 0x004AB174
		// (set) Token: 0x06021B27 RID: 138023 RVA: 0x004ACF7C File Offset: 0x004AB17C
		public int Weight { get; set; }

		// Token: 0x06021B28 RID: 138024 RVA: 0x004ACF85 File Offset: 0x004AB185
		public IEntityCategoryWeightT()
		{
			this.EntitiyMatch = null;
			this.Weight = 0;
		}
	}
}
