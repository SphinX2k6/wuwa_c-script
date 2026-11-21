using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02003D26 RID: 15654
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectData : RoleDevelopProjectBaseData
	{
		// Token: 0x06028146 RID: 164166 RVA: 0x00B38B72 File Offset: 0x00B36D72
		public RoleDevelopProjectData(int id, RoleDevelopRoleBaseData developRoleData) : base(id, developRoleData)
		{
		}

		// Token: 0x06028147 RID: 164167 RVA: 0x00B38B7C File Offset: 0x00B36D7C
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Normal;
		}

		// Token: 0x06028148 RID: 164168 RVA: 0x00B38B80 File Offset: 0x00B36D80
		public RoleDevProject GetRoleDevProjectConfig()
		{
			return RoleDevConfig.Instance.GetRoleDevProjectConfig(this.Id).GetValueOrDefault();
		}

		// Token: 0x06028149 RID: 164169 RVA: 0x00B38BA8 File Offset: 0x00B36DA8
		public RoleDevCultivateProject GetCultivateProject()
		{
			return RoleDevelopUtil.GetCultivateProject(this.Id).GetValueOrDefault();
		}

		// Token: 0x0602814A RID: 164170 RVA: 0x00B38BC8 File Offset: 0x00B36DC8
		public RoleDataBase GetRoleData()
		{
			int id = this.Id;
			return RoleModel.Instance.GetRoleDataById(id, true);
		}

		// Token: 0x0602814B RID: 164171 RVA: 0x00B38BE8 File Offset: 0x00B36DE8
		public int GetRoleLevel()
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return this.GetRoleData().GetLevelData().GetLevel();
			}
			return 1;
		}

		// Token: 0x0602814C RID: 164172 RVA: 0x00B38C0E File Offset: 0x00B36E0E
		public int GetRoleBreachLevel()
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return this.GetRoleData().GetLevelData().GetBreachLevel();
			}
			return 0;
		}

		// Token: 0x0602814D RID: 164173 RVA: 0x00B38C34 File Offset: 0x00B36E34
		public int GetRoleExp()
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return this.GetRoleData().GetLevelData().GetExp();
			}
			return 0;
		}

		// Token: 0x0602814E RID: 164174 RVA: 0x00B38C5A File Offset: 0x00B36E5A
		public bool IsRoleMaxLevel()
		{
			return RoleModel.Instance.IsRoleOwned(this.Id) && this.GetRoleData().GetLevelData().GetRoleIsMaxLevel();
		}

		// Token: 0x0602814F RID: 164175 RVA: 0x00B38C80 File Offset: 0x00B36E80
		public bool IsRoleNeedBreakUp()
		{
			return !RoleModel.Instance.IsRoleOwned(this.Id) || this.GetRoleData().GetLevelData().GetRoleNeedBreakUp();
		}

		// Token: 0x06028150 RID: 164176 RVA: 0x00B38CA8 File Offset: 0x00B36EA8
		public override int GetRoleTargetLevel()
		{
			return this.GetCultivateProject().RoleLevel;
		}

		// Token: 0x06028151 RID: 164177 RVA: 0x00B38CC4 File Offset: 0x00B36EC4
		public int GetRoleTargetBreachLevel()
		{
			return this.GetCultivateProject().RoleBreachLevel;
		}

		// Token: 0x06028152 RID: 164178 RVA: 0x00B38CE0 File Offset: 0x00B36EE0
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

		// Token: 0x06028153 RID: 164179 RVA: 0x00B38D38 File Offset: 0x00B36F38
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

		// Token: 0x06028154 RID: 164180 RVA: 0x00B38DAC File Offset: 0x00B36FAC
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

		// Token: 0x06028155 RID: 164181 RVA: 0x00B38E4C File Offset: 0x00B3704C
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

		// Token: 0x06028156 RID: 164182 RVA: 0x00B38F4C File Offset: 0x00B3714C
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

		// Token: 0x06028157 RID: 164183 RVA: 0x00B3908C File Offset: 0x00B3728C
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

		// Token: 0x06028158 RID: 164184 RVA: 0x00B39124 File Offset: 0x00B37324
		public override int GetWeaponType()
		{
			return this.GetRoleDevProjectConfig().WeaponType;
		}

		// Token: 0x06028159 RID: 164185 RVA: 0x00B39140 File Offset: 0x00B37340
		public override int GetWeaponTargetLevel()
		{
			return this.GetCultivateProject().WeaponLevel;
		}

		// Token: 0x0602815A RID: 164186 RVA: 0x00B3915C File Offset: 0x00B3735C
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

		// Token: 0x0602815B RID: 164187 RVA: 0x00B39218 File Offset: 0x00B37418
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

		// Token: 0x0602815C RID: 164188 RVA: 0x00B392A4 File Offset: 0x00B374A4
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

		// Token: 0x0602815D RID: 164189 RVA: 0x00B39378 File Offset: 0x00B37578
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

		// Token: 0x0602815E RID: 164190 RVA: 0x00B395E4 File Offset: 0x00B377E4
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

		// Token: 0x0602815F RID: 164191 RVA: 0x00B3967C File Offset: 0x00B3787C
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

		// Token: 0x06028160 RID: 164192 RVA: 0x00B39881 File Offset: 0x00B37A81
		public override bool IsSkillPlanFinished()
		{
			if (!RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return false;
			}
			return this.GetSkillDevelopData().TrueForAll((RoleDevelopSkillData skill) => skill.CurrentLevel >= skill.TargetLevel);
		}

		// Token: 0x06028161 RID: 164193 RVA: 0x00B398C4 File Offset: 0x00B37AC4
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

		// Token: 0x06028162 RID: 164194 RVA: 0x00B39970 File Offset: 0x00B37B70
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

		// Token: 0x06028163 RID: 164195 RVA: 0x00B39A4C File Offset: 0x00B37C4C
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

		// Token: 0x06028164 RID: 164196 RVA: 0x00B39ACC File Offset: 0x00B37CCC
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

		// Token: 0x06028165 RID: 164197 RVA: 0x00B39B80 File Offset: 0x00B37D80
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

		// Token: 0x06028166 RID: 164198 RVA: 0x00B39BF0 File Offset: 0x00B37DF0
		public override bool IsShowCanImproveHint(ERoleDevelopCategoryType categoryType)
		{
			if (RoleModel.Instance.IsRoleOwned(this.Id))
			{
				switch (categoryType)
				{
				case ERoleDevelopCategoryType.Role:
					return RoleDevelopUtil.GetRoleState(this.Id) == ERoleDevelopRoleState.LevelNotEnough;
				case ERoleDevelopCategoryType.Weapon:
				{
					ERoleDevelopWeaponState weaponState = RoleDevelopUtil.GetWeaponState(this.Id);
					return weaponState - ERoleDevelopWeaponState.QualityLow <= 1;
				}
				case ERoleDevelopCategoryType.Phantom:
					return RoleDevelopUtil.GetPhantomState(this.Id) > ERoleDevelopPhantomState.Complete;
				case ERoleDevelopCategoryType.Skill:
					return RoleDevelopUtil.GetSkillState(this.Id) == ERoleDevelopSkillState.PlanNotFinished;
				}
			}
			return false;
		}

		// Token: 0x06028167 RID: 164199 RVA: 0x00B39C71 File Offset: 0x00B37E71
		public override bool IsRoleDevelopFinished()
		{
			return this.IsRoleReachTargetLevel() && this.IsRoleReachBreachLevel();
		}

		// Token: 0x06028168 RID: 164200 RVA: 0x00B39C83 File Offset: 0x00B37E83
		public override bool IsWeaponDevelopFinished()
		{
			return this.IsWeaponReachTargetLevel() && this.IsWeaponReachBreachLevel();
		}

		// Token: 0x06028169 RID: 164201 RVA: 0x00B39C95 File Offset: 0x00B37E95
		public override bool IsRoleReachTargetLevel()
		{
			return this.GetRoleLevel() >= this.GetRoleTargetLevel();
		}

		// Token: 0x0602816A RID: 164202 RVA: 0x00B39CA8 File Offset: 0x00B37EA8
		public override bool IsRoleReachBreachLevel()
		{
			return this.GetRoleBreachLevel() >= this.GetRoleTargetBreachLevel();
		}

		// Token: 0x0602816B RID: 164203 RVA: 0x00B39CBB File Offset: 0x00B37EBB
		public override bool IsWeaponReachTargetLevel()
		{
			return this.DevelopRoleData.GetWeaponLevel() >= this.GetWeaponTargetLevel();
		}

		// Token: 0x0602816C RID: 164204 RVA: 0x00B39CD3 File Offset: 0x00B37ED3
		public override bool IsWeaponReachBreachLevel()
		{
			return this.DevelopRoleData.GetWeaponBreachLevel() >= this.DevelopRoleData.GetWeaponTargetBreachLevel();
		}
	}
}
