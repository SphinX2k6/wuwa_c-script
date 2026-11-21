using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007807 RID: 30727
	public class ISetNpcHuggingBearPerformT
	{
		// Token: 0x1700E136 RID: 57654
		// (get) Token: 0x06035FCB RID: 221131 RVA: 0x0073B3FB File Offset: 0x007395FB
		// (set) Token: 0x06035FCC RID: 221132 RVA: 0x0073B403 File Offset: 0x00739603
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700E137 RID: 57655
		// (get) Token: 0x06035FCD RID: 221133 RVA: 0x0073B40C File Offset: 0x0073960C
		// (set) Token: 0x06035FCE RID: 221134 RVA: 0x0073B414 File Offset: 0x00739614
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700E138 RID: 57656
		// (get) Token: 0x06035FCF RID: 221135 RVA: 0x0073B41D File Offset: 0x0073961D
		// (set) Token: 0x06035FD0 RID: 221136 RVA: 0x0073B425 File Offset: 0x00739625
		public int Target { get; set; }

		// Token: 0x1700E139 RID: 57657
		// (get) Token: 0x06035FD1 RID: 221137 RVA: 0x0073B42E File Offset: 0x0073962E
		// (set) Token: 0x06035FD2 RID: 221138 RVA: 0x0073B436 File Offset: 0x00739636
		public ENpcGroupPerformNpcType NpcType { get; set; }

		// Token: 0x06035FD3 RID: 221139 RVA: 0x0073B43F File Offset: 0x0073963F
		public ISetNpcHuggingBearPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
			this.NpcType = ENpcGroupPerformNpcType.LevelBCommonMale;
		}
	}
}
