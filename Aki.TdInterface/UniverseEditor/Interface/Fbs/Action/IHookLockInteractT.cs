using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FED RID: 28653
	public class IHookLockInteractT
	{
		// Token: 0x1700D1E1 RID: 53729
		// (get) Token: 0x06031A6A RID: 203370 RVA: 0x006B9DBC File Offset: 0x006B7FBC
		// (set) Token: 0x06031A6B RID: 203371 RVA: 0x006B9DC4 File Offset: 0x006B7FC4
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D1E2 RID: 53730
		// (get) Token: 0x06031A6C RID: 203372 RVA: 0x006B9DCD File Offset: 0x006B7FCD
		// (set) Token: 0x06031A6D RID: 203373 RVA: 0x006B9DD5 File Offset: 0x006B7FD5
		public int EntityId { get; set; }

		// Token: 0x06031A6E RID: 203374 RVA: 0x006B9DDE File Offset: 0x006B7FDE
		public IHookLockInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
		}
	}
}
