using System;
using System.Runtime.CompilerServices;

// Token: 0x0200157A RID: 5498
[NullableContext(1)]
[Nullable(0)]
public class RegionAndIpSt
{
	// Token: 0x0600DC17 RID: 56343 RVA: 0x00412492 File Offset: 0x00410692
	public void Phrase(string region, string ip)
	{
		this.Region = region;
		this.Ip = ip;
	}

	// Token: 0x04007AE3 RID: 31459
	public string Region = string.Empty;

	// Token: 0x04007AE4 RID: 31460
	public string Ip = string.Empty;
}
