using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200799C RID: 31132
	public class IStateProgramSpecialProcessChangeTeamOptimizationT
	{
		// Token: 0x1700E467 RID: 58471
		// (get) Token: 0x06036DC6 RID: 224710 RVA: 0x0075690A File Offset: 0x00754B0A
		// (set) Token: 0x06036DC7 RID: 224711 RVA: 0x00756912 File Offset: 0x00754B12
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x1700E468 RID: 58472
		// (get) Token: 0x06036DC8 RID: 224712 RVA: 0x0075691B File Offset: 0x00754B1B
		// (set) Token: 0x06036DC9 RID: 224713 RVA: 0x00756923 File Offset: 0x00754B23
		public bool IsOpenBlackScreen { get; set; }

		// Token: 0x1700E469 RID: 58473
		// (get) Token: 0x06036DCA RID: 224714 RVA: 0x0075692C File Offset: 0x00754B2C
		// (set) Token: 0x06036DCB RID: 224715 RVA: 0x00756934 File Offset: 0x00754B34
		public byte NullMask { get; set; }

		// Token: 0x06036DCC RID: 224716 RVA: 0x0075693D File Offset: 0x00754B3D
		public IStateProgramSpecialProcessChangeTeamOptimizationT()
		{
			this.Type = ELogicProgramSpecialProcess.ChangeTeamOptimization;
			this.IsOpenBlackScreen = false;
			this.NullMask = 0;
		}
	}
}
