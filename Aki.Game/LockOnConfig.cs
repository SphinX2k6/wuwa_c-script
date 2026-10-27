using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;

// Token: 0x0200303D RID: 12349
public class LockOnConfig
{
	// Token: 0x0601A317 RID: 107287 RVA: 0x006E3A32 File Offset: 0x006E1C32
	[NullableContext(1)]
	public LockOnConfig(SLockOnConfig config)
	{
		this.IsOpened = config.IsOpened;
		this.Distance = (double)config.Distance;
		this.UpDistance = (double)config.UpDistance;
		this.DownDistance = (double)config.DownDistance;
	}

	// Token: 0x0400C731 RID: 50993
	public bool IsOpened;

	// Token: 0x0400C732 RID: 50994
	public double Distance;

	// Token: 0x0400C733 RID: 50995
	public double UpDistance;

	// Token: 0x0400C734 RID: 50996
	public double DownDistance;
}
