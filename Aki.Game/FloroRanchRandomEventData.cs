using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FB7 RID: 4023
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRandomEventData
{
	// Token: 0x0600A104 RID: 41220 RVA: 0x002F78CB File Offset: 0x002F5ACB
	public FloroRanchRandomEventData(FloroRanchEvent config)
	{
		this.Config = config;
	}

	// Token: 0x0600A105 RID: 41221 RVA: 0x002F78DC File Offset: 0x002F5ADC
	public int GetId()
	{
		return this.Config.Id;
	}

	// Token: 0x0600A106 RID: 41222 RVA: 0x002F78F8 File Offset: 0x002F5AF8
	public string GetEventTitle()
	{
		return this.Config.Title;
	}

	// Token: 0x0600A107 RID: 41223 RVA: 0x002F7914 File Offset: 0x002F5B14
	public string GetEventDesc()
	{
		return this.Config.Desc;
	}

	// Token: 0x04005EE0 RID: 24288
	private readonly FloroRanchEvent Config;
}
