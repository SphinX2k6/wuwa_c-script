using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x020014C9 RID: 5321
public class InterfaceDataUnit
{
	// Token: 0x0600D4EA RID: 54506 RVA: 0x003F529B File Offset: 0x003F349B
	public InterfaceDataUnit(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600D4EB RID: 54507 RVA: 0x003F52B8 File Offset: 0x003F34B8
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

	// Token: 0x0600D4EC RID: 54508 RVA: 0x003F52F4 File Offset: 0x003F34F4
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

	// Token: 0x04007792 RID: 30610
	public int Index;

	// Token: 0x04007793 RID: 30611
	public EPlayMode Mode;

	// Token: 0x04007794 RID: 30612
	[Nullable(1)]
	public List<ItemRewardInfo> WaitList = new List<ItemRewardInfo>();
}
