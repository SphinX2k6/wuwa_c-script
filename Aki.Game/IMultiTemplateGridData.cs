using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CE0 RID: 11488
[NullableContext(1)]
public interface IMultiTemplateGridData<[Nullable(2)] TData, [Nullable(0)] TProxy> : IMultiTemplateGridData where TProxy : ISyncGridProxy<TData>
{
	// Token: 0x1700207D RID: 8317
	// (get) Token: 0x060181C8 RID: 98760
	// (set) Token: 0x060181C9 RID: 98761
	TData Data { get; set; }

	// Token: 0x060181CA RID: 98762
	int GetTemplateIndex();
}
