using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D7 RID: 22231
	public class IEntityCategoryWeightT
	{
		// Token: 0x1700A038 RID: 41016
		// (get) Token: 0x06023A7C RID: 146044 RVA: 0x004E6F83 File Offset: 0x004E5183
		// (set) Token: 0x06023A7D RID: 146045 RVA: 0x004E6F8B File Offset: 0x004E518B
		public IStaticEntitiyMatchT EntitiyMatch { get; set; }

		// Token: 0x1700A039 RID: 41017
		// (get) Token: 0x06023A7E RID: 146046 RVA: 0x004E6F94 File Offset: 0x004E5194
		// (set) Token: 0x06023A7F RID: 146047 RVA: 0x004E6F9C File Offset: 0x004E519C
		public int Weight { get; set; }

		// Token: 0x06023A80 RID: 146048 RVA: 0x004E6FA5 File Offset: 0x004E51A5
		public IEntityCategoryWeightT()
		{
			this.EntitiyMatch = null;
			this.Weight = 0;
		}
	}
}
