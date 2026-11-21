using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200499C RID: 18844
	public class INoneRewardParamT
	{
		// Token: 0x170083E9 RID: 33769
		// (get) Token: 0x0601C220 RID: 115232 RVA: 0x003F97F6 File Offset: 0x003F79F6
		// (set) Token: 0x0601C221 RID: 115233 RVA: 0x003F97FE File Offset: 0x003F79FE
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x0601C222 RID: 115234 RVA: 0x003F9807 File Offset: 0x003F7A07
		public INoneRewardParamT()
		{
			this.Type = ELevelPlayRewardType.None;
		}
	}
}
