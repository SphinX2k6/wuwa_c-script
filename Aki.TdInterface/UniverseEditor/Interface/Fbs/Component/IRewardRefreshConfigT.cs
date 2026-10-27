using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586B RID: 22635
	public class IRewardRefreshConfigT
	{
		// Token: 0x1700A94F RID: 43343
		// (get) Token: 0x0602623C RID: 156220 RVA: 0x005425E3 File Offset: 0x005407E3
		// (set) Token: 0x0602623D RID: 156221 RVA: 0x005425EB File Offset: 0x005407EB
		public TRefreshConditionUnion RefreshCondition { get; set; }

		// Token: 0x1700A950 RID: 43344
		// (get) Token: 0x0602623E RID: 156222 RVA: 0x005425F4 File Offset: 0x005407F4
		// (set) Token: 0x0602623F RID: 156223 RVA: 0x005425FC File Offset: 0x005407FC
		public TRefreshRuleUnion RefreshType { get; set; }

		// Token: 0x1700A951 RID: 43345
		// (get) Token: 0x06026240 RID: 156224 RVA: 0x00542605 File Offset: 0x00540805
		// (set) Token: 0x06026241 RID: 156225 RVA: 0x0054260D File Offset: 0x0054080D
		public int MaxCount { get; set; }

		// Token: 0x1700A952 RID: 43346
		// (get) Token: 0x06026242 RID: 156226 RVA: 0x00542616 File Offset: 0x00540816
		// (set) Token: 0x06026243 RID: 156227 RVA: 0x0054261E File Offset: 0x0054081E
		public byte NullMask { get; set; }

		// Token: 0x06026244 RID: 156228 RVA: 0x00542627 File Offset: 0x00540827
		public IRewardRefreshConfigT()
		{
			this.RefreshCondition = null;
			this.RefreshType = null;
			this.MaxCount = 0;
			this.NullMask = 0;
		}
	}
}
