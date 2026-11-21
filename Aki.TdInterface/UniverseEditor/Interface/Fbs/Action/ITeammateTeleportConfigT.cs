using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B4C RID: 31564
	public class ITeammateTeleportConfigT
	{
		// Token: 0x1700EC61 RID: 60513
		// (get) Token: 0x06038D87 RID: 232839 RVA: 0x007AFA7A File Offset: 0x007ADC7A
		// (set) Token: 0x06038D88 RID: 232840 RVA: 0x007AFA82 File Offset: 0x007ADC82
		public ETeammateTeleportType Type { get; set; }

		// Token: 0x06038D89 RID: 232841 RVA: 0x007AFA8B File Offset: 0x007ADC8B
		public ITeammateTeleportConfigT()
		{
			this.Type = ETeammateTeleportType.TelePortAfterTimeOut;
		}
	}
}
