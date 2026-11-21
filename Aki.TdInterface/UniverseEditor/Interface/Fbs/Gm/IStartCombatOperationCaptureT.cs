using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B11 RID: 19217
	public class IStartCombatOperationCaptureT
	{
		// Token: 0x170086BF RID: 34495
		// (get) Token: 0x0601CF96 RID: 118678 RVA: 0x00413227 File Offset: 0x00411427
		// (set) Token: 0x0601CF97 RID: 118679 RVA: 0x0041322F File Offset: 0x0041142F
		public EGmCommand Type { get; set; }

		// Token: 0x170086C0 RID: 34496
		// (get) Token: 0x0601CF98 RID: 118680 RVA: 0x00413238 File Offset: 0x00411438
		// (set) Token: 0x0601CF99 RID: 118681 RVA: 0x00413240 File Offset: 0x00411440
		public string FileId { get; set; }

		// Token: 0x0601CF9A RID: 118682 RVA: 0x00413249 File Offset: 0x00411449
		public IStartCombatOperationCaptureT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.FileId = null;
		}
	}
}
