using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004857 RID: 18519
	public class IEditorArgConfigT
	{
		// Token: 0x17008506 RID: 34054
		// (get) Token: 0x0601CAD2 RID: 117458 RVA: 0x0040DC35 File Offset: 0x0040BE35
		// (set) Token: 0x0601CAD3 RID: 117459 RVA: 0x0040DC3D File Offset: 0x0040BE3D
		public string ExecCmds { get; set; }

		// Token: 0x17008507 RID: 34055
		// (get) Token: 0x0601CAD4 RID: 117460 RVA: 0x0040DC46 File Offset: 0x0040BE46
		// (set) Token: 0x0601CAD5 RID: 117461 RVA: 0x0040DC4E File Offset: 0x0040BE4E
		public string LocalGameServerStartPort { get; set; }

		// Token: 0x17008508 RID: 34056
		// (get) Token: 0x0601CAD6 RID: 117462 RVA: 0x0040DC57 File Offset: 0x0040BE57
		// (set) Token: 0x0601CAD7 RID: 117463 RVA: 0x0040DC5F File Offset: 0x0040BE5F
		public string LocalGameServerNode { get; set; }

		// Token: 0x17008509 RID: 34057
		// (get) Token: 0x0601CAD8 RID: 117464 RVA: 0x0040DC68 File Offset: 0x0040BE68
		// (set) Token: 0x0601CAD9 RID: 117465 RVA: 0x0040DC70 File Offset: 0x0040BE70
		public string TsEditorServicePort { get; set; }

		// Token: 0x1700850A RID: 34058
		// (get) Token: 0x0601CADA RID: 117466 RVA: 0x0040DC79 File Offset: 0x0040BE79
		// (set) Token: 0x0601CADB RID: 117467 RVA: 0x0040DC81 File Offset: 0x0040BE81
		public string IgnoreStartupCheck { get; set; }

		// Token: 0x1700850B RID: 34059
		// (get) Token: 0x0601CADC RID: 117468 RVA: 0x0040DC8A File Offset: 0x0040BE8A
		// (set) Token: 0x0601CADD RID: 117469 RVA: 0x0040DC92 File Offset: 0x0040BE92
		public string DisablePopEditorSaviorOnError { get; set; }

		// Token: 0x1700850C RID: 34060
		// (get) Token: 0x0601CADE RID: 117470 RVA: 0x0040DC9B File Offset: 0x0040BE9B
		// (set) Token: 0x0601CADF RID: 117471 RVA: 0x0040DCA3 File Offset: 0x0040BEA3
		public string DisableAutoStartServer { get; set; }

		// Token: 0x1700850D RID: 34061
		// (get) Token: 0x0601CAE0 RID: 117472 RVA: 0x0040DCAC File Offset: 0x0040BEAC
		// (set) Token: 0x0601CAE1 RID: 117473 RVA: 0x0040DCB4 File Offset: 0x0040BEB4
		public string UseTemp { get; set; }

		// Token: 0x0601CAE2 RID: 117474 RVA: 0x0040DCBD File Offset: 0x0040BEBD
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
		}
	}
}
