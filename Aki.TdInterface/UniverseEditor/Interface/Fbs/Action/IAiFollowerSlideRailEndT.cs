using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200617A RID: 24954
	public class IAiFollowerSlideRailEndT
	{
		// Token: 0x1700BA0A RID: 47626
		// (get) Token: 0x0602AFB0 RID: 176048 RVA: 0x005EE1F4 File Offset: 0x005EC3F4
		// (set) Token: 0x0602AFB1 RID: 176049 RVA: 0x005EE1FC File Offset: 0x005EC3FC
		public ESlideRailEndType Type { get; set; }

		// Token: 0x1700BA0B RID: 47627
		// (get) Token: 0x0602AFB2 RID: 176050 RVA: 0x005EE205 File Offset: 0x005EC405
		// (set) Token: 0x0602AFB3 RID: 176051 RVA: 0x005EE20D File Offset: 0x005EC40D
		public int AiEntityId { get; set; }

		// Token: 0x0602AFB4 RID: 176052 RVA: 0x005EE216 File Offset: 0x005EC416
		public IAiFollowerSlideRailEndT()
		{
			this.Type = ESlideRailEndType.Player;
			this.AiEntityId = 0;
		}
	}
}
