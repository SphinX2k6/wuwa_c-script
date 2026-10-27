using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02004D60 RID: 19808
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopRoleData : RoleDevelopRoleBaseData
	{
		// Token: 0x0603333C RID: 209724 RVA: 0x00BF1387 File Offset: 0x00BEF587
		public RoleDevelopRoleData(int id) : base(id)
		{
		}

		// Token: 0x0603333D RID: 209725 RVA: 0x00BF1390 File Offset: 0x00BEF590
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Normal;
		}

		// Token: 0x0603333E RID: 209726 RVA: 0x00BF1393 File Offset: 0x00BEF593
		private RoleDataBase GetRoleData()
		{
			return RoleModel.Instance.GetRoleDataById(this.Id, true);
		}

		// Token: 0x0603333F RID: 209727 RVA: 0x00BF13A6 File Offset: 0x00BEF5A6
		private bool IsOwned()
		{
			return RoleModel.Instance.IsRoleOwned(this.Id);
		}

		// Token: 0x06033340 RID: 209728 RVA: 0x00BF13B8 File Offset: 0x00BEF5B8
		private RoleInfo GetRoleConfig()
		{
			return RoleConfig.Instance.GetRoleConfig(this.Id).Value;
		}

		// Token: 0x06033341 RID: 209729 RVA: 0x00BF13E0 File Offset: 0x00BEF5E0
		public RoleDevCultivateProject GetCultivateProject()
		{
			return RoleDevelopUtil.GetCultivateProject(this.Id).Value;
		}

		// Token: 0x06033342 RID: 209730 RVA: 0x00BF1400 File Offset: 0x00BEF600
		public override string GetName()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetRoleConfig().Name, null);
		}

		// Token: 0x06033343 RID: 209731 RVA: 0x00BF1424 File Offset: 0x00BEF624
		public override int GetElementId()
		{
			return this.GetRoleConfig().ElementId;
		}

		// Token: 0x06033344 RID: 209732 RVA: 0x00BF1440 File Offset: 0x00BEF640
		public override string GetRoleIconPath()
		{
			if (RoleDevelopUtil.IsHotRole(this.Id) && RoleDevConfig.Instance.GetRoleDevProsListConfig(this.Id).TypeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(this.Id))
			{
				return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id).RoleHeadIcon;
			}
			RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(this.Id);
			if (roleSkinDataByRoleId == null)
			{
				return this.GetRoleConfig().RoleHeadIconLarge;
			}
			return roleSkinDataByRoleId.GetRoleSkinConfig().RoleHeadIconLarge;
		}

		// Token: 0x06033345 RID: 209733 RVA: 0x00BF14C8 File Offset: 0x00BEF6C8
		public override string GetRoleIllustrationPath()
		{
			if (RoleDevelopUtil.IsHotRole(this.Id) && RoleDevConfig.Instance.GetRoleDevProsListConfig(this.Id).TypeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(this.Id))
			{
				return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id).FormationRoleCard;
			}
			RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(this.Id);
			if (roleSkinDataByRoleId == null)
			{
				return this.GetRoleConfig().FormationRoleCard;
			}
			return roleSkinDataByRoleId.GetRoleSkinConfig().FormationRoleCard;
		}

		// Token: 0x06033346 RID: 209734 RVA: 0x00BF1550 File Offset: 0x00BEF750
		public override string GetRoleCircleIconPath()
		{
			if (RoleDevelopUtil.IsHotRole(this.Id) && RoleDevConfig.Instance.GetRoleDevProsListConfig(this.Id).TypeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(this.Id))
			{
				return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id).RoleHeadIconSmall;
			}
			RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(this.Id);
			if (roleSkinDataByRoleId == null)
			{
				return this.GetRoleConfig().RoleHeadIconCircle;
			}
			return roleSkinDataByRoleId.GetRoleSkinConfig().RoleHeadIconCircle;
		}

		// Token: 0x06033347 RID: 209735 RVA: 0x00BF15D8 File Offset: 0x00BEF7D8
		public override string GetRoleSmallIconPath()
		{
			if (RoleDevelopUtil.IsHotRole(this.Id) && RoleDevConfig.Instance.GetRoleDevProsListConfig(this.Id).TypeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(this.Id))
			{
				return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id).RoleHeadIconSmall;
			}
			RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(this.Id);
			if (roleSkinDataByRoleId == null)
			{
				return this.GetRoleConfig().RoleHeadIcon;
			}
			return roleSkinDataByRoleId.GetRoleSkinConfig().RoleHeadIcon;
		}

		// Token: 0x06033348 RID: 209736 RVA: 0x00BF1660 File Offset: 0x00BEF860
		public override int GetKeyProperty()
		{
			return RoleDevConfig.Instance.GetRoleDevProjectConfig(this.Id).Value.KeyProperty;
		}

		// Token: 0x06033349 RID: 209737 RVA: 0x00BF168D File Offset: 0x00BEF88D
		public override int GetRoleLevel()
		{
			if (this.IsOwned())
			{
				return this.GetRoleData().GetLevelData().GetLevel();
			}
			return 1;
		}

		// Token: 0x0603334A RID: 209738 RVA: 0x00BF16A9 File Offset: 0x00BEF8A9
		public override int GetRoleBreachLevel()
		{
			if (this.IsOwned())
			{
				return this.GetRoleData().GetLevelData().GetBreachLevel();
			}
			return 0;
		}

		// Token: 0x0603334B RID: 209739 RVA: 0x00BF16C5 File Offset: 0x00BEF8C5
		public override int GetRoleExp()
		{
			if (this.IsOwned())
			{
				return this.GetRoleData().GetLevelData().GetExp();
			}
			return 0;
		}

		// Token: 0x0603334C RID: 209740 RVA: 0x00BF16E1 File Offset: 0x00BEF8E1
		public override bool IsRoleMaxLevel()
		{
			return this.IsOwned() && this.GetRoleData().GetLevelData().GetRoleIsMaxLevel();
		}

		// Token: 0x0603334D RID: 209741 RVA: 0x00BF16FD File Offset: 0x00BEF8FD
		public override bool IsRoleNeedBreakUp()
		{
			return !this.IsOwned() || this.GetRoleData().GetLevelData().GetRoleNeedBreakUp();
		}

		// Token: 0x0603334E RID: 209742 RVA: 0x00BF171C File Offset: 0x00BEF91C
		public override int GetRoleTargetLevel()
		{
			return this.GetCultivateProject().RoleLevel;
		}

		// Token: 0x0603334F RID: 209743 RVA: 0x00BF1738 File Offset: 0x00BEF938
		public override int GetRoleTargetBreachLevel()
		{
			return this.GetCultivateProject().RoleBreachLevel;
		}

		// Token: 0x06033350 RID: 209744 RVA: 0x00BF1754 File Offset: 0x00BEF954
		public override int GetWeaponType()
		{
			return RoleDevConfig.Instance.GetRoleDevProjectConfig(this.Id).Value.WeaponType;
		}

		// Token: 0x06033351 RID: 209745 RVA: 0x00BF1781 File Offset: 0x00BEF981
		public override WeaponInstance GetWeaponInstance()
		{
			if (!this.IsOwned())
			{
				return null;
			}
			return WeaponModel.Instance.GetWeaponInstanceByRoleId(this.Id);
		}

		// Token: 0x06033352 RID: 209746 RVA: 0x00BF17A0 File Offset: 0x00BEF9A0
		public override string GetWeaponName()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return WeaponConfig.Instance.GetWeaponConfigByItemId(weaponInstance.GetItemId()).Value.WeaponName;
			}
			return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.GetWeaponType()).Value.WeaponTypeDescribe;
		}

		// Token: 0x06033353 RID: 209747 RVA: 0x00BF17FC File Offset: 0x00BEF9FC
		public override int GetWeaponLevel()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return weaponInstance.GetLevel();
			}
			return 0;
		}

		// Token: 0x06033354 RID: 209748 RVA: 0x00BF181C File Offset: 0x00BEFA1C
		public override int GetWeaponBreachLevel()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return weaponInstance.GetBreachLevel();
			}
			return 0;
		}

		// Token: 0x06033355 RID: 209749 RVA: 0x00BF183C File Offset: 0x00BEFA3C
		public override int GetWeaponExp()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return weaponInstance.GetExp();
			}
			return 0;
		}

		// Token: 0x06033356 RID: 209750 RVA: 0x00BF185C File Offset: 0x00BEFA5C
		public override int GetWeaponTargetLevel()
		{
			return this.GetCultivateProject().WeaponLevel;
		}

		// Token: 0x06033357 RID: 209751 RVA: 0x00BF1878 File Offset: 0x00BEFA78
		public override int GetWeaponTargetBreachLevel()
		{
			int num = this.GetCultivateProject().WeaponBreachLevel;
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				WeaponConf? weaponConfig = weaponInstance.GetWeaponConfig();
				if (weaponConfig != null)
				{
					int weaponBreachMaxLevel = WeaponModel.Instance.GetWeaponBreachMaxLevel(weaponConfig.Value.BreachId);
					num = Math.Min(num, weaponBreachMaxLevel);
				}
			}
			return num;
		}

		// Token: 0x06033358 RID: 209752 RVA: 0x00BF18D4 File Offset: 0x00BEFAD4
		public override bool IsWeaponMaxLevel()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			return weaponInstance != null && weaponInstance.GetLevel() >= weaponInstance.GetMaxLevel();
		}

		// Token: 0x06033359 RID: 209753 RVA: 0x00BF1900 File Offset: 0x00BEFB00
		public override bool IsWeaponNeedBreakUp()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			return weaponInstance != null && weaponInstance.GetBreachLevel() < this.GetWeaponTargetBreachLevel();
		}

		// Token: 0x0603335A RID: 209754 RVA: 0x00BF1927 File Offset: 0x00BEFB27
		public override List<int> GetPhantomIdList()
		{
			if (!RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return new List<int>();
			}
			return PhantomBattleModel.Instance.GetBattleDataById(this.Id).GetIncrIdList();
		}

		// Token: 0x0603335B RID: 209755 RVA: 0x00BF1956 File Offset: 0x00BEFB56
		public override bool CanDevelopPhantom()
		{
			return RoleModel.Instance.IsRoleOwned(this.Id);
		}

		// Token: 0x0603335C RID: 209756 RVA: 0x00BF1968 File Offset: 0x00BEFB68
		public override List<RoleDevelopPhantomSuitData> GetRecommendPhantomSuits(int? planId = null, int? firstVisionMonsterId = null)
		{
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.Id);
			if (roleFetterRecommendInfo == null)
			{
				return new List<RoleDevelopPhantomSuitData>();
			}
			RoleDevelopUtil.SortVisionFetterRecommendInfo(roleFetterRecommendInfo);
			int recommendPlanId = planId ?? RoleDevelopUtil.GetDefaultRecommendPlanId(this.Id);
			return RoleDevelopUtil.CreatePhantomSuitDataList(this.Id, roleFetterRecommendInfo, recommendPlanId, firstVisionMonsterId);
		}

		// Token: 0x0603335D RID: 209757 RVA: 0x00BF19C4 File Offset: 0x00BEFBC4
		public override int GetRecommendPlanId()
		{
			if (RoleDevelopModel.Instance.DevTargetRoleId == this.Id)
			{
				int selectPlanId = RoleDevelopModel.Instance.SelectPlanId;
				if (selectPlanId != 0)
				{
					return selectPlanId;
				}
			}
			return RoleDevelopUtil.GetDefaultRecommendPlanId(this.Id);
		}

		// Token: 0x0603335E RID: 209758 RVA: 0x00BF1A00 File Offset: 0x00BEFC00
		public override int GetRecommendFirstVisionMonsterId()
		{
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.Id);
			if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
			{
				return 0;
			}
			RoleDevelopUtil.SortVisionFetterRecommendInfo(roleFetterRecommendInfo);
			if (RoleDevelopModel.Instance.DevTargetRoleId != this.Id)
			{
				List<MainPhantomRecommendInfo> mainPhantomList = roleFetterRecommendInfo[0].GetMainPhantomList();
				if (mainPhantomList.Count <= 0)
				{
					return 0;
				}
				return mainPhantomList[0].GetMonsterId();
			}
			else
			{
				int planId = this.GetRecommendPlanId();
				VisionFetterRecommendInfo visionFetterRecommendInfo;
				if ((visionFetterRecommendInfo = roleFetterRecommendInfo.Find((VisionFetterRecommendInfo recommend) => recommend.GetPlanId() == planId)) == null)
				{
					visionFetterRecommendInfo = (roleFetterRecommendInfo.Find((VisionFetterRecommendInfo recommend) => recommend.GetRecommendFetterGroupId() == planId) ?? roleFetterRecommendInfo[0]);
				}
				List<MainPhantomRecommendInfo> mainPhantomList2 = visionFetterRecommendInfo.GetMainPhantomList();
				int selectFirstVisionMonsterId = RoleDevelopModel.Instance.SelectFirstVisionMonsterId;
				if (selectFirstVisionMonsterId != 0 && mainPhantomList2.Exists((MainPhantomRecommendInfo info) => info.GetMonsterId() == selectFirstVisionMonsterId))
				{
					return selectFirstVisionMonsterId;
				}
				if (mainPhantomList2.Count <= 0)
				{
					return 0;
				}
				return mainPhantomList2[0].GetMonsterId();
			}
		}
	}
}
