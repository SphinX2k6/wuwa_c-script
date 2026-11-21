using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200262E RID: 9774
[NullableContext(2)]
[Nullable(0)]
public class CustomizedLockedQueue
{
	// Token: 0x0601864F RID: 99919 RVA: 0x0075C2C8 File Offset: 0x0075A4C8
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

	// Token: 0x06018650 RID: 99920 RVA: 0x0075C307 File Offset: 0x0075A507
	public void Push(LockOnInfo info)
	{
		if (info != null && !this.Has(info))
		{
			this.LruLockedArray.Add(info);
		}
	}

	// Token: 0x06018651 RID: 99921 RVA: 0x0075C321 File Offset: 0x0075A521
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

	// Token: 0x06018652 RID: 99922 RVA: 0x0075C34A File Offset: 0x0075A54A
	public void Clear()
	{
		this.LruLockedArray.Clear();
	}

	// Token: 0x0400D28C RID: 53900
	[Nullable(1)]
	private readonly List<LockOnInfo> LruLockedArray = new List<LockOnInfo>();
}
