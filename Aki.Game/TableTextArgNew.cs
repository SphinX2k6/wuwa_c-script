using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002CD7 RID: 11479
[NullableContext(2)]
[Nullable(0)]
public class TableTextArgNew
{
	// Token: 0x0601814A RID: 98634 RVA: 0x0061F46E File Offset: 0x0061D66E
	public TableTextArgNew(string textKey, [ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> args)
	{
	}

	// Token: 0x0400B31A RID: 45850
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public IReadOnlyList<object> Params = args;

	// Token: 0x0400B31B RID: 45851
	public string TextKey = textKey;
}
