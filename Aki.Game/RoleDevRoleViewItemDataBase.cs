using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002819 RID: 10265
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevRoleViewItemDataBase
{
	// Token: 0x0601517D RID: 86397 RVA: 0x00557164 File Offset: 0x00555364
	public void InitByRoleId(int roleId, ERoleDevDataType roleType)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.InitByRoleType(roleId);
	}

	// Token: 0x0601517E RID: 86398
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001BDC RID: 7132
	// (get) Token: 0x0601517F RID: 86399 RVA: 0x0055717B File Offset: 0x0055537B
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001BDD RID: 7133
	// (get) Token: 0x06015180 RID: 86400 RVA: 0x00557183 File Offset: 0x00555383
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x06015181 RID: 86401
	protected abstract int GetRoleLevel();

	// Token: 0x06015182 RID: 86402
	protected abstract int GetRoleBreachLevel();

	// Token: 0x06015183 RID: 86403
	protected abstract int GetRoleGoalUpgradeLevel();

	// Token: 0x06015184 RID: 86404
	protected abstract int GetRoleGoalBreakLevel();

	// Token: 0x06015185 RID: 86405
	protected abstract List<global::IRoleDevDetailItemData> GetDetailItems();

	// Token: 0x06015186 RID: 86406
	protected abstract string GetRoleName();

	// Token: 0x06015187 RID: 86407
	protected abstract bool GetIsCanUpgrade();

	// Token: 0x06015188 RID: 86408
	protected abstract bool GetIsCanBreach();

	// Token: 0x06015189 RID: 86409
	protected abstract bool GetIsCall();

	// Token: 0x0601518A RID: 86410
	protected abstract int GetGachaId();

	// Token: 0x0601518B RID: 86411
	protected abstract bool GetIsForecast();

	// Token: 0x17001BDE RID: 7134
	// (get) Token: 0x0601518C RID: 86412 RVA: 0x0055718B File Offset: 0x0055538B
	public int RoleLevel
	{
		get
		{
			return this.GetRoleLevel();
		}
	}

	// Token: 0x17001BDF RID: 7135
	// (get) Token: 0x0601518D RID: 86413 RVA: 0x00557193 File Offset: 0x00555393
	public int RoleBreachLevel
	{
		get
		{
			return this.GetRoleBreachLevel();
		}
	}

	// Token: 0x17001BE0 RID: 7136
	// (get) Token: 0x0601518E RID: 86414 RVA: 0x0055719B File Offset: 0x0055539B
	public int RoleGoalUpgradeLevel
	{
		get
		{
			return this.GetRoleGoalUpgradeLevel();
		}
	}

	// Token: 0x17001BE1 RID: 7137
	// (get) Token: 0x0601518F RID: 86415 RVA: 0x005571A3 File Offset: 0x005553A3
	public int RoleGoalBreakLevel
	{
		get
		{
			return this.GetRoleGoalBreakLevel();
		}
	}

	// Token: 0x17001BE2 RID: 7138
	// (get) Token: 0x06015190 RID: 86416 RVA: 0x005571AB File Offset: 0x005553AB
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.GetDetailItems();
		}
	}

	// Token: 0x17001BE3 RID: 7139
	// (get) Token: 0x06015191 RID: 86417 RVA: 0x005571B3 File Offset: 0x005553B3
	public string RoleName
	{
		get
		{
			return this.GetRoleName();
		}
	}

	// Token: 0x17001BE4 RID: 7140
	// (get) Token: 0x06015192 RID: 86418 RVA: 0x005571BB File Offset: 0x005553BB
	public bool IsCanUpgrade
	{
		get
		{
			return this.GetIsCanUpgrade();
		}
	}

	// Token: 0x17001BE5 RID: 7141
	// (get) Token: 0x06015193 RID: 86419 RVA: 0x005571C3 File Offset: 0x005553C3
	public bool IsCanBreach
	{
		get
		{
			return this.GetIsCanBreach();
		}
	}

	// Token: 0x17001BE6 RID: 7142
	// (get) Token: 0x06015194 RID: 86420 RVA: 0x005571CB File Offset: 0x005553CB
	public bool IsCall
	{
		get
		{
			return this.GetIsCall();
		}
	}

	// Token: 0x17001BE7 RID: 7143
	// (get) Token: 0x06015195 RID: 86421 RVA: 0x005571D3 File Offset: 0x005553D3
	public int GachaId
	{
		get
		{
			return this.GetGachaId();
		}
	}

	// Token: 0x17001BE8 RID: 7144
	// (get) Token: 0x06015196 RID: 86422 RVA: 0x005571DB File Offset: 0x005553DB
	public bool IsForecast
	{
		get
		{
			return this.GetIsForecast();
		}
	}

	// Token: 0x17001BE9 RID: 7145
	// (get) Token: 0x06015197 RID: 86423 RVA: 0x005571E3 File Offset: 0x005553E3
	public bool IsCanShowUpgradeItem
	{
		get
		{
			return this.RoleLevel < this.RoleGoalUpgradeLevel;
		}
	}

	// Token: 0x17001BEA RID: 7146
	// (get) Token: 0x06015198 RID: 86424 RVA: 0x005571F3 File Offset: 0x005553F3
	public bool IsCanShowBreachItem
	{
		get
		{
			return this.RoleBreachLevel < this.RoleGoalBreakLevel;
		}
	}

	// Token: 0x17001BEB RID: 7147
	// (get) Token: 0x06015199 RID: 86425 RVA: 0x00557203 File Offset: 0x00555403
	public bool IsFinish
	{
		get
		{
			return !this.IsCanShowUpgradeItem && !this.IsCanShowBreachItem;
		}
	}

	// Token: 0x17001BEC RID: 7148
	// (get) Token: 0x0601519A RID: 86426 RVA: 0x00557218 File Offset: 0x00555418
	public bool IsAllMaterialEnough
	{
		get
		{
			return RoleDevUtils.CheckAllItemsUp(this.DetailItems);
		}
	}

	// Token: 0x17001BED RID: 7149
	// (get) Token: 0x0601519B RID: 86427 RVA: 0x00557225 File Offset: 0x00555425
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001BEE RID: 7150
	// (get) Token: 0x0601519C RID: 86428 RVA: 0x00557230 File Offset: 0x00555430
	public bool RoleLevelIsMax
	{
		get
		{
			return this.RoleLevel >= this.GetMaxLevel();
		}
	}

	// Token: 0x0601519D RID: 86429
	protected abstract int GetMaxLevel();

	// Token: 0x04009E3C RID: 40508
	protected int RoleIdInternal;

	// Token: 0x04009E3D RID: 40509
	protected ERoleDevDataType RoleTypeInternal;
}
