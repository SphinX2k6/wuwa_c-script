using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021D9 RID: 8665
[NullableContext(1)]
[Nullable(0)]
public class AnsContextSet<[Nullable(0)] T> where T : UiAnsContextBase
{
	// Token: 0x06015538 RID: 87352 RVA: 0x00633210 File Offset: 0x00631410
	[return: Nullable(2)]
	public UiAnsContextBase Has(T value)
	{
		if (this.ContextSet.Contains(value))
		{
			return value;
		}
		foreach (UiAnsContextBase uiAnsContextBase in this.ContextSet)
		{
			if (uiAnsContextBase.IsEqual(value))
			{
				return uiAnsContextBase;
			}
		}
		return null;
	}

	// Token: 0x06015539 RID: 87353 RVA: 0x0063328C File Offset: 0x0063148C
	public void Add(T value)
	{
		if (this.Has(value) != null)
		{
			return;
		}
		this.ContextSet.Add(value);
	}

	// Token: 0x0601553A RID: 87354 RVA: 0x006332AA File Offset: 0x006314AA
	public bool Delete(T value)
	{
		return this.ContextSet.Remove(value);
	}

	// Token: 0x0601553B RID: 87355 RVA: 0x006332BD File Offset: 0x006314BD
	public void Clear()
	{
		this.ContextSet.Clear();
	}

	// Token: 0x0400B4C6 RID: 46278
	public readonly HashSet<UiAnsContextBase> ContextSet = new HashSet<UiAnsContextBase>();
}
