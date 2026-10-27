using System;
using System.Runtime.CompilerServices;

// Token: 0x02003189 RID: 12681
public class AimingLockOnInfo
{
	// Token: 0x0601B491 RID: 111761 RVA: 0x00771A90 File Offset: 0x0076FC90
	public void Reset()
	{
		this.Target = null;
		this.SocketName = "";
	}

	// Token: 0x0400D51E RID: 54558
	[Nullable(2)]
	public EntityHandle Target;

	// Token: 0x0400D51F RID: 54559
	[Nullable(1)]
	public string SocketName = "";
}
