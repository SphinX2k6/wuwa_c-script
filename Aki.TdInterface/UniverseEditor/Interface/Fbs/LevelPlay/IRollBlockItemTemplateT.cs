using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A08 RID: 18952
	public class IRollBlockItemTemplateT
	{
		// Token: 0x170084E5 RID: 34021
		// (get) Token: 0x0601C6C4 RID: 116420 RVA: 0x00403A27 File Offset: 0x00401C27
		// (set) Token: 0x0601C6C5 RID: 116421 RVA: 0x00403A2F File Offset: 0x00401C2F
		public ERollBlockItemType ItemType { get; set; }

		// Token: 0x170084E6 RID: 34022
		// (get) Token: 0x0601C6C6 RID: 116422 RVA: 0x00403A38 File Offset: 0x00401C38
		// (set) Token: 0x0601C6C7 RID: 116423 RVA: 0x00403A40 File Offset: 0x00401C40
		public string TemplateId { get; set; }

		// Token: 0x0601C6C8 RID: 116424 RVA: 0x00403A49 File Offset: 0x00401C49
		public IRollBlockItemTemplateT()
		{
			this.ItemType = ERollBlockItemType.BreakableObstacle;
			this.TemplateId = null;
		}
	}
}
