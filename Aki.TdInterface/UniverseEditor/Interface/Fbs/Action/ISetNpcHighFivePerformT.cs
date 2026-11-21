using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007804 RID: 30724
	public class ISetNpcHighFivePerformT
	{
		// Token: 0x1700E12D RID: 57645
		// (get) Token: 0x06035FAD RID: 221101 RVA: 0x0073B05B File Offset: 0x0073925B
		// (set) Token: 0x06035FAE RID: 221102 RVA: 0x0073B063 File Offset: 0x00739263
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700E12E RID: 57646
		// (get) Token: 0x06035FAF RID: 221103 RVA: 0x0073B06C File Offset: 0x0073926C
		// (set) Token: 0x06035FB0 RID: 221104 RVA: 0x0073B074 File Offset: 0x00739274
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700E12F RID: 57647
		// (get) Token: 0x06035FB1 RID: 221105 RVA: 0x0073B07D File Offset: 0x0073927D
		// (set) Token: 0x06035FB2 RID: 221106 RVA: 0x0073B085 File Offset: 0x00739285
		public int Target { get; set; }

		// Token: 0x1700E130 RID: 57648
		// (get) Token: 0x06035FB3 RID: 221107 RVA: 0x0073B08E File Offset: 0x0073928E
		// (set) Token: 0x06035FB4 RID: 221108 RVA: 0x0073B096 File Offset: 0x00739296
		public ENpcGroupPerformNpcType NpcType { get; set; }

		// Token: 0x06035FB5 RID: 221109 RVA: 0x0073B09F File Offset: 0x0073929F
		public ISetNpcHighFivePerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
			this.NpcType = ENpcGroupPerformNpcType.LevelBCommonMale;
		}
	}
}
