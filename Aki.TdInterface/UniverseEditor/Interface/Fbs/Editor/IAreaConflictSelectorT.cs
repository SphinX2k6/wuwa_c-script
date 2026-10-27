using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200481E RID: 18462
	public class IAreaConflictSelectorT
	{
		// Token: 0x17008473 RID: 33907
		// (get) Token: 0x0601C841 RID: 116801 RVA: 0x004086AE File Offset: 0x004068AE
		// (set) Token: 0x0601C842 RID: 116802 RVA: 0x004086B6 File Offset: 0x004068B6
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x0601C843 RID: 116803 RVA: 0x004086BF File Offset: 0x004068BF
		public IAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
		}
	}
}
