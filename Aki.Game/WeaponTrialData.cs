using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002253 RID: 8787
[NullableContext(2)]
[Nullable(0)]
public class WeaponTrialData : WeaponDataBase
{
	// Token: 0x06015B91 RID: 88977 RVA: 0x0064CD21 File Offset: 0x0064AF21
	public void SetTrialId(int trialId, bool needFullLevelWeaponData = true)
	{
		this.TrialId = trialId;
		this.TrialConfig = WeaponConfig.Instance.GetTrialWeaponConfig(this.TrialId);
		this.InitWeaponBreachLevel();
		if (needFullLevelWeaponData)
		{
			this.InitFullLevelWeaponData();
			return;
		}
		this.FullLevelWeaponData = null;
	}

	// Token: 0x06015B92 RID: 88978 RVA: 0x0064CD58 File Offset: 0x0064AF58
	protected void InitWeaponBreachLevel()
	{
		IEnumerable<WeaponBreach> breachConfigList = base.GetBreachConfigList();
		int level = this.GetLevel();
		foreach (WeaponBreach weaponBreach in breachConfigList)
		{
			if (level <= weaponBreach.LevelLimit)
			{
				this.BreachLevel = weaponBreach.Level;
				break;
			}
		}
	}

	// Token: 0x06015B93 RID: 88979 RVA: 0x0064CDC0 File Offset: 0x0064AFC0
	protected void InitFullLevelWeaponData()
	{
		int fullLevelTrialId = this.TrialConfig.Value.FullLevelTrialId;
		if (fullLevelTrialId <= 0)
		{
			return;
		}
		TrialWeaponInfo? trialWeaponConfig = WeaponConfig.Instance.GetTrialWeaponConfig(fullLevelTrialId);
		if (trialWeaponConfig == null)
		{
			this.FullLevelWeaponData = null;
			return;
		}
		this.FullLevelWeaponData = new WeaponTrialData();
		this.FullLevelWeaponData.SetTrialId(trialWeaponConfig.Value.Id, false);
	}

	// Token: 0x06015B94 RID: 88980 RVA: 0x0064CE2C File Offset: 0x0064B02C
	public override int GetItemId()
	{
		return this.TrialConfig.Value.WeaponId;
	}

	// Token: 0x06015B95 RID: 88981 RVA: 0x0064CE4C File Offset: 0x0064B04C
	public int GetSkinId()
	{
		if (this.TrialConfig.Value.WeaponSkinId > 0)
		{
			return this.TrialConfig.Value.WeaponSkinId;
		}
		return -1;
	}

	// Token: 0x06015B96 RID: 88982 RVA: 0x0064CE84 File Offset: 0x0064B084
	public override int GetLevel()
	{
		return this.TrialConfig.Value.WeaponLevel;
	}

	// Token: 0x06015B97 RID: 88983 RVA: 0x0064CEA4 File Offset: 0x0064B0A4
	public override int GetResonanceLevel()
	{
		return this.TrialConfig.Value.WeaponResonanceLevel;
	}

	// Token: 0x06015B98 RID: 88984 RVA: 0x0064CEC4 File Offset: 0x0064B0C4
	public override int GetBreachLevel()
	{
		return this.BreachLevel;
	}

	// Token: 0x06015B99 RID: 88985 RVA: 0x0064CECC File Offset: 0x0064B0CC
	public override bool HasRole()
	{
		return this.RoleId != 0;
	}

	// Token: 0x06015B9A RID: 88986 RVA: 0x0064CED7 File Offset: 0x0064B0D7
	public override void SetRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06015B9B RID: 88987 RVA: 0x0064CEE0 File Offset: 0x0064B0E0
	public override int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x06015B9C RID: 88988 RVA: 0x0064CEE8 File Offset: 0x0064B0E8
	public override bool IsTrial()
	{
		return true;
	}

	// Token: 0x06015B9D RID: 88989 RVA: 0x0064CEEB File Offset: 0x0064B0EB
	public override bool CanGoBreach()
	{
		return false;
	}

	// Token: 0x06015B9E RID: 88990 RVA: 0x0064CEEE File Offset: 0x0064B0EE
	public TrialWeaponInfo? GetTrialConfig()
	{
		return this.TrialConfig;
	}

	// Token: 0x06015B9F RID: 88991 RVA: 0x0064CEF6 File Offset: 0x0064B0F6
	public WeaponTrialData GetFullLevelWeaponData()
	{
		return this.FullLevelWeaponData;
	}

	// Token: 0x0400B747 RID: 46919
	protected int TrialId;

	// Token: 0x0400B748 RID: 46920
	protected TrialWeaponInfo? TrialConfig;

	// Token: 0x0400B749 RID: 46921
	protected WeaponTrialData FullLevelWeaponData;

	// Token: 0x0400B74A RID: 46922
	protected int RoleId;

	// Token: 0x0400B74B RID: 46923
	protected int BreachLevel;
}
