using System;
using System.Runtime.CompilerServices;

// Token: 0x020023F0 RID: 9200
[NullableContext(1)]
public interface IPhantomArenaStartViewData
{
	// Token: 0x170017CD RID: 6093
	// (get) Token: 0x06012630 RID: 75312
	// (set) Token: 0x06012631 RID: 75313
	string ContentTextId { get; set; }

	// Token: 0x170017CE RID: 6094
	// (get) Token: 0x06012632 RID: 75314
	// (set) Token: 0x06012633 RID: 75315
	bool IsOwn { get; set; }

	// Token: 0x170017CF RID: 6095
	// (get) Token: 0x06012634 RID: 75316
	// (set) Token: 0x06012635 RID: 75317
	[Nullable(2)]
	Action Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
