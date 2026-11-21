using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02003D29 RID: 15657
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopRoleData : RoleDevelopRoleBaseData
	{
		// Token: 0x060281A9 RID: 164265 RVA: 0x00B3A542 File Offset: 0x00B38742
		public RoleDevelopRoleData(int id) : base(id)
		{
		}

		// Token: 0x060281AA RID: 164266 RVA: 0x00B3A54B File Offset: 0x00B3874B
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Normal;
		}

		// Token: 0x060281AB RID: 164267 RVA: 0x00B3A54E File Offset: 0x00B3874E
		private RoleDataBase GetRoleData()
		{
			return RoleModel.Instance.GetRoleDataById(this.Id, true);
		}

		// Token: 0x060281AC RID: 164268 RVA: 0x00B3A561 File Offset: 0x00B38761
		private bool IsOwned()
		{
			return RoleModel.Instance.IsRoleOwned(this.Id);
		}

		// Token: 0x060281AD RID: 164269 RVA: 0x00B3A574 File Offset: 0x00B38774
		private RoleInfo GetRoleConfig()
		{
			return RoleConfig.Instance.GetRoleConfig(this.Id).Value;
		}

		// Token: 0x060281AE RID: 164270 RVA: 0x00B3A59C File Offset: 0x00B3879C
		public RoleDevCultivateProject GetCultivateProject()
		{
			return RoleDevelopUtil.GetCultivateProject(this.Id).Value;
		}

		// Token: 0x060281AF RID: 164271 RVA: 0x00B3A5BC File Offset: 0x00B387BC
		public override string GetName()
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.GetRoleConfig().Name, null);
		}

		// Token: 0x060281B0 RID: 164272 RVA: 0x00B3A5E0 File Offset: 0x00B387E0
		public override int GetElementId()
		{
			return this.GetRoleConfig().ElementId;
		}

		// Token: 0x060281B1 RID: 164273 RVA: 0x00B3A5FC File Offset: 0x00B387FC
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

		// Token: 0x060281B2 RID: 164274 RVA: 0x00B3A684 File Offset: 0x00B38884
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

		// Token: 0x060281B3 RID: 164275 RVA: 0x00B3A70C File Offset: 0x00B3890C
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

		// Token: 0x060281B4 RID: 164276 RVA: 0x00B3A794 File Offset: 0x00B38994
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

		// Token: 0x060281B5 RID: 164277 RVA: 0x00B3A81C File Offset: 0x00B38A1C
		public override int GetKeyProperty()
		{
			return RoleDevConfig.Instance.GetRoleDevProjectConfig(this.Id).Value.KeyProperty;
		}

		// Token: 0x060281B6 RID: 164278 RVA: 0x00B3A849 File Offset: 0x00B38A49
		public override int GetRoleLevel()
		{
			if (this.IsOwned())
			{
				return this.GetRoleData().GetLevelData().GetLevel();
			}
			return 1;
		}

		// Token: 0x060281B7 RID: 164279 RVA: 0x00B3A865 File Offset: 0x00B38A65
		public override int GetRoleBreachLevel()
		{
			if (this.IsOwned())
			{
				return this.GetRoleData().GetLevelData().GetBreachLevel();
			}
			return 0;
		}

		// Token: 0x060281B8 RID: 164280 RVA: 0x00B3A881 File Offset: 0x00B38A81
		public override int GetRoleExp()
		{
			if (this.IsOwned())
			{
				return this.GetRoleData().GetLevelData().GetExp();
			}
			return 0;
		}

		// Token: 0x060281B9 RID: 164281 RVA: 0x00B3A89D File Offset: 0x00B38A9D
		public override bool IsRoleMaxLevel()
		{
			return this.IsOwned() && this.GetRoleData().GetLevelData().GetRoleIsMaxLevel();
		}

		// Token: 0x060281BA RID: 164282 RVA: 0x00B3A8B9 File Offset: 0x00B38AB9
		public override bool IsRoleNeedBreakUp()
		{
			return !this.IsOwned() || this.GetRoleData().GetLevelData().GetRoleNeedBreakUp();
		}

		// Token: 0x060281BB RID: 164283 RVA: 0x00B3A8D8 File Offset: 0x00B38AD8
		public override int GetRoleTargetLevel()
		{
			return this.GetCultivateProject().RoleLevel;
		}

		// Token: 0x060281BC RID: 164284 RVA: 0x00B3A8F4 File Offset: 0x00B38AF4
		public override int GetRoleTargetBreachLevel()
		{
			return this.GetCultivateProject().RoleBreachLevel;
		}

		// Token: 0x060281BD RID: 164285 RVA: 0x00B3A910 File Offset: 0x00B38B10
		public override int GetWeaponType()
		{
			return RoleDevConfig.Instance.GetRoleDevProjectConfig(this.Id).Value.WeaponType;
		}

		// Token: 0x060281BE RID: 164286 RVA: 0x00B3A93D File Offset: 0x00B38B3D
		public override WeaponInstance GetWeaponInstance()
		{
			if (!this.IsOwned())
			{
				return null;
			}
			return WeaponModel.Instance.GetWeaponInstanceByRoleId(this.Id);
		}

		// Token: 0x060281BF RID: 164287 RVA: 0x00B3A95C File Offset: 0x00B38B5C
		public override string GetWeaponName()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return WeaponConfig.Instance.GetWeaponConfigByItemId(weaponInstance.GetItemId()).Value.WeaponName;
			}
			return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.GetWeaponType()).Value.WeaponTypeDescribe;
		}

		// Token: 0x060281C0 RID: 164288 RVA: 0x00B3A9B8 File Offset: 0x00B38BB8
		public override int GetWeaponLevel()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return weaponInstance.GetLevel();
			}
			return 0;
		}

		// Token: 0x060281C1 RID: 164289 RVA: 0x00B3A9D8 File Offset: 0x00B38BD8
		public override int GetWeaponBreachLevel()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return weaponInstance.GetBreachLevel();
			}
			return 0;
		}

		// Token: 0x060281C2 RID: 164290 RVA: 0x00B3A9F8 File Offset: 0x00B38BF8
		public override int GetWeaponExp()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			if (weaponInstance != null)
			{
				return weaponInstance.GetExp();
			}
			return 0;
		}

		// Token: 0x060281C3 RID: 164291 RVA: 0x00B3AA18 File Offset: 0x00B38C18
		public override int GetWeaponTargetLevel()
		{
			return this.GetCultivateProject().WeaponLevel;
		}

		// Token: 0x060281C4 RID: 164292 RVA: 0x00B3AA34 File Offset: 0x00B38C34
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

		// Token: 0x060281C5 RID: 164293 RVA: 0x00B3AA90 File Offset: 0x00B38C90
		public override bool IsWeaponMaxLevel()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			return weaponInstance != null && weaponInstance.GetLevel() >= weaponInstance.GetMaxLevel();
		}

		// Token: 0x060281C6 RID: 164294 RVA: 0x00B3AABC File Offset: 0x00B38CBC
		public override bool IsWeaponNeedBreakUp()
		{
			WeaponInstance weaponInstance = this.GetWeaponInstance();
			return weaponInstance != null && weaponInstance.GetBreachLevel() < this.GetWeaponTargetBreachLevel();
		}

		// Token: 0x060281C7 RID: 164295 RVA: 0x00B3AAE3 File Offset: 0x00B38CE3
		public override List<int> GetPhantomIdList()
		{
			if (!RoleModel.Instance.IsRoleOwned(this.Id))
			{
				return new List<int>();
			}
			return PhantomBattleModel.Instance.GetBattleDataById(this.Id).GetIncrIdList();
		}

		// Token: 0x060281C8 RID: 164296 RVA: 0x00B3AB12 File Offset: 0x00B38D12
		public override bool CanDevelopPhantom()
		{
			return RoleModel.Instance.IsRoleOwned(this.Id);
		}

		// Token: 0x060281C9 RID: 164297 RVA: 0x00B3AB24 File Offset: 0x00B38D24
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

		// Token: 0x060281CA RID: 164298 RVA: 0x00B3AB80 File Offset: 0x00B38D80
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

		// Token: 0x060281CB RID: 164299 RVA: 0x00B3ABBC File Offset: 0x00B38DBC
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
