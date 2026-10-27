using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C3 RID: 22979
	public class IStaticEntitiyMatchT
	{
		// Token: 0x1700AC7B RID: 44155
		// (get) Token: 0x06026F2B RID: 159531 RVA: 0x0055BC51 File Offset: 0x00559E51
		// (set) Token: 0x06026F2C RID: 159532 RVA: 0x0055BC59 File Offset: 0x00559E59
		public IEntityCategoryT Category { get; set; }

		// Token: 0x1700AC7C RID: 44156
		// (get) Token: 0x06026F2D RID: 159533 RVA: 0x0055BC62 File Offset: 0x00559E62
		// (set) Token: 0x06026F2E RID: 159534 RVA: 0x0055BC6A File Offset: 0x00559E6A
		public EEntityCategory CategoryType { get; set; }

		// Token: 0x1700AC7D RID: 44157
		// (get) Token: 0x06026F2F RID: 159535 RVA: 0x0055BC73 File Offset: 0x00559E73
		// (set) Token: 0x06026F30 RID: 159536 RVA: 0x0055BC7B File Offset: 0x00559E7B
		public byte NullMask { get; set; }

		// Token: 0x06026F31 RID: 159537 RVA: 0x0055BC84 File Offset: 0x00559E84
		public IStaticEntitiyMatchT()
		{
			this.Category = null;
			this.CategoryType = EEntityCategory.MonsterMatchType;
			this.NullMask = 0;
		}
	}
}
