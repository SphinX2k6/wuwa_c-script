using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006444 RID: 25668
	public class IInitNpcPerformStateT
	{
		// Token: 0x1700BD7F RID: 48511
		// (get) Token: 0x0602B9D0 RID: 178640 RVA: 0x005EFD7A File Offset: 0x005EDF7A
		// (set) Token: 0x0602B9D1 RID: 178641 RVA: 0x005EFD82 File Offset: 0x005EDF82
		public string Type { get; set; }

		// Token: 0x1700BD80 RID: 48512
		// (get) Token: 0x0602B9D2 RID: 178642 RVA: 0x005EFD8B File Offset: 0x005EDF8B
		// (set) Token: 0x0602B9D3 RID: 178643 RVA: 0x005EFD93 File Offset: 0x005EDF93
		public string State { get; set; }

		// Token: 0x0602B9D4 RID: 178644 RVA: 0x005EFD9C File Offset: 0x005EDF9C
		public IInitNpcPerformStateT()
		{
			this.Type = null;
			this.State = null;
		}
	}
}
