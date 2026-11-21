using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FC6 RID: 4038
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTerrainData
{
	// Token: 0x0600A17F RID: 41343 RVA: 0x002F8193 File Offset: 0x002F6393
	public FloroRanchTerrainData(FloroRanchTerrain config)
	{
		this.Config = config;
		this.TagData.SetTagId(this.Config.Tag);
	}

	// Token: 0x1700114E RID: 4430
	// (get) Token: 0x0600A180 RID: 41344 RVA: 0x002F81C4 File Offset: 0x002F63C4
	public string Name
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
		}
	}

	// Token: 0x1700114F RID: 4431
	// (get) Token: 0x0600A181 RID: 41345 RVA: 0x002F81E5 File Offset: 0x002F63E5
	public string Desc
	{
		get
		{
			return this.TagData.Desc;
		}
	}

	// Token: 0x17001150 RID: 4432
	// (get) Token: 0x0600A182 RID: 41346 RVA: 0x002F81F4 File Offset: 0x002F63F4
	public string Icon
	{
		get
		{
			return this.Config.Pic;
		}
	}

	// Token: 0x04005F06 RID: 24326
	private readonly FloroRanchTerrain Config;

	// Token: 0x04005F07 RID: 24327
	public FloroRanchTagData TagData = new FloroRanchTagData();
}
