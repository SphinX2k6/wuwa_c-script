using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CBF RID: 19647
	public class IEditorArgConfigT
	{
		// Token: 0x17008B52 RID: 35666
		// (get) Token: 0x0601E2D3 RID: 123603 RVA: 0x0043A625 File Offset: 0x00438825
		// (set) Token: 0x0601E2D4 RID: 123604 RVA: 0x0043A62D File Offset: 0x0043882D
		public string ExecCmds { get; set; }

		// Token: 0x17008B53 RID: 35667
		// (get) Token: 0x0601E2D5 RID: 123605 RVA: 0x0043A636 File Offset: 0x00438836
		// (set) Token: 0x0601E2D6 RID: 123606 RVA: 0x0043A63E File Offset: 0x0043883E
		public string LocalGameServerStartPort { get; set; }

		// Token: 0x17008B54 RID: 35668
		// (get) Token: 0x0601E2D7 RID: 123607 RVA: 0x0043A647 File Offset: 0x00438847
		// (set) Token: 0x0601E2D8 RID: 123608 RVA: 0x0043A64F File Offset: 0x0043884F
		public string LocalGameServerNode { get; set; }

		// Token: 0x17008B55 RID: 35669
		// (get) Token: 0x0601E2D9 RID: 123609 RVA: 0x0043A658 File Offset: 0x00438858
		// (set) Token: 0x0601E2DA RID: 123610 RVA: 0x0043A660 File Offset: 0x00438860
		public string TsEditorServicePort { get; set; }

		// Token: 0x17008B56 RID: 35670
		// (get) Token: 0x0601E2DB RID: 123611 RVA: 0x0043A669 File Offset: 0x00438869
		// (set) Token: 0x0601E2DC RID: 123612 RVA: 0x0043A671 File Offset: 0x00438871
		public string IgnoreStartupCheck { get; set; }

		// Token: 0x17008B57 RID: 35671
		// (get) Token: 0x0601E2DD RID: 123613 RVA: 0x0043A67A File Offset: 0x0043887A
		// (set) Token: 0x0601E2DE RID: 123614 RVA: 0x0043A682 File Offset: 0x00438882
		public string DisablePopEditorSaviorOnError { get; set; }

		// Token: 0x17008B58 RID: 35672
		// (get) Token: 0x0601E2DF RID: 123615 RVA: 0x0043A68B File Offset: 0x0043888B
		// (set) Token: 0x0601E2E0 RID: 123616 RVA: 0x0043A693 File Offset: 0x00438893
		public string DisableAutoStartServer { get; set; }

		// Token: 0x17008B59 RID: 35673
		// (get) Token: 0x0601E2E1 RID: 123617 RVA: 0x0043A69C File Offset: 0x0043889C
		// (set) Token: 0x0601E2E2 RID: 123618 RVA: 0x0043A6A4 File Offset: 0x004388A4
		public string UseTemp { get; set; }

		// Token: 0x17008B5A RID: 35674
		// (get) Token: 0x0601E2E3 RID: 123619 RVA: 0x0043A6AD File Offset: 0x004388AD
		// (set) Token: 0x0601E2E4 RID: 123620 RVA: 0x0043A6B5 File Offset: 0x004388B5
		public string PipelineServerLogStamp { get; set; }

		// Token: 0x0601E2E5 RID: 123621 RVA: 0x0043A6C0 File Offset: 0x004388C0
		public IEditorArgConfigT()
		{
			this.ExecCmds = null;
			this.LocalGameServerStartPort = null;
			this.LocalGameServerNode = null;
			this.TsEditorServicePort = null;
			this.IgnoreStartupCheck = null;
			this.DisablePopEditorSaviorOnError = null;
			this.DisableAutoStartServer = null;
			this.UseTemp = null;
			this.PipelineServerLogStamp = null;
		}
	}
}
