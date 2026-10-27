using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002834 RID: 10292
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x0601536F RID: 86895 RVA: 0x0055CDC9 File Offset: 0x0055AFC9
	public void InitByRoleId(int roleId)
	{
		this.RoleIdInternal = roleId;
		this.InitByRoleType(roleId);
	}

	// Token: 0x06015370 RID: 86896
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001C29 RID: 7209
	// (get) Token: 0x06015371 RID: 86897 RVA: 0x0055CDD9 File Offset: 0x0055AFD9
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C2A RID: 7210
	// (get) Token: 0x06015372 RID: 86898 RVA: 0x0055CDE1 File Offset: 0x0055AFE1
	public bool IsRoleObtained
	{
		get
		{
			return RoleModel.Instance.GetRoleInstanceById(this.RoleId) != null;
		}
	}

	// Token: 0x17001C2B RID: 7211
	// (get) Token: 0x06015373 RID: 86899 RVA: 0x0055CDF6 File Offset: 0x0055AFF6
	public List<RoleDevWeaponSubRecommendItemDataBase> SubRecommendItems
	{
		get
		{
			return this.SubRecommendItemsInternal;
		}
	}

	// Token: 0x06015374 RID: 86900
	protected abstract int GetWeaponConfigId();

	// Token: 0x06015375 RID: 86901
	protected abstract string GetWeaponName();

	// Token: 0x06015376 RID: 86902
	protected abstract int GetWeaponLevel();

	// Token: 0x06015377 RID: 86903
	protected abstract int GetWeaponGoalUpgradeLevel();

	// Token: 0x06015378 RID: 86904
	protected abstract bool GetIsCall();

	// Token: 0x06015379 RID: 86905
	protected abstract int GetGachaId();

	// Token: 0x0601537A RID: 86906
	protected abstract bool GetIsWeaponHighQuality();

	// Token: 0x0601537B RID: 86907
	protected abstract bool GetIsObtained();

	// Token: 0x0601537C RID: 86908
	protected abstract bool GetIsForecast();

	// Token: 0x17001C2C RID: 7212
	// (get) Token: 0x0601537D RID: 86909 RVA: 0x0055CDFE File Offset: 0x0055AFFE
	public int WeaponConfigId
	{
		get
		{
			return this.GetWeaponConfigId();
		}
	}

	// Token: 0x17001C2D RID: 7213
	// (get) Token: 0x0601537E RID: 86910 RVA: 0x0055CE06 File Offset: 0x0055B006
	public string WeaponName
	{
		get
		{
			return this.GetWeaponName();
		}
	}

	// Token: 0x17001C2E RID: 7214
	// (get) Token: 0x0601537F RID: 86911 RVA: 0x0055CE0E File Offset: 0x0055B00E
	public int WeaponLevel
	{
		get
		{
			return this.GetWeaponLevel();
		}
	}

	// Token: 0x17001C2F RID: 7215
	// (get) Token: 0x06015380 RID: 86912 RVA: 0x0055CE16 File Offset: 0x0055B016
	public int WeaponGoalUpgradeLevel
	{
		get
		{
			return this.GetWeaponGoalUpgradeLevel();
		}
	}

	// Token: 0x17001C30 RID: 7216
	// (get) Token: 0x06015381 RID: 86913 RVA: 0x0055CE1E File Offset: 0x0055B01E
	public bool IsCall
	{
		get
		{
			return this.GetIsCall();
		}
	}

	// Token: 0x17001C31 RID: 7217
	// (get) Token: 0x06015382 RID: 86914 RVA: 0x0055CE26 File Offset: 0x0055B026
	public int GachaId
	{
		get
		{
			return this.GetGachaId();
		}
	}

	// Token: 0x17001C32 RID: 7218
	// (get) Token: 0x06015383 RID: 86915 RVA: 0x0055CE2E File Offset: 0x0055B02E
	public bool IsWeaponHighQuality
	{
		get
		{
			return this.GetIsWeaponHighQuality();
		}
	}

	// Token: 0x17001C33 RID: 7219
	// (get) Token: 0x06015384 RID: 86916 RVA: 0x0055CE36 File Offset: 0x0055B036
	public bool IsObtained
	{
		get
		{
			return this.GetIsObtained();
		}
	}

	// Token: 0x17001C34 RID: 7220
	// (get) Token: 0x06015385 RID: 86917 RVA: 0x0055CE3E File Offset: 0x0055B03E
	public bool IsForecast
	{
		get
		{
			return this.GetIsForecast();
		}
	}

	// Token: 0x06015386 RID: 86918 RVA: 0x0055CE48 File Offset: 0x0055B048
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

	// Token: 0x06015387 RID: 86919 RVA: 0x0055CEA8 File Offset: 0x0055B0A8
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

	// Token: 0x04009E9E RID: 40606
	protected int RoleIdInternal;

	// Token: 0x04009E9F RID: 40607
	protected readonly List<RoleDevWeaponSubRecommendItemDataBase> SubRecommendItemsInternal = new List<RoleDevWeaponSubRecommendItemDataBase>();
}
