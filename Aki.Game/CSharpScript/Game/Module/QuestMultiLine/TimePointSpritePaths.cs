using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02004FA6 RID: 20390
	[NullableContext(1)]
	[Nullable(0)]
	public class TimePointSpritePaths : ITimePointSpritePaths
	{
		// Token: 0x17007F73 RID: 32627
		// (get) Token: 0x06034324 RID: 213796 RVA: 0x00C40B0D File Offset: 0x00C3ED0D
		// (set) Token: 0x06034325 RID: 213797 RVA: 0x00C40B15 File Offset: 0x00C3ED15
		public string Idle { get; set; }

		// Token: 0x17007F74 RID: 32628
		// (get) Token: 0x06034326 RID: 213798 RVA: 0x00C40B1E File Offset: 0x00C3ED1E
		// (set) Token: 0x06034327 RID: 213799 RVA: 0x00C40B26 File Offset: 0x00C3ED26
		public string Hover { get; set; }

		// Token: 0x17007F75 RID: 32629
		// (get) Token: 0x06034328 RID: 213800 RVA: 0x00C40B2F File Offset: 0x00C3ED2F
		// (set) Token: 0x06034329 RID: 213801 RVA: 0x00C40B37 File Offset: 0x00C3ED37
		public string Pressed { get; set; }

		// Token: 0x17007F76 RID: 32630
		// (get) Token: 0x0603432A RID: 213802 RVA: 0x00C40B40 File Offset: 0x00C3ED40
		// (set) Token: 0x0603432B RID: 213803 RVA: 0x00C40B48 File Offset: 0x00C3ED48
		public string Selected { get; set; }
	}
}
