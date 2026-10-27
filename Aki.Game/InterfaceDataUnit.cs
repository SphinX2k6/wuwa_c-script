using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x02001FF6 RID: 8182
public class InterfaceDataUnit
{
	// Token: 0x06010082 RID: 65666 RVA: 0x003E8CA3 File Offset: 0x003E6EA3
	public InterfaceDataUnit(int index)
	{
		this.Index = index;
	}

	// Token: 0x06010083 RID: 65667 RVA: 0x003E8CC0 File Offset: 0x003E6EC0
	public int GetMaxCount()
	{
		int result = 1;
		if (this.Mode == EPlayMode.Low)
		{
			result = RewardConfig.Instance.GetLowModeCount();
		}
		else if (this.Mode == EPlayMode.Fast)
		{
			result = RewardConfig.Instance.GetFastModeCount();
		}
		return result;
	}

	// Token: 0x06010084 RID: 65668 RVA: 0x003E8CFC File Offset: 0x003E6EFC
	public int GetAddItemTime()
	{
		int result = 0;
		if (this.Mode == EPlayMode.Low)
		{
			result = RewardConfig.Instance.GetLowModeNextAddItemTime();
		}
		else if (this.Mode == EPlayMode.Fast)
		{
			result = RewardConfig.Instance.GetFastModeNextAddItemTime();
		}
		return result;
	}

	// Token: 0x040076A9 RID: 30377
	public int Index;

	// Token: 0x040076AA RID: 30378
	public EPlayMode Mode;

	// Token: 0x040076AB RID: 30379
	[Nullable(1)]
	public List<ItemRewardInfo> WaitList = new List<ItemRewardInfo>();
}
