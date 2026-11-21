using System;
using System.Runtime.CompilerServices;

// Token: 0x0200222D RID: 8749
public interface ISyncGridProxy<[Nullable(2)] TData> : ISyncGridProxy
{
	// Token: 0x060159B7 RID: 88503
	[NullableContext(1)]
	void Refresh(TData data);
}
