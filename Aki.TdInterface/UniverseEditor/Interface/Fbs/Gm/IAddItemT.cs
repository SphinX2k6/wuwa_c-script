using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004637 RID: 17975
	public class IAddItemT
	{
		// Token: 0x17007F8E RID: 32654
		// (get) Token: 0x0601B399 RID: 111513 RVA: 0x003E0262 File Offset: 0x003DE462
		// (set) Token: 0x0601B39A RID: 111514 RVA: 0x003E026A File Offset: 0x003DE46A
		public EGmCommand Type { get; set; }

		// Token: 0x17007F8F RID: 32655
		// (get) Token: 0x0601B39B RID: 111515 RVA: 0x003E0273 File Offset: 0x003DE473
		// (set) Token: 0x0601B39C RID: 111516 RVA: 0x003E027B File Offset: 0x003DE47B
		public int ItemId { get; set; }

		// Token: 0x17007F90 RID: 32656
		// (get) Token: 0x0601B39D RID: 111517 RVA: 0x003E0284 File Offset: 0x003DE484
		// (set) Token: 0x0601B39E RID: 111518 RVA: 0x003E028C File Offset: 0x003DE48C
		public int Count { get; set; }

		// Token: 0x0601B39F RID: 111519 RVA: 0x003E0295 File Offset: 0x003DE495
		public IAddItemT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}
