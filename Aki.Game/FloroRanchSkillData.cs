using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AFF RID: 6911
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSkillData
{
	// Token: 0x0600CD23 RID: 52515 RVA: 0x002ECB14 File Offset: 0x002EAD14
	public FloroRanchSkillData(FloroRanchSkill config)
	{
		this.Config = config;
	}

	// Token: 0x170010F9 RID: 4345
	// (get) Token: 0x0600CD24 RID: 52516 RVA: 0x002ECB24 File Offset: 0x002EAD24
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170010FA RID: 4346
	// (get) Token: 0x0600CD25 RID: 52517 RVA: 0x002ECB40 File Offset: 0x002EAD40
	public string Name
	{
		get
		{
			return this.Config.Name;
		}
	}

	// Token: 0x0600CD26 RID: 52518 RVA: 0x002ECB5C File Offset: 0x002EAD5C
	public string GetRealName()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
	}

	// Token: 0x170010FB RID: 4347
	// (get) Token: 0x0600CD27 RID: 52519 RVA: 0x002ECB80 File Offset: 0x002EAD80
	public string Icon
	{
		get
		{
			return this.Config.Icon;
		}
	}

	// Token: 0x170010FC RID: 4348
	// (get) Token: 0x0600CD28 RID: 52520 RVA: 0x002ECB9C File Offset: 0x002EAD9C
	public string Desc
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x170010FD RID: 4349
	// (get) Token: 0x0600CD29 RID: 52521 RVA: 0x002ECBB8 File Offset: 0x002EADB8
	public bool IsActiveSkill
	{
		get
		{
			return this.Config.Type == 0;
		}
	}

	// Token: 0x04005E1D RID: 24093
	private readonly FloroRanchSkill Config;
}
