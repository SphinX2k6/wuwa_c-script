using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002CF9 RID: 11513
[NullableContext(2)]
[Nullable(0)]
public class WeaponTrialData : WeaponDataBase
{
	// Token: 0x060182F0 RID: 99056 RVA: 0x00626D59 File Offset: 0x00624F59
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

	// Token: 0x060182F1 RID: 99057 RVA: 0x00626D90 File Offset: 0x00624F90
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

	// Token: 0x060182F2 RID: 99058 RVA: 0x00626DF8 File Offset: 0x00624FF8
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

	// Token: 0x060182F3 RID: 99059 RVA: 0x00626E64 File Offset: 0x00625064
	public override int GetItemId()
	{
		return this.TrialConfig.Value.WeaponId;
	}

	// Token: 0x060182F4 RID: 99060 RVA: 0x00626E84 File Offset: 0x00625084
	public int GetSkinId()
	{
		if (this.TrialConfig.Value.WeaponSkinId > 0)
		{
			return this.TrialConfig.Value.WeaponSkinId;
		}
		return -1;
	}

	// Token: 0x060182F5 RID: 99061 RVA: 0x00626EBC File Offset: 0x006250BC
	public override int GetLevel()
	{
		return this.TrialConfig.Value.WeaponLevel;
	}

	// Token: 0x060182F6 RID: 99062 RVA: 0x00626EDC File Offset: 0x006250DC
	public override int GetResonanceLevel()
	{
		return this.TrialConfig.Value.WeaponResonanceLevel;
	}

	// Token: 0x060182F7 RID: 99063 RVA: 0x00626EFC File Offset: 0x006250FC
	public override int GetBreachLevel()
	{
		return this.BreachLevel;
	}

	// Token: 0x060182F8 RID: 99064 RVA: 0x00626F04 File Offset: 0x00625104
	public override bool HasRole()
	{
		return this.RoleId != 0;
	}

	// Token: 0x060182F9 RID: 99065 RVA: 0x00626F0F File Offset: 0x0062510F
	public override void SetRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x060182FA RID: 99066 RVA: 0x00626F18 File Offset: 0x00625118
	public override int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x060182FB RID: 99067 RVA: 0x00626F20 File Offset: 0x00625120
	public override bool IsTrial()
	{
		return true;
	}

	// Token: 0x060182FC RID: 99068 RVA: 0x00626F23 File Offset: 0x00625123
	public override bool CanGoBreach()
	{
		return false;
	}

	// Token: 0x060182FD RID: 99069 RVA: 0x00626F26 File Offset: 0x00625126
	public TrialWeaponInfo? GetTrialConfig()
	{
		return this.TrialConfig;
	}

	// Token: 0x060182FE RID: 99070 RVA: 0x00626F2E File Offset: 0x0062512E
	public WeaponTrialData GetFullLevelWeaponData()
	{
		return this.FullLevelWeaponData;
	}

	// Token: 0x0400B3D2 RID: 46034
	protected int TrialId;

	// Token: 0x0400B3D3 RID: 46035
	protected TrialWeaponInfo? TrialConfig;

	// Token: 0x0400B3D4 RID: 46036
	protected WeaponTrialData FullLevelWeaponData;

	// Token: 0x0400B3D5 RID: 46037
	protected int RoleId;

	// Token: 0x0400B3D6 RID: 46038
	protected int BreachLevel;
}
