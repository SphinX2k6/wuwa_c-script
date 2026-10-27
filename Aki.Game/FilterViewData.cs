using System;
using System.Runtime.CompilerServices;

// Token: 0x02001850 RID: 6224
[NullableContext(2)]
[Nullable(0)]
public class FilterViewData
{
	// Token: 0x0600B655 RID: 46677 RVA: 0x002937B3 File Offset: 0x002919B3
	public FilterViewData(int uniqueId, Action confirmFunction = null)
	{
		this.UniqueId = uniqueId;
		this.ConfirmFunction = confirmFunction;
	}

	// Token: 0x0400526A RID: 21098
	public int UniqueId;

	// Token: 0x0400526B RID: 21099
	public Action ConfirmFunction;
}
