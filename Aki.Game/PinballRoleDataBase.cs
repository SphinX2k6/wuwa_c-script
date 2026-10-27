using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020013E6 RID: 5094
[NullableContext(2)]
[Nullable(0)]
public abstract class PinballRoleDataBase
{
	// Token: 0x06008FC5 RID: 36805 RVA: 0x001F1709 File Offset: 0x001EF909
	public PinballRoleDataBase(int id)
	{
		this.Id = id;
	}

	// Token: 0x06008FC6 RID: 36806 RVA: 0x001F1723 File Offset: 0x001EF923
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06008FC7 RID: 36807 RVA: 0x001F172B File Offset: 0x001EF92B
	public void SetLevel(int level)
	{
		this.Level = level;
		this.UpdateAttribute();
	}

	// Token: 0x06008FC8 RID: 36808 RVA: 0x001F173A File Offset: 0x001EF93A
	public int GetLevel()
	{
		return this.Level;
	}

	// Token: 0x06008FC9 RID: 36809 RVA: 0x001F1742 File Offset: 0x001EF942
	public void SetWeaponData(PinballWeaponData weaponData)
	{
		this.WeaponData = weaponData;
		this.UpdateAttribute();
	}

	// Token: 0x06008FCA RID: 36810 RVA: 0x001F1751 File Offset: 0x001EF951
	public PinballWeaponData GetWeaponData()
	{
		return this.WeaponData;
	}

	// Token: 0x06008FCB RID: 36811 RVA: 0x001F1759 File Offset: 0x001EF959
	[NullableContext(1)]
	public Dictionary<EPinballAttr, int> GetAttributes()
	{
		return this.Attributes;
	}

	// Token: 0x06008FCC RID: 36812 RVA: 0x001F1764 File Offset: 0x001EF964
	public int GetAttribute(EPinballAttr id)
	{
		int result;
		if (!this.Attributes.TryGetValue(id, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06008FCD RID: 36813 RVA: 0x001F1784 File Offset: 0x001EF984
	public PinballRoleConfig GetConfig()
	{
		return PinballConfig.Instance.GetPinballRoleConfigById(this.Id).Value;
	}

	// Token: 0x06008FCE RID: 36814 RVA: 0x001F17AC File Offset: 0x001EF9AC
	protected void UpdateAttribute()
	{
		this.Attributes.Clear();
		int gradeUpGroup = this.GetConfig().GradeUpGroup;
		PinballRoleLevelConfig? pinballRoleLevelConfigByGroupIdAndLevel = PinballConfig.Instance.GetPinballRoleLevelConfigByGroupIdAndLevel(gradeUpGroup, this.Level);
		if (pinballRoleLevelConfigByGroupIdAndLevel == null)
		{
			return;
		}
		int prop = pinballRoleLevelConfigByGroupIdAndLevel.Value.Prop;
		PinballAttr? pinballRoleAttrConfigById = PinballConfig.Instance.GetPinballRoleAttrConfigById(prop);
		if (pinballRoleAttrConfigById == null)
		{
			return;
		}
		this.Attributes[EPinballAttr.MaxLife] = pinballRoleAttrConfigById.Value.LifeMax;
		this.Attributes[EPinballAttr.Atk] = pinballRoleAttrConfigById.Value.Atk;
		this.Attributes[EPinballAttr.Def] = pinballRoleAttrConfigById.Value.Def;
		this.Attributes[EPinballAttr.EnergyEfficiency] = pinballRoleAttrConfigById.Value.EnergyEfficiency;
		this.Attributes[EPinballAttr.Crit] = pinballRoleAttrConfigById.Value.Crit;
		this.Attributes[EPinballAttr.CritDamage] = pinballRoleAttrConfigById.Value.CritDamage;
		this.Attributes[EPinballAttr.DamageChange] = pinballRoleAttrConfigById.Value.DamageChange;
		this.Attributes[EPinballAttr.DamageChangeAuto] = pinballRoleAttrConfigById.Value.DamageChangeAuto;
		this.Attributes[EPinballAttr.DamageChangeStrong] = pinballRoleAttrConfigById.Value.DamageChangeStrong;
		this.Attributes[EPinballAttr.DamageChangeSkill] = pinballRoleAttrConfigById.Value.DamageChangeSkill;
		this.Attributes[EPinballAttr.DamageChangeSprint] = pinballRoleAttrConfigById.Value.DamageChangeSprint;
		this.Attributes[EPinballAttr.DamageChangeSummon] = pinballRoleAttrConfigById.Value.DamageChangeSummon;
		this.Attributes[EPinballAttr.HealEfficiency] = pinballRoleAttrConfigById.Value.HealEfficiency;
		this.Attributes[EPinballAttr.ProtectEfficiency] = pinballRoleAttrConfigById.Value.ProtectEfficiency;
		this.Attributes[EPinballAttr.EnergyRecoverSpeed] = pinballRoleAttrConfigById.Value.EnergyRecoverSpeed;
		this.AddWeaponAttribute();
	}

	// Token: 0x06008FCF RID: 36815 RVA: 0x001F19CC File Offset: 0x001EFBCC
	protected void AddWeaponAttribute()
	{
		PinballWeaponData weaponData = this.GetWeaponData();
		if (weaponData == null)
		{
			return;
		}
		foreach (int id in weaponData.PropList)
		{
			PinballWeaponAttr? pinballWeaponAttrConfigById = PinballConfig.Instance.GetPinballWeaponAttrConfigById(id);
			if (pinballWeaponAttrConfigById != null)
			{
				EPinballAttr properKey = (EPinballAttr)pinballWeaponAttrConfigById.Value.ProperKey;
				int num2;
				int num = this.Attributes.TryGetValue(properKey, out num2) ? num2 : 0;
				this.Attributes[properKey] = num + (int)pinballWeaponAttrConfigById.Value.ProperVal;
			}
		}
	}

	// Token: 0x06008FD0 RID: 36816
	public abstract bool IsLocked();

	// Token: 0x04003F93 RID: 16275
	protected int Id;

	// Token: 0x04003F94 RID: 16276
	protected int Level;

	// Token: 0x04003F95 RID: 16277
	protected PinballWeaponData WeaponData;

	// Token: 0x04003F96 RID: 16278
	[Nullable(1)]
	protected Dictionary<EPinballAttr, int> Attributes = new Dictionary<EPinballAttr, int>();
}
