using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200487B RID: 18555
	public class IFlowEditorConfigT
	{
		// Token: 0x1700864D RID: 34381
		// (get) Token: 0x0601CE80 RID: 118400 RVA: 0x00415F04 File Offset: 0x00414104
		// (set) Token: 0x0601CE81 RID: 118401 RVA: 0x00415F0C File Offset: 0x0041410C
		public string CsvExportPath { get; set; }

		// Token: 0x1700864E RID: 34382
		// (get) Token: 0x0601CE82 RID: 118402 RVA: 0x00415F15 File Offset: 0x00414115
		// (set) Token: 0x0601CE83 RID: 118403 RVA: 0x00415F1D File Offset: 0x0041411D
		public string CsvImportPath { get; set; }

		// Token: 0x1700864F RID: 34383
		// (get) Token: 0x0601CE84 RID: 118404 RVA: 0x00415F26 File Offset: 0x00414126
		// (set) Token: 0x0601CE85 RID: 118405 RVA: 0x00415F2E File Offset: 0x0041412E
		public string PlotRootDir { get; set; }

		// Token: 0x17008650 RID: 34384
		// (get) Token: 0x0601CE86 RID: 118406 RVA: 0x00415F37 File Offset: 0x00414137
		// (set) Token: 0x0601CE87 RID: 118407 RVA: 0x00415F3F File Offset: 0x0041413F
		public bool IsVerbose { get; set; }

		// Token: 0x17008651 RID: 34385
		// (get) Token: 0x0601CE88 RID: 118408 RVA: 0x00415F48 File Offset: 0x00414148
		// (set) Token: 0x0601CE89 RID: 118409 RVA: 0x00415F50 File Offset: 0x00414150
		public bool ShowActionFilter { get; set; }

		// Token: 0x17008652 RID: 34386
		// (get) Token: 0x0601CE8A RID: 118410 RVA: 0x00415F59 File Offset: 0x00414159
		// (set) Token: 0x0601CE8B RID: 118411 RVA: 0x00415F61 File Offset: 0x00414161
		public bool ShowTextHiddenStatus { get; set; }

		// Token: 0x17008653 RID: 34387
		// (get) Token: 0x0601CE8C RID: 118412 RVA: 0x00415F6A File Offset: 0x0041416A
		// (set) Token: 0x0601CE8D RID: 118413 RVA: 0x00415F72 File Offset: 0x00414172
		public bool ShowLookAtDebugArrow { get; set; }

		// Token: 0x17008654 RID: 34388
		// (get) Token: 0x0601CE8E RID: 118414 RVA: 0x00415F7B File Offset: 0x0041417B
		// (set) Token: 0x0601CE8F RID: 118415 RVA: 0x00415F83 File Offset: 0x00414183
		public byte NullMask { get; set; }

		// Token: 0x0601CE90 RID: 118416 RVA: 0x00415F8C File Offset: 0x0041418C
		public IFlowEditorConfigT()
		{
			this.CsvExportPath = null;
			this.CsvImportPath = null;
			this.PlotRootDir = null;
			this.IsVerbose = false;
			this.ShowActionFilter = false;
			this.ShowTextHiddenStatus = false;
			this.ShowLookAtDebugArrow = false;
			this.NullMask = 0;
		}
	}
}
