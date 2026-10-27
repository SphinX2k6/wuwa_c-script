using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004866 RID: 18534
	public class IEditorRestartInfoT
	{
		// Token: 0x1700857B RID: 34171
		// (get) Token: 0x0601CC22 RID: 117794 RVA: 0x00410A44 File Offset: 0x0040EC44
		// (set) Token: 0x0601CC23 RID: 117795 RVA: 0x00410A4C File Offset: 0x0040EC4C
		public bool IsRestarting { get; set; }

		// Token: 0x1700857C RID: 34172
		// (get) Token: 0x0601CC24 RID: 117796 RVA: 0x00410A55 File Offset: 0x0040EC55
		// (set) Token: 0x0601CC25 RID: 117797 RVA: 0x00410A5D File Offset: 0x0040EC5D
		public bool IsUseIdleLoad { get; set; }

		// Token: 0x1700857D RID: 34173
		// (get) Token: 0x0601CC26 RID: 117798 RVA: 0x00410A66 File Offset: 0x0040EC66
		// (set) Token: 0x0601CC27 RID: 117799 RVA: 0x00410A6E File Offset: 0x0040EC6E
		public TEditorRestartReason Reason { get; set; }

		// Token: 0x1700857E RID: 34174
		// (get) Token: 0x0601CC28 RID: 117800 RVA: 0x00410A77 File Offset: 0x0040EC77
		// (set) Token: 0x0601CC29 RID: 117801 RVA: 0x00410A7F File Offset: 0x0040EC7F
		public long Timestamp { get; set; }

		// Token: 0x0601CC2A RID: 117802 RVA: 0x00410A88 File Offset: 0x0040EC88
		public IEditorRestartInfoT()
		{
			this.IsRestarting = false;
			this.IsUseIdleLoad = false;
			this.Reason = TEditorRestartReason.ChangeMap;
			this.Timestamp = 0L;
		}
	}
}
