using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020000F2 RID: 242
[NullableContext(1)]
[Nullable(0)]
public class KuroStringBuilder
{
	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x0600076C RID: 1900 RVA: 0x000286E6 File Offset: 0x000268E6
	public List<object> Store
	{
		get
		{
			return this.StoreInternal;
		}
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x000286EE File Offset: 0x000268EE
	public KuroStringBuilder(params object[] parameters)
	{
		this.StoreInternal = new List<object>(16);
		if (parameters.Length != 0)
		{
			this.Append(parameters);
		}
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00028710 File Offset: 0x00026910
	public void Append(params object[] parameters)
	{
		foreach (object obj in parameters)
		{
			if (obj is string)
			{
				this.StoreInternal.Add(obj);
			}
			else
			{
				Array array = obj as Array;
				if (array != null)
				{
					using (IEnumerator enumerator = array.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object element = enumerator.Current;
							this.StoreInternal.Append(element);
						}
						goto IL_9A;
					}
				}
				if (obj is KuroStringBuilder)
				{
					this.StoreInternal.AddRange(((KuroStringBuilder)obj).Store);
				}
				else
				{
					this.StoreInternal.Add(obj);
				}
			}
			IL_9A:;
		}
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x000287D4 File Offset: 0x000269D4
	public void RemoveLast(int removeNum)
	{
		for (int i = 0; i < removeNum; i++)
		{
			if (this.StoreInternal.Count > 0)
			{
				this.StoreInternal.RemoveAt(this.StoreInternal.Count - 1);
			}
		}
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00028813 File Offset: 0x00026A13
	public override string ToString()
	{
		return string.Join<object>("", this.StoreInternal);
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00028825 File Offset: 0x00026A25
	public void Clear()
	{
		this.StoreInternal.Clear();
	}

	// Token: 0x040005CF RID: 1487
	private const int DEFAULT_SIZE = 16;

	// Token: 0x040005D0 RID: 1488
	private List<object> StoreInternal;
}
