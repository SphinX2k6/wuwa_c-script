using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CD4 RID: 11476
public interface ISyncGridProxy<[Nullable(2)] TData> : ISyncGridProxy
{
	// Token: 0x0601813A RID: 98618
	[NullableContext(1)]
	void Refresh(TData data);
}
