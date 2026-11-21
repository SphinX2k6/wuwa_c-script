using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FB6 RID: 4022
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRaceData
{
	// Token: 0x0600A0FD RID: 41213 RVA: 0x002F7813 File Offset: 0x002F5A13
	public FloroRanchRaceData(FloroRanchRace config)
	{
		this.Config = config;
	}

	// Token: 0x17001115 RID: 4373
	// (get) Token: 0x0600A0FE RID: 41214 RVA: 0x002F7824 File Offset: 0x002F5A24
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600A0FF RID: 41215 RVA: 0x002F7840 File Offset: 0x002F5A40
	public string GetRaceName()
	{
		return this.Config.Name;
	}

	// Token: 0x17001116 RID: 4374
	// (get) Token: 0x0600A100 RID: 41216 RVA: 0x002F785C File Offset: 0x002F5A5C
	public string Icon
	{
		get
		{
			return this.Config.Icon;
		}
	}

	// Token: 0x17001117 RID: 4375
	// (get) Token: 0x0600A101 RID: 41217 RVA: 0x002F7878 File Offset: 0x002F5A78
	public string SmallIcon
	{
		get
		{
			return this.Config.SmallIcon;
		}
	}

	// Token: 0x0600A102 RID: 41218 RVA: 0x002F7894 File Offset: 0x002F5A94
	public string GetDesc()
	{
		return this.Config.Description;
	}

	// Token: 0x17001118 RID: 4376
	// (get) Token: 0x0600A103 RID: 41219 RVA: 0x002F78B0 File Offset: 0x002F5AB0
	public bool IsCommon
	{
		get
		{
			return this.Config.IsCommon;
		}
	}

	// Token: 0x04005EDF RID: 24287
	private readonly FloroRanchRace Config;
}
