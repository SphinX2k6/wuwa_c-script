using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002230 RID: 8752
[NullableContext(2)]
[Nullable(0)]
public class TableTextArgNew
{
	// Token: 0x060159C7 RID: 88519 RVA: 0x00645026 File Offset: 0x00643226
	public TableTextArgNew(string textKey, [ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> args)
	{
	}

	// Token: 0x0400B686 RID: 46726
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public IReadOnlyList<object> Params = args;

	// Token: 0x0400B687 RID: 46727
	public string TextKey = textKey;
}
