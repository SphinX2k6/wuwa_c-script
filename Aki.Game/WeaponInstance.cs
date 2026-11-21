using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02002271 RID: 8817
public class WeaponInstance : WeaponDataBase
{
	// Token: 0x06015CBE RID: 89278 RVA: 0x0065229F File Offset: 0x0065049F
	[NullableContext(1)]
	public void SetWeaponItem(WeaponItem weaponItem)
	{
		this.WeaponItem = weaponItem;
	}

	// Token: 0x06015CBF RID: 89279 RVA: 0x006522A8 File Offset: 0x006504A8
	public void SetLevel(int level)
	{
		this.WeaponItem.WeaponLevel = level;
	}

	// Token: 0x06015CC0 RID: 89280 RVA: 0x006522B6 File Offset: 0x006504B6
	public override int GetLevel()
	{
		return this.WeaponItem.WeaponLevel;
	}

	// Token: 0x06015CC1 RID: 89281 RVA: 0x006522C3 File Offset: 0x006504C3
	public void SetExp(int exp)
	{
		this.WeaponItem.WeaponExp = exp;
	}

	// Token: 0x06015CC2 RID: 89282 RVA: 0x006522D1 File Offset: 0x006504D1
	public int GetExp()
	{
		return this.WeaponItem.WeaponExp;
	}

	// Token: 0x06015CC3 RID: 89283 RVA: 0x006522DE File Offset: 0x006504DE
	public void SetResonanceLevel(int resonanceLevel)
	{
		this.WeaponItem.WeaponResonLevel = resonanceLevel;
	}

	// Token: 0x06015CC4 RID: 89284 RVA: 0x006522EC File Offset: 0x006504EC
	public override int GetResonanceLevel()
	{
		return this.WeaponItem.WeaponResonLevel;
	}

	// Token: 0x06015CC5 RID: 89285 RVA: 0x006522F9 File Offset: 0x006504F9
	public void SetBreachLevel(int breachLevel)
	{
		this.WeaponItem.WeaponBreach = breachLevel;
	}

	// Token: 0x06015CC6 RID: 89286 RVA: 0x00652307 File Offset: 0x00650507
	public override int GetBreachLevel()
	{
		return this.WeaponItem.WeaponBreach;
	}

	// Token: 0x06015CC7 RID: 89287 RVA: 0x00652314 File Offset: 0x00650514
	public int? GetIncId()
	{
		return new int?(this.WeaponItem.IncrId);
	}

	// Token: 0x06015CC8 RID: 89288 RVA: 0x00652328 File Offset: 0x00650528
	public override int GetItemId()
	{
		int? incId = this.GetIncId();
		return InventoryModel.Instance.GetWeaponItemData(incId.Value).GetConfigId();
	}

	// Token: 0x06015CC9 RID: 89289 RVA: 0x00652354 File Offset: 0x00650554
	public bool IsLock()
	{
		int? incId = this.GetIncId();
		return InventoryModel.Instance.GetWeaponItemData(incId.Value).GetIsLock();
	}

	// Token: 0x06015CCA RID: 89290 RVA: 0x0065237E File Offset: 0x0065057E
	public override bool IsTrial()
	{
		return false;
	}

	// Token: 0x06015CCB RID: 89291 RVA: 0x00652381 File Offset: 0x00650581
	public override bool HasRole()
	{
		return this.GetRoleId() > 0;
	}

	// Token: 0x06015CCC RID: 89292 RVA: 0x0065238C File Offset: 0x0065058C
	public override void SetRoleId(int roleId)
	{
		this.WeaponItem.RoleId = roleId;
	}

	// Token: 0x06015CCD RID: 89293 RVA: 0x0065239A File Offset: 0x0065059A
	public override int GetRoleId()
	{
		return this.WeaponItem.RoleId;
	}

	// Token: 0x06015CCE RID: 89294 RVA: 0x006523A8 File Offset: 0x006505A8
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

	// Token: 0x06015CCF RID: 89295 RVA: 0x0065242C File Offset: 0x0065062C
	public bool HasWeaponCultivated()
	{
		bool flag = this.GetResonanceLevel() > 1;
		bool flag2 = this.GetLevel() > 1;
		bool flag3 = this.GetExp() > 0;
		return flag || flag2 || flag3;
	}

	// Token: 0x0400B7AD RID: 47021
	[Nullable(2)]
	protected WeaponItem WeaponItem;
}
