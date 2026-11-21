using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FBE RID: 4030
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSkillData
{
	// Token: 0x0600A134 RID: 41268 RVA: 0x002F7C00 File Offset: 0x002F5E00
	public FloroRanchSkillData(FloroRanchSkill config)
	{
		this.Config = config;
	}

	// Token: 0x1700111E RID: 4382
	// (get) Token: 0x0600A135 RID: 41269 RVA: 0x002F7C10 File Offset: 0x002F5E10
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x1700111F RID: 4383
	// (get) Token: 0x0600A136 RID: 41270 RVA: 0x002F7C2C File Offset: 0x002F5E2C
	public string Name
	{
		get
		{
			return this.Config.Name;
		}
	}

	// Token: 0x0600A137 RID: 41271 RVA: 0x002F7C48 File Offset: 0x002F5E48
	public string GetRealName()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
	}

	// Token: 0x17001120 RID: 4384
	// (get) Token: 0x0600A138 RID: 41272 RVA: 0x002F7C6C File Offset: 0x002F5E6C
	public string Icon
	{
		get
		{
			return this.Config.Icon;
		}
	}

	// Token: 0x17001121 RID: 4385
	// (get) Token: 0x0600A139 RID: 41273 RVA: 0x002F7C88 File Offset: 0x002F5E88
	public string Desc
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x17001122 RID: 4386
	// (get) Token: 0x0600A13A RID: 41274 RVA: 0x002F7CA4 File Offset: 0x002F5EA4
	public bool IsActiveSkill
	{
		get
		{
			return this.Config.Type == 0;
		}
	}

	// Token: 0x04005EEC RID: 24300
	private readonly FloroRanchSkill Config;
}
