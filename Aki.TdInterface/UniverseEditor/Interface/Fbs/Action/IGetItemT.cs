using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F24 RID: 28452
	public class IGetItemT
	{
		// Token: 0x1700D098 RID: 53400
		// (get) Token: 0x060313D7 RID: 201687 RVA: 0x006AC06D File Offset: 0x006AA26D
		// (set) Token: 0x060313D8 RID: 201688 RVA: 0x006AC075 File Offset: 0x006AA275
		public List<IItemDataT> Items { get; set; }

		// Token: 0x1700D099 RID: 53401
		// (get) Token: 0x060313D9 RID: 201689 RVA: 0x006AC07E File Offset: 0x006AA27E
		// (set) Token: 0x060313DA RID: 201690 RVA: 0x006AC086 File Offset: 0x006AA286
		public EItemGetUiType UiType { get; set; }

		// Token: 0x1700D09A RID: 53402
		// (get) Token: 0x060313DB RID: 201691 RVA: 0x006AC08F File Offset: 0x006AA28F
		// (set) Token: 0x060313DC RID: 201692 RVA: 0x006AC097 File Offset: 0x006AA297
		public IItemGetUiConfigSpecialQuestT UiConfig { get; set; }

		// Token: 0x1700D09B RID: 53403
		// (get) Token: 0x060313DD RID: 201693 RVA: 0x006AC0A0 File Offset: 0x006AA2A0
		// (set) Token: 0x060313DE RID: 201694 RVA: 0x006AC0A8 File Offset: 0x006AA2A8
		public byte NullMask { get; set; }

		// Token: 0x060313DF RID: 201695 RVA: 0x006AC0B1 File Offset: 0x006AA2B1
		public IGetItemT()
		{
			this.Items = null;
			this.UiType = EItemGetUiType.None;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}
