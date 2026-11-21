using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B14 RID: 19220
	public class IStartCombatOperationReplayT
	{
		// Token: 0x170086C4 RID: 34500
		// (get) Token: 0x0601CFAE RID: 118702 RVA: 0x0041345B File Offset: 0x0041165B
		// (set) Token: 0x0601CFAF RID: 118703 RVA: 0x00413463 File Offset: 0x00411663
		public EGmCommand Type { get; set; }

		// Token: 0x170086C5 RID: 34501
		// (get) Token: 0x0601CFB0 RID: 118704 RVA: 0x0041346C File Offset: 0x0041166C
		// (set) Token: 0x0601CFB1 RID: 118705 RVA: 0x00413474 File Offset: 0x00411674
		public string FileId { get; set; }

		// Token: 0x0601CFB2 RID: 118706 RVA: 0x0041347D File Offset: 0x0041167D
		public IStartCombatOperationReplayT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.FileId = null;
		}
	}
}
