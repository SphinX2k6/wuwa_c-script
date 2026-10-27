using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736B RID: 29547
	public class ITeammateTeleportConfigT
	{
		// Token: 0x1700E056 RID: 57430
		// (get) Token: 0x06035A0E RID: 219662 RVA: 0x0074D83E File Offset: 0x0074BA3E
		// (set) Token: 0x06035A0F RID: 219663 RVA: 0x0074D846 File Offset: 0x0074BA46
		public ETeammateTeleportType Type { get; set; }

		// Token: 0x06035A10 RID: 219664 RVA: 0x0074D84F File Offset: 0x0074BA4F
		public ITeammateTeleportConfigT()
		{
			this.Type = ETeammateTeleportType.TelePortAfterTimeOut;
		}
	}
}
