using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x0200471F RID: 18207
	public class ITestCaseT
	{
		// Token: 0x17008278 RID: 33400
		// (get) Token: 0x0601BF6F RID: 114543 RVA: 0x003F6A60 File Offset: 0x003F4C60
		// (set) Token: 0x0601BF70 RID: 114544 RVA: 0x003F6A68 File Offset: 0x003F4C68
		public string Id { get; set; }

		// Token: 0x17008279 RID: 33401
		// (get) Token: 0x0601BF71 RID: 114545 RVA: 0x003F6A71 File Offset: 0x003F4C71
		// (set) Token: 0x0601BF72 RID: 114546 RVA: 0x003F6A79 File Offset: 0x003F4C79
		public string Name { get; set; }

		// Token: 0x1700827A RID: 33402
		// (get) Token: 0x0601BF73 RID: 114547 RVA: 0x003F6A82 File Offset: 0x003F4C82
		// (set) Token: 0x0601BF74 RID: 114548 RVA: 0x003F6A8A File Offset: 0x003F4C8A
		public string Author { get; set; }

		// Token: 0x1700827B RID: 33403
		// (get) Token: 0x0601BF75 RID: 114549 RVA: 0x003F6A93 File Offset: 0x003F4C93
		// (set) Token: 0x0601BF76 RID: 114550 RVA: 0x003F6A9B File Offset: 0x003F4C9B
		public string Desc { get; set; }

		// Token: 0x1700827C RID: 33404
		// (get) Token: 0x0601BF77 RID: 114551 RVA: 0x003F6AA4 File Offset: 0x003F4CA4
		// (set) Token: 0x0601BF78 RID: 114552 RVA: 0x003F6AAC File Offset: 0x003F4CAC
		public List<string> Steps { get; set; }

		// Token: 0x1700827D RID: 33405
		// (get) Token: 0x0601BF79 RID: 114553 RVA: 0x003F6AB5 File Offset: 0x003F4CB5
		// (set) Token: 0x0601BF7A RID: 114554 RVA: 0x003F6ABD File Offset: 0x003F4CBD
		public string Result { get; set; }

		// Token: 0x1700827E RID: 33406
		// (get) Token: 0x0601BF7B RID: 114555 RVA: 0x003F6AC6 File Offset: 0x003F4CC6
		// (set) Token: 0x0601BF7C RID: 114556 RVA: 0x003F6ACE File Offset: 0x003F4CCE
		public int EntityId { get; set; }

		// Token: 0x0601BF7D RID: 114557 RVA: 0x003F6AD7 File Offset: 0x003F4CD7
		public ITestCaseT()
		{
			this.Id = null;
			this.Name = null;
			this.Author = null;
			this.Desc = null;
			this.Steps = null;
			this.Result = null;
			this.EntityId = 0;
		}
	}
}
