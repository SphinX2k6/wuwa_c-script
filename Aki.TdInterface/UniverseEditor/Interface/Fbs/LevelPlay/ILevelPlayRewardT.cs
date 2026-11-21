using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200497E RID: 18814
	public class ILevelPlayRewardT
	{
		// Token: 0x170083A2 RID: 33698
		// (get) Token: 0x0601C118 RID: 114968 RVA: 0x003F7BE2 File Offset: 0x003F5DE2
		// (set) Token: 0x0601C119 RID: 114969 RVA: 0x003F7BEA File Offset: 0x003F5DEA
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x0601C11A RID: 114970 RVA: 0x003F7BF3 File Offset: 0x003F5DF3
		public ILevelPlayRewardT()
		{
			this.Type = ELevelPlayRewardType.None;
		}
	}
}
