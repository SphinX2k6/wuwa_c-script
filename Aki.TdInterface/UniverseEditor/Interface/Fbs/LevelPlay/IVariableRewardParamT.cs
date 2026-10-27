using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045EB RID: 17899
	public class IVariableRewardParamT
	{
		// Token: 0x17007F45 RID: 32581
		// (get) Token: 0x0601B1C3 RID: 111043 RVA: 0x003DD207 File Offset: 0x003DB407
		// (set) Token: 0x0601B1C4 RID: 111044 RVA: 0x003DD20F File Offset: 0x003DB40F
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x17007F46 RID: 32582
		// (get) Token: 0x0601B1C5 RID: 111045 RVA: 0x003DD218 File Offset: 0x003DB418
		// (set) Token: 0x0601B1C6 RID: 111046 RVA: 0x003DD220 File Offset: 0x003DB420
		public List<IVariableRewardConfigT> RewardConfig { get; set; }

		// Token: 0x0601B1C7 RID: 111047 RVA: 0x003DD229 File Offset: 0x003DB429
		public IVariableRewardParamT()
		{
			this.Type = ELevelPlayRewardType.None;
			this.RewardConfig = null;
		}
	}
}
