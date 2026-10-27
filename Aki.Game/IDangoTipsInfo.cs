using System;
using System.Runtime.CompilerServices;

// Token: 0x02001236 RID: 4662
[NullableContext(1)]
public interface IDangoTipsInfo
{
	// Token: 0x17000AB8 RID: 2744
	// (get) Token: 0x06007E07 RID: 32263
	// (set) Token: 0x06007E08 RID: 32264
	string Text { get; set; }

	// Token: 0x17000AB9 RID: 2745
	// (get) Token: 0x06007E09 RID: 32265
	// (set) Token: 0x06007E0A RID: 32266
	[Nullable(2)]
	string Icon { [NullableContext(2)] get; [NullableContext(2)] set; }
}
