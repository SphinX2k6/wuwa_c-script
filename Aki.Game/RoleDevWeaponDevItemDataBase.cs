using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002832 RID: 10290
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevWeaponDevItemDataBase
{
	// Token: 0x06015349 RID: 86857 RVA: 0x0055CC76 File Offset: 0x0055AE76
	public void InitByRoleId(int roleId, ERoleDevDataType roleType)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.InitByRoleType(roleId);
	}

	// Token: 0x0601534A RID: 86858
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001C15 RID: 7189
	// (get) Token: 0x0601534B RID: 86859 RVA: 0x0055CC8D File Offset: 0x0055AE8D
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C16 RID: 7190
	// (get) Token: 0x0601534C RID: 86860 RVA: 0x0055CC95 File Offset: 0x0055AE95
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x0601534D RID: 86861
	protected abstract int GetWeaponLevel();

	// Token: 0x0601534E RID: 86862
	protected abstract int GetWeaponBreachLevel();

	// Token: 0x0601534F RID: 86863
	protected abstract int GetWeaponGoalUpgradeLevel();

	// Token: 0x06015350 RID: 86864
	protected abstract int GetWeaponGoalBreakLevel();

	// Token: 0x06015351 RID: 86865
	protected abstract List<global::IRoleDevDetailItemData> GetDetailItems();

	// Token: 0x06015352 RID: 86866
	protected abstract string GetWeaponName();

	// Token: 0x06015353 RID: 86867
	protected abstract bool GetIsCanUpgrade();

	// Token: 0x06015354 RID: 86868
	protected abstract bool GetIsCanBreach();

	// Token: 0x06015355 RID: 86869
	protected abstract bool GetIsCall();

	// Token: 0x06015356 RID: 86870
	protected abstract int GetGachaId();

	// Token: 0x06015357 RID: 86871
	protected abstract int GetWeaponConfigId();

	// Token: 0x06015358 RID: 86872
	protected abstract bool GetIsHighQuality();

	// Token: 0x17001C17 RID: 7191
	// (get) Token: 0x06015359 RID: 86873 RVA: 0x0055CC9D File Offset: 0x0055AE9D
	public int WeaponLevel
	{
		get
		{
			return this.GetWeaponLevel();
		}
	}

	// Token: 0x17001C18 RID: 7192
	// (get) Token: 0x0601535A RID: 86874 RVA: 0x0055CCA5 File Offset: 0x0055AEA5
	public int WeaponBreachLevel
	{
		get
		{
			return this.GetWeaponBreachLevel();
		}
	}

	// Token: 0x17001C19 RID: 7193
	// (get) Token: 0x0601535B RID: 86875 RVA: 0x0055CCAD File Offset: 0x0055AEAD
	public int WeaponGoalUpgradeLevel
	{
		get
		{
			return this.GetWeaponGoalUpgradeLevel();
		}
	}

	// Token: 0x17001C1A RID: 7194
	// (get) Token: 0x0601535C RID: 86876 RVA: 0x0055CCB5 File Offset: 0x0055AEB5
	public int WeaponGoalBreakLevel
	{
		get
		{
			return this.GetWeaponGoalBreakLevel();
		}
	}

	// Token: 0x17001C1B RID: 7195
	// (get) Token: 0x0601535D RID: 86877 RVA: 0x0055CCBD File Offset: 0x0055AEBD
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.GetDetailItems();
		}
	}

	// Token: 0x17001C1C RID: 7196
	// (get) Token: 0x0601535E RID: 86878 RVA: 0x0055CCC5 File Offset: 0x0055AEC5
	public string WeaponName
	{
		get
		{
			return this.GetWeaponName();
		}
	}

	// Token: 0x17001C1D RID: 7197
	// (get) Token: 0x0601535F RID: 86879 RVA: 0x0055CCCD File Offset: 0x0055AECD
	public bool IsCanUpgrade
	{
		get
		{
			return this.GetIsCanUpgrade();
		}
	}

	// Token: 0x17001C1E RID: 7198
	// (get) Token: 0x06015360 RID: 86880 RVA: 0x0055CCD5 File Offset: 0x0055AED5
	public bool IsCanBreach
	{
		get
		{
			return this.GetIsCanBreach();
		}
	}

	// Token: 0x17001C1F RID: 7199
	// (get) Token: 0x06015361 RID: 86881 RVA: 0x0055CCDD File Offset: 0x0055AEDD
	public bool IsCall
	{
		get
		{
			return this.GetIsCall();
		}
	}

	// Token: 0x17001C20 RID: 7200
	// (get) Token: 0x06015362 RID: 86882 RVA: 0x0055CCE5 File Offset: 0x0055AEE5
	public int GachaId
	{
		get
		{
			return this.GetGachaId();
		}
	}

	// Token: 0x17001C21 RID: 7201
	// (get) Token: 0x06015363 RID: 86883 RVA: 0x0055CCED File Offset: 0x0055AEED
	public int WeaponConfigId
	{
		get
		{
			return this.GetWeaponConfigId();
		}
	}

	// Token: 0x17001C22 RID: 7202
	// (get) Token: 0x06015364 RID: 86884 RVA: 0x0055CCF5 File Offset: 0x0055AEF5
	public bool IsHighQuality
	{
		get
		{
			return this.GetIsHighQuality();
		}
	}

	// Token: 0x17001C23 RID: 7203
	// (get) Token: 0x06015365 RID: 86885 RVA: 0x0055CCFD File Offset: 0x0055AEFD
	public bool IsCanShowUpgradeItem
	{
		get
		{
			return this.WeaponLevel < this.WeaponGoalUpgradeLevel;
		}
	}

	// Token: 0x17001C24 RID: 7204
	// (get) Token: 0x06015366 RID: 86886 RVA: 0x0055CD0D File Offset: 0x0055AF0D
	public bool IsCanShowBreachItem
	{
		get
		{
			return this.WeaponBreachLevel < this.WeaponGoalBreakLevel;
		}
	}

	// Token: 0x17001C25 RID: 7205
	// (get) Token: 0x06015367 RID: 86887 RVA: 0x0055CD1D File Offset: 0x0055AF1D
	public bool IsFinish
	{
		get
		{
			return !this.IsCanShowUpgradeItem && !this.IsCanShowBreachItem;
		}
	}

	// Token: 0x17001C26 RID: 7206
	// (get) Token: 0x06015368 RID: 86888 RVA: 0x0055CD32 File Offset: 0x0055AF32
	public bool IsAllMaterialEnough
	{
		get
		{
			return RoleDevUtils.CheckAllItemsUp(this.DetailItems);
		}
	}

	// Token: 0x17001C27 RID: 7207
	// (get) Token: 0x06015369 RID: 86889 RVA: 0x0055CD3F File Offset: 0x0055AF3F
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001C28 RID: 7208
	// (get) Token: 0x0601536A RID: 86890 RVA: 0x0055CD4A File Offset: 0x0055AF4A
	public bool WeaponIsMaxLevel
	{
		get
		{
			return this.WeaponLevel >= this.GetMaxLevel();
		}
	}

	// Token: 0x0601536B RID: 86891
	protected abstract int GetMaxLevel();

	// Token: 0x04009E9C RID: 40604
	protected int RoleIdInternal;

	// Token: 0x04009E9D RID: 40605
	protected ERoleDevDataType RoleTypeInternal;
}
