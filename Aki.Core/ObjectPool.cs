using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000B7 RID: 183
[NullableContext(1)]
[Nullable(0)]
public class ObjectPool<[Nullable(0)] T> where T : ObjectBase
{
	// Token: 0x060005FA RID: 1530 RVA: 0x0001F10C File Offset: 0x0001D30C
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

	// Token: 0x060005FB RID: 1531 RVA: 0x0001F161 File Offset: 0x0001D361
	public void DeSpawn(T obj)
	{
		this.PoolInternal.Add(obj);
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0001F16F File Offset: 0x0001D36F
	public bool IsEmpty()
	{
		return this.PoolInternal.Count == 0;
	}

	// Token: 0x040004AD RID: 1197
	private readonly List<T> PoolInternal = new List<T>();
}
