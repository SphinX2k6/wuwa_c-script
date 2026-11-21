using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;

// Token: 0x02000F30 RID: 3888
[NullableContext(1)]
[Nullable(0)]
public class DangoData
{
	// Token: 0x06009B67 RID: 39783 RVA: 0x002E151C File Offset: 0x002DF71C
	private DangoData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06009B68 RID: 39784 RVA: 0x002E158E File Offset: 0x002DF78E
	public static DangoData Create(int id)
	{
		DangoData dangoData = new DangoData(id);
		dangoData.Init();
		return dangoData;
	}

	// Token: 0x06009B69 RID: 39785 RVA: 0x002E159C File Offset: 0x002DF79C
	private void Init()
	{
		Dango? dangoById = CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig.Instance.GetDangoById(this.Id);
		if (dangoById == null)
		{
			return;
		}
		this.DangoConfig = new Dango?(dangoById.Value);
		this.NameKey = dangoById.Value.Name;
		this.DiceId = dangoById.Value.DiceId;
		this.SkillId = dangoById.Value.SkillId;
		this.ModelId = dangoById.Value.ModelId;
		this.Icon = dangoById.Value.Icon;
		this.IconDamage = dangoById.Value.IconDamage;
		this.IconDamageLarge = dangoById.Value.IconDamageLarge;
		this.IconAttack = dangoById.Value.IconAttack;
		this.IconAttackLarge = dangoById.Value.IconAttackLarge;
		this.DangoSay = dangoById.Value.Dialog;
		this.DangoVoice = dangoById.Value.Audio;
		this.ModelHeight = dangoById.Value.ModelHeight;
	}

	// Token: 0x06009B6A RID: 39786 RVA: 0x002E16D2 File Offset: 0x002DF8D2
	public Dice? GetDiceConfig()
	{
		return CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig.Instance.GetDiceById(this.DiceId);
	}

	// Token: 0x06009B6B RID: 39787 RVA: 0x002E16E4 File Offset: 0x002DF8E4
	public DangoSkill? GetSkillConfig()
	{
		return CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig.Instance.GetDangoSkillById(this.SkillId);
	}

	// Token: 0x06009B6C RID: 39788 RVA: 0x002E16F8 File Offset: 0x002DF8F8
	public DangoSkillEffect? GetSkillEffectConfig()
	{
		DangoSkill? skillConfig = this.GetSkillConfig();
		if (skillConfig == null)
		{
			return null;
		}
		return CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig.Instance.GetDangoSkillEffectById(skillConfig.Value.SkillEffect);
	}

	// Token: 0x06009B6D RID: 39789 RVA: 0x002E1738 File Offset: 0x002DF938
	public string GetDangoActiveSkillDesc()
	{
		DangoSkill? skillConfig = this.GetSkillConfig();
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(skillConfig.Value.Name);
		string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(skillConfig.Value.ActivateDesc);
		return TextConfig.Instance.GetMultiText("Dango_InGame_SkillActivated", new string[]
		{
			multiTextByKey,
			multiTextByKey2
		});
	}

	// Token: 0x04005CB8 RID: 23736
	public int Id;

	// Token: 0x04005CB9 RID: 23737
	public string NameKey = string.Empty;

	// Token: 0x04005CBA RID: 23738
	public int DiceId;

	// Token: 0x04005CBB RID: 23739
	public int SkillId;

	// Token: 0x04005CBC RID: 23740
	public int ModelId;

	// Token: 0x04005CBD RID: 23741
	public string Icon = string.Empty;

	// Token: 0x04005CBE RID: 23742
	public string IconDamage = string.Empty;

	// Token: 0x04005CBF RID: 23743
	public string IconDamageLarge = string.Empty;

	// Token: 0x04005CC0 RID: 23744
	public string IconAttack = string.Empty;

	// Token: 0x04005CC1 RID: 23745
	public string IconAttackLarge = string.Empty;

	// Token: 0x04005CC2 RID: 23746
	public string DangoSay = string.Empty;

	// Token: 0x04005CC3 RID: 23747
	public string DangoVoice = string.Empty;

	// Token: 0x04005CC4 RID: 23748
	public int ModelHeight;

	// Token: 0x04005CC5 RID: 23749
	public Dango? DangoConfig;
}
