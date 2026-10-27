using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004534 RID: 17716
	public class INoneRewardParamT
	{
		// Token: 0x17007DA8 RID: 32168
		// (get) Token: 0x0601AA4B RID: 109131 RVA: 0x003CD55A File Offset: 0x003CB75A
		// (set) Token: 0x0601AA4C RID: 109132 RVA: 0x003CD562 File Offset: 0x003CB762
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x0601AA4D RID: 109133 RVA: 0x003CD56B File Offset: 0x003CB76B
		public INoneRewardParamT()
		{
			this.Type = ELevelPlayRewardType.None;
		}
	}
}
