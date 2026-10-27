using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AF8 RID: 6904
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRandomEventData
{
	// Token: 0x0600CCF3 RID: 52467 RVA: 0x002EC7DF File Offset: 0x002EA9DF
	public FloroRanchRandomEventData(FloroRanchEvent config)
	{
		this.Config = config;
	}

	// Token: 0x0600CCF4 RID: 52468 RVA: 0x002EC7F0 File Offset: 0x002EA9F0
	public int GetId()
	{
		return this.Config.Id;
	}

	// Token: 0x0600CCF5 RID: 52469 RVA: 0x002EC80C File Offset: 0x002EAA0C
	public string GetEventTitle()
	{
		return this.Config.Title;
	}

	// Token: 0x0600CCF6 RID: 52470 RVA: 0x002EC828 File Offset: 0x002EAA28
	public string GetEventDesc()
	{
		return this.Config.Desc;
	}

	// Token: 0x04005E11 RID: 24081
	private readonly FloroRanchEvent Config;
}
