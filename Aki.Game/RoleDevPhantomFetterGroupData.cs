using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001D7C RID: 7548
public class RoleDevPhantomFetterGroupData : RoleDevPhantomVisionSuitItemData
{
	// Token: 0x06012A3C RID: 76348 RVA: 0x0057D718 File Offset: 0x0057B918
	[NullableContext(2)]
	public void InitByFetterGroup(int fetterGroupId, int roleId, List<int> recommendGroupIds = null)
	{
		if (recommendGroupIds == null)
		{
			recommendGroupIds = new List<int>();
		}
		int num = 4;
		int[] fetterGroupMonsterIdArray = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(fetterGroupId);
		if (fetterGroupMonsterIdArray != null && fetterGroupMonsterIdArray.Length != 0)
		{
			List<IPhantomMonsterItemData> list = new List<IPhantomMonsterItemData>();
			foreach (int monsterId in fetterGroupMonsterIdArray)
			{
				if (this.IsMonsterCost4(monsterId, num))
				{
					list.Add(this.CreateMonsterData(monsterId));
				}
			}
			if (list.Count > 0)
			{
				string buttonName = "RoleProject_Button02";
				int id = 1;
				EVisionSuitItemType itemType = EVisionSuitItemType.Phantom;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Cost");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				base.InitByBaseData(id, itemType, defaultInterpolatedStringHandler.ToStringAndClear(), num, buttonName, "");
				base.SetMonsterDataList(list);
				base.SetFetterGroupInfo(fetterGroupId, roleId, recommendGroupIds);
			}
		}
	}

	// Token: 0x06012A3D RID: 76349 RVA: 0x0057D7D8 File Offset: 0x0057B9D8
	private bool IsMonsterCost4(int monsterId, int targetCost)
	{
		IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId);
		if (phantomItemByMonsterId == null || phantomItemByMonsterId.Count == 0)
		{
			return false;
		}
		int rarity = phantomItemByMonsterId[0].Rarity;
		PhantomRarity? phantomRareConfig = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity);
		return phantomRareConfig != null && phantomRareConfig.Value.Cost == targetCost;
	}

	// Token: 0x06012A3E RID: 76350 RVA: 0x0057D838 File Offset: 0x0057BA38
	[NullableContext(1)]
	private IPhantomMonsterItemData CreateMonsterData(int monsterId)
	{
		return new PhantomMonsterItemData
		{
			MonsterId = monsterId,
			QualityId = 0,
			RoleId = 0
		};
	}
}
