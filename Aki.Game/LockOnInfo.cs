using System;
using System.Runtime.CompilerServices;

// Token: 0x020030D5 RID: 12501
[NullableContext(1)]
[Nullable(0)]
public class LockOnInfo
{
	// Token: 0x0601AC36 RID: 109622 RVA: 0x0073649C File Offset: 0x0073469C
	public LockOnInfo([Nullable(2)] EntityHandle entityHandle = null, string socketName = "")
	{
		this.EntityHandle = entityHandle;
		this.SocketName = socketName;
	}

	// Token: 0x0601AC37 RID: 109623 RVA: 0x007364BD File Offset: 0x007346BD
	public void Copy(LockOnInfo info)
	{
		this.EntityHandle = info.EntityHandle;
		this.SocketName = info.SocketName;
	}

	// Token: 0x0601AC38 RID: 109624 RVA: 0x007364D8 File Offset: 0x007346D8
	public bool Equal(LockOnInfo info)
	{
		EntityHandle entityHandle = this.EntityHandle;
		int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
		EntityHandle entityHandle2 = info.EntityHandle;
		int? num2 = (entityHandle2 != null) ? new int?(entityHandle2.Id) : null;
		return (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) && this.SocketName == info.SocketName;
	}

	// Token: 0x0601AC39 RID: 109625 RVA: 0x0073655C File Offset: 0x0073475C
	public bool Different(LockOnInfo info)
	{
		return this.EntityHandle != info.EntityHandle || (this.SocketName != info.SocketName && !string.IsNullOrEmpty(info.SocketName) && !string.IsNullOrEmpty(this.SocketName));
	}

	// Token: 0x0400CE9A RID: 52890
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400CE9B RID: 52891
	public string SocketName = "";
}
