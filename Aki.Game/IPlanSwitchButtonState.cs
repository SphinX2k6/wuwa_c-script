using System;
using System.Runtime.CompilerServices;

// Token: 0x020027F3 RID: 10227
[NullableContext(1)]
public interface IPlanSwitchButtonState
{
	// Token: 0x17001BA5 RID: 7077
	// (get) Token: 0x06014FF1 RID: 86001
	// (set) Token: 0x06014FF2 RID: 86002
	bool IsShow { get; set; }

	// Token: 0x17001BA6 RID: 7078
	// (get) Token: 0x06014FF3 RID: 86003
	// (set) Token: 0x06014FF4 RID: 86004
	string Text { get; set; }

	// Token: 0x17001BA7 RID: 7079
	// (get) Token: 0x06014FF5 RID: 86005
	// (set) Token: 0x06014FF6 RID: 86006
	bool IsHighlight { get; set; }
}
