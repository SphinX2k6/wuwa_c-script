using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;

// Token: 0x02002593 RID: 9619
public class LockOnConfig
{
	// Token: 0x06017C81 RID: 97409 RVA: 0x0070B5BA File Offset: 0x007097BA
	[NullableContext(1)]
	public LockOnConfig(SLockOnConfig config)
	{
		this.IsOpened = config.IsOpened;
		this.Distance = (double)config.Distance;
		this.UpDistance = (double)config.UpDistance;
		this.DownDistance = (double)config.DownDistance;
	}

	// Token: 0x0400CB0A RID: 51978
	public bool IsOpened;

	// Token: 0x0400CB0B RID: 51979
	public double Distance;

	// Token: 0x0400CB0C RID: 51980
	public double UpDistance;

	// Token: 0x0400CB0D RID: 51981
	public double DownDistance;
}
