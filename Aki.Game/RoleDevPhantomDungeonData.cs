using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02002800 RID: 10240
public class RoleDevPhantomDungeonData : RoleDevPhantomVisionSuitItemData
{
	// Token: 0x06015039 RID: 86073 RVA: 0x005527EC File Offset: 0x005509EC
	public void InitByDungeon(int dungeonId)
	{
		if (dungeonId <= 0)
		{
			return;
		}
		SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
		if (silentAreaDetectData == null || silentAreaDetectData.IsLock)
		{
			return;
		}
		SilentAreaDetection conf = silentAreaDetectData.Conf;
		List<IDropRewardItemData> dungeonDropRewards = this.GetDungeonDropRewards(conf);
		string buttonName = "RoleProject_Button03";
		base.InitByBaseData(dungeonId, EVisionSuitItemType.Dungeon, conf.Name ?? "", 0, buttonName, conf.BigIcon);
		base.SetRewardDataList(dungeonDropRewards);
		base.SetDungeonId(dungeonId);
	}

	// Token: 0x0601503A RID: 86074 RVA: 0x0055285C File Offset: 0x00550A5C
	[NullableContext(1)]
	protected List<IDropRewardItemData> GetDungeonDropRewards(SilentAreaDetection conf)
	{
		List<IDropRewardItemData> list = new List<IDropRewardItemData>();
		if (conf.ShowRewardMap().Count > 0)
		{
			Dictionary<int, int> dictionary;
			if (conf.Secondary == 63 || conf.Secondary == 64)
			{
				dictionary = AdventureGuideConfig.Instance.GetNightMareShowReward(conf.ShowRewardMapCalabash());
			}
			else
			{
				dictionary = AdventureGuideConfig.Instance.GetShowReward(conf.ShowRewardMap(), null);
			}
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in dictionary)
				{
					list.Add(new DropRewardItemData
					{
						Type = ERoleDevItemType.Reward,
						ItemId = keyValuePair.Key,
						Count = keyValuePair.Value,
						HaveFinish = false
					});
				}
			}
		}
		return list;
	}
}
