using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000B5 RID: 181
[NullableContext(1)]
[Nullable(0)]
public class ObjectPool<[Nullable(0)] T> where T : ObjectBase
{
	// Token: 0x060005B9 RID: 1465 RVA: 0x0001EA68 File Offset: 0x0001CC68
	public T Spawn(Func<int, int, T> ctor)
	{
		if (this.PoolInternal.Count == 0)
		{
			throw new InvalidOperationException("Pool is empty");
		}
		T result = this.PoolInternal[this.PoolInternal.Count - 1];
		this.PoolInternal.RemoveAt(this.PoolInternal.Count - 1);
		return result;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0001EABD File Offset: 0x0001CCBD
	public void DeSpawn(T obj)
	{
		this.PoolInternal.Add(obj);
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0001EACB File Offset: 0x0001CCCB
	public bool IsEmpty()
	{
		return this.PoolInternal.Count == 0;
	}

	// Token: 0x0400049F RID: 1183
	private readonly List<T> PoolInternal = new List<T>();
}
