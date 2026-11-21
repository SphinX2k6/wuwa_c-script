using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02003D2A RID: 15658
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopRoleProspectData : RoleDevelopRoleBaseData
	{
		// Token: 0x060281CC RID: 164300 RVA: 0x00B3ACBA File Offset: 0x00B38EBA
		public RoleDevelopRoleProspectData(int id) : base(id)
		{
		}

		// Token: 0x060281CD RID: 164301 RVA: 0x00B3ACC3 File Offset: 0x00B38EC3
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Prospect;
		}

		// Token: 0x060281CE RID: 164302 RVA: 0x00B3ACC6 File Offset: 0x00B38EC6
		private IRoleDevProsProjectConfig GetDevPropsProjectConfig()
		{
			return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id);
		}

		// Token: 0x060281CF RID: 164303 RVA: 0x00B3ACD8 File Offset: 0x00B38ED8
		public override string GetName()
		{
			return this.GetDevPropsProjectConfig().RoleName;
		}

		// Token: 0x060281D0 RID: 164304 RVA: 0x00B3ACE5 File Offset: 0x00B38EE5
		public override int GetElementId()
		{
			return this.GetDevPropsProjectConfig().ElementId;
		}

		// Token: 0x060281D1 RID: 164305 RVA: 0x00B3ACF2 File Offset: 0x00B38EF2
		public override string GetRoleIllustrationPath()
		{
			return this.GetDevPropsProjectConfig().FormationRoleCard;
		}

		// Token: 0x060281D2 RID: 164306 RVA: 0x00B3ACFF File Offset: 0x00B38EFF
		public override string GetRoleIconPath()
		{
			return this.GetDevPropsProjectConfig().RoleHeadIcon;
		}

		// Token: 0x060281D3 RID: 164307 RVA: 0x00B3AD0C File Offset: 0x00B38F0C
		public override string GetRoleSmallIconPath()
		{
			return this.GetDevPropsProjectConfig().RoleHeadIconSmall;
		}

		// Token: 0x060281D4 RID: 164308 RVA: 0x00B3AD19 File Offset: 0x00B38F19
		public override string GetRoleCircleIconPath()
		{
			return this.GetDevPropsProjectConfig().RoleHeadIconSmall;
		}

		// Token: 0x060281D5 RID: 164309 RVA: 0x00B3AD26 File Offset: 0x00B38F26
		public override int GetKeyProperty()
		{
			return 0;
		}

		// Token: 0x060281D6 RID: 164310 RVA: 0x00B3AD29 File Offset: 0x00B38F29
		public override int GetRoleLevel()
		{
			return 1;
		}

		// Token: 0x060281D7 RID: 164311 RVA: 0x00B3AD2C File Offset: 0x00B38F2C
		public override int GetRoleBreachLevel()
		{
			return 0;
		}

		// Token: 0x060281D8 RID: 164312 RVA: 0x00B3AD2F File Offset: 0x00B38F2F
		public override int GetRoleExp()
		{
			return 0;
		}

		// Token: 0x060281D9 RID: 164313 RVA: 0x00B3AD32 File Offset: 0x00B38F32
		public override bool IsRoleMaxLevel()
		{
			return false;
		}

		// Token: 0x060281DA RID: 164314 RVA: 0x00B3AD35 File Offset: 0x00B38F35
		public override bool IsRoleNeedBreakUp()
		{
			return true;
		}

		// Token: 0x060281DB RID: 164315 RVA: 0x00B3AD38 File Offset: 0x00B38F38
		public override int GetRoleTargetLevel()
		{
			return this.GetDevPropsProjectConfig().RoleGoalLevel;
		}

		// Token: 0x060281DC RID: 164316 RVA: 0x00B3AD45 File Offset: 0x00B38F45
		public override int GetRoleTargetBreachLevel()
		{
			return 0;
		}

		// Token: 0x060281DD RID: 164317 RVA: 0x00B3AD48 File Offset: 0x00B38F48
		public override int GetWeaponType()
		{
			return this.GetDevPropsProjectConfig().WeaponType;
		}

		// Token: 0x060281DE RID: 164318 RVA: 0x00B3AD55 File Offset: 0x00B38F55
		public override WeaponInstance GetWeaponInstance()
		{
			return null;
		}

		// Token: 0x060281DF RID: 164319 RVA: 0x00B3AD58 File Offset: 0x00B38F58
		public override string GetWeaponName()
		{
			return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.GetWeaponType()).Value.WeaponTypeDescribe;
		}

		// Token: 0x060281E0 RID: 164320 RVA: 0x00B3AD85 File Offset: 0x00B38F85
		public override int GetWeaponLevel()
		{
			return 1;
		}

		// Token: 0x060281E1 RID: 164321 RVA: 0x00B3AD88 File Offset: 0x00B38F88
		public override int GetWeaponBreachLevel()
		{
			return 0;
		}

		// Token: 0x060281E2 RID: 164322 RVA: 0x00B3AD8B File Offset: 0x00B38F8B
		public override int GetWeaponExp()
		{
			return 0;
		}

		// Token: 0x060281E3 RID: 164323 RVA: 0x00B3AD8E File Offset: 0x00B38F8E
		public override int GetWeaponTargetLevel()
		{
			return this.GetDevPropsProjectConfig().WeaponGoalLevel;
		}

		// Token: 0x060281E4 RID: 164324 RVA: 0x00B3AD9B File Offset: 0x00B38F9B
		public override int GetWeaponTargetBreachLevel()
		{
			return 0;
		}

		// Token: 0x060281E5 RID: 164325 RVA: 0x00B3AD9E File Offset: 0x00B38F9E
		public override bool IsWeaponMaxLevel()
		{
			return false;
		}

		// Token: 0x060281E6 RID: 164326 RVA: 0x00B3ADA1 File Offset: 0x00B38FA1
		public override bool IsWeaponNeedBreakUp()
		{
			return false;
		}

		// Token: 0x060281E7 RID: 164327 RVA: 0x00B3ADA4 File Offset: 0x00B38FA4
		public override List<int> GetPhantomIdList()
		{
			return new List<int>();
		}

		// Token: 0x060281E8 RID: 164328 RVA: 0x00B3ADAB File Offset: 0x00B38FAB
		public override bool CanDevelopPhantom()
		{
			return false;
		}

		// Token: 0x060281E9 RID: 164329 RVA: 0x00B3ADAE File Offset: 0x00B38FAE
		public override List<RoleDevelopPhantomSuitData> GetRecommendPhantomSuits(int? planId = null, int? firstVisionMonsterId = null)
		{
			return new List<RoleDevelopPhantomSuitData>();
		}

		// Token: 0x060281EA RID: 164330 RVA: 0x00B3ADB5 File Offset: 0x00B38FB5
		public override int GetRecommendPlanId()
		{
			return 0;
		}

		// Token: 0x060281EB RID: 164331 RVA: 0x00B3ADB8 File Offset: 0x00B38FB8
		public override int GetRecommendFirstVisionMonsterId()
		{
			return 0;
		}
	}
}
