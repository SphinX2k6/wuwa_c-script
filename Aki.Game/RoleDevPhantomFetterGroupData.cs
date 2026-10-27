using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002801 RID: 10241
public class RoleDevPhantomFetterGroupData : RoleDevPhantomVisionSuitItemData
{
	// Token: 0x0601503C RID: 86076 RVA: 0x00552944 File Offset: 0x00550B44
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

	// Token: 0x0601503D RID: 86077 RVA: 0x00552A04 File Offset: 0x00550C04
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

	// Token: 0x0601503E RID: 86078 RVA: 0x00552A64 File Offset: 0x00550C64
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
