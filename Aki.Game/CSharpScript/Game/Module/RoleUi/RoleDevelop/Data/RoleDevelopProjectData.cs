using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02004D5D RID: 19805
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectData : RoleDevelopProjectBaseData
	{
		// Token: 0x060332DB RID: 209627 RVA: 0x00BEFA3E File Offset: 0x00BEDC3E
		public RoleDevelopProjectData(int id, RoleDevelopRoleBaseData developRoleData) : base(id, developRoleData)
		{
		}

		// Token: 0x060332DC RID: 209628 RVA: 0x00BEFA48 File Offset: 0x00BEDC48
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Normal;
		}

		// Token: 0x060332DD RID: 209629 RVA: 0x00BEFA4C File Offset: 0x00BEDC4C
		public RoleDevProject GetRoleDevProjectConfig()
		{
			return RoleDevConfig.Instance.GetRoleDevProjectConfig(this.Id).GetValueOrDefault();
		}

		// Token: 0x060332DE RID: 209630 RVA: 0x00BEFA74 File Offset: 0x00BEDC74
		public RoleDevCultivateProject GetCultivateProject()
		{
			return RoleDevelopUtil.GetCultivateProject(this.Id).GetValueOrDefault();
		}

		// Token: 0x060332DF RID: 209631 RVA: 0x00BEFA94 File Offset: 0x00BEDC94
		public RoleDataBase GetRoleData()
		{
			int id = this.Id;
			return RoleModel.Instance.GetRoleDataById(id, true);
		}

		// Token: 0x060332E0 RID: 209632 RVA: 0x00BEFAB4 File Offset: 0x00BEDCB4
		public int GetRoleLevel()
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return this.GetRoleData().GetLevelData().GetLevel();
			}
			return 1;
		}

		// Token: 0x060332E1 RID: 209633 RVA: 0x00BEFADA File Offset: 0x00BEDCDA
		public int GetRoleBreachLevel()
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return this.GetRoleData().GetLevelData().GetBreachLevel();
			}
			return 0;
		}

		// Token: 0x060332E2 RID: 209634 RVA: 0x00BEFB00 File Offset: 0x00BEDD00
		public int GetRoleExp()
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return this.GetRoleData().GetLevelData().GetExp();
			}
			return 0;
		}

		// Token: 0x060332E3 RID: 209635 RVA: 0x00BEFB26 File Offset: 0x00BEDD26
		public bool IsRoleMaxLevel()
		{
			return RoleModel.Instance.IsRoleOwned(this.Id) && this.GetRoleData().GetLevelData().GetRoleIsMaxLevel();
		}

		// Token: 0x060332E4 RID: 209636 RVA: 0x00BEFB4C File Offset: 0x00BEDD4C
		public bool IsRoleNeedBreakUp()
		{
			return !RoleModel.Instance.IsRoleOwned(this.Id) || this.GetRoleData().GetLevelData().GetRoleNeedBreakUp();
		}

		// Token: 0x060332E5 RID: 209637 RVA: 0x00BEFB74 File Offset: 0x00BEDD74
		public override int GetRoleTargetLevel()
		{
			return this.GetCultivateProject().RoleLevel;
		}

		// Token: 0x060332E6 RID: 209638 RVA: 0x00BEFB90 File Offset: 0x00BEDD90
		public int GetRoleTargetBreachLevel()
		{
			return this.GetCultivateProject().RoleBreachLevel;
		}

		// Token: 0x060332E7 RID: 209639 RVA: 0x00BEFBAC File Offset: 0x00BEDDAC
		public override int GetRoleUpgradeExp()
		{
			int num = 0;
			int id = this.Id;
			int roleTargetLevel = this.GetRoleTargetLevel();
			int roleLevel = this.GetRoleLevel();
			int roleExp = this.GetRoleExp();
			for (int i = roleLevel + 1; i <= roleTargetLevel; i++)
			{
				num += RoleModel.Instance.GetRoleLevelUpExp(id, i);
			}
			return num + this.GetRoleBreachOverflowExp() - roleExp;
		}

		// Token: 0x060332E8 RID: 209640 RVA: 0x00BEFC04 File Offset: 0x00BEDE04
		public int GetRoleBreachOverflowExp()
		{
			int roleBreachLevel = this.GetRoleBreachLevel();
			int num = this.GetRoleTargetBreachLevel() - roleBreachLevel;
			if (num <= 0)
			{
				return 0;
			}
			RoleDevConfig instance = RoleDevConfig.Instance;
			RoleDevCulProjectConfig? roleDevCulProjectConfig;
			int valueOrDefault = ((instance != null) ? ((instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().OverflowExperience) : null) : null).GetValueOrDefault(1);
			return num * valueOrDefault;
		}

		// Token: 0x060332E9 RID: 209641 RVA: 0x00BEFC78 File Offset: 0x00BEDE78
		public override List<RoleDevelopNeedItem> GetRoleUpgradeNeedItems()
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (ISelectedData selectedData in base.GetSortedRoleExpItemList())
			{
				list.Add(new RoleDevelopNeedItem
				{
					ItemId = selectedData.ItemId,
					Count = selectedData.Count
				});
			}
			return RoleDevelopUtil.CalcUpgradeNeedItems(this.GetRoleUpgradeExp(), list, (int itemId) => RoleModel.Instance.GetRoleExpItemExp(itemId).GetValueOrDefault(0));
		}

		// Token: 0x060332EA RID: 209642 RVA: 0x00BEFD18 File Offset: 0x00BEDF18
		public override List<RoleDevelopNeedItem> GetRoleBreachNeedItems()
		{
			int id = this.Id;
			Dictionary<int, RoleDevelopNeedItem> dictionary = new Dictionary<int, RoleDevelopNeedItem>();
			int roleBreachLevel = this.GetRoleBreachLevel();
			int roleTargetBreachLevel = this.GetRoleTargetBreachLevel();
			for (int i = roleBreachLevel + 1; i <= roleTargetBreachLevel; i++)
			{
				RoleBreach? roleBreachConfig = RoleConfig.Instance.GetRoleBreachConfig(id, i);
				if (roleBreachConfig != null)
				{
					foreach (DicIntInt dicIntInt in roleBreachConfig.Value.BreachConsumeIter())
					{
						int key = dicIntInt.Key;
						int value = dicIntInt.Value;
						if (!base.IsShouldSkipItem(key))
						{
							RoleDevelopNeedItem roleDevelopNeedItem;
							if (dictionary.TryGetValue(key, out roleDevelopNeedItem))
							{
								roleDevelopNeedItem.Count += value;
							}
							else
							{
								dictionary[key] = new RoleDevelopNeedItem
								{
									ItemId = key,
									Count = value
								};
							}
						}
					}
				}
			}
			return new List<RoleDevelopNeedItem>(dictionary.Values);
		}

		// Token: 0x060332EB RID: 209643 RVA: 0x00BEFE18 File Offset: 0x00BEE018
		public override List<RoleDevelopNeedItem> GetRoleDevelopNeedItems()
		{
			Dictionary<int, RoleDevelopNeedItem> dictionary = new Dictionary<int, RoleDevelopNeedItem>();
			List<RoleDevelopNeedItem> roleUpgradeNeedItems = this.GetRoleUpgradeNeedItems();
			List<RoleDevelopNeedItem> roleBreachNeedItems = this.GetRoleBreachNeedItems();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in roleUpgradeNeedItems)
			{
				RoleDevelopNeedItem roleDevelopNeedItem2;
				if (dictionary.TryGetValue(roleDevelopNeedItem.ItemId, out roleDevelopNeedItem2))
				{
					roleDevelopNeedItem2.Count += roleDevelopNeedItem.Count;
				}
				else
				{
					dictionary[roleDevelopNeedItem.ItemId] = new RoleDevelopNeedItem
					{
						ItemId = roleDevelopNeedItem.ItemId,
						Count = roleDevelopNeedItem.Count
					};
				}
			}
			foreach (RoleDevelopNeedItem roleDevelopNeedItem3 in roleBreachNeedItems)
			{
				RoleDevelopNeedItem roleDevelopNeedItem4;
				if (dictionary.TryGetValue(roleDevelopNeedItem3.ItemId, out roleDevelopNeedItem4))
				{
					roleDevelopNeedItem4.Count += roleDevelopNeedItem3.Count;
				}
				else
				{
					dictionary[roleDevelopNeedItem3.ItemId] = new RoleDevelopNeedItem
					{
						ItemId = roleDevelopNeedItem3.ItemId,
						Count = roleDevelopNeedItem3.Count
					};
				}
			}
			return new List<RoleDevelopNeedItem>(dictionary.Values);
		}

		// Token: 0x060332EC RID: 209644 RVA: 0x00BEFF58 File Offset: 0x00BEE158
		public override List<RoleDevelopProjectMaterialItemData> GetRoleDevelopProjectViewItems()
		{
			List<RoleDevelopProjectMaterialItemData> list = new List<RoleDevelopProjectMaterialItemData>();
			List<RoleDevelopNeedItem> list2 = new List<RoleDevelopNeedItem>();
			list2.AddRange(this.GetRoleUpgradeNeedItems());
			list2.AddRange(this.GetRoleBreachNeedItems());
			foreach (RoleDevelopItemGroup groupItem in RoleDevelopUtil.BuildGroupItemDataByNeedItems(list2, false, true, false))
			{
				list.Add(new RoleDevelopProjectMaterialItemData
				{
					GroupItem = groupItem,
					JumpCallback = new Action<RoleDevelopItemGroup>(base.HandleItemJumpCallback)
				});
			}
			return list;
		}

		// Token: 0x060332ED RID: 209645 RVA: 0x00BEFFF0 File Offset: 0x00BEE1F0
		public override int GetWeaponType()
		{
			return this.GetRoleDevProjectConfig().WeaponType;
		}

		// Token: 0x060332EE RID: 209646 RVA: 0x00BF000C File Offset: 0x00BEE20C
		public override int GetWeaponTargetLevel()
		{
			return this.GetCultivateProject().WeaponLevel;
		}

		// Token: 0x060332EF RID: 209647 RVA: 0x00BF0028 File Offset: 0x00BEE228
		public override int GetWeaponUpgradeExp()
		{
			if (!RoleModel.Instance.IsRoleOwned(this.Id))
			{
				RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(base.GetId());
				RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(roleDevProjectConfig.Value.WeaponType);
				int currentProjectNum = RoleDevelopUtil.GetCurrentProjectNum();
				return roleDevWeaponItemConfig.Value.WeaponTypeExperience(currentProjectNum);
			}
			RoleDevelopRoleBaseData developRoleData = this.DevelopRoleData;
			int num = 0;
			WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
			if (weaponInstance == null)
			{
				return 0;
			}
			int weaponTargetLevel = this.GetWeaponTargetLevel();
			int weaponLevel = developRoleData.GetWeaponLevel();
			int weaponExp = developRoleData.GetWeaponExp();
			for (int i = weaponLevel; i < weaponTargetLevel; i++)
			{
				num += weaponInstance.GetLevelExp(i);
			}
			return num + this.GetWeaponBreachOverflowExp() - weaponExp;
		}

		// Token: 0x060332F0 RID: 209648 RVA: 0x00BF00E4 File Offset: 0x00BEE2E4
		private int GetWeaponBreachOverflowExp()
		{
			RoleDevelopRoleBaseData developRoleData = this.DevelopRoleData;
			WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
			if (weaponInstance == null)
			{
				return 0;
			}
			int breachLevel = weaponInstance.GetBreachLevel();
			int num = developRoleData.GetWeaponTargetBreachLevel() - breachLevel;
			if (num <= 0)
			{
				return 0;
			}
			RoleDevConfig instance = RoleDevConfig.Instance;
			RoleDevCulProjectConfig? roleDevCulProjectConfig;
			int valueOrDefault = ((instance != null) ? ((instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().OverflowExperience) : null) : null).GetValueOrDefault(1);
			return num * valueOrDefault;
		}

		// Token: 0x060332F1 RID: 209649 RVA: 0x00BF0170 File Offset: 0x00BEE370
		public override List<RoleDevelopNeedItem> GetWeaponUpgradeNeedItems()
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				WeaponInstance weaponInstance = this.DevelopRoleData.GetWeaponInstance();
				if (weaponInstance != null && !WeaponModel.Instance.IsWeaponHighQuality(weaponInstance))
				{
					return new List<RoleDevelopNeedItem>();
				}
			}
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (ISelectedData selectedData in base.GetSortedWeaponExpItemList())
			{
				list.Add(new RoleDevelopNeedItem
				{
					ItemId = selectedData.ItemId,
					Count = selectedData.Count
				});
			}
			return RoleDevelopUtil.CalcUpgradeNeedItems(this.GetWeaponUpgradeExp(), list, (int itemId) => WeaponModel.Instance.GetWeaponItemExp(0, itemId));
		}

		// Token: 0x060332F2 RID: 209650 RVA: 0x00BF0244 File Offset: 0x00BEE444
		public override List<RoleDevelopNeedItem> GetWeaponBreachNeedItems()
		{
			RoleDevelopRoleBaseData developRoleData = this.DevelopRoleData;
			int weaponTargetBreachLevel = developRoleData.GetWeaponTargetBreachLevel();
			Dictionary<int, RoleDevelopNeedItem> dictionary = new Dictionary<int, RoleDevelopNeedItem>();
			if (!RoleModel.Instance.IsRoleOwned(this.Id))
			{
				int weaponType = RoleDevConfig.Instance.GetRoleDevProjectConfig(base.GetId()).Value.WeaponType;
				RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType);
				for (int i = 0; i <= weaponTargetBreachLevel; i++)
				{
					WeaponBreach? weaponBreach = WeaponConfig.Instance.GetWeaponBreach(roleDevWeaponItemConfig.Value.WeaponItemGroup, i);
					if (weaponBreach != null)
					{
						foreach (DicIntInt dicIntInt in weaponBreach.Value.ConsumeIter())
						{
							int key = dicIntInt.Key;
							int value = dicIntInt.Value;
							if (!base.IsShouldSkipItem(key))
							{
								RoleDevelopNeedItem roleDevelopNeedItem;
								if (dictionary.TryGetValue(key, out roleDevelopNeedItem))
								{
									roleDevelopNeedItem.Count += value;
								}
								else
								{
									dictionary[key] = new RoleDevelopNeedItem
									{
										ItemId = key,
										Count = value
									};
								}
							}
						}
					}
				}
				return new List<RoleDevelopNeedItem>(dictionary.Values);
			}
			WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
			if (weaponInstance == null)
			{
				return new List<RoleDevelopNeedItem>();
			}
			if (!WeaponModel.Instance.IsWeaponHighQuality(weaponInstance))
			{
				return new List<RoleDevelopNeedItem>();
			}
			WeaponConf? weaponConfig = weaponInstance.GetWeaponConfig();
			for (int j = weaponInstance.GetBreachLevel(); j < weaponTargetBreachLevel; j++)
			{
				WeaponBreach? weaponBreach2 = WeaponConfig.Instance.GetWeaponBreach(weaponConfig.Value.BreachId, j);
				if (weaponBreach2 != null)
				{
					foreach (DicIntInt dicIntInt2 in weaponBreach2.Value.ConsumeIter())
					{
						int key2 = dicIntInt2.Key;
						int value2 = dicIntInt2.Value;
						if (!base.IsShouldSkipItem(key2))
						{
							RoleDevelopNeedItem roleDevelopNeedItem2;
							if (dictionary.TryGetValue(key2, out roleDevelopNeedItem2))
							{
								roleDevelopNeedItem2.Count += value2;
							}
							else
							{
								dictionary[key2] = new RoleDevelopNeedItem
								{
									ItemId = key2,
									Count = value2
								};
							}
						}
					}
				}
			}
			return new List<RoleDevelopNeedItem>(dictionary.Values);
		}

		// Token: 0x060332F3 RID: 209651 RVA: 0x00BF04B0 File Offset: 0x00BEE6B0
		public override List<RoleDevelopProjectMaterialItemData> GetWeaponDevelopProjectViewItems()
		{
			List<RoleDevelopProjectMaterialItemData> list = new List<RoleDevelopProjectMaterialItemData>();
			List<RoleDevelopNeedItem> list2 = new List<RoleDevelopNeedItem>();
			list2.AddRange(this.GetWeaponUpgradeNeedItems());
			list2.AddRange(this.GetWeaponBreachNeedItems());
			foreach (RoleDevelopItemGroup groupItem in RoleDevelopUtil.BuildGroupItemDataByNeedItems(list2, false, true, false))
			{
				list.Add(new RoleDevelopProjectMaterialItemData
				{
					GroupItem = groupItem,
					JumpCallback = new Action<RoleDevelopItemGroup>(base.HandleItemJumpCallback)
				});
			}
			return list;
		}

		// Token: 0x060332F4 RID: 209652 RVA: 0x00BF0548 File Offset: 0x00BEE748
		public override List<RoleDevelopSkillData> GetSkillDevelopData()
		{
			int id = this.Id;
			RoleDevCultivateProject cultivateProject = this.GetCultivateProject();
			int[] prefectSkillLevelArray = cultivateProject.GetPrefectSkillLevelArray();
			int[] canLevelUpSkillNodeIndexList = RoleDevConfig.Instance.GetCanLevelUpSkillNodeIndexList();
			if (canLevelUpSkillNodeIndexList.Length != prefectSkillLevelArray.Length)
			{
				Log.Instance.Error(ELogModule.RoleDev, ELogAuthor.LJS, "LevelUpSkillNodeIndexList长度与PrefectSkillLevel长度不一致", default(ReadOnlySpan<ValueTuple<string, object>>));
				return new List<RoleDevelopSkillData>();
			}
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			List<int> list3 = new List<int>();
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(id);
			bool flag = RoleModel.Instance.IsRoleOwned(id);
			for (int i = 0; i < canLevelUpSkillNodeIndexList.Length; i++)
			{
				int nodeIndex = canLevelUpSkillNodeIndexList[i];
				int id2 = RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndIndex(roleConfig.Value.SkillTreeGroupId, nodeIndex).Value.Id;
				list3.Add(id2);
				if (flag)
				{
					list.Add(RoleModel.Instance.GetRoleSkillTreeNodeLevel(id, id2));
				}
				else
				{
					list.Add(1);
				}
				list2.Add(prefectSkillLevelArray[i]);
			}
			int[] skillTreeConfigArrayArray = cultivateProject.GetSkillTreeConfigArrayArray();
			if (skillTreeConfigArrayArray != null)
			{
				foreach (int nodeIndex2 in skillTreeConfigArrayArray)
				{
					int id3 = RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndIndex(roleConfig.Value.SkillTreeGroupId, nodeIndex2).Value.Id;
					list3.Add(id3);
					if (flag)
					{
						list.Add(RoleModel.Instance.GetRoleSkillTreeNodeLevel(id, id3));
					}
					else
					{
						list.Add(0);
					}
					list2.Add(1);
				}
			}
			List<RoleDevelopSkillData> list4 = new List<RoleDevelopSkillData>();
			for (int k = 0; k < list3.Count; k++)
			{
				RoleDevelopSkillData item = new RoleDevelopSkillData
				{
					RoleId = id,
					SkillNodeId = list3[k],
					CurrentLevel = list[k],
					TargetLevel = list2[k],
					Index = k
				};
				list4.Add(item);
			}
			return list4;
		}

		// Token: 0x060332F5 RID: 209653 RVA: 0x00BF074D File Offset: 0x00BEE94D
		public override bool IsSkillPlanFinished()
		{
			if (!RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return false;
			}
			return this.GetSkillDevelopData().TrueForAll((RoleDevelopSkillData skill) => skill.CurrentLevel >= skill.TargetLevel);
		}

		// Token: 0x060332F6 RID: 209654 RVA: 0x00BF0790 File Offset: 0x00BEE990
		public override List<RoleDevelopNeedItem> GetSkillPlanNeedItems()
		{
			Dictionary<int, RoleDevelopNeedItem> dictionary = new Dictionary<int, RoleDevelopNeedItem>();
			bool flag = RoleModel.Instance.IsRoleOwned(this.Id);
			foreach (RoleDevelopSkillData roleDevelopSkillData in this.GetSkillDevelopData())
			{
				int skillNodeId = roleDevelopSkillData.SkillNodeId;
				int currentLevel = flag ? RoleModel.Instance.GetRoleSkillTreeNodeLevel(this.Id, skillNodeId) : roleDevelopSkillData.CurrentLevel;
				int targetLevel = roleDevelopSkillData.TargetLevel;
				this.CollectSkillNodeNeedItems(skillNodeId, currentLevel, targetLevel, dictionary);
			}
			return new List<RoleDevelopNeedItem>(dictionary.Values);
		}

		// Token: 0x060332F7 RID: 209655 RVA: 0x00BF083C File Offset: 0x00BEEA3C
		private void CollectSkillNodeNeedItems(int skillNodeId, int currentLevel, int targetLevel, Dictionary<int, RoleDevelopNeedItem> needItemMap)
		{
			if (targetLevel - currentLevel <= 0)
			{
				return;
			}
			for (int i = currentLevel + 1; i <= targetLevel; i++)
			{
				IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(skillNodeId, i);
				if (roleSkillTreeConsume != null)
				{
					foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
					{
						int key = dicIntInt.Value.Key;
						int value = dicIntInt.Value.Value;
						if (!base.IsShouldSkipItem(key))
						{
							RoleDevelopNeedItem roleDevelopNeedItem;
							if (needItemMap.TryGetValue(key, out roleDevelopNeedItem))
							{
								roleDevelopNeedItem.Count += value;
							}
							else
							{
								needItemMap[key] = new RoleDevelopNeedItem
								{
									ItemId = key,
									Count = value
								};
							}
						}
					}
				}
			}
		}

		// Token: 0x060332F8 RID: 209656 RVA: 0x00BF0918 File Offset: 0x00BEEB18
		public override List<RoleDevelopProjectMaterialItemData> GetSkillDevelopProjectViewItems()
		{
			List<RoleDevelopProjectMaterialItemData> list = new List<RoleDevelopProjectMaterialItemData>();
			foreach (RoleDevelopItemGroup groupItem in RoleDevelopUtil.BuildGroupItemDataByNeedItems(this.GetSkillPlanNeedItems(), false, true, false))
			{
				list.Add(new RoleDevelopProjectMaterialItemData
				{
					GroupItem = groupItem,
					JumpCallback = new Action<RoleDevelopItemGroup>(base.HandleItemJumpCallback)
				});
			}
			return list;
		}

		// Token: 0x060332F9 RID: 209657 RVA: 0x00BF0998 File Offset: 0x00BEEB98
		public override bool IsShowUpgradeHint(ERoleDevelopCategoryType categoryType)
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				switch (categoryType)
				{
				case ERoleDevelopCategoryType.Role:
					return !this.IsRoleDevelopFinished() && RoleDevelopUtil.CheckIsAllNeedItemsEnoughOrCanBeFilled(this.GetRoleDevelopNeedItems());
				case ERoleDevelopCategoryType.Weapon:
				{
					WeaponInstance weaponInstance = this.DevelopRoleData.GetWeaponInstance();
					if (weaponInstance == null || !WeaponModel.Instance.IsWeaponHighQuality(weaponInstance) || this.IsWeaponDevelopFinished())
					{
						return false;
					}
					List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
					list.AddRange(this.GetWeaponUpgradeNeedItems());
					list.AddRange(this.GetWeaponBreachNeedItems());
					return RoleDevelopUtil.CheckIsAllNeedItemsEnoughOrCanBeFilled(list);
				}
				case ERoleDevelopCategoryType.Phantom:
					return false;
				case ERoleDevelopCategoryType.Skill:
					return !this.IsSkillPlanFinished() && RoleDevelopUtil.CheckIsAllNeedItemsEnoughOrCanBeFilled(this.GetSkillPlanNeedItems());
				}
			}
			return false;
		}

		// Token: 0x060332FA RID: 209658 RVA: 0x00BF0A4C File Offset: 0x00BEEC4C
		public override bool IsShowFinishHint(ERoleDevelopCategoryType categoryType)
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				switch (categoryType)
				{
				case ERoleDevelopCategoryType.Role:
					return this.IsRoleDevelopFinished();
				case ERoleDevelopCategoryType.Weapon:
				{
					WeaponInstance weaponInstance = this.DevelopRoleData.GetWeaponInstance();
					return weaponInstance != null && WeaponModel.Instance.IsWeaponHighQuality(weaponInstance) && this.IsWeaponDevelopFinished();
				}
				case ERoleDevelopCategoryType.Phantom:
					return false;
				case ERoleDevelopCategoryType.Skill:
					return this.IsSkillPlanFinished();
				}
			}
			return false;
		}

		// Token: 0x060332FB RID: 209659 RVA: 0x00BF0ABB File Offset: 0x00BEECBB
		public override bool IsRoleDevelopFinished()
		{
			return this.IsRoleReachTargetLevel() && this.IsRoleReachBreachLevel();
		}

		// Token: 0x060332FC RID: 209660 RVA: 0x00BF0ACD File Offset: 0x00BEECCD
		public override bool IsWeaponDevelopFinished()
		{
			return this.IsWeaponReachTargetLevel() && this.IsWeaponReachBreachLevel();
		}

		// Token: 0x060332FD RID: 209661 RVA: 0x00BF0ADF File Offset: 0x00BEECDF
		public override bool IsRoleReachTargetLevel()
		{
			return this.GetRoleLevel() >= this.GetRoleTargetLevel();
		}

		// Token: 0x060332FE RID: 209662 RVA: 0x00BF0AF2 File Offset: 0x00BEECF2
		public override bool IsRoleReachBreachLevel()
		{
			return this.GetRoleBreachLevel() >= this.GetRoleTargetBreachLevel();
		}

		// Token: 0x060332FF RID: 209663 RVA: 0x00BF0B05 File Offset: 0x00BEED05
		public override bool IsWeaponReachTargetLevel()
		{
			return this.DevelopRoleData.GetWeaponLevel() >= this.GetWeaponTargetLevel();
		}

		// Token: 0x06033300 RID: 209664 RVA: 0x00BF0B1D File Offset: 0x00BEED1D
		public override bool IsWeaponReachBreachLevel()
		{
			return this.DevelopRoleData.GetWeaponBreachLevel() >= this.DevelopRoleData.GetWeaponTargetBreachLevel();
		}
	}
}
