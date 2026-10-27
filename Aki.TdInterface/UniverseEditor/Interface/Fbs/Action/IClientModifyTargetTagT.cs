using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063DA RID: 25562
	public class IClientModifyTargetTagT
	{
		// Token: 0x1700BE6C RID: 48748
		// (get) Token: 0x0602C383 RID: 181123 RVA: 0x00611FB2 File Offset: 0x006101B2
		// (set) Token: 0x0602C384 RID: 181124 RVA: 0x00611FBA File Offset: 0x006101BA
		public bool IsAddTag { get; set; }

		// Token: 0x1700BE6D RID: 48749
		// (get) Token: 0x0602C385 RID: 181125 RVA: 0x00611FC3 File Offset: 0x006101C3
		// (set) Token: 0x0602C386 RID: 181126 RVA: 0x00611FCB File Offset: 0x006101CB
		public TClientModifyTargetUnion Target { get; set; }

		// Token: 0x1700BE6E RID: 48750
		// (get) Token: 0x0602C387 RID: 181127 RVA: 0x00611FD4 File Offset: 0x006101D4
		// (set) Token: 0x0602C388 RID: 181128 RVA: 0x00611FDC File Offset: 0x006101DC
		public List<string> PerformanceTag { get; set; }

		// Token: 0x0602C389 RID: 181129 RVA: 0x00611FE5 File Offset: 0x006101E5
		public IClientModifyTargetTagT()
		{
			this.IsAddTag = false;
			this.Target = null;
			this.PerformanceTag = null;
		}
	}
}
