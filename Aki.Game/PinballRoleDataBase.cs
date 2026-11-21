using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200089A RID: 2202
[NullableContext(2)]
[Nullable(0)]
public abstract class PinballRoleDataBase
{
	// Token: 0x0600635A RID: 25434 RVA: 0x001FA245 File Offset: 0x001F8445
	public PinballRoleDataBase(int id)
	{
		this.Id = id;
	}

	// Token: 0x0600635B RID: 25435 RVA: 0x001FA25F File Offset: 0x001F845F
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600635C RID: 25436 RVA: 0x001FA267 File Offset: 0x001F8467
	public void SetLevel(int level)
	{
		this.Level = level;
		this.UpdateAttribute();
	}

	// Token: 0x0600635D RID: 25437 RVA: 0x001FA276 File Offset: 0x001F8476
	public int GetLevel()
	{
		return this.Level;
	}

	// Token: 0x0600635E RID: 25438 RVA: 0x001FA27E File Offset: 0x001F847E
	public void SetWeaponData(PinballWeaponData weaponData)
	{
		this.WeaponData = weaponData;
		this.UpdateAttribute();
	}

	// Token: 0x0600635F RID: 25439 RVA: 0x001FA28D File Offset: 0x001F848D
	public PinballWeaponData GetWeaponData()
	{
		return this.WeaponData;
	}

	// Token: 0x06006360 RID: 25440 RVA: 0x001FA295 File Offset: 0x001F8495
	[NullableContext(1)]
	public Dictionary<EPinballAttr, int> GetAttributes()
	{
		return this.Attributes;
	}

	// Token: 0x06006361 RID: 25441 RVA: 0x001FA2A0 File Offset: 0x001F84A0
	public int GetAttribute(EPinballAttr id)
	{
		int result;
		if (!this.Attributes.TryGetValue(id, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06006362 RID: 25442 RVA: 0x001FA2C0 File Offset: 0x001F84C0
	public PinballRoleConfig GetConfig()
	{
		return PinballConfig.Instance.GetPinballRoleConfigById(this.Id).Value;
	}

	// Token: 0x06006363 RID: 25443 RVA: 0x001FA2E8 File Offset: 0x001F84E8
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

	// Token: 0x06006364 RID: 25444 RVA: 0x001FA508 File Offset: 0x001F8708
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

	// Token: 0x06006365 RID: 25445
	public abstract bool IsLocked();

	// Token: 0x0400402B RID: 16427
	protected int Id;

	// Token: 0x0400402C RID: 16428
	protected int Level;

	// Token: 0x0400402D RID: 16429
	protected PinballWeaponData WeaponData;

	// Token: 0x0400402E RID: 16430
	[Nullable(1)]
	protected Dictionary<EPinballAttr, int> Attributes = new Dictionary<EPinballAttr, int>();
}
