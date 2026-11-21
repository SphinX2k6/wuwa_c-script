using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C86 RID: 19590
	public class IAreaConflictSelectorT
	{
		// Token: 0x17008ABE RID: 35518
		// (get) Token: 0x0601E03E RID: 122942 RVA: 0x00434FFE File Offset: 0x004331FE
		// (set) Token: 0x0601E03F RID: 122943 RVA: 0x00435006 File Offset: 0x00433206
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x0601E040 RID: 122944 RVA: 0x0043500F File Offset: 0x0043320F
		public IAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
		}
	}
}
