using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200489D RID: 18589
	public class IAutomaticRewardParamT
	{
		// Token: 0x17008146 RID: 33094
		// (get) Token: 0x0601B767 RID: 112487 RVA: 0x003E2F08 File Offset: 0x003E1108
		// (set) Token: 0x0601B768 RID: 112488 RVA: 0x003E2F10 File Offset: 0x003E1110
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x17008147 RID: 33095
		// (get) Token: 0x0601B769 RID: 112489 RVA: 0x003E2F19 File Offset: 0x003E1119
		// (set) Token: 0x0601B76A RID: 112490 RVA: 0x003E2F21 File Offset: 0x003E1121
		public int RewardId { get; set; }

		// Token: 0x17008148 RID: 33096
		// (get) Token: 0x0601B76B RID: 112491 RVA: 0x003E2F2A File Offset: 0x003E112A
		// (set) Token: 0x0601B76C RID: 112492 RVA: 0x003E2F32 File Offset: 0x003E1132
		public int FirstRewardId { get; set; }

		// Token: 0x17008149 RID: 33097
		// (get) Token: 0x0601B76D RID: 112493 RVA: 0x003E2F3B File Offset: 0x003E113B
		// (set) Token: 0x0601B76E RID: 112494 RVA: 0x003E2F43 File Offset: 0x003E1143
		public byte NullMask { get; set; }

		// Token: 0x0601B76F RID: 112495 RVA: 0x003E2F4C File Offset: 0x003E114C
		public IAutomaticRewardParamT()
		{
			this.Type = ELevelPlayRewardType.None;
			this.RewardId = 0;
			this.FirstRewardId = 0;
			this.NullMask = 0;
		}
	}
}
