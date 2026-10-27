using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200457F RID: 17791
	public class IRollBlockGridTemplateT
	{
		// Token: 0x17007E6D RID: 32365
		// (get) Token: 0x0601ADFB RID: 110075 RVA: 0x003D5FF7 File Offset: 0x003D41F7
		// (set) Token: 0x0601ADFC RID: 110076 RVA: 0x003D5FFF File Offset: 0x003D41FF
		public ERollBlockGridType GridType { get; set; }

		// Token: 0x17007E6E RID: 32366
		// (get) Token: 0x0601ADFD RID: 110077 RVA: 0x003D6008 File Offset: 0x003D4208
		// (set) Token: 0x0601ADFE RID: 110078 RVA: 0x003D6010 File Offset: 0x003D4210
		public string TemplateId { get; set; }

		// Token: 0x0601ADFF RID: 110079 RVA: 0x003D6019 File Offset: 0x003D4219
		public IRollBlockGridTemplateT()
		{
			this.GridType = ERollBlockGridType.Empty;
			this.TemplateId = null;
		}
	}
}
