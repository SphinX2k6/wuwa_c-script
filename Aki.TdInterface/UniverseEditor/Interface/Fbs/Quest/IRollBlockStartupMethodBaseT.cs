using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004533 RID: 17715
	public class IRollBlockStartupMethodBaseT
	{
		// Token: 0x17007B35 RID: 31541
		// (get) Token: 0x06019A5A RID: 105050 RVA: 0x003A70A6 File Offset: 0x003A52A6
		// (set) Token: 0x06019A5B RID: 105051 RVA: 0x003A70AE File Offset: 0x003A52AE
		public ERollBlockLaunchMethod Type { get; set; }

		// Token: 0x06019A5C RID: 105052 RVA: 0x003A70B7 File Offset: 0x003A52B7
		public IRollBlockStartupMethodBaseT()
		{
			this.Type = ERollBlockLaunchMethod.Interact;
		}
	}
}
