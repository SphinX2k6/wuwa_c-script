using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x020062C8 RID: 25288
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PinballModel : ModelBase
	{
		// Token: 0x0603FA15 RID: 260629 RVA: 0x00F65127 File Offset: 0x00F63327
		public void SetActivityId(int id)
		{
			this.ActivityDataIdInternal = id;
		}

		// Token: 0x17009287 RID: 37511
		// (get) Token: 0x0603FA16 RID: 260630 RVA: 0x00F65130 File Offset: 0x00F63330
		public PinballActivityData ActivityData
		{
			get
			{
				return ActivityModel.Instance.GetActivityById(this.ActivityDataIdInternal) as PinballActivityData;
			}
		}

		// Token: 0x0603FA17 RID: 260631 RVA: 0x00F65148 File Offset: 0x00F63348
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

		// Token: 0x0603FA18 RID: 260632 RVA: 0x00F6516C File Offset: 0x00F6336C
		public List<PinballWeaponData> GetAllWeaponDataList()
		{
			return this.ActivityData.GetWeaponDataAll();
		}

		// Token: 0x0603FA19 RID: 260633 RVA: 0x00F65179 File Offset: 0x00F63379
		[NullableContext(2)]
		public PinballWeaponData GetWeaponDataByIncId(int incId)
		{
			return this.ActivityData.GetWeaponDataByIncId(incId);
		}

		// Token: 0x0603FA1A RID: 260634 RVA: 0x00F65187 File Offset: 0x00F63387
		public void RemoveWeaponData(List<int> incIdList)
		{
			this.ActivityData.RemoveWeaponData(incIdList);
			this.ActivityData.UpdateRoleWeaponRedDot();
		}

		// Token: 0x0603FA1B RID: 260635 RVA: 0x00F651A0 File Offset: 0x00F633A0
		public int GetWeaponItemCount(int configId)
		{
			return this.ActivityData.GetWeaponCountByConfigId(configId);
		}

		// Token: 0x0603FA1C RID: 260636 RVA: 0x00F651B0 File Offset: 0x00F633B0
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

		// Token: 0x0603FA1D RID: 260637 RVA: 0x00F6520C File Offset: 0x00F6340C
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

		// Token: 0x0603FA1E RID: 260638 RVA: 0x00F65270 File Offset: 0x00F63470
		public int GetMaxLevelByPinballRoleConfig(PinballRoleConfig roleConfig)
		{
			return this.GetMaxLevelByGroupId(roleConfig.GradeUpGroup);
		}

		// Token: 0x0603FA1F RID: 260639 RVA: 0x00F65280 File Offset: 0x00F63480
		public int GetMaxLevelByPinballByRoleId(int roleId)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				return 0;
			}
			return this.GetMaxLevelByPinballRoleConfig(pinballRoleConfigById.Value);
		}

		// Token: 0x0603FA20 RID: 260640 RVA: 0x00F652B4 File Offset: 0x00F634B4
		public string GetRoleNameByPinballRoleConfig(PinballRoleConfig roleConfig)
		{
			RoleInfo? roleConfig2 = RoleConfig.Instance.GetRoleConfig(roleConfig.RoleId);
			return ((roleConfig2 != null) ? roleConfig2.GetValueOrDefault().Name : null) ?? "";
		}

		// Token: 0x0603FA21 RID: 260641 RVA: 0x00F652F8 File Offset: 0x00F634F8
		public string GetRoleNameByPinballRoleId(int roleId)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				return "";
			}
			return this.GetRoleNameByPinballRoleConfig(pinballRoleConfigById.Value);
		}

		// Token: 0x0603FA22 RID: 260642 RVA: 0x00F65330 File Offset: 0x00F63530
		public int GetRoleLevelUpCostItemId(int activityId)
		{
			PinballActivity? pinballActivityConfigByActivityId = PinballConfig.Instance.GetPinballActivityConfigByActivityId(activityId);
			if (pinballActivityConfigByActivityId == null)
			{
				return 0;
			}
			return pinballActivityConfigByActivityId.Value.ExpItemId;
		}

		// Token: 0x0603FA23 RID: 260643 RVA: 0x00F65364 File Offset: 0x00F63564
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

		// Token: 0x0603FA24 RID: 260644 RVA: 0x00F653A8 File Offset: 0x00F635A8
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

		// Token: 0x0603FA25 RID: 260645 RVA: 0x00F653FC File Offset: 0x00F635FC
		public int GetPinballWeaponPackageCapacity()
		{
			int itemTypeId = 10;
			int packageId = InventoryConfig.Instance.GetItemMainTypeConfig(itemTypeId).Value.PackageId;
			return InventoryConfig.Instance.GetPackageConfig(packageId).Value.Capacity;
		}

		// Token: 0x0603FA26 RID: 260646 RVA: 0x00F65445 File Offset: 0x00F63645
		public void SetBattleCenterRootItem(UUIItem item)
		{
			this.BattleCenterRootItem = item;
		}

		// Token: 0x0603FA27 RID: 260647 RVA: 0x00F6544E File Offset: 0x00F6364E
		[NullableContext(2)]
		public UUIItem GetBattleCenterRootItem()
		{
			return this.BattleCenterRootItem;
		}

		// Token: 0x0603FA28 RID: 260648 RVA: 0x00F65456 File Offset: 0x00F63656
		public void ClearBattleCenterRootItem()
		{
			this.BattleCenterRootItem = null;
		}

		// Token: 0x0603FA29 RID: 260649 RVA: 0x00F6545F File Offset: 0x00F6365F
		public int GetSelectRoleFormationNumber(int roleId)
		{
			return this.SelectRoleHandleList.IndexOf(roleId) + 1;
		}

		// Token: 0x0603FA2A RID: 260650 RVA: 0x00F65470 File Offset: 0x00F63670
		public void UnSelectRoleInHandleList(int roleId)
		{
			this.SelectRoleHandleList.RemoveAll((int id) => id == roleId);
		}

		// Token: 0x0603FA2B RID: 260651 RVA: 0x00F654A2 File Offset: 0x00F636A2
		public void SelectRoleInHandleList(int roleId)
		{
			this.SelectRoleHandleList.Add(roleId);
		}

		// Token: 0x0603FA2C RID: 260652 RVA: 0x00F654B0 File Offset: 0x00F636B0
		public List<int> GetPinballCanSelectRoleList()
		{
			PinballActivityData activityData = this.ActivityData;
			return ((activityData != null) ? activityData.GetUnlockRoleList() : null) ?? new List<int>();
		}

		// Token: 0x0603FA2D RID: 260653 RVA: 0x00F654D0 File Offset: 0x00F636D0
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

		// Token: 0x0603FA2E RID: 260654 RVA: 0x00F65538 File Offset: 0x00F63738
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

		// Token: 0x0603FA2F RID: 260655 RVA: 0x00F6556D File Offset: 0x00F6376D
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

		// Token: 0x0603FA30 RID: 260656 RVA: 0x00F65581 File Offset: 0x00F63781
		public bool IsRoleUnlock(int roleId)
		{
			PinballActivityData activityData = this.ActivityData;
			return ((activityData != null) ? activityData.GetRoleData(roleId) : null) != null;
		}

		// Token: 0x0603FA31 RID: 260657 RVA: 0x00F6559C File Offset: 0x00F6379C
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

		// Token: 0x0603FA32 RID: 260658 RVA: 0x00F655E5 File Offset: 0x00F637E5
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

		// Token: 0x0603FA33 RID: 260659 RVA: 0x00F65604 File Offset: 0x00F63804
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

		// Token: 0x0603FA34 RID: 260660 RVA: 0x00F65669 File Offset: 0x00F63869
		public bool IsRoleFunctionOpen()
		{
			PinballActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsRoleFunctionOpen();
		}

		// Token: 0x0603FA35 RID: 260661 RVA: 0x00F6567C File Offset: 0x00F6387C
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

		// Token: 0x0603FA36 RID: 260662 RVA: 0x00F656D0 File Offset: 0x00F638D0
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

		// Token: 0x0603FA37 RID: 260663 RVA: 0x00F657D0 File Offset: 0x00F639D0
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

		// Token: 0x0603FA38 RID: 260664 RVA: 0x00F65834 File Offset: 0x00F63A34
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

		// Token: 0x0603FA39 RID: 260665 RVA: 0x00F65904 File Offset: 0x00F63B04
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

		// Token: 0x0603FA3A RID: 260666 RVA: 0x00F659D8 File Offset: 0x00F63BD8
		public int GetPersonWeaponType(int roleId)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				return 0;
			}
			return pinballRoleConfigById.Value.PersonWeaponType;
		}

		// Token: 0x0603FA3B RID: 260667 RVA: 0x00F65A0B File Offset: 0x00F63C0B
		public bool CheckWeaponCanEquip(PinballWeaponData weaponData, int weaponType, int personWeaponType)
		{
			return weaponData.Type == weaponType && (!weaponData.GetIsPersonWeapon() || weaponData.PersonType == personWeaponType);
		}

		// Token: 0x0603FA3C RID: 260668 RVA: 0x00F65A2C File Offset: 0x00F63C2C
		public bool GetWeaponRedDot(int activityId, int roleId)
		{
			PinballActivityData activityDataByActivityId = this.GetActivityDataByActivityId(activityId);
			return activityDataByActivityId != null && activityDataByActivityId.GetRoleWeaponRedDot(roleId);
		}

		// Token: 0x17009288 RID: 37512
		// (get) Token: 0x0603FA3D RID: 260669 RVA: 0x00F65A4D File Offset: 0x00F63C4D
		public static PinballModel Instance
		{
			get
			{
				return PinballModel._Instance;
			}
		}

		// Token: 0x0603FA3E RID: 260670 RVA: 0x00F65A54 File Offset: 0x00F63C54
		public static PinballModel GetOrCreateInstance()
		{
			if (PinballModel._Instance == null)
			{
				PinballModel.CreateInstance();
			}
			return PinballModel._Instance;
		}

		// Token: 0x0603FA3F RID: 260671 RVA: 0x00F65A68 File Offset: 0x00F63C68
		public static bool CreateInstance()
		{
			if (PinballModel._Instance != null)
			{
				return true;
			}
			PinballModel._Instance = new PinballModel();
			return true;
		}

		// Token: 0x0603FA40 RID: 260672 RVA: 0x00F65A7E File Offset: 0x00F63C7E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603FA41 RID: 260673 RVA: 0x00F65A80 File Offset: 0x00F63C80
		public static void ResetStaticDefaultValue()
		{
			PinballModel._Instance = null;
		}

		// Token: 0x0603FA42 RID: 260674 RVA: 0x00F65A88 File Offset: 0x00F63C88
		static PinballModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PinballModel.CreateStaticDefaultValue), new Action(PinballModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402141B RID: 136219
		private int ActivityDataIdInternal = -1;

		// Token: 0x0402141C RID: 136220
		public int CurLevelConfigId;

		// Token: 0x0402141D RID: 136221
		public int CurLevelId;

		// Token: 0x0402141E RID: 136222
		[Nullable(2)]
		private UUIItem BattleCenterRootItem;

		// Token: 0x0402141F RID: 136223
		public List<int> SelectRoleHandleList = new List<int>();

		// Token: 0x04021420 RID: 136224
		public int CurrentFormationLevel;

		// Token: 0x04021421 RID: 136225
		[Nullable(2)]
		private static PinballModel _Instance;
	}
}
