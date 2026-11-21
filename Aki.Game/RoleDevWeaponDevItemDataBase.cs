using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DAD RID: 7597
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevWeaponDevItemDataBase
{
	// Token: 0x06012D47 RID: 77127 RVA: 0x005879D2 File Offset: 0x00585BD2
	public void InitByRoleId(int roleId, ERoleDevDataType roleType)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.InitByRoleType(roleId);
	}

	// Token: 0x06012D48 RID: 77128
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001C6D RID: 7277
	// (get) Token: 0x06012D49 RID: 77129 RVA: 0x005879E9 File Offset: 0x00585BE9
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C6E RID: 7278
	// (get) Token: 0x06012D4A RID: 77130 RVA: 0x005879F1 File Offset: 0x00585BF1
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x06012D4B RID: 77131
	protected abstract int GetWeaponLevel();

	// Token: 0x06012D4C RID: 77132
	protected abstract int GetWeaponBreachLevel();

	// Token: 0x06012D4D RID: 77133
	protected abstract int GetWeaponGoalUpgradeLevel();

	// Token: 0x06012D4E RID: 77134
	protected abstract int GetWeaponGoalBreakLevel();

	// Token: 0x06012D4F RID: 77135
	protected abstract List<global::IRoleDevDetailItemData> GetDetailItems();

	// Token: 0x06012D50 RID: 77136
	protected abstract string GetWeaponName();

	// Token: 0x06012D51 RID: 77137
	protected abstract bool GetIsCanUpgrade();

	// Token: 0x06012D52 RID: 77138
	protected abstract bool GetIsCanBreach();

	// Token: 0x06012D53 RID: 77139
	protected abstract bool GetIsCall();

	// Token: 0x06012D54 RID: 77140
	protected abstract int GetGachaId();

	// Token: 0x06012D55 RID: 77141
	protected abstract int GetWeaponConfigId();

	// Token: 0x06012D56 RID: 77142
	protected abstract bool GetIsHighQuality();

	// Token: 0x17001C6F RID: 7279
	// (get) Token: 0x06012D57 RID: 77143 RVA: 0x005879F9 File Offset: 0x00585BF9
	public int WeaponLevel
	{
		get
		{
			return this.GetWeaponLevel();
		}
	}

	// Token: 0x17001C70 RID: 7280
	// (get) Token: 0x06012D58 RID: 77144 RVA: 0x00587A01 File Offset: 0x00585C01
	public int WeaponBreachLevel
	{
		get
		{
			return this.GetWeaponBreachLevel();
		}
	}

	// Token: 0x17001C71 RID: 7281
	// (get) Token: 0x06012D59 RID: 77145 RVA: 0x00587A09 File Offset: 0x00585C09
	public int WeaponGoalUpgradeLevel
	{
		get
		{
			return this.GetWeaponGoalUpgradeLevel();
		}
	}

	// Token: 0x17001C72 RID: 7282
	// (get) Token: 0x06012D5A RID: 77146 RVA: 0x00587A11 File Offset: 0x00585C11
	public int WeaponGoalBreakLevel
	{
		get
		{
			return this.GetWeaponGoalBreakLevel();
		}
	}

	// Token: 0x17001C73 RID: 7283
	// (get) Token: 0x06012D5B RID: 77147 RVA: 0x00587A19 File Offset: 0x00585C19
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.GetDetailItems();
		}
	}

	// Token: 0x17001C74 RID: 7284
	// (get) Token: 0x06012D5C RID: 77148 RVA: 0x00587A21 File Offset: 0x00585C21
	public string WeaponName
	{
		get
		{
			return this.GetWeaponName();
		}
	}

	// Token: 0x17001C75 RID: 7285
	// (get) Token: 0x06012D5D RID: 77149 RVA: 0x00587A29 File Offset: 0x00585C29
	public bool IsCanUpgrade
	{
		get
		{
			return this.GetIsCanUpgrade();
		}
	}

	// Token: 0x17001C76 RID: 7286
	// (get) Token: 0x06012D5E RID: 77150 RVA: 0x00587A31 File Offset: 0x00585C31
	public bool IsCanBreach
	{
		get
		{
			return this.GetIsCanBreach();
		}
	}

	// Token: 0x17001C77 RID: 7287
	// (get) Token: 0x06012D5F RID: 77151 RVA: 0x00587A39 File Offset: 0x00585C39
	public bool IsCall
	{
		get
		{
			return this.GetIsCall();
		}
	}

	// Token: 0x17001C78 RID: 7288
	// (get) Token: 0x06012D60 RID: 77152 RVA: 0x00587A41 File Offset: 0x00585C41
	public int GachaId
	{
		get
		{
			return this.GetGachaId();
		}
	}

	// Token: 0x17001C79 RID: 7289
	// (get) Token: 0x06012D61 RID: 77153 RVA: 0x00587A49 File Offset: 0x00585C49
	public int WeaponConfigId
	{
		get
		{
			return this.GetWeaponConfigId();
		}
	}

	// Token: 0x17001C7A RID: 7290
	// (get) Token: 0x06012D62 RID: 77154 RVA: 0x00587A51 File Offset: 0x00585C51
	public bool IsHighQuality
	{
		get
		{
			return this.GetIsHighQuality();
		}
	}

	// Token: 0x17001C7B RID: 7291
	// (get) Token: 0x06012D63 RID: 77155 RVA: 0x00587A59 File Offset: 0x00585C59
	public bool IsCanShowUpgradeItem
	{
		get
		{
			return this.WeaponLevel < this.WeaponGoalUpgradeLevel;
		}
	}

	// Token: 0x17001C7C RID: 7292
	// (get) Token: 0x06012D64 RID: 77156 RVA: 0x00587A69 File Offset: 0x00585C69
	public bool IsCanShowBreachItem
	{
		get
		{
			return this.WeaponBreachLevel < this.WeaponGoalBreakLevel;
		}
	}

	// Token: 0x17001C7D RID: 7293
	// (get) Token: 0x06012D65 RID: 77157 RVA: 0x00587A79 File Offset: 0x00585C79
	public bool IsFinish
	{
		get
		{
			return !this.IsCanShowUpgradeItem && !this.IsCanShowBreachItem;
		}
	}

	// Token: 0x17001C7E RID: 7294
	// (get) Token: 0x06012D66 RID: 77158 RVA: 0x00587A8E File Offset: 0x00585C8E
	public bool IsAllMaterialEnough
	{
		get
		{
			return RoleDevUtils.CheckAllItemsUp(this.DetailItems);
		}
	}

	// Token: 0x17001C7F RID: 7295
	// (get) Token: 0x06012D67 RID: 77159 RVA: 0x00587A9B File Offset: 0x00585C9B
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001C80 RID: 7296
	// (get) Token: 0x06012D68 RID: 77160 RVA: 0x00587AA6 File Offset: 0x00585CA6
	public bool WeaponIsMaxLevel
	{
		get
		{
			return this.WeaponLevel >= this.GetMaxLevel();
		}
	}

	// Token: 0x06012D69 RID: 77161
	protected abstract int GetMaxLevel();

	// Token: 0x0400A285 RID: 41605
	protected int RoleIdInternal;

	// Token: 0x0400A286 RID: 41606
	protected ERoleDevDataType RoleTypeInternal;
}
