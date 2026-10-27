using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200476D RID: 18285
	public class IPerformanceSettingT
	{
		// Token: 0x17008329 RID: 33577
		// (get) Token: 0x0601C277 RID: 115319 RVA: 0x003FCF30 File Offset: 0x003FB130
		// (set) Token: 0x0601C278 RID: 115320 RVA: 0x003FCF38 File Offset: 0x003FB138
		public string Author { get; set; }

		// Token: 0x1700832A RID: 33578
		// (get) Token: 0x0601C279 RID: 115321 RVA: 0x003FCF41 File Offset: 0x003FB141
		// (set) Token: 0x0601C27A RID: 115322 RVA: 0x003FCF49 File Offset: 0x003FB149
		public string Note { get; set; }

		// Token: 0x1700832B RID: 33579
		// (get) Token: 0x0601C27B RID: 115323 RVA: 0x003FCF52 File Offset: 0x003FB152
		// (set) Token: 0x0601C27C RID: 115324 RVA: 0x003FCF5A File Offset: 0x003FB15A
		public bool EnableOptimize { get; set; }

		// Token: 0x1700832C RID: 33580
		// (get) Token: 0x0601C27D RID: 115325 RVA: 0x003FCF63 File Offset: 0x003FB163
		// (set) Token: 0x0601C27E RID: 115326 RVA: 0x003FCF6B File Offset: 0x003FB16B
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700832D RID: 33581
		// (get) Token: 0x0601C27F RID: 115327 RVA: 0x003FCF74 File Offset: 0x003FB174
		// (set) Token: 0x0601C280 RID: 115328 RVA: 0x003FCF7C File Offset: 0x003FB17C
		public IHighPerformanceModeT Mode { get; set; }

		// Token: 0x0601C281 RID: 115329 RVA: 0x003FCF85 File Offset: 0x003FB185
		public IPerformanceSettingT()
		{
			this.Author = null;
			this.Note = null;
			this.EnableOptimize = false;
			this.RangeEntities = null;
			this.Mode = null;
		}
	}
}
