using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BDC RID: 19420
	public class BossPilingTaskInfo : IBossPilingTaskInfo
	{
		// Token: 0x17006147 RID: 24903
		// (get) Token: 0x06030791 RID: 198545 RVA: 0x00D823C4 File Offset: 0x00D805C4
		// (set) Token: 0x06030792 RID: 198546 RVA: 0x00D823CC File Offset: 0x00D805CC
		public int Id { get; set; }

		// Token: 0x17006148 RID: 24904
		// (get) Token: 0x06030793 RID: 198547 RVA: 0x00D823D5 File Offset: 0x00D805D5
		// (set) Token: 0x06030794 RID: 198548 RVA: 0x00D823DD File Offset: 0x00D805DD
		public int Current { get; set; }

		// Token: 0x17006149 RID: 24905
		// (get) Token: 0x06030795 RID: 198549 RVA: 0x00D823E6 File Offset: 0x00D805E6
		// (set) Token: 0x06030796 RID: 198550 RVA: 0x00D823EE File Offset: 0x00D805EE
		public int Target { get; set; }

		// Token: 0x1700614A RID: 24906
		// (get) Token: 0x06030797 RID: 198551 RVA: 0x00D823F7 File Offset: 0x00D805F7
		// (set) Token: 0x06030798 RID: 198552 RVA: 0x00D823FF File Offset: 0x00D805FF
		public ConditionTaskState Status { get; set; }
	}
}
