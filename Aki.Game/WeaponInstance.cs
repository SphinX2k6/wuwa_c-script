using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02002D17 RID: 11543
public class WeaponInstance : WeaponDataBase
{
	// Token: 0x0601841D RID: 99357 RVA: 0x0062C2AB File Offset: 0x0062A4AB
	[NullableContext(1)]
	public void SetWeaponItem(WeaponItem weaponItem)
	{
		this.WeaponItem = weaponItem;
	}

	// Token: 0x0601841E RID: 99358 RVA: 0x0062C2B4 File Offset: 0x0062A4B4
	public void SetLevel(int level)
	{
		this.WeaponItem.WeaponLevel = level;
	}

	// Token: 0x0601841F RID: 99359 RVA: 0x0062C2C2 File Offset: 0x0062A4C2
	public override int GetLevel()
	{
		return this.WeaponItem.WeaponLevel;
	}

	// Token: 0x06018420 RID: 99360 RVA: 0x0062C2CF File Offset: 0x0062A4CF
	public void SetExp(int exp)
	{
		this.WeaponItem.WeaponExp = exp;
	}

	// Token: 0x06018421 RID: 99361 RVA: 0x0062C2DD File Offset: 0x0062A4DD
	public int GetExp()
	{
		return this.WeaponItem.WeaponExp;
	}

	// Token: 0x06018422 RID: 99362 RVA: 0x0062C2EA File Offset: 0x0062A4EA
	public void SetResonanceLevel(int resonanceLevel)
	{
		this.WeaponItem.WeaponResonLevel = resonanceLevel;
	}

	// Token: 0x06018423 RID: 99363 RVA: 0x0062C2F8 File Offset: 0x0062A4F8
	public override int GetResonanceLevel()
	{
		return this.WeaponItem.WeaponResonLevel;
	}

	// Token: 0x06018424 RID: 99364 RVA: 0x0062C305 File Offset: 0x0062A505
	public void SetBreachLevel(int breachLevel)
	{
		this.WeaponItem.WeaponBreach = breachLevel;
	}

	// Token: 0x06018425 RID: 99365 RVA: 0x0062C313 File Offset: 0x0062A513
	public override int GetBreachLevel()
	{
		return this.WeaponItem.WeaponBreach;
	}

	// Token: 0x06018426 RID: 99366 RVA: 0x0062C320 File Offset: 0x0062A520
	public int? GetIncId()
	{
		return new int?(this.WeaponItem.IncrId);
	}

	// Token: 0x06018427 RID: 99367 RVA: 0x0062C334 File Offset: 0x0062A534
	public override int GetItemId()
	{
		int? incId = this.GetIncId();
		return InventoryModel.Instance.GetWeaponItemData(incId.Value).GetConfigId();
	}

	// Token: 0x06018428 RID: 99368 RVA: 0x0062C360 File Offset: 0x0062A560
	public bool IsLock()
	{
		int? incId = this.GetIncId();
		return InventoryModel.Instance.GetWeaponItemData(incId.Value).GetIsLock();
	}

	// Token: 0x06018429 RID: 99369 RVA: 0x0062C38A File Offset: 0x0062A58A
	public override bool IsTrial()
	{
		return false;
	}

	// Token: 0x0601842A RID: 99370 RVA: 0x0062C38D File Offset: 0x0062A58D
	public override bool HasRole()
	{
		return this.GetRoleId() > 0;
	}

	// Token: 0x0601842B RID: 99371 RVA: 0x0062C398 File Offset: 0x0062A598
	public override void SetRoleId(int roleId)
	{
		this.WeaponItem.RoleId = roleId;
	}

	// Token: 0x0601842C RID: 99372 RVA: 0x0062C3A6 File Offset: 0x0062A5A6
	public override int GetRoleId()
	{
		return this.WeaponItem.RoleId;
	}

	// Token: 0x0601842D RID: 99373 RVA: 0x0062C3B4 File Offset: 0x0062A5B4
	public int GetMaterialExp()
	{
		int qualityId = base.GetItemConfig().QualityId;
		WeaponQualityInfo? weaponQualityInfo = WeaponConfig.Instance.GetWeaponQualityInfo(qualityId);
		int exp = this.GetExp();
		int level = this.GetLevel();
		if (exp <= 0 && level == 1)
		{
			return weaponQualityInfo.Value.BasicExp;
		}
		float weaponExpCoefficient = WeaponConfig.Instance.GetWeaponExpCoefficient();
		return (int)Math.Floor((double)((float)weaponQualityInfo.Value.BasicExp + (float)(base.GetLastLevelMaxExp() + exp) * weaponExpCoefficient));
	}

	// Token: 0x0601842E RID: 99374 RVA: 0x0062C438 File Offset: 0x0062A638
	public bool HasWeaponCultivated()
	{
		bool flag = this.GetResonanceLevel() > 1;
		bool flag2 = this.GetLevel() > 1;
		bool flag3 = this.GetExp() > 0;
		return flag || flag2 || flag3;
	}

	// Token: 0x0400B438 RID: 46136
	[Nullable(2)]
	protected WeaponItem WeaponItem;
}
