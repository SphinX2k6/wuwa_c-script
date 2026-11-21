using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001D94 RID: 7572
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevRoleViewItemDataBase
{
	// Token: 0x06012B7D RID: 76669 RVA: 0x00581F64 File Offset: 0x00580164
	public void InitByRoleId(int roleId, ERoleDevDataType roleType)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.InitByRoleType(roleId);
	}

	// Token: 0x06012B7E RID: 76670
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001C34 RID: 7220
	// (get) Token: 0x06012B7F RID: 76671 RVA: 0x00581F7B File Offset: 0x0058017B
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C35 RID: 7221
	// (get) Token: 0x06012B80 RID: 76672 RVA: 0x00581F83 File Offset: 0x00580183
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x06012B81 RID: 76673
	protected abstract int GetRoleLevel();

	// Token: 0x06012B82 RID: 76674
	protected abstract int GetRoleBreachLevel();

	// Token: 0x06012B83 RID: 76675
	protected abstract int GetRoleGoalUpgradeLevel();

	// Token: 0x06012B84 RID: 76676
	protected abstract int GetRoleGoalBreakLevel();

	// Token: 0x06012B85 RID: 76677
	protected abstract List<global::IRoleDevDetailItemData> GetDetailItems();

	// Token: 0x06012B86 RID: 76678
	protected abstract string GetRoleName();

	// Token: 0x06012B87 RID: 76679
	protected abstract bool GetIsCanUpgrade();

	// Token: 0x06012B88 RID: 76680
	protected abstract bool GetIsCanBreach();

	// Token: 0x06012B89 RID: 76681
	protected abstract bool GetIsCall();

	// Token: 0x06012B8A RID: 76682
	protected abstract int GetGachaId();

	// Token: 0x06012B8B RID: 76683
	protected abstract bool GetIsForecast();

	// Token: 0x17001C36 RID: 7222
	// (get) Token: 0x06012B8C RID: 76684 RVA: 0x00581F8B File Offset: 0x0058018B
	public int RoleLevel
	{
		get
		{
			return this.GetRoleLevel();
		}
	}

	// Token: 0x17001C37 RID: 7223
	// (get) Token: 0x06012B8D RID: 76685 RVA: 0x00581F93 File Offset: 0x00580193
	public int RoleBreachLevel
	{
		get
		{
			return this.GetRoleBreachLevel();
		}
	}

	// Token: 0x17001C38 RID: 7224
	// (get) Token: 0x06012B8E RID: 76686 RVA: 0x00581F9B File Offset: 0x0058019B
	public int RoleGoalUpgradeLevel
	{
		get
		{
			return this.GetRoleGoalUpgradeLevel();
		}
	}

	// Token: 0x17001C39 RID: 7225
	// (get) Token: 0x06012B8F RID: 76687 RVA: 0x00581FA3 File Offset: 0x005801A3
	public int RoleGoalBreakLevel
	{
		get
		{
			return this.GetRoleGoalBreakLevel();
		}
	}

	// Token: 0x17001C3A RID: 7226
	// (get) Token: 0x06012B90 RID: 76688 RVA: 0x00581FAB File Offset: 0x005801AB
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.GetDetailItems();
		}
	}

	// Token: 0x17001C3B RID: 7227
	// (get) Token: 0x06012B91 RID: 76689 RVA: 0x00581FB3 File Offset: 0x005801B3
	public string RoleName
	{
		get
		{
			return this.GetRoleName();
		}
	}

	// Token: 0x17001C3C RID: 7228
	// (get) Token: 0x06012B92 RID: 76690 RVA: 0x00581FBB File Offset: 0x005801BB
	public bool IsCanUpgrade
	{
		get
		{
			return this.GetIsCanUpgrade();
		}
	}

	// Token: 0x17001C3D RID: 7229
	// (get) Token: 0x06012B93 RID: 76691 RVA: 0x00581FC3 File Offset: 0x005801C3
	public bool IsCanBreach
	{
		get
		{
			return this.GetIsCanBreach();
		}
	}

	// Token: 0x17001C3E RID: 7230
	// (get) Token: 0x06012B94 RID: 76692 RVA: 0x00581FCB File Offset: 0x005801CB
	public bool IsCall
	{
		get
		{
			return this.GetIsCall();
		}
	}

	// Token: 0x17001C3F RID: 7231
	// (get) Token: 0x06012B95 RID: 76693 RVA: 0x00581FD3 File Offset: 0x005801D3
	public int GachaId
	{
		get
		{
			return this.GetGachaId();
		}
	}

	// Token: 0x17001C40 RID: 7232
	// (get) Token: 0x06012B96 RID: 76694 RVA: 0x00581FDB File Offset: 0x005801DB
	public bool IsForecast
	{
		get
		{
			return this.GetIsForecast();
		}
	}

	// Token: 0x17001C41 RID: 7233
	// (get) Token: 0x06012B97 RID: 76695 RVA: 0x00581FE3 File Offset: 0x005801E3
	public bool IsCanShowUpgradeItem
	{
		get
		{
			return this.RoleLevel < this.RoleGoalUpgradeLevel;
		}
	}

	// Token: 0x17001C42 RID: 7234
	// (get) Token: 0x06012B98 RID: 76696 RVA: 0x00581FF3 File Offset: 0x005801F3
	public bool IsCanShowBreachItem
	{
		get
		{
			return this.RoleBreachLevel < this.RoleGoalBreakLevel;
		}
	}

	// Token: 0x17001C43 RID: 7235
	// (get) Token: 0x06012B99 RID: 76697 RVA: 0x00582003 File Offset: 0x00580203
	public bool IsFinish
	{
		get
		{
			return !this.IsCanShowUpgradeItem && !this.IsCanShowBreachItem;
		}
	}

	// Token: 0x17001C44 RID: 7236
	// (get) Token: 0x06012B9A RID: 76698 RVA: 0x00582018 File Offset: 0x00580218
	public bool IsAllMaterialEnough
	{
		get
		{
			return RoleDevUtils.CheckAllItemsUp(this.DetailItems);
		}
	}

	// Token: 0x17001C45 RID: 7237
	// (get) Token: 0x06012B9B RID: 76699 RVA: 0x00582025 File Offset: 0x00580225
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001C46 RID: 7238
	// (get) Token: 0x06012B9C RID: 76700 RVA: 0x00582030 File Offset: 0x00580230
	public bool RoleLevelIsMax
	{
		get
		{
			return this.RoleLevel >= this.GetMaxLevel();
		}
	}

	// Token: 0x06012B9D RID: 76701
	protected abstract int GetMaxLevel();

	// Token: 0x0400A225 RID: 41509
	protected int RoleIdInternal;

	// Token: 0x0400A226 RID: 41510
	protected ERoleDevDataType RoleTypeInternal;
}
