using System;
using System.Runtime.CompilerServices;

// Token: 0x020018A5 RID: 6309
[NullableContext(1)]
[Nullable(0)]
public class SortViewData
{
	// Token: 0x0600B8AB RID: 47275 RVA: 0x0029E909 File Offset: 0x0029CB09
	public SortViewData(int uniqueId, Action confirmFunction)
	{
		this.UniqueId = uniqueId;
		this.ConfirmFunction = confirmFunction;
	}

	// Token: 0x040053AD RID: 21421
	public int UniqueId;

	// Token: 0x040053AE RID: 21422
	public Action ConfirmFunction;
}
