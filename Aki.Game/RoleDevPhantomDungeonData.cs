using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02001D7B RID: 7547
public class RoleDevPhantomDungeonData : RoleDevPhantomVisionSuitItemData
{
	// Token: 0x06012A39 RID: 76345 RVA: 0x0057D5C0 File Offset: 0x0057B7C0
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

	// Token: 0x06012A3A RID: 76346 RVA: 0x0057D630 File Offset: 0x0057B830
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
