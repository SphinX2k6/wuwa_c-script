using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B07 RID: 6919
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTerrainData
{
	// Token: 0x0600CD6E RID: 52590 RVA: 0x002ED0A7 File Offset: 0x002EB2A7
	public FloroRanchTerrainData(FloroRanchTerrain config)
	{
		this.Config = config;
		this.TagData.SetTagId(this.Config.Tag);
	}

	// Token: 0x17001129 RID: 4393
	// (get) Token: 0x0600CD6F RID: 52591 RVA: 0x002ED0D8 File Offset: 0x002EB2D8
	public string Name
	{
		get
		{
			return ConfigMultiTextLang.GetLocalTextNew(this.Config.Name, null);
		}
	}

	// Token: 0x1700112A RID: 4394
	// (get) Token: 0x0600CD70 RID: 52592 RVA: 0x002ED0F9 File Offset: 0x002EB2F9
	public string Desc
	{
		get
		{
			return this.TagData.Desc;
		}
	}

	// Token: 0x1700112B RID: 4395
	// (get) Token: 0x0600CD71 RID: 52593 RVA: 0x002ED108 File Offset: 0x002EB308
	public string Icon
	{
		get
		{
			return this.Config.Pic;
		}
	}

	// Token: 0x04005E37 RID: 24119
	private readonly FloroRanchTerrain Config;

	// Token: 0x04005E38 RID: 24120
	public FloroRanchTagData TagData = new FloroRanchTagData();
}
