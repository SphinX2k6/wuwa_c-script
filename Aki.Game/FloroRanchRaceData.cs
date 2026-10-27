using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AF7 RID: 6903
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRaceData
{
	// Token: 0x0600CCEC RID: 52460 RVA: 0x002EC727 File Offset: 0x002EA927
	public FloroRanchRaceData(FloroRanchRace config)
	{
		this.Config = config;
	}

	// Token: 0x170010F0 RID: 4336
	// (get) Token: 0x0600CCED RID: 52461 RVA: 0x002EC738 File Offset: 0x002EA938
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x0600CCEE RID: 52462 RVA: 0x002EC754 File Offset: 0x002EA954
	public string GetRaceName()
	{
		return this.Config.Name;
	}

	// Token: 0x170010F1 RID: 4337
	// (get) Token: 0x0600CCEF RID: 52463 RVA: 0x002EC770 File Offset: 0x002EA970
	public string Icon
	{
		get
		{
			return this.Config.Icon;
		}
	}

	// Token: 0x170010F2 RID: 4338
	// (get) Token: 0x0600CCF0 RID: 52464 RVA: 0x002EC78C File Offset: 0x002EA98C
	public string SmallIcon
	{
		get
		{
			return this.Config.SmallIcon;
		}
	}

	// Token: 0x0600CCF1 RID: 52465 RVA: 0x002EC7A8 File Offset: 0x002EA9A8
	public string GetDesc()
	{
		return this.Config.Description;
	}

	// Token: 0x170010F3 RID: 4339
	// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x002EC7C4 File Offset: 0x002EA9C4
	public bool IsCommon
	{
		get
		{
			return this.Config.IsCommon;
		}
	}

	// Token: 0x04005E10 RID: 24080
	private readonly FloroRanchRace Config;
}
