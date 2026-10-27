using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A9 RID: 18089
	public class IStartCombatOperationCaptureT
	{
		// Token: 0x1700807E RID: 32894
		// (get) Token: 0x0601B7C1 RID: 112577 RVA: 0x003E6F8B File Offset: 0x003E518B
		// (set) Token: 0x0601B7C2 RID: 112578 RVA: 0x003E6F93 File Offset: 0x003E5193
		public EGmCommand Type { get; set; }

		// Token: 0x1700807F RID: 32895
		// (get) Token: 0x0601B7C3 RID: 112579 RVA: 0x003E6F9C File Offset: 0x003E519C
		// (set) Token: 0x0601B7C4 RID: 112580 RVA: 0x003E6FA4 File Offset: 0x003E51A4
		public string FileId { get; set; }

		// Token: 0x0601B7C5 RID: 112581 RVA: 0x003E6FAD File Offset: 0x003E51AD
		public IStartCombatOperationCaptureT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.FileId = null;
		}
	}
}
