using System;
using System.Runtime.CompilerServices;

// Token: 0x02002239 RID: 8761
[NullableContext(1)]
public interface IMultiTemplateGridData<[Nullable(2)] TData, [Nullable(0)] TProxy> : IMultiTemplateGridData where TProxy : ISyncGridProxy<TData>
{
	// Token: 0x170020D0 RID: 8400
	// (get) Token: 0x06015A47 RID: 88647
	// (set) Token: 0x06015A48 RID: 88648
	TData Data { get; set; }

	// Token: 0x06015A49 RID: 88649
	int GetTemplateIndex();
}
