using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E1 RID: 29409
	public class INewSplineMoveTargetT
	{
		// Token: 0x1700D7AE RID: 55214
		// (get) Token: 0x06033489 RID: 210057 RVA: 0x006EB022 File Offset: 0x006E9222
		// (set) Token: 0x0603348A RID: 210058 RVA: 0x006EB02A File Offset: 0x006E922A
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x0603348B RID: 210059 RVA: 0x006EB033 File Offset: 0x006E9233
		public INewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}
