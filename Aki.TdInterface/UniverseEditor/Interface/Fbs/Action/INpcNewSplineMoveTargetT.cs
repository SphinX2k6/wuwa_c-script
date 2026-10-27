using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDD RID: 27613
	public class INpcNewSplineMoveTargetT
	{
		// Token: 0x1700CD2F RID: 52527
		// (get) Token: 0x0603082C RID: 198700 RVA: 0x00696114 File Offset: 0x00694314
		// (set) Token: 0x0603082D RID: 198701 RVA: 0x0069611C File Offset: 0x0069431C
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700CD30 RID: 52528
		// (get) Token: 0x0603082E RID: 198702 RVA: 0x00696125 File Offset: 0x00694325
		// (set) Token: 0x0603082F RID: 198703 RVA: 0x0069612D File Offset: 0x0069432D
		public int NpcId { get; set; }

		// Token: 0x06030830 RID: 198704 RVA: 0x00696136 File Offset: 0x00694336
		public INpcNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.NpcId = 0;
		}
	}
}
