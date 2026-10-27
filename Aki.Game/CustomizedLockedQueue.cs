using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020030D6 RID: 12502
[NullableContext(2)]
[Nullable(0)]
public class CustomizedLockedQueue
{
	// Token: 0x0601AC3A RID: 109626 RVA: 0x007365AC File Offset: 0x007347AC
	public bool Has(LockOnInfo info)
	{
		if (info == null)
		{
			return false;
		}
		for (int i = 0; i < this.LruLockedArray.Count; i++)
		{
			if (this.LruLockedArray[i].Equal(info))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601AC3B RID: 109627 RVA: 0x007365EB File Offset: 0x007347EB
	public void Push(LockOnInfo info)
	{
		if (info != null && !this.Has(info))
		{
			this.LruLockedArray.Add(info);
		}
	}

	// Token: 0x0601AC3C RID: 109628 RVA: 0x00736605 File Offset: 0x00734805
	public LockOnInfo Pop()
	{
		if (this.LruLockedArray.Count == 0)
		{
			return null;
		}
		LockOnInfo result = this.LruLockedArray[0];
		this.LruLockedArray.RemoveAt(0);
		return result;
	}

	// Token: 0x0601AC3D RID: 109629 RVA: 0x0073662E File Offset: 0x0073482E
	public void Clear()
	{
		this.LruLockedArray.Clear();
	}

	// Token: 0x0400CE9C RID: 52892
	[Nullable(1)]
	private readonly List<LockOnInfo> LruLockedArray = new List<LockOnInfo>();
}
