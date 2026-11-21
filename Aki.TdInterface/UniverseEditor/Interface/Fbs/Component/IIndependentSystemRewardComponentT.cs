using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005976 RID: 22902
	public class IIndependentSystemRewardComponentT
	{
		// Token: 0x1700A660 RID: 42592
		// (get) Token: 0x06025559 RID: 152921 RVA: 0x0051FD71 File Offset: 0x0051DF71
		// (set) Token: 0x0602555A RID: 152922 RVA: 0x0051FD79 File Offset: 0x0051DF79
		public bool Disabled { get; set; }

		// Token: 0x1700A661 RID: 42593
		// (get) Token: 0x0602555B RID: 152923 RVA: 0x0051FD82 File Offset: 0x0051DF82
		// (set) Token: 0x0602555C RID: 152924 RVA: 0x0051FD8A File Offset: 0x0051DF8A
		public IDarkTideIndependentSystemRewardT RewardType { get; set; }

		// Token: 0x1700A662 RID: 42594
		// (get) Token: 0x0602555D RID: 152925 RVA: 0x0051FD93 File Offset: 0x0051DF93
		// (set) Token: 0x0602555E RID: 152926 RVA: 0x0051FD9B File Offset: 0x0051DF9B
		public byte NullMask { get; set; }

		// Token: 0x0602555F RID: 152927 RVA: 0x0051FDA4 File Offset: 0x0051DFA4
		public IIndependentSystemRewardComponentT()
		{
			this.Disabled = false;
			this.RewardType = null;
			this.NullMask = 0;
		}
	}
}
