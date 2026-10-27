using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02004D61 RID: 19809
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopRoleProspectData : RoleDevelopRoleBaseData
	{
		// Token: 0x0603335F RID: 209759 RVA: 0x00BF1AFE File Offset: 0x00BEFCFE
		public RoleDevelopRoleProspectData(int id) : base(id)
		{
		}

		// Token: 0x06033360 RID: 209760 RVA: 0x00BF1B07 File Offset: 0x00BEFD07
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Prospect;
		}

		// Token: 0x06033361 RID: 209761 RVA: 0x00BF1B0A File Offset: 0x00BEFD0A
		private IRoleDevProsProjectConfig GetDevPropsProjectConfig()
		{
			return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id);
		}

		// Token: 0x06033362 RID: 209762 RVA: 0x00BF1B1C File Offset: 0x00BEFD1C
		public override string GetName()
		{
			return this.GetDevPropsProjectConfig().RoleName;
		}

		// Token: 0x06033363 RID: 209763 RVA: 0x00BF1B29 File Offset: 0x00BEFD29
		public override int GetElementId()
		{
			return this.GetDevPropsProjectConfig().ElementId;
		}

		// Token: 0x06033364 RID: 209764 RVA: 0x00BF1B36 File Offset: 0x00BEFD36
		public override string GetRoleIllustrationPath()
		{
			return this.GetDevPropsProjectConfig().FormationRoleCard;
		}

		// Token: 0x06033365 RID: 209765 RVA: 0x00BF1B43 File Offset: 0x00BEFD43
		public override string GetRoleIconPath()
		{
			return this.GetDevPropsProjectConfig().RoleHeadIcon;
		}

		// Token: 0x06033366 RID: 209766 RVA: 0x00BF1B50 File Offset: 0x00BEFD50
		public override string GetRoleSmallIconPath()
		{
			return this.GetDevPropsProjectConfig().RoleHeadIconSmall;
		}

		// Token: 0x06033367 RID: 209767 RVA: 0x00BF1B5D File Offset: 0x00BEFD5D
		public override string GetRoleCircleIconPath()
		{
			return this.GetDevPropsProjectConfig().RoleHeadIconSmall;
		}

		// Token: 0x06033368 RID: 209768 RVA: 0x00BF1B6A File Offset: 0x00BEFD6A
		public override int GetKeyProperty()
		{
			return 0;
		}

		// Token: 0x06033369 RID: 209769 RVA: 0x00BF1B6D File Offset: 0x00BEFD6D
		public override int GetRoleLevel()
		{
			return 1;
		}

		// Token: 0x0603336A RID: 209770 RVA: 0x00BF1B70 File Offset: 0x00BEFD70
		public override int GetRoleBreachLevel()
		{
			return 0;
		}

		// Token: 0x0603336B RID: 209771 RVA: 0x00BF1B73 File Offset: 0x00BEFD73
		public override int GetRoleExp()
		{
			return 0;
		}

		// Token: 0x0603336C RID: 209772 RVA: 0x00BF1B76 File Offset: 0x00BEFD76
		public override bool IsRoleMaxLevel()
		{
			return false;
		}

		// Token: 0x0603336D RID: 209773 RVA: 0x00BF1B79 File Offset: 0x00BEFD79
		public override bool IsRoleNeedBreakUp()
		{
			return true;
		}

		// Token: 0x0603336E RID: 209774 RVA: 0x00BF1B7C File Offset: 0x00BEFD7C
		public override int GetRoleTargetLevel()
		{
			return this.GetDevPropsProjectConfig().RoleGoalLevel;
		}

		// Token: 0x0603336F RID: 209775 RVA: 0x00BF1B89 File Offset: 0x00BEFD89
		public override int GetRoleTargetBreachLevel()
		{
			return 0;
		}

		// Token: 0x06033370 RID: 209776 RVA: 0x00BF1B8C File Offset: 0x00BEFD8C
		public override int GetWeaponType()
		{
			return this.GetDevPropsProjectConfig().WeaponType;
		}

		// Token: 0x06033371 RID: 209777 RVA: 0x00BF1B99 File Offset: 0x00BEFD99
		public override WeaponInstance GetWeaponInstance()
		{
			return null;
		}

		// Token: 0x06033372 RID: 209778 RVA: 0x00BF1B9C File Offset: 0x00BEFD9C
		public override string GetWeaponName()
		{
			return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.GetWeaponType()).Value.WeaponTypeDescribe;
		}

		// Token: 0x06033373 RID: 209779 RVA: 0x00BF1BC9 File Offset: 0x00BEFDC9
		public override int GetWeaponLevel()
		{
			return 1;
		}

		// Token: 0x06033374 RID: 209780 RVA: 0x00BF1BCC File Offset: 0x00BEFDCC
		public override int GetWeaponBreachLevel()
		{
			return 0;
		}

		// Token: 0x06033375 RID: 209781 RVA: 0x00BF1BCF File Offset: 0x00BEFDCF
		public override int GetWeaponExp()
		{
			return 0;
		}

		// Token: 0x06033376 RID: 209782 RVA: 0x00BF1BD2 File Offset: 0x00BEFDD2
		public override int GetWeaponTargetLevel()
		{
			return this.GetDevPropsProjectConfig().WeaponGoalLevel;
		}

		// Token: 0x06033377 RID: 209783 RVA: 0x00BF1BDF File Offset: 0x00BEFDDF
		public override int GetWeaponTargetBreachLevel()
		{
			return 0;
		}

		// Token: 0x06033378 RID: 209784 RVA: 0x00BF1BE2 File Offset: 0x00BEFDE2
		public override bool IsWeaponMaxLevel()
		{
			return false;
		}

		// Token: 0x06033379 RID: 209785 RVA: 0x00BF1BE5 File Offset: 0x00BEFDE5
		public override bool IsWeaponNeedBreakUp()
		{
			return false;
		}

		// Token: 0x0603337A RID: 209786 RVA: 0x00BF1BE8 File Offset: 0x00BEFDE8
		public override List<int> GetPhantomIdList()
		{
			return new List<int>();
		}

		// Token: 0x0603337B RID: 209787 RVA: 0x00BF1BEF File Offset: 0x00BEFDEF
		public override bool CanDevelopPhantom()
		{
			return false;
		}

		// Token: 0x0603337C RID: 209788 RVA: 0x00BF1BF2 File Offset: 0x00BEFDF2
		public override List<RoleDevelopPhantomSuitData> GetRecommendPhantomSuits(int? planId = null, int? firstVisionMonsterId = null)
		{
			return new List<RoleDevelopPhantomSuitData>();
		}

		// Token: 0x0603337D RID: 209789 RVA: 0x00BF1BF9 File Offset: 0x00BEFDF9
		public override int GetRecommendPlanId()
		{
			return 0;
		}

		// Token: 0x0603337E RID: 209790 RVA: 0x00BF1BFC File Offset: 0x00BEFDFC
		public override int GetRecommendFirstVisionMonsterId()
		{
			return 0;
		}
	}
}
