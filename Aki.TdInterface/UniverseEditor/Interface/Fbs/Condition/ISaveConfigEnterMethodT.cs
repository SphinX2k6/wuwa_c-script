using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051B5 RID: 20917
	public class ISaveConfigEnterMethodT
	{
		// Token: 0x170095CE RID: 38350
		// (get) Token: 0x06020EDD RID: 134877 RVA: 0x0048DFF2 File Offset: 0x0048C1F2
		// (set) Token: 0x06020EDE RID: 134878 RVA: 0x0048DFFA File Offset: 0x0048C1FA
		public ECondition Type { get; set; }

		// Token: 0x170095CF RID: 38351
		// (get) Token: 0x06020EDF RID: 134879 RVA: 0x0048E003 File Offset: 0x0048C203
		// (set) Token: 0x06020EE0 RID: 134880 RVA: 0x0048E00B File Offset: 0x0048C20B
		public ECompare Compare { get; set; }

		// Token: 0x170095D0 RID: 38352
		// (get) Token: 0x06020EE1 RID: 134881 RVA: 0x0048E014 File Offset: 0x0048C214
		// (set) Token: 0x06020EE2 RID: 134882 RVA: 0x0048E01C File Offset: 0x0048C21C
		public ESaveConfigEnterMethod EnterMethod { get; set; }

		// Token: 0x06020EE3 RID: 134883 RVA: 0x0048E025 File Offset: 0x0048C225
		public ISaveConfigEnterMethodT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.EnterMethod = ESaveConfigEnterMethod.FirstTime;
		}
	}
}
