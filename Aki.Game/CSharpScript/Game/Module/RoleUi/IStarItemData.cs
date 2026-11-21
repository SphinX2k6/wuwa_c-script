using System;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C99 RID: 15513
	public interface IStarItemData
	{
		// Token: 0x1700514A RID: 20810
		// (get) Token: 0x06027B56 RID: 162646
		// (set) Token: 0x06027B57 RID: 162647
		bool StarOnActive { get; set; }

		// Token: 0x1700514B RID: 20811
		// (get) Token: 0x06027B58 RID: 162648
		// (set) Token: 0x06027B59 RID: 162649
		bool StarOffActive { get; set; }

		// Token: 0x1700514C RID: 20812
		// (get) Token: 0x06027B5A RID: 162650
		// (set) Token: 0x06027B5B RID: 162651
		bool StarNextActive { get; set; }

		// Token: 0x1700514D RID: 20813
		// (get) Token: 0x06027B5C RID: 162652
		// (set) Token: 0x06027B5D RID: 162653
		bool StarLoopActive { get; set; }

		// Token: 0x1700514E RID: 20814
		// (get) Token: 0x06027B5E RID: 162654
		// (set) Token: 0x06027B5F RID: 162655
		bool PlayLoopSequence { get; set; }

		// Token: 0x1700514F RID: 20815
		// (get) Token: 0x06027B60 RID: 162656
		// (set) Token: 0x06027B61 RID: 162657
		bool PlayActivateSequence { get; set; }
	}
}
