using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CE0 RID: 19680
	public class IFlowEditorConfigT
	{
		// Token: 0x17008C95 RID: 35989
		// (get) Token: 0x0601E66D RID: 124525 RVA: 0x004426A0 File Offset: 0x004408A0
		// (set) Token: 0x0601E66E RID: 124526 RVA: 0x004426A8 File Offset: 0x004408A8
		public string CsvExportPath { get; set; }

		// Token: 0x17008C96 RID: 35990
		// (get) Token: 0x0601E66F RID: 124527 RVA: 0x004426B1 File Offset: 0x004408B1
		// (set) Token: 0x0601E670 RID: 124528 RVA: 0x004426B9 File Offset: 0x004408B9
		public string CsvImportPath { get; set; }

		// Token: 0x17008C97 RID: 35991
		// (get) Token: 0x0601E671 RID: 124529 RVA: 0x004426C2 File Offset: 0x004408C2
		// (set) Token: 0x0601E672 RID: 124530 RVA: 0x004426CA File Offset: 0x004408CA
		public string PlotRootDir { get; set; }

		// Token: 0x17008C98 RID: 35992
		// (get) Token: 0x0601E673 RID: 124531 RVA: 0x004426D3 File Offset: 0x004408D3
		// (set) Token: 0x0601E674 RID: 124532 RVA: 0x004426DB File Offset: 0x004408DB
		public bool IsVerbose { get; set; }

		// Token: 0x17008C99 RID: 35993
		// (get) Token: 0x0601E675 RID: 124533 RVA: 0x004426E4 File Offset: 0x004408E4
		// (set) Token: 0x0601E676 RID: 124534 RVA: 0x004426EC File Offset: 0x004408EC
		public bool ShowActionFilter { get; set; }

		// Token: 0x17008C9A RID: 35994
		// (get) Token: 0x0601E677 RID: 124535 RVA: 0x004426F5 File Offset: 0x004408F5
		// (set) Token: 0x0601E678 RID: 124536 RVA: 0x004426FD File Offset: 0x004408FD
		public bool ShowTextHiddenStatus { get; set; }

		// Token: 0x17008C9B RID: 35995
		// (get) Token: 0x0601E679 RID: 124537 RVA: 0x00442706 File Offset: 0x00440906
		// (set) Token: 0x0601E67A RID: 124538 RVA: 0x0044270E File Offset: 0x0044090E
		public bool ShowLookAtDebugArrow { get; set; }

		// Token: 0x17008C9C RID: 35996
		// (get) Token: 0x0601E67B RID: 124539 RVA: 0x00442717 File Offset: 0x00440917
		// (set) Token: 0x0601E67C RID: 124540 RVA: 0x0044271F File Offset: 0x0044091F
		public byte NullMask { get; set; }

		// Token: 0x0601E67D RID: 124541 RVA: 0x00442728 File Offset: 0x00440928
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
