using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x02005246 RID: 21062
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PinballModel : ModelBase
	{
		// Token: 0x060346D6 RID: 214742 RVA: 0x00EAC083 File Offset: 0x00EAA283
		public void SetActivityId(int id)
		{
			this.ActivityDataIdInternal = id;
		}

		// Token: 0x170065E9 RID: 26089
		// (get) Token: 0x060346D7 RID: 214743 RVA: 0x00EAC08C File Offset: 0x00EAA28C
		public PinballActivityData ActivityData
		{
			get
			{
				return ActivityModel.Instance.GetActivityById(this.ActivityDataIdInternal) as PinballActivityData;
			}
		}

		// Token: 0x060346D8 RID: 214744 RVA: 0x00EAC0A4 File Offset: 0x00EAA2A4
		[NullableContext(2)]
		public PinballActivityData GetActivityDataByActivityId(int activityId)
		{
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(activityId);
			if (activityById == null)
			{
				return null;
			}
			return activityById as PinballActivityData;
		}

		// Token: 0x060346D9 RID: 214745 RVA: 0x00EAC0C8 File Offset: 0x00EAA2C8
		public List<PinballWeaponData> GetAllWeaponDataList()
		{
			return this.ActivityData.GetWeaponDataAll();
		}

		// Token: 0x060346DA RID: 214746 RVA: 0x00EAC0D5 File Offset: 0x00EAA2D5
		[NullableContext(2)]
		public PinballWeaponData GetWeaponDataByIncId(int incId)
		{
			return this.ActivityData.GetWeaponDataByIncId(incId);
		}

		// Token: 0x060346DB RID: 214747 RVA: 0x00EAC0E3 File Offset: 0x00EAA2E3
		public void RemoveWeaponData(List<int> incIdList)
		{
			this.ActivityData.RemoveWeaponData(incIdList);
			this.ActivityData.UpdateRoleWeaponRedDot();
		}

		// Token: 0x060346DC RID: 214748 RVA: 0x00EAC0FC File Offset: 0x00EAA2FC
		public int GetWeaponItemCount(int configId)
		{
			return this.ActivityData.GetWeaponCountByConfigId(configId);
		}

		// Token: 0x060346DD RID: 214749 RVA: 0x00EAC10C File Offset: 0x00EAA30C
		public string GetFormatAttributeValueString(PinballPropertyIndex config, float attributeValue)
		{
			float num = attributeValue;
			if (config.ShowCoefficient > 1)
			{
				num /= (float)config.ShowCoefficient;
			}
			if (config.IsPercent)
			{
				int num2 = 100;
				return MathUtils.Instance.GetFloatPointFloorString((double)(num / (float)num2), 1) + "%";
			}
			return ((int)Math.Floor((double)num)).ToString();
		}

		// Token: 0x060346DE RID: 214750 RVA: 0x00EAC168 File Offset: 0x00EAA368
		public int GetMaxLevelByGroupId(int groupId)
		{
			IReadOnlyList<PinballRoleLevelConfig> pinballRoleLevelConfigListByGroupId = PinballConfig.Instance.GetPinballRoleLevelConfigListByGroupId(groupId);
			int num = 0;
			if (pinballRoleLevelConfigListByGroupId != null)
			{
				foreach (PinballRoleLevelConfig pinballRoleLevelConfig in pinballRoleLevelConfigListByGroupId)
				{
					num = Math.Max(num, pinballRoleLevelConfig.Level);
				}
			}
			return num;
		}

		// Token: 0x060346DF RID: 214751 RVA: 0x00EAC1CC File Offset: 0x00EAA3CC
		public int GetMaxLevelByPinballRoleConfig(PinballRoleConfig roleConfig)
		{
			return this.GetMaxLevelByGroupId(roleConfig.GradeUpGroup);
		}

		// Token: 0x060346E0 RID: 214752 RVA: 0x00EAC1DC File Offset: 0x00EAA3DC
		public int GetMaxLevelByPinballByRoleId(int roleId)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				return 0;
			}
			return this.GetMaxLevelByPinballRoleConfig(pinballRoleConfigById.Value);
		}

		// Token: 0x060346E1 RID: 214753 RVA: 0x00EAC210 File Offset: 0x00EAA410
		public string GetRoleNameByPinballRoleConfig(PinballRoleConfig roleConfig)
		{
			RoleInfo? roleConfig2 = RoleConfig.Instance.GetRoleConfig(roleConfig.RoleId);
			return ((roleConfig2 != null) ? roleConfig2.GetValueOrDefault().Name : null) ?? "";
		}

		// Token: 0x060346E2 RID: 214754 RVA: 0x00EAC254 File Offset: 0x00EAA454
		public string GetRoleNameByPinballRoleId(int roleId)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				return "";
			}
			return this.GetRoleNameByPinballRoleConfig(pinballRoleConfigById.Value);
		}

		// Token: 0x060346E3 RID: 214755 RVA: 0x00EAC28C File Offset: 0x00EAA48C
		public int GetRoleLevelUpCostItemId(int activityId)
		{
			PinballActivity? pinballActivityConfigByActivityId = PinballConfig.Instance.GetPinballActivityConfigByActivityId(activityId);
			if (pinballActivityConfigByActivityId == null)
			{
				return 0;
			}
			return pinballActivityConfigByActivityId.Value.ExpItemId;
		}

		// Token: 0x060346E4 RID: 214756 RVA: 0x00EAC2C0 File Offset: 0x00EAA4C0
		public int GetRoleLevelUpCostCount(int gradeUpGroup, int curLevel, int targetLevel)
		{
			int num = 0;
			for (int i = curLevel; i < targetLevel; i++)
			{
				PinballRoleLevelConfig? pinballRoleLevelConfigByGroupIdAndLevel = PinballConfig.Instance.GetPinballRoleLevelConfigByGroupIdAndLevel(gradeUpGroup, i);
				if (pinballRoleLevelConfigByGroupIdAndLevel != null)
				{
					num += pinballRoleLevelConfigByGroupIdAndLevel.Value.Consume;
				}
			}
			return num;
		}

		// Token: 0x060346E5 RID: 214757 RVA: 0x00EAC304 File Offset: 0x00EAA504
		public bool IsRoleMaxLevel(int roleId)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				return false;
			}
			int maxLevelByPinballRoleConfig = this.GetMaxLevelByPinballRoleConfig(pinballRoleConfigById.Value);
			PinballRoleData roleData = PinballModel.Instance.ActivityData.GetRoleData(roleId);
			return roleData != null && roleData.GetLevel() >= maxLevelByPinballRoleConfig;
		}

		// Token: 0x060346E6 RID: 214758 RVA: 0x00EAC358 File Offset: 0x00EAA558
		public int GetPinballWeaponPackageCapacity()
		{
			int itemTypeId = 10;
			int packageId = InventoryConfig.Instance.GetItemMainTypeConfig(itemTypeId).Value.PackageId;
			return InventoryConfig.Instance.GetPackageConfig(packageId).Value.Capacity;
		}

		// Token: 0x060346E7 RID: 214759 RVA: 0x00EAC3A1 File Offset: 0x00EAA5A1
		public void SetBattleCenterRootItem(UUIItem item)
		{
			this.BattleCenterRootItem = item;
		}

		// Token: 0x060346E8 RID: 214760 RVA: 0x00EAC3AA File Offset: 0x00EAA5AA
		[NullableContext(2)]
		public UUIItem GetBattleCenterRootItem()
		{
			return this.BattleCenterRootItem;
		}

		// Token: 0x060346E9 RID: 214761 RVA: 0x00EAC3B2 File Offset: 0x00EAA5B2
		public void ClearBattleCenterRootItem()
		{
			this.BattleCenterRootItem = null;
		}

		// Token: 0x060346EA RID: 214762 RVA: 0x00EAC3BB File Offset: 0x00EAA5BB
		public int GetSelectRoleFormationNumber(int roleId)
		{
			return this.SelectRoleHandleList.IndexOf(roleId) + 1;
		}

		// Token: 0x060346EB RID: 214763 RVA: 0x00EAC3CC File Offset: 0x00EAA5CC
		public void UnSelectRoleInHandleList(int roleId)
		{
			this.SelectRoleHandleList.RemoveAll((int id) => id == roleId);
		}

		// Token: 0x060346EC RID: 214764 RVA: 0x00EAC3FE File Offset: 0x00EAA5FE
		public void SelectRoleInHandleList(int roleId)
		{
			this.SelectRoleHandleList.Add(roleId);
		}

		// Token: 0x060346ED RID: 214765 RVA: 0x00EAC40C File Offset: 0x00EAA60C
		public List<int> GetPinballCanSelectRoleList()
		{
			PinballActivityData activityData = this.ActivityData;
			return ((activityData != null) ? activityData.GetUnlockRoleList() : null) ?? new List<int>();
		}

		// Token: 0x060346EE RID: 214766 RVA: 0x00EAC42C File Offset: 0x00EAA62C
		public int GetPinballSelectRoleLevelAverage(List<int> roleIdList)
		{
			if (roleIdList.Count <= 0)
			{
				return 0;
			}
			int num = 0;
			foreach (int roleId in roleIdList)
			{
				num += this.GetRoleLevel(roleId);
			}
			return num / roleIdList.Count;
		}

		// Token: 0x060346EF RID: 214767 RVA: 0x00EAC494 File Offset: 0x00EAA694
		public List<int> GetPinballLevelLastSelectedRoleList(int formationGroup)
		{
			PinballActivityData activityData = this.ActivityData;
			int[] collection;
			if (activityData != null && activityData.LevelFormationMap.TryGetValue(formationGroup, out collection))
			{
				return new List<int>(collection);
			}
			return new List<int>();
		}

		// Token: 0x060346F0 RID: 214768 RVA: 0x00EAC4C9 File Offset: 0x00EAA6C9
		[NullableContext(2)]
		public PinballRoleData GetRoleData(int roleId)
		{
			PinballActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				return null;
			}
			return activityData.GetRoleData(roleId);
		}

		// Token: 0x060346F1 RID: 214769 RVA: 0x00EAC4DD File Offset: 0x00EAA6DD
		public bool IsRoleUnlock(int roleId)
		{
			PinballActivityData activityData = this.ActivityData;
			return ((activityData != null) ? activityData.GetRoleData(roleId) : null) != null;
		}

		// Token: 0x060346F2 RID: 214770 RVA: 0x00EAC4F8 File Offset: 0x00EAA6F8
		public int GetRoleLevel(int roleId)
		{
			PinballActivityData activityData = this.ActivityData;
			int? num;
			if (activityData == null)
			{
				num = null;
			}
			else
			{
				PinballRoleData roleData = activityData.GetRoleData(roleId);
				num = ((roleData != null) ? new int?(roleData.GetLevel()) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x060346F3 RID: 214771 RVA: 0x00EAC541 File Offset: 0x00EAA741
		[NullableContext(2)]
		public PinballWeaponData GetRoleWeapon(int roleId)
		{
			PinballActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				return null;
			}
			PinballRoleData roleData = activityData.GetRoleData(roleId);
			if (roleData == null)
			{
				return null;
			}
			return roleData.GetWeaponData();
		}

		// Token: 0x060346F4 RID: 214772 RVA: 0x00EAC560 File Offset: 0x00EAA760
		public bool IsRecommendRole(int roleId)
		{
			if (this.CurrentFormationLevel == 0)
			{
				return false;
			}
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.CurrentFormationLevel);
			if (pinballLevelConfigById == null)
			{
				return false;
			}
			int recommendRoleLength = pinballLevelConfigById.Value.RecommendRoleLength;
			for (int i = 0; i < recommendRoleLength; i++)
			{
				if (pinballLevelConfigById.Value.RecommendRole(i) == roleId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060346F5 RID: 214773 RVA: 0x00EAC5C5 File Offset: 0x00EAA7C5
		public bool IsRoleFunctionOpen()
		{
			PinballActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsRoleFunctionOpen();
		}

		// Token: 0x060346F6 RID: 214774 RVA: 0x00EAC5D8 File Offset: 0x00EAA7D8
		public bool GetRoleRedDot(int activityId, int roleId)
		{
			PinballActivityData activityDataByActivityId = this.GetActivityDataByActivityId(activityId);
			if (activityDataByActivityId == null)
			{
				return false;
			}
			PinballRoleData roleData = activityDataByActivityId.GetRoleData(roleId);
			if (roleData == null)
			{
				return false;
			}
			if (roleData.IsLocked())
			{
				return false;
			}
			int subId = roleData.GetConfig().SubId;
			return ActivityModel.Instance.GetActivityCacheData(activityId, 0, subId, 0, 0) == 0;
		}

		// Token: 0x060346F7 RID: 214775 RVA: 0x00EAC62C File Offset: 0x00EAA82C
		public HashSet<int> CollectMonsterTypesByLevel(int levelId)
		{
			HashSet<int> hashSet = new HashSet<int>();
			IReadOnlyList<PinballWaveConfig> pinballWaveConfigListByLevel = PinballConfig.Instance.GetPinballWaveConfigListByLevel(levelId);
			if (pinballWaveConfigListByLevel == null)
			{
				return hashSet;
			}
			foreach (PinballWaveConfig pinballWaveConfig in pinballWaveConfigListByLevel)
			{
				int monsterSpawnGroupLength = pinballWaveConfig.MonsterSpawnGroupLength;
				for (int i = 0; i < monsterSpawnGroupLength; i++)
				{
					int id = pinballWaveConfig.MonsterSpawnGroup(i);
					PinballSpawnConfig? pinballSpawnConfigById = PinballConfig.Instance.GetPinballSpawnConfigById(id);
					if (pinballSpawnConfigById != null)
					{
						int monsterIdsLength = pinballSpawnConfigById.Value.MonsterIdsLength;
						for (int j = 0; j < monsterIdsLength; j++)
						{
							int id2 = pinballSpawnConfigById.Value.MonsterIds(j);
							hashSet.Add(PinballConfig.Instance.GetPinballMonsterConfigById(id2).Value.MonsterType);
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x060346F8 RID: 214776 RVA: 0x00EAC72C File Offset: 0x00EAA92C
		[NullableContext(2)]
		public BuffView CreateBuffView(int buffId, int buffCount)
		{
			PinballBuffConfig? pinballBuffConfigById = PinballConfig.Instance.GetPinballBuffConfigById(buffId);
			if (pinballBuffConfigById == null)
			{
				return null;
			}
			return new BuffView
			{
				BuffId = buffId,
				BuffType = (EPinballBuffType)pinballBuffConfigById.Value.BuffType,
				BuffCount = buffCount,
				Sort = pinballBuffConfigById.Value.Sort
			};
		}

		// Token: 0x060346F9 RID: 214777 RVA: 0x00EAC790 File Offset: 0x00EAA990
		public List<IBuffView> GetBuffViewList(List<IBuffView> rawBuffViewList, int targetCount = -1)
		{
			int num = (targetCount >= 0) ? targetCount : rawBuffViewList.Count;
			List<IBuffView> list = new List<IBuffView>();
			List<IBuffView> list2 = new List<IBuffView>();
			foreach (IBuffView buffView in rawBuffViewList)
			{
				if (buffView.BuffType == EPinballBuffType.Special)
				{
					list2.Add(buffView);
				}
			}
			list2.Sort((IBuffView a, IBuffView b) => b.Sort - a.Sort);
			list.AddRange(list2);
			this.MergeBuffByType(rawBuffViewList, EPinballBuffType.Critical, list);
			this.MergeBuffByType(rawBuffViewList, EPinballBuffType.Attack, list);
			this.MergeBuffByType(rawBuffViewList, EPinballBuffType.Defense, list);
			if (list.Count > num)
			{
				return list.GetRange(0, num);
			}
			return list;
		}

		// Token: 0x060346FA RID: 214778 RVA: 0x00EAC860 File Offset: 0x00EAAA60
		private void MergeBuffByType(List<IBuffView> rawBuffViewList, EPinballBuffType buffType, List<IBuffView> buffViewList)
		{
			List<IBuffView> list = new List<IBuffView>();
			foreach (IBuffView buffView in rawBuffViewList)
			{
				if (buffView.BuffType == buffType)
				{
					list.Add(buffView);
				}
			}
			if (list.Count > 0)
			{
				int num = 0;
				foreach (IBuffView buffView2 in list)
				{
					num += buffView2.BuffCount;
				}
				BuffView item = new BuffView
				{
					BuffId = 0,
					BuffType = buffType,
					BuffCount = num,
					Sort = 0
				};
				buffViewList.Add(item);
			}
		}

		// Token: 0x060346FB RID: 214779 RVA: 0x00EAC934 File Offset: 0x00EAAB34
		public int GetPersonWeaponType(int roleId)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				return 0;
			}
			return pinballRoleConfigById.Value.PersonWeaponType;
		}

		// Token: 0x060346FC RID: 214780 RVA: 0x00EAC967 File Offset: 0x00EAAB67
		public bool CheckWeaponCanEquip(PinballWeaponData weaponData, int weaponType, int personWeaponType)
		{
			return weaponData.Type == weaponType && (!weaponData.GetIsPersonWeapon() || weaponData.PersonType == personWeaponType);
		}

		// Token: 0x060346FD RID: 214781 RVA: 0x00EAC988 File Offset: 0x00EAAB88
		public bool GetWeaponRedDot(int activityId, int roleId)
		{
			PinballActivityData activityDataByActivityId = this.GetActivityDataByActivityId(activityId);
			return activityDataByActivityId != null && activityDataByActivityId.GetRoleWeaponRedDot(roleId);
		}

		// Token: 0x170065EA RID: 26090
		// (get) Token: 0x060346FE RID: 214782 RVA: 0x00EAC9A9 File Offset: 0x00EAABA9
		public static PinballModel Instance
		{
			get
			{
				return PinballModel._Instance;
			}
		}

		// Token: 0x060346FF RID: 214783 RVA: 0x00EAC9B0 File Offset: 0x00EAABB0
		public static PinballModel GetOrCreateInstance()
		{
			if (PinballModel._Instance == null)
			{
				PinballModel.CreateInstance();
			}
			return PinballModel._Instance;
		}

		// Token: 0x06034700 RID: 214784 RVA: 0x00EAC9C4 File Offset: 0x00EAABC4
		public static bool CreateInstance()
		{
			if (PinballModel._Instance != null)
			{
				return true;
			}
			PinballModel._Instance = new PinballModel();
			return true;
		}

		// Token: 0x06034701 RID: 214785 RVA: 0x00EAC9DA File Offset: 0x00EAABDA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034702 RID: 214786 RVA: 0x00EAC9DC File Offset: 0x00EAABDC
		public static void ResetStaticDefaultValue()
		{
			PinballModel._Instance = null;
		}

		// Token: 0x06034703 RID: 214787 RVA: 0x00EAC9E4 File Offset: 0x00EAABE4
		static PinballModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PinballModel.CreateStaticDefaultValue), new Action(PinballModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD4A RID: 113994
		private int ActivityDataIdInternal = -1;

		// Token: 0x0401BD4B RID: 113995
		public int CurLevelConfigId;

		// Token: 0x0401BD4C RID: 113996
		public int CurLevelId;

		// Token: 0x0401BD4D RID: 113997
		[Nullable(2)]
		private UUIItem BattleCenterRootItem;

		// Token: 0x0401BD4E RID: 113998
		public List<int> SelectRoleHandleList = new List<int>();

		// Token: 0x0401BD4F RID: 113999
		public int CurrentFormationLevel;

		// Token: 0x0401BD50 RID: 114000
		[Nullable(2)]
		private static PinballModel _Instance;
	}
}
