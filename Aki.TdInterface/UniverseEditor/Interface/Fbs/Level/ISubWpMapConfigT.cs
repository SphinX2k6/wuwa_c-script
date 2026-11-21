using System;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004881 RID: 18561
	public class ISubWpMapConfigT
	{
		// Token: 0x1700813D RID: 33085
		// (get) Token: 0x0601B749 RID: 112457 RVA: 0x003E2BF6 File Offset: 0x003E0DF6
		// (set) Token: 0x0601B74A RID: 112458 RVA: 0x003E2BFE File Offset: 0x003E0DFE
		public int Id { get; set; }

		// Token: 0x1700813E RID: 33086
		// (get) Token: 0x0601B74B RID: 112459 RVA: 0x003E2C07 File Offset: 0x003E0E07
		// (set) Token: 0x0601B74C RID: 112460 RVA: 0x003E2C0F File Offset: 0x003E0E0F
		public string Name { get; set; }

		// Token: 0x1700813F RID: 33087
		// (get) Token: 0x0601B74D RID: 112461 RVA: 0x003E2C18 File Offset: 0x003E0E18
		// (set) Token: 0x0601B74E RID: 112462 RVA: 0x003E2C20 File Offset: 0x003E0E20
		public string ContentPath { get; set; }

		// Token: 0x17008140 RID: 33088
		// (get) Token: 0x0601B74F RID: 112463 RVA: 0x003E2C29 File Offset: 0x003E0E29
		// (set) Token: 0x0601B750 RID: 112464 RVA: 0x003E2C31 File Offset: 0x003E0E31
		public bool IsTest { get; set; }

		// Token: 0x0601B751 RID: 112465 RVA: 0x003E2C3A File Offset: 0x003E0E3A
		public ISubWpMapConfigT()
		{
			this.Id = 0;
			this.Name = null;
			this.ContentPath = null;
			this.IsTest = false;
		}
	}
}
