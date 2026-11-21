using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007398 RID: 29592
	public class IOpenSoaringChallengeResultWithReturnT
	{
		// Token: 0x1700D925 RID: 55589
		// (get) Token: 0x06033B1F RID: 211743 RVA: 0x006F8857 File Offset: 0x006F6A57
		// (set) Token: 0x06033B20 RID: 211744 RVA: 0x006F885F File Offset: 0x006F6A5F
		public ESystemType Type { get; set; }

		// Token: 0x1700D926 RID: 55590
		// (get) Token: 0x06033B21 RID: 211745 RVA: 0x006F8868 File Offset: 0x006F6A68
		// (set) Token: 0x06033B22 RID: 211746 RVA: 0x006F8870 File Offset: 0x006F6A70
		public TVarRefUnion Score { get; set; }

		// Token: 0x1700D927 RID: 55591
		// (get) Token: 0x06033B23 RID: 211747 RVA: 0x006F8879 File Offset: 0x006F6A79
		// (set) Token: 0x06033B24 RID: 211748 RVA: 0x006F8881 File Offset: 0x006F6A81
		public int RankS { get; set; }

		// Token: 0x1700D928 RID: 55592
		// (get) Token: 0x06033B25 RID: 211749 RVA: 0x006F888A File Offset: 0x006F6A8A
		// (set) Token: 0x06033B26 RID: 211750 RVA: 0x006F8892 File Offset: 0x006F6A92
		public int RankA { get; set; }

		// Token: 0x1700D929 RID: 55593
		// (get) Token: 0x06033B27 RID: 211751 RVA: 0x006F889B File Offset: 0x006F6A9B
		// (set) Token: 0x06033B28 RID: 211752 RVA: 0x006F88A3 File Offset: 0x006F6AA3
		public int RankB { get; set; }

		// Token: 0x1700D92A RID: 55594
		// (get) Token: 0x06033B29 RID: 211753 RVA: 0x006F88AC File Offset: 0x006F6AAC
		// (set) Token: 0x06033B2A RID: 211754 RVA: 0x006F88B4 File Offset: 0x006F6AB4
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06033B2B RID: 211755 RVA: 0x006F88BD File Offset: 0x006F6ABD
		public IOpenSoaringChallengeResultWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.Score = null;
			this.RankS = 0;
			this.RankA = 0;
			this.RankB = 0;
			this.ReturnVar = null;
		}
	}
}
