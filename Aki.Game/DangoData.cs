using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;

// Token: 0x02001A71 RID: 6769
[NullableContext(1)]
[Nullable(0)]
public class DangoData
{
	// Token: 0x0600C757 RID: 51031 RVA: 0x002D642C File Offset: 0x002D462C
	private DangoData(int id)
	{
		this.Id = id;
	}

	// Token: 0x0600C758 RID: 51032 RVA: 0x002D649E File Offset: 0x002D469E
	public static DangoData Create(int id)
	{
		DangoData dangoData = new DangoData(id);
		dangoData.Init();
		return dangoData;
	}

	// Token: 0x0600C759 RID: 51033 RVA: 0x002D64AC File Offset: 0x002D46AC
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

	// Token: 0x0600C75A RID: 51034 RVA: 0x002D65E2 File Offset: 0x002D47E2
	public Dice? GetDiceConfig()
	{
		return CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig.Instance.GetDiceById(this.DiceId);
	}

	// Token: 0x0600C75B RID: 51035 RVA: 0x002D65F4 File Offset: 0x002D47F4
	public DangoSkill? GetSkillConfig()
	{
		return CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig.Instance.GetDangoSkillById(this.SkillId);
	}

	// Token: 0x0600C75C RID: 51036 RVA: 0x002D6608 File Offset: 0x002D4808
	public DangoSkillEffect? GetSkillEffectConfig()
	{
		DangoSkill? skillConfig = this.GetSkillConfig();
		if (skillConfig == null)
		{
			return null;
		}
		return CSharpScript.Game.Module.Dango.DangoLogic.DangoConfig.Instance.GetDangoSkillEffectById(skillConfig.Value.SkillEffect);
	}

	// Token: 0x0600C75D RID: 51037 RVA: 0x002D6648 File Offset: 0x002D4848
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

	// Token: 0x04005BE9 RID: 23529
	public int Id;

	// Token: 0x04005BEA RID: 23530
	public string NameKey = string.Empty;

	// Token: 0x04005BEB RID: 23531
	public int DiceId;

	// Token: 0x04005BEC RID: 23532
	public int SkillId;

	// Token: 0x04005BED RID: 23533
	public int ModelId;

	// Token: 0x04005BEE RID: 23534
	public string Icon = string.Empty;

	// Token: 0x04005BEF RID: 23535
	public string IconDamage = string.Empty;

	// Token: 0x04005BF0 RID: 23536
	public string IconDamageLarge = string.Empty;

	// Token: 0x04005BF1 RID: 23537
	public string IconAttack = string.Empty;

	// Token: 0x04005BF2 RID: 23538
	public string IconAttackLarge = string.Empty;

	// Token: 0x04005BF3 RID: 23539
	public string DangoSay = string.Empty;

	// Token: 0x04005BF4 RID: 23540
	public string DangoVoice = string.Empty;

	// Token: 0x04005BF5 RID: 23541
	public int ModelHeight;

	// Token: 0x04005BF6 RID: 23542
	public Dango? DangoConfig;
}
