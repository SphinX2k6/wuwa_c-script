using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x0200281F RID: 10271
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevSkillViewItemDataBase
{
	// Token: 0x060151FB RID: 86523 RVA: 0x005589CF File Offset: 0x00556BCF
	public void InitByRoleId(int roleId, ERoleDevDataType roleType, RoleDevViewModel roleDevViewModel)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.InitByRoleType(roleId, roleDevViewModel);
	}

	// Token: 0x060151FC RID: 86524
	protected abstract void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel);

	// Token: 0x17001BEF RID: 7151
	// (get) Token: 0x060151FD RID: 86525 RVA: 0x005589E7 File Offset: 0x00556BE7
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001BF0 RID: 7152
	// (get) Token: 0x060151FE RID: 86526 RVA: 0x005589EF File Offset: 0x00556BEF
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x060151FF RID: 86527
	protected abstract bool GetIsRoleOwned();

	// Token: 0x06015200 RID: 86528
	protected abstract bool GetIsPerfectPlan();

	// Token: 0x06015201 RID: 86529
	protected abstract bool GetIsNormalPlanFinished();

	// Token: 0x06015202 RID: 86530
	protected abstract bool GetIsPerfectPlanFinished();

	// Token: 0x06015203 RID: 86531
	protected abstract List<global::ISkillSlotExtendData> GetSkillSlots();

	// Token: 0x06015204 RID: 86532
	protected abstract List<int> GetSkillGoalUpgradeLevel();

	// Token: 0x06015205 RID: 86533
	protected abstract List<global::IRoleDevDetailItemData> GetNormalDetailItems();

	// Token: 0x06015206 RID: 86534
	protected abstract bool GetIsNormalAllMaterialEnough();

	// Token: 0x06015207 RID: 86535
	protected abstract bool GetIsUnlockedPerfect();

	// Token: 0x06015208 RID: 86536
	protected abstract List<int> GetPerfectGoalUpgradeLevel();

	// Token: 0x06015209 RID: 86537
	protected abstract List<global::IRoleDevDetailItemData> GetPerfectDetailItems();

	// Token: 0x0601520A RID: 86538
	protected abstract bool GetIsPerfectMaterialEnough();

	// Token: 0x0601520B RID: 86539
	protected abstract bool GetIsBreakthroughLevelLow();

	// Token: 0x0601520C RID: 86540
	protected abstract bool GetIsHideMaterialList();

	// Token: 0x0601520D RID: 86541
	protected abstract bool GetIsForecast();

	// Token: 0x0601520E RID: 86542
	protected abstract bool GetShouldForcePerfectPlan();

	// Token: 0x17001BF1 RID: 7153
	// (get) Token: 0x0601520F RID: 86543 RVA: 0x005589F7 File Offset: 0x00556BF7
	public bool IsRoleOwned
	{
		get
		{
			return this.GetIsRoleOwned();
		}
	}

	// Token: 0x17001BF2 RID: 7154
	// (get) Token: 0x06015210 RID: 86544 RVA: 0x005589FF File Offset: 0x00556BFF
	public bool IsPerfectPlan
	{
		get
		{
			return this.GetIsPerfectPlan();
		}
	}

	// Token: 0x17001BF3 RID: 7155
	// (get) Token: 0x06015211 RID: 86545 RVA: 0x00558A07 File Offset: 0x00556C07
	public bool IsNormalPlanFinished
	{
		get
		{
			return this.GetIsNormalPlanFinished();
		}
	}

	// Token: 0x17001BF4 RID: 7156
	// (get) Token: 0x06015212 RID: 86546 RVA: 0x00558A0F File Offset: 0x00556C0F
	public bool IsPerfectPlanFinished
	{
		get
		{
			return this.GetIsPerfectPlanFinished();
		}
	}

	// Token: 0x17001BF5 RID: 7157
	// (get) Token: 0x06015213 RID: 86547 RVA: 0x00558A17 File Offset: 0x00556C17
	public List<global::ISkillSlotExtendData> SkillSlots
	{
		get
		{
			return this.GetSkillSlots();
		}
	}

	// Token: 0x17001BF6 RID: 7158
	// (get) Token: 0x06015214 RID: 86548 RVA: 0x00558A1F File Offset: 0x00556C1F
	public List<int> SkillGoalUpgradeLevel
	{
		get
		{
			return this.GetSkillGoalUpgradeLevel();
		}
	}

	// Token: 0x17001BF7 RID: 7159
	// (get) Token: 0x06015215 RID: 86549 RVA: 0x00558A27 File Offset: 0x00556C27
	public List<global::IRoleDevDetailItemData> NormalDetailItems
	{
		get
		{
			return this.GetNormalDetailItems();
		}
	}

	// Token: 0x17001BF8 RID: 7160
	// (get) Token: 0x06015216 RID: 86550 RVA: 0x00558A2F File Offset: 0x00556C2F
	public bool IsNormalAllMaterialEnough
	{
		get
		{
			return this.GetIsNormalAllMaterialEnough();
		}
	}

	// Token: 0x17001BF9 RID: 7161
	// (get) Token: 0x06015217 RID: 86551 RVA: 0x00558A37 File Offset: 0x00556C37
	public bool IsCurrentPlanAllMaterialEnough
	{
		get
		{
			return this.GetIsCurrentPlanAllMaterialEnough();
		}
	}

	// Token: 0x17001BFA RID: 7162
	// (get) Token: 0x06015218 RID: 86552 RVA: 0x00558A3F File Offset: 0x00556C3F
	public bool IsUnlockedPerfect
	{
		get
		{
			return this.GetIsUnlockedPerfect();
		}
	}

	// Token: 0x17001BFB RID: 7163
	// (get) Token: 0x06015219 RID: 86553 RVA: 0x00558A47 File Offset: 0x00556C47
	public List<int> PerfectGoalUpgradeLevel
	{
		get
		{
			return this.GetPerfectGoalUpgradeLevel();
		}
	}

	// Token: 0x17001BFC RID: 7164
	// (get) Token: 0x0601521A RID: 86554 RVA: 0x00558A4F File Offset: 0x00556C4F
	public List<global::IRoleDevDetailItemData> PerfectDetailItems
	{
		get
		{
			return this.GetPerfectDetailItems();
		}
	}

	// Token: 0x17001BFD RID: 7165
	// (get) Token: 0x0601521B RID: 86555 RVA: 0x00558A57 File Offset: 0x00556C57
	public bool IsPerfectMaterialEnough
	{
		get
		{
			return this.GetIsPerfectMaterialEnough();
		}
	}

	// Token: 0x17001BFE RID: 7166
	// (get) Token: 0x0601521C RID: 86556 RVA: 0x00558A5F File Offset: 0x00556C5F
	public bool IsBreakthroughLevelLow
	{
		get
		{
			return this.GetIsBreakthroughLevelLow();
		}
	}

	// Token: 0x17001BFF RID: 7167
	// (get) Token: 0x0601521D RID: 86557 RVA: 0x00558A67 File Offset: 0x00556C67
	public bool IsHideMaterialList
	{
		get
		{
			return this.GetIsHideMaterialList();
		}
	}

	// Token: 0x17001C00 RID: 7168
	// (get) Token: 0x0601521E RID: 86558 RVA: 0x00558A6F File Offset: 0x00556C6F
	public bool IsForecast
	{
		get
		{
			return this.GetIsForecast();
		}
	}

	// Token: 0x17001C01 RID: 7169
	// (get) Token: 0x0601521F RID: 86559 RVA: 0x00558A77 File Offset: 0x00556C77
	public bool ShouldForcePerfectPlan
	{
		get
		{
			return this.GetShouldForcePerfectPlan();
		}
	}

	// Token: 0x17001C02 RID: 7170
	// (get) Token: 0x06015220 RID: 86560 RVA: 0x00558A7F File Offset: 0x00556C7F
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

	// Token: 0x17001C03 RID: 7171
	// (get) Token: 0x06015221 RID: 86561 RVA: 0x00558A96 File Offset: 0x00556C96
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

	// Token: 0x17001C04 RID: 7172
	// (get) Token: 0x06015222 RID: 86562 RVA: 0x00558AAD File Offset: 0x00556CAD
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x06015223 RID: 86563 RVA: 0x00558AB8 File Offset: 0x00556CB8
	public global::EJumpTarget GetJumpTarget()
	{
		if (!this.IsRoleOwned)
		{
			return global::EJumpTarget.IllustrationPage;
		}
		return global::EJumpTarget.SkillPage;
	}

	// Token: 0x06015224 RID: 86564 RVA: 0x00558AC8 File Offset: 0x00556CC8
	public global::IButtonState GetButtonState()
	{
		return new global::ButtonState
		{
			Text = (this.IsRoleOwned ? "RoleProject_Button01" : "RoleProject_Button02"),
			IsHighlight = (this.IsRoleOwned && (this.IsPerfectPlan ? this.IsPerfectMaterialEnough : this.IsNormalAllMaterialEnough))
		};
	}

	// Token: 0x06015225 RID: 86565 RVA: 0x00558B1C File Offset: 0x00556D1C
	public global::IPlanSwitchButtonState GetPlanSwitchButtonState()
	{
		return new global::PlanSwitchButtonState
		{
			IsShow = (this.PerfectGoalUpgradeLevel.Count > 0),
			Text = (this.IsPerfectPlan ? "RoleProject_Button_SkillUpgradeBasic" : "RoleProject_Button_SkillUpgradePrefect"),
			IsHighlight = (!this.IsPerfectPlan && this.IsNormalPlanFinished && !this.IsPerfectPlanFinished)
		};
	}

	// Token: 0x06015226 RID: 86566 RVA: 0x00558B7E File Offset: 0x00556D7E
	public virtual void SwitchPlan()
	{
		throw new Exception("SwitchPlan must be implemented by subclass");
	}

	// Token: 0x06015227 RID: 86567 RVA: 0x00558B8A File Offset: 0x00556D8A
	protected bool GetIsCurrentPlanAllMaterialEnough()
	{
		if (!this.IsPerfectPlan)
		{
			return this.IsNormalAllMaterialEnough;
		}
		return this.IsPerfectMaterialEnough;
	}

	// Token: 0x04009E57 RID: 40535
	protected int RoleIdInternal;

	// Token: 0x04009E58 RID: 40536
	protected ERoleDevDataType RoleTypeInternal;
}
