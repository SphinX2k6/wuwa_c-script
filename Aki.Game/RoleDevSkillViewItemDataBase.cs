using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001D9A RID: 7578
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevSkillViewItemDataBase
{
	// Token: 0x06012BF9 RID: 76793 RVA: 0x005836E5 File Offset: 0x005818E5
	public void InitByRoleId(int roleId, ERoleDevDataType roleType, RoleDevViewModel roleDevViewModel)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.InitByRoleType(roleId, roleDevViewModel);
	}

	// Token: 0x06012BFA RID: 76794
	protected abstract void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel);

	// Token: 0x17001C47 RID: 7239
	// (get) Token: 0x06012BFB RID: 76795 RVA: 0x005836FD File Offset: 0x005818FD
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C48 RID: 7240
	// (get) Token: 0x06012BFC RID: 76796 RVA: 0x00583705 File Offset: 0x00581905
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x06012BFD RID: 76797
	protected abstract bool GetIsRoleOwned();

	// Token: 0x06012BFE RID: 76798
	protected abstract bool GetIsPerfectPlan();

	// Token: 0x06012BFF RID: 76799
	protected abstract bool GetIsNormalPlanFinished();

	// Token: 0x06012C00 RID: 76800
	protected abstract bool GetIsPerfectPlanFinished();

	// Token: 0x06012C01 RID: 76801
	protected abstract List<global::ISkillSlotExtendData> GetSkillSlots();

	// Token: 0x06012C02 RID: 76802
	protected abstract List<int> GetSkillGoalUpgradeLevel();

	// Token: 0x06012C03 RID: 76803
	protected abstract List<global::IRoleDevDetailItemData> GetNormalDetailItems();

	// Token: 0x06012C04 RID: 76804
	protected abstract bool GetIsNormalAllMaterialEnough();

	// Token: 0x06012C05 RID: 76805
	protected abstract bool GetIsUnlockedPerfect();

	// Token: 0x06012C06 RID: 76806
	protected abstract List<int> GetPerfectGoalUpgradeLevel();

	// Token: 0x06012C07 RID: 76807
	protected abstract List<global::IRoleDevDetailItemData> GetPerfectDetailItems();

	// Token: 0x06012C08 RID: 76808
	protected abstract bool GetIsPerfectMaterialEnough();

	// Token: 0x06012C09 RID: 76809
	protected abstract bool GetIsBreakthroughLevelLow();

	// Token: 0x06012C0A RID: 76810
	protected abstract bool GetIsHideMaterialList();

	// Token: 0x06012C0B RID: 76811
	protected abstract bool GetIsForecast();

	// Token: 0x06012C0C RID: 76812
	protected abstract bool GetShouldForcePerfectPlan();

	// Token: 0x17001C49 RID: 7241
	// (get) Token: 0x06012C0D RID: 76813 RVA: 0x0058370D File Offset: 0x0058190D
	public bool IsRoleOwned
	{
		get
		{
			return this.GetIsRoleOwned();
		}
	}

	// Token: 0x17001C4A RID: 7242
	// (get) Token: 0x06012C0E RID: 76814 RVA: 0x00583715 File Offset: 0x00581915
	public bool IsPerfectPlan
	{
		get
		{
			return this.GetIsPerfectPlan();
		}
	}

	// Token: 0x17001C4B RID: 7243
	// (get) Token: 0x06012C0F RID: 76815 RVA: 0x0058371D File Offset: 0x0058191D
	public bool IsNormalPlanFinished
	{
		get
		{
			return this.GetIsNormalPlanFinished();
		}
	}

	// Token: 0x17001C4C RID: 7244
	// (get) Token: 0x06012C10 RID: 76816 RVA: 0x00583725 File Offset: 0x00581925
	public bool IsPerfectPlanFinished
	{
		get
		{
			return this.GetIsPerfectPlanFinished();
		}
	}

	// Token: 0x17001C4D RID: 7245
	// (get) Token: 0x06012C11 RID: 76817 RVA: 0x0058372D File Offset: 0x0058192D
	public List<global::ISkillSlotExtendData> SkillSlots
	{
		get
		{
			return this.GetSkillSlots();
		}
	}

	// Token: 0x17001C4E RID: 7246
	// (get) Token: 0x06012C12 RID: 76818 RVA: 0x00583735 File Offset: 0x00581935
	public List<int> SkillGoalUpgradeLevel
	{
		get
		{
			return this.GetSkillGoalUpgradeLevel();
		}
	}

	// Token: 0x17001C4F RID: 7247
	// (get) Token: 0x06012C13 RID: 76819 RVA: 0x0058373D File Offset: 0x0058193D
	public List<global::IRoleDevDetailItemData> NormalDetailItems
	{
		get
		{
			return this.GetNormalDetailItems();
		}
	}

	// Token: 0x17001C50 RID: 7248
	// (get) Token: 0x06012C14 RID: 76820 RVA: 0x00583745 File Offset: 0x00581945
	public bool IsNormalAllMaterialEnough
	{
		get
		{
			return this.GetIsNormalAllMaterialEnough();
		}
	}

	// Token: 0x17001C51 RID: 7249
	// (get) Token: 0x06012C15 RID: 76821 RVA: 0x0058374D File Offset: 0x0058194D
	public bool IsCurrentPlanAllMaterialEnough
	{
		get
		{
			return this.GetIsCurrentPlanAllMaterialEnough();
		}
	}

	// Token: 0x17001C52 RID: 7250
	// (get) Token: 0x06012C16 RID: 76822 RVA: 0x00583755 File Offset: 0x00581955
	public bool IsUnlockedPerfect
	{
		get
		{
			return this.GetIsUnlockedPerfect();
		}
	}

	// Token: 0x17001C53 RID: 7251
	// (get) Token: 0x06012C17 RID: 76823 RVA: 0x0058375D File Offset: 0x0058195D
	public List<int> PerfectGoalUpgradeLevel
	{
		get
		{
			return this.GetPerfectGoalUpgradeLevel();
		}
	}

	// Token: 0x17001C54 RID: 7252
	// (get) Token: 0x06012C18 RID: 76824 RVA: 0x00583765 File Offset: 0x00581965
	public List<global::IRoleDevDetailItemData> PerfectDetailItems
	{
		get
		{
			return this.GetPerfectDetailItems();
		}
	}

	// Token: 0x17001C55 RID: 7253
	// (get) Token: 0x06012C19 RID: 76825 RVA: 0x0058376D File Offset: 0x0058196D
	public bool IsPerfectMaterialEnough
	{
		get
		{
			return this.GetIsPerfectMaterialEnough();
		}
	}

	// Token: 0x17001C56 RID: 7254
	// (get) Token: 0x06012C1A RID: 76826 RVA: 0x00583775 File Offset: 0x00581975
	public bool IsBreakthroughLevelLow
	{
		get
		{
			return this.GetIsBreakthroughLevelLow();
		}
	}

	// Token: 0x17001C57 RID: 7255
	// (get) Token: 0x06012C1B RID: 76827 RVA: 0x0058377D File Offset: 0x0058197D
	public bool IsHideMaterialList
	{
		get
		{
			return this.GetIsHideMaterialList();
		}
	}

	// Token: 0x17001C58 RID: 7256
	// (get) Token: 0x06012C1C RID: 76828 RVA: 0x00583785 File Offset: 0x00581985
	public bool IsForecast
	{
		get
		{
			return this.GetIsForecast();
		}
	}

	// Token: 0x17001C59 RID: 7257
	// (get) Token: 0x06012C1D RID: 76829 RVA: 0x0058378D File Offset: 0x0058198D
	public bool ShouldForcePerfectPlan
	{
		get
		{
			return this.GetShouldForcePerfectPlan();
		}
	}

	// Token: 0x17001C5A RID: 7258
	// (get) Token: 0x06012C1E RID: 76830 RVA: 0x00583795 File Offset: 0x00581995
	public bool CurrentPlanMaterialEnough
	{
		get
		{
			if (!this.IsPerfectPlan)
			{
				return this.IsNormalAllMaterialEnough;
			}
			return this.IsPerfectMaterialEnough;
		}
	}

	// Token: 0x17001C5B RID: 7259
	// (get) Token: 0x06012C1F RID: 76831 RVA: 0x005837AC File Offset: 0x005819AC
	public bool CurrentPlanFinished
	{
		get
		{
			if (!this.IsPerfectPlan)
			{
				return this.IsNormalPlanFinished;
			}
			return this.IsPerfectPlanFinished;
		}
	}

	// Token: 0x17001C5C RID: 7260
	// (get) Token: 0x06012C20 RID: 76832 RVA: 0x005837C3 File Offset: 0x005819C3
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x06012C21 RID: 76833 RVA: 0x005837CE File Offset: 0x005819CE
	public global::EJumpTarget GetJumpTarget()
	{
		if (!this.IsRoleOwned)
		{
			return global::EJumpTarget.IllustrationPage;
		}
		return global::EJumpTarget.SkillPage;
	}

	// Token: 0x06012C22 RID: 76834 RVA: 0x005837DC File Offset: 0x005819DC
	public global::IButtonState GetButtonState()
	{
		return new global::ButtonState
		{
			Text = (this.IsRoleOwned ? "RoleProject_Button01" : "RoleProject_Button02"),
			IsHighlight = (this.IsRoleOwned && (this.IsPerfectPlan ? this.IsPerfectMaterialEnough : this.IsNormalAllMaterialEnough))
		};
	}

	// Token: 0x06012C23 RID: 76835 RVA: 0x00583830 File Offset: 0x00581A30
	public global::IPlanSwitchButtonState GetPlanSwitchButtonState()
	{
		return new global::PlanSwitchButtonState
		{
			IsShow = (this.PerfectGoalUpgradeLevel.Count > 0),
			Text = (this.IsPerfectPlan ? "RoleProject_Button_SkillUpgradeBasic" : "RoleProject_Button_SkillUpgradePrefect"),
			IsHighlight = (!this.IsPerfectPlan && this.IsNormalPlanFinished && !this.IsPerfectPlanFinished)
		};
	}

	// Token: 0x06012C24 RID: 76836 RVA: 0x00583892 File Offset: 0x00581A92
	public virtual void SwitchPlan()
	{
		throw new Exception("SwitchPlan must be implemented by subclass");
	}

	// Token: 0x06012C25 RID: 76837 RVA: 0x0058389E File Offset: 0x00581A9E
	protected bool GetIsCurrentPlanAllMaterialEnough()
	{
		if (!this.IsPerfectPlan)
		{
			return this.IsNormalAllMaterialEnough;
		}
		return this.IsPerfectMaterialEnough;
	}

	// Token: 0x0400A240 RID: 41536
	protected int RoleIdInternal;

	// Token: 0x0400A241 RID: 41537
	protected ERoleDevDataType RoleTypeInternal;
}
