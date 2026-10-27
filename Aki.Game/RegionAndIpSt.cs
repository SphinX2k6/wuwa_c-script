using System;
using System.Runtime.CompilerServices;

// Token: 0x020020A3 RID: 8355
[NullableContext(1)]
[Nullable(0)]
public class RegionAndIpSt
{
	// Token: 0x060107A9 RID: 67497 RVA: 0x00405E7E File Offset: 0x0040407E
	public void Phrase(string region, string ip)
	{
		this.Region = region;
		this.Ip = ip;
	}

	// Token: 0x040079E5 RID: 31205
	public string Region = string.Empty;

	// Token: 0x040079E6 RID: 31206
	public string Ip = string.Empty;
}
