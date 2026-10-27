using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A0 RID: 17824
	public class IRollBlockItemTemplateT
	{
		// Token: 0x17007EA4 RID: 32420
		// (get) Token: 0x0601AEEF RID: 110319 RVA: 0x003D778B File Offset: 0x003D598B
		// (set) Token: 0x0601AEF0 RID: 110320 RVA: 0x003D7793 File Offset: 0x003D5993
		public ERollBlockItemType ItemType { get; set; }

		// Token: 0x17007EA5 RID: 32421
		// (get) Token: 0x0601AEF1 RID: 110321 RVA: 0x003D779C File Offset: 0x003D599C
		// (set) Token: 0x0601AEF2 RID: 110322 RVA: 0x003D77A4 File Offset: 0x003D59A4
		public string TemplateId { get; set; }

		// Token: 0x0601AEF3 RID: 110323 RVA: 0x003D77AD File Offset: 0x003D59AD
		public IRollBlockItemTemplateT()
		{
			this.ItemType = ERollBlockItemType.BreakableObstacle;
			this.TemplateId = null;
		}
	}
}
