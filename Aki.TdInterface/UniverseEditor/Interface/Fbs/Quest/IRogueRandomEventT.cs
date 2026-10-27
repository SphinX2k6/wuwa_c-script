using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B3 RID: 16563
	public class IRogueRandomEventT
	{
		// Token: 0x170074E6 RID: 29926
		// (get) Token: 0x0601820D RID: 98829 RVA: 0x0037A632 File Offset: 0x00378832
		// (set) Token: 0x0601820E RID: 98830 RVA: 0x0037A63A File Offset: 0x0037883A
		public EShowUiType Type { get; set; }

		// Token: 0x0601820F RID: 98831 RVA: 0x0037A643 File Offset: 0x00378843
		public IRogueRandomEventT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
