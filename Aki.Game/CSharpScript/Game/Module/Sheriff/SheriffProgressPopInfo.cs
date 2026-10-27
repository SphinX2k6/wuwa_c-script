using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C4E RID: 19534
	public class SheriffProgressPopInfo : ISheriffProgressPopInfo
	{
		// Token: 0x17007CC8 RID: 31944
		// (get) Token: 0x06032807 RID: 206855 RVA: 0x00BC3434 File Offset: 0x00BC1634
		// (set) Token: 0x06032808 RID: 206856 RVA: 0x00BC343C File Offset: 0x00BC163C
		public SheriffProgress Progress { get; set; }

		// Token: 0x17007CC9 RID: 31945
		// (get) Token: 0x06032809 RID: 206857 RVA: 0x00BC3445 File Offset: 0x00BC1645
		// (set) Token: 0x0603280A RID: 206858 RVA: 0x00BC344D File Offset: 0x00BC164D
		public bool NeedAnim { get; set; }
	}
}
