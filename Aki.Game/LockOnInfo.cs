using System;
using System.Runtime.CompilerServices;

// Token: 0x0200262D RID: 9773
[NullableContext(1)]
[Nullable(0)]
public class LockOnInfo
{
	// Token: 0x0601864B RID: 99915 RVA: 0x0075C1B8 File Offset: 0x0075A3B8
	public LockOnInfo([Nullable(2)] EntityHandle entityHandle = null, string socketName = "")
	{
		this.EntityHandle = entityHandle;
		this.SocketName = socketName;
	}

	// Token: 0x0601864C RID: 99916 RVA: 0x0075C1D9 File Offset: 0x0075A3D9
	public void Copy(LockOnInfo info)
	{
		this.EntityHandle = info.EntityHandle;
		this.SocketName = info.SocketName;
	}

	// Token: 0x0601864D RID: 99917 RVA: 0x0075C1F4 File Offset: 0x0075A3F4
	public bool Equal(LockOnInfo info)
	{
		EntityHandle entityHandle = this.EntityHandle;
		int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
		EntityHandle entityHandle2 = info.EntityHandle;
		int? num2 = (entityHandle2 != null) ? new int?(entityHandle2.Id) : null;
		return (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) && this.SocketName == info.SocketName;
	}

	// Token: 0x0601864E RID: 99918 RVA: 0x0075C278 File Offset: 0x0075A478
	public bool Different(LockOnInfo info)
	{
		return this.EntityHandle != info.EntityHandle || (this.SocketName != info.SocketName && !string.IsNullOrEmpty(info.SocketName) && !string.IsNullOrEmpty(this.SocketName));
	}

	// Token: 0x0400D28A RID: 53898
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400D28B RID: 53899
	public string SocketName = "";
}
