using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200515E RID: 20830
	public class IOnlinePlayerConditionTargetParticipatorT
	{
		// Token: 0x1700953C RID: 38204
		// (get) Token: 0x06020C4B RID: 134219 RVA: 0x00489B78 File Offset: 0x00487D78
		// (set) Token: 0x06020C4C RID: 134220 RVA: 0x00489B80 File Offset: 0x00487D80
		public EOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x1700953D RID: 38205
		// (get) Token: 0x06020C4D RID: 134221 RVA: 0x00489B89 File Offset: 0x00487D89
		// (set) Token: 0x06020C4E RID: 134222 RVA: 0x00489B91 File Offset: 0x00487D91
		public bool AnyPlayer { get; set; }

		// Token: 0x06020C4F RID: 134223 RVA: 0x00489B9A File Offset: 0x00487D9A
		public IOnlinePlayerConditionTargetParticipatorT()
		{
			this.Type = EOnlinePlayerConditionTarget.Host;
			this.AnyPlayer = false;
		}
	}
}
