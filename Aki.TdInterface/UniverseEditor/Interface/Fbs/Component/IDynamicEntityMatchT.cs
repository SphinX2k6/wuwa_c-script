using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D9 RID: 20697
	public class IDynamicEntityMatchT
	{
		// Token: 0x170096A7 RID: 38567
		// (get) Token: 0x060214F5 RID: 136437 RVA: 0x004A0588 File Offset: 0x0049E788
		// (set) Token: 0x060214F6 RID: 136438 RVA: 0x004A0590 File Offset: 0x0049E790
		public IEntityCategoryT Category { get; set; }

		// Token: 0x170096A8 RID: 38568
		// (get) Token: 0x060214F7 RID: 136439 RVA: 0x004A0599 File Offset: 0x0049E799
		// (set) Token: 0x060214F8 RID: 136440 RVA: 0x004A05A1 File Offset: 0x0049E7A1
		public EEntityCategory CategoryType { get; set; }

		// Token: 0x170096A9 RID: 38569
		// (get) Token: 0x060214F9 RID: 136441 RVA: 0x004A05AA File Offset: 0x0049E7AA
		// (set) Token: 0x060214FA RID: 136442 RVA: 0x004A05B2 File Offset: 0x0049E7B2
		public List<int> EntityIds { get; set; }

		// Token: 0x170096AA RID: 38570
		// (get) Token: 0x060214FB RID: 136443 RVA: 0x004A05BB File Offset: 0x0049E7BB
		// (set) Token: 0x060214FC RID: 136444 RVA: 0x004A05C3 File Offset: 0x0049E7C3
		public IEntityStateT State { get; set; }

		// Token: 0x170096AB RID: 38571
		// (get) Token: 0x060214FD RID: 136445 RVA: 0x004A05CC File Offset: 0x0049E7CC
		// (set) Token: 0x060214FE RID: 136446 RVA: 0x004A05D4 File Offset: 0x0049E7D4
		public List<EEntityPropertyType> HasProperty { get; set; }

		// Token: 0x170096AC RID: 38572
		// (get) Token: 0x060214FF RID: 136447 RVA: 0x004A05DD File Offset: 0x0049E7DD
		// (set) Token: 0x06021500 RID: 136448 RVA: 0x004A05E5 File Offset: 0x0049E7E5
		public List<EEntityPropertyType> NoProperty { get; set; }

		// Token: 0x170096AD RID: 38573
		// (get) Token: 0x06021501 RID: 136449 RVA: 0x004A05EE File Offset: 0x0049E7EE
		// (set) Token: 0x06021502 RID: 136450 RVA: 0x004A05F6 File Offset: 0x0049E7F6
		public byte NullMask { get; set; }

		// Token: 0x06021503 RID: 136451 RVA: 0x004A05FF File Offset: 0x0049E7FF
		public IDynamicEntityMatchT()
		{
			this.Category = null;
			this.CategoryType = EEntityCategory.MonsterMatchType;
			this.EntityIds = null;
			this.State = null;
			this.HasProperty = null;
			this.NoProperty = null;
			this.NullMask = 0;
		}
	}
}
