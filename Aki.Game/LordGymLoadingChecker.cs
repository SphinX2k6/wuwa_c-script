using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x0200153F RID: 5439
public class LordGymLoadingChecker : ISpecialCustomLoadingTypeChecker
{
	// Token: 0x0600D9DC RID: 55772 RVA: 0x00408DFC File Offset: 0x00406FFC
	public bool CanHandle(int instanceId)
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 48;
	}

	// Token: 0x0600D9DD RID: 55773 RVA: 0x00408E34 File Offset: 0x00407034
	public EUiViewName? GetLoadingViewName(int instanceId)
	{
		IReadOnlyList<LordGymEntranceSet> configList = ConfigLordGymEntranceSetAll.GetConfigList(true);
		if (configList == null)
		{
			return null;
		}
		LordGymEntranceSet? lordGymEntranceSet = null;
		foreach (LordGymEntranceSet value in configList)
		{
			if (value.DungeonId == instanceId)
			{
				lordGymEntranceSet = new LordGymEntranceSet?(value);
				break;
			}
		}
		if (lordGymEntranceSet == null)
		{
			return null;
		}
		if (lordGymEntranceSet.Value.Id == 200104)
		{
			return new EUiViewName?(EUiViewName.LordGymThird5LoadingView);
		}
		if (lordGymEntranceSet.Value.Id != 200103 && LordGymModel.Instance.LastChallengeEntryFromGuide)
		{
			return null;
		}
		return new EUiViewName?(EUiViewName.LordGymLoadingView);
	}
}
