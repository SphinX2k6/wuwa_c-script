using System;
using System.Runtime.CompilerServices;

// Token: 0x020026F6 RID: 9974
public class AimingLockOnInfo
{
	// Token: 0x06018F96 RID: 102294 RVA: 0x007993F4 File Offset: 0x007975F4
	public void Reset()
	{
		this.Target = null;
		this.SocketName = "";
	}

	// Token: 0x0400D981 RID: 55681
	[Nullable(2)]
	public EntityHandle Target;

	// Token: 0x0400D982 RID: 55682
	[Nullable(1)]
	public string SocketName = "";
}
