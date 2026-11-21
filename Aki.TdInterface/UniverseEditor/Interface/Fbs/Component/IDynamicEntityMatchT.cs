using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563E RID: 22078
	public class IDynamicEntityMatchT
	{
		// Token: 0x17009E94 RID: 40596
		// (get) Token: 0x06023449 RID: 144457 RVA: 0x004DA514 File Offset: 0x004D8714
		// (set) Token: 0x0602344A RID: 144458 RVA: 0x004DA51C File Offset: 0x004D871C
		public IEntityCategoryT Category { get; set; }

		// Token: 0x17009E95 RID: 40597
		// (get) Token: 0x0602344B RID: 144459 RVA: 0x004DA525 File Offset: 0x004D8725
		// (set) Token: 0x0602344C RID: 144460 RVA: 0x004DA52D File Offset: 0x004D872D
		public EEntityCategory CategoryType { get; set; }

		// Token: 0x17009E96 RID: 40598
		// (get) Token: 0x0602344D RID: 144461 RVA: 0x004DA536 File Offset: 0x004D8736
		// (set) Token: 0x0602344E RID: 144462 RVA: 0x004DA53E File Offset: 0x004D873E
		public List<int> EntityIds { get; set; }

		// Token: 0x17009E97 RID: 40599
		// (get) Token: 0x0602344F RID: 144463 RVA: 0x004DA547 File Offset: 0x004D8747
		// (set) Token: 0x06023450 RID: 144464 RVA: 0x004DA54F File Offset: 0x004D874F
		public IEntityStateT State { get; set; }

		// Token: 0x17009E98 RID: 40600
		// (get) Token: 0x06023451 RID: 144465 RVA: 0x004DA558 File Offset: 0x004D8758
		// (set) Token: 0x06023452 RID: 144466 RVA: 0x004DA560 File Offset: 0x004D8760
		public List<EEntityPropertyType> HasProperty { get; set; }

		// Token: 0x17009E99 RID: 40601
		// (get) Token: 0x06023453 RID: 144467 RVA: 0x004DA569 File Offset: 0x004D8769
		// (set) Token: 0x06023454 RID: 144468 RVA: 0x004DA571 File Offset: 0x004D8771
		public List<EEntityPropertyType> NoProperty { get; set; }

		// Token: 0x17009E9A RID: 40602
		// (get) Token: 0x06023455 RID: 144469 RVA: 0x004DA57A File Offset: 0x004D877A
		// (set) Token: 0x06023456 RID: 144470 RVA: 0x004DA582 File Offset: 0x004D8782
		public byte NullMask { get; set; }

		// Token: 0x06023457 RID: 144471 RVA: 0x004DA58B File Offset: 0x004D878B
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
