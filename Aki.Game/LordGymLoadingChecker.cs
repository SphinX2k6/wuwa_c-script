using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x0200206C RID: 8300
public class LordGymLoadingChecker : ISpecialCustomLoadingTypeChecker
{
	// Token: 0x06010574 RID: 66932 RVA: 0x003FC9B4 File Offset: 0x003FABB4
	public bool CanHandle(int instanceId)
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 48;
	}

	// Token: 0x06010575 RID: 66933 RVA: 0x003FC9EC File Offset: 0x003FABEC
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
