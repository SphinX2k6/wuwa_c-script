using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007374 RID: 29556
	public class ITelePortAfterTimeOutT
	{
		// Token: 0x1700E061 RID: 57441
		// (get) Token: 0x06035A44 RID: 219716 RVA: 0x0074DD14 File Offset: 0x0074BF14
		// (set) Token: 0x06035A45 RID: 219717 RVA: 0x0074DD1C File Offset: 0x0074BF1C
		public ETeammateTeleportType Type { get; set; }

		// Token: 0x1700E062 RID: 57442
		// (get) Token: 0x06035A46 RID: 219718 RVA: 0x0074DD25 File Offset: 0x0074BF25
		// (set) Token: 0x06035A47 RID: 219719 RVA: 0x0074DD2D File Offset: 0x0074BF2D
		public int TimeOut { get; set; }

		// Token: 0x06035A48 RID: 219720 RVA: 0x0074DD36 File Offset: 0x0074BF36
		public ITelePortAfterTimeOutT()
		{
			this.Type = ETeammateTeleportType.TelePortAfterTimeOut;
			this.TimeOut = 0;
		}
	}
}
