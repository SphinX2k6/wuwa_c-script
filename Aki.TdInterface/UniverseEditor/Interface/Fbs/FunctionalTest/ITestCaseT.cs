using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004B87 RID: 19335
	public class ITestCaseT
	{
		// Token: 0x170088B9 RID: 35001
		// (get) Token: 0x0601D744 RID: 120644 RVA: 0x00422CFC File Offset: 0x00420EFC
		// (set) Token: 0x0601D745 RID: 120645 RVA: 0x00422D04 File Offset: 0x00420F04
		public string Id { get; set; }

		// Token: 0x170088BA RID: 35002
		// (get) Token: 0x0601D746 RID: 120646 RVA: 0x00422D0D File Offset: 0x00420F0D
		// (set) Token: 0x0601D747 RID: 120647 RVA: 0x00422D15 File Offset: 0x00420F15
		public string Name { get; set; }

		// Token: 0x170088BB RID: 35003
		// (get) Token: 0x0601D748 RID: 120648 RVA: 0x00422D1E File Offset: 0x00420F1E
		// (set) Token: 0x0601D749 RID: 120649 RVA: 0x00422D26 File Offset: 0x00420F26
		public string Author { get; set; }

		// Token: 0x170088BC RID: 35004
		// (get) Token: 0x0601D74A RID: 120650 RVA: 0x00422D2F File Offset: 0x00420F2F
		// (set) Token: 0x0601D74B RID: 120651 RVA: 0x00422D37 File Offset: 0x00420F37
		public string Desc { get; set; }

		// Token: 0x170088BD RID: 35005
		// (get) Token: 0x0601D74C RID: 120652 RVA: 0x00422D40 File Offset: 0x00420F40
		// (set) Token: 0x0601D74D RID: 120653 RVA: 0x00422D48 File Offset: 0x00420F48
		public List<string> Steps { get; set; }

		// Token: 0x170088BE RID: 35006
		// (get) Token: 0x0601D74E RID: 120654 RVA: 0x00422D51 File Offset: 0x00420F51
		// (set) Token: 0x0601D74F RID: 120655 RVA: 0x00422D59 File Offset: 0x00420F59
		public string Result { get; set; }

		// Token: 0x170088BF RID: 35007
		// (get) Token: 0x0601D750 RID: 120656 RVA: 0x00422D62 File Offset: 0x00420F62
		// (set) Token: 0x0601D751 RID: 120657 RVA: 0x00422D6A File Offset: 0x00420F6A
		public int EntityId { get; set; }

		// Token: 0x0601D752 RID: 120658 RVA: 0x00422D73 File Offset: 0x00420F73
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
