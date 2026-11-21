using System;
using System.Runtime.CompilerServices;

// Token: 0x020018D5 RID: 6357
[NullableContext(1)]
public interface IPhantomArenaStartViewData
{
	// Token: 0x17001807 RID: 6151
	// (get) Token: 0x0600FAE2 RID: 64226
	// (set) Token: 0x0600FAE3 RID: 64227
	string ContentTextId { get; set; }

	// Token: 0x17001808 RID: 6152
	// (get) Token: 0x0600FAE4 RID: 64228
	// (set) Token: 0x0600FAE5 RID: 64229
	bool IsOwn { get; set; }

	// Token: 0x17001809 RID: 6153
	// (get) Token: 0x0600FAE6 RID: 64230
	// (set) Token: 0x0600FAE7 RID: 64231
	[Nullable(2)]
	Action Callback { [NullableContext(2)] get; [NullableContext(2)] set; }
}
