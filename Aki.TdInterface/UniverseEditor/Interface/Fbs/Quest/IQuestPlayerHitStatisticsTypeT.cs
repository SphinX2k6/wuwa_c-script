using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004446 RID: 17478
	public class IQuestPlayerHitStatisticsTypeT
	{
		// Token: 0x17007930 RID: 31024
		// (get) Token: 0x06019109 RID: 102665 RVA: 0x00393592 File Offset: 0x00391792
		// (set) Token: 0x0601910A RID: 102666 RVA: 0x0039359A File Offset: 0x0039179A
		public EPlayerHitStatisticsType Type { get; set; }

		// Token: 0x0601910B RID: 102667 RVA: 0x003935A3 File Offset: 0x003917A3
		public IQuestPlayerHitStatisticsTypeT()
		{
			this.Type = EPlayerHitStatisticsType.HitCount;
		}
	}
}
