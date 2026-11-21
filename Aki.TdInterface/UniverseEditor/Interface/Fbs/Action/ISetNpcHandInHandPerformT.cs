using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007801 RID: 30721
	public class ISetNpcHandInHandPerformT
	{
		// Token: 0x1700E125 RID: 57637
		// (get) Token: 0x06035F91 RID: 221073 RVA: 0x0073ACE1 File Offset: 0x00738EE1
		// (set) Token: 0x06035F92 RID: 221074 RVA: 0x0073ACE9 File Offset: 0x00738EE9
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700E126 RID: 57638
		// (get) Token: 0x06035F93 RID: 221075 RVA: 0x0073ACF2 File Offset: 0x00738EF2
		// (set) Token: 0x06035F94 RID: 221076 RVA: 0x0073ACFA File Offset: 0x00738EFA
		public IHandInHandInitiatorT Initiator { get; set; }

		// Token: 0x1700E127 RID: 57639
		// (get) Token: 0x06035F95 RID: 221077 RVA: 0x0073AD03 File Offset: 0x00738F03
		// (set) Token: 0x06035F96 RID: 221078 RVA: 0x0073AD0B File Offset: 0x00738F0B
		public int Follower { get; set; }

		// Token: 0x06035F97 RID: 221079 RVA: 0x0073AD14 File Offset: 0x00738F14
		public ISetNpcHandInHandPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Follower = 0;
		}
	}
}
