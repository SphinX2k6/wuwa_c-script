using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C80 RID: 11392
[NullableContext(1)]
[Nullable(0)]
public class AnsContextSet<[Nullable(0)] T> where T : UiAnsContextBase
{
	// Token: 0x06017CC5 RID: 97477 RVA: 0x0060D72C File Offset: 0x0060B92C
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

	// Token: 0x06017CC6 RID: 97478 RVA: 0x0060D7A8 File Offset: 0x0060B9A8
	public void Add(T value)
	{
		if (this.Has(value) != null)
		{
			return;
		}
		this.ContextSet.Add(value);
	}

	// Token: 0x06017CC7 RID: 97479 RVA: 0x0060D7C6 File Offset: 0x0060B9C6
	public bool Delete(T value)
	{
		return this.ContextSet.Remove(value);
	}

	// Token: 0x06017CC8 RID: 97480 RVA: 0x0060D7D9 File Offset: 0x0060B9D9
	public void Clear()
	{
		this.ContextSet.Clear();
	}

	// Token: 0x0400B15B RID: 45403
	public readonly HashSet<UiAnsContextBase> ContextSet = new HashSet<UiAnsContextBase>();
}
