using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A53 RID: 19027
	public class IVariableRewardParamT
	{
		// Token: 0x17008586 RID: 34182
		// (get) Token: 0x0601C998 RID: 117144 RVA: 0x004094A3 File Offset: 0x004076A3
		// (set) Token: 0x0601C999 RID: 117145 RVA: 0x004094AB File Offset: 0x004076AB
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x17008587 RID: 34183
		// (get) Token: 0x0601C99A RID: 117146 RVA: 0x004094B4 File Offset: 0x004076B4
		// (set) Token: 0x0601C99B RID: 117147 RVA: 0x004094BC File Offset: 0x004076BC
		public List<IVariableRewardConfigT> RewardConfig { get; set; }

		// Token: 0x0601C99C RID: 117148 RVA: 0x004094C5 File Offset: 0x004076C5
		public IVariableRewardParamT()
		{
			this.Type = ELevelPlayRewardType.None;
			this.RewardConfig = null;
		}
	}
}
