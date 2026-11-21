using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001DAF RID: 7599
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x06012D6D RID: 77165 RVA: 0x00587B25 File Offset: 0x00585D25
	public void InitByRoleId(int roleId)
	{
		this.RoleIdInternal = roleId;
		this.InitByRoleType(roleId);
	}

	// Token: 0x06012D6E RID: 77166
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001C81 RID: 7297
	// (get) Token: 0x06012D6F RID: 77167 RVA: 0x00587B35 File Offset: 0x00585D35
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C82 RID: 7298
	// (get) Token: 0x06012D70 RID: 77168 RVA: 0x00587B3D File Offset: 0x00585D3D
	public bool IsRoleObtained
	{
		get
		{
			return RoleModel.Instance.GetRoleInstanceById(this.RoleId) != null;
		}
	}

	// Token: 0x17001C83 RID: 7299
	// (get) Token: 0x06012D71 RID: 77169 RVA: 0x00587B52 File Offset: 0x00585D52
	public List<RoleDevWeaponSubRecommendItemDataBase> SubRecommendItems
	{
		get
		{
			return this.SubRecommendItemsInternal;
		}
	}

	// Token: 0x06012D72 RID: 77170
	protected abstract int GetWeaponConfigId();

	// Token: 0x06012D73 RID: 77171
	protected abstract string GetWeaponName();

	// Token: 0x06012D74 RID: 77172
	protected abstract int GetWeaponLevel();

	// Token: 0x06012D75 RID: 77173
	protected abstract int GetWeaponGoalUpgradeLevel();

	// Token: 0x06012D76 RID: 77174
	protected abstract bool GetIsCall();

	// Token: 0x06012D77 RID: 77175
	protected abstract int GetGachaId();

	// Token: 0x06012D78 RID: 77176
	protected abstract bool GetIsWeaponHighQuality();

	// Token: 0x06012D79 RID: 77177
	protected abstract bool GetIsObtained();

	// Token: 0x06012D7A RID: 77178
	protected abstract bool GetIsForecast();

	// Token: 0x17001C84 RID: 7300
	// (get) Token: 0x06012D7B RID: 77179 RVA: 0x00587B5A File Offset: 0x00585D5A
	public int WeaponConfigId
	{
		get
		{
			return this.GetWeaponConfigId();
		}
	}

	// Token: 0x17001C85 RID: 7301
	// (get) Token: 0x06012D7C RID: 77180 RVA: 0x00587B62 File Offset: 0x00585D62
	public string WeaponName
	{
		get
		{
			return this.GetWeaponName();
		}
	}

	// Token: 0x17001C86 RID: 7302
	// (get) Token: 0x06012D7D RID: 77181 RVA: 0x00587B6A File Offset: 0x00585D6A
	public int WeaponLevel
	{
		get
		{
			return this.GetWeaponLevel();
		}
	}

	// Token: 0x17001C87 RID: 7303
	// (get) Token: 0x06012D7E RID: 77182 RVA: 0x00587B72 File Offset: 0x00585D72
	public int WeaponGoalUpgradeLevel
	{
		get
		{
			return this.GetWeaponGoalUpgradeLevel();
		}
	}

	// Token: 0x17001C88 RID: 7304
	// (get) Token: 0x06012D7F RID: 77183 RVA: 0x00587B7A File Offset: 0x00585D7A
	public bool IsCall
	{
		get
		{
			return this.GetIsCall();
		}
	}

	// Token: 0x17001C89 RID: 7305
	// (get) Token: 0x06012D80 RID: 77184 RVA: 0x00587B82 File Offset: 0x00585D82
	public int GachaId
	{
		get
		{
			return this.GetGachaId();
		}
	}

	// Token: 0x17001C8A RID: 7306
	// (get) Token: 0x06012D81 RID: 77185 RVA: 0x00587B8A File Offset: 0x00585D8A
	public bool IsWeaponHighQuality
	{
		get
		{
			return this.GetIsWeaponHighQuality();
		}
	}

	// Token: 0x17001C8B RID: 7307
	// (get) Token: 0x06012D82 RID: 77186 RVA: 0x00587B92 File Offset: 0x00585D92
	public bool IsObtained
	{
		get
		{
			return this.GetIsObtained();
		}
	}

	// Token: 0x17001C8C RID: 7308
	// (get) Token: 0x06012D83 RID: 77187 RVA: 0x00587B9A File Offset: 0x00585D9A
	public bool IsForecast
	{
		get
		{
			return this.GetIsForecast();
		}
	}

	// Token: 0x06012D84 RID: 77188 RVA: 0x00587BA4 File Offset: 0x00585DA4
	protected void InitSubRecommendItems(int roleId)
	{
		this.SubRecommendItemsInternal.Clear();
		int[] weaponRecommendListConfig = RoleDevConfig.Instance.GetWeaponRecommendListConfig(roleId);
		if (weaponRecommendListConfig == null || weaponRecommendListConfig.Length == 0)
		{
			return;
		}
		foreach (int weaponId in weaponRecommendListConfig)
		{
			RoleDevWeaponSubRecommendItemDataBase roleDevWeaponSubRecommendItemDataBase = new RoleDevWeaponSubRecommendItemDataBase();
			roleDevWeaponSubRecommendItemDataBase.InitByWeaponId(weaponId, roleId);
			this.SubRecommendItemsInternal.Add(roleDevWeaponSubRecommendItemDataBase);
		}
	}

	// Token: 0x06012D85 RID: 77189 RVA: 0x00587C04 File Offset: 0x00585E04
	public bool IsEquipRecommendWeapon()
	{
		int weaponConfigId = this.GetWeaponConfigId();
		if (weaponConfigId <= 0)
		{
			return false;
		}
		using (List<RoleDevWeaponSubRecommendItemDataBase>.Enumerator enumerator = this.SubRecommendItemsInternal.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.WeaponId == weaponConfigId)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0400A287 RID: 41607
	protected int RoleIdInternal;

	// Token: 0x0400A288 RID: 41608
	protected readonly List<RoleDevWeaponSubRecommendItemDataBase> SubRecommendItemsInternal = new List<RoleDevWeaponSubRecommendItemDataBase>();
}
