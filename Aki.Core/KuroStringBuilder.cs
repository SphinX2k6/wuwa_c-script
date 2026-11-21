using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000F2 RID: 242
[NullableContext(1)]
[Nullable(0)]
public class KuroStringBuilder
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00028A1A File Offset: 0x00026C1A
	public List<object> Store
	{
		get
		{
			return this.StoreInternal;
		}
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00028A22 File Offset: 0x00026C22
	public KuroStringBuilder(params object[] parameters)
	{
		this.StoreInternal = new List<object>(16);
		if (parameters.Length != 0)
		{
			this.Append(parameters);
		}
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00028A44 File Offset: 0x00026C44
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
							object item = enumerator.Current;
							this.StoreInternal.Add(item);
						}
						goto IL_99;
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
			IL_99:;
		}
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00028B08 File Offset: 0x00026D08
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

	// Token: 0x060007AA RID: 1962 RVA: 0x00028B47 File Offset: 0x00026D47
	public override string ToString()
	{
		return string.Join<object>("", this.StoreInternal);
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00028B59 File Offset: 0x00026D59
	public void Clear()
	{
		this.StoreInternal.Clear();
	}

	// Token: 0x040005DA RID: 1498
	private const int DEFAULT_SIZE = 16;

	// Token: 0x040005DB RID: 1499
	private List<object> StoreInternal;
}
