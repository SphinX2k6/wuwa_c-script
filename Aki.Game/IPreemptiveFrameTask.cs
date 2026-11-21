using System;
using System.Runtime.CompilerServices;

// Token: 0x020016DC RID: 5852
[NullableContext(2)]
public interface IPreemptiveFrameTask
{
	// Token: 0x170015AF RID: 5551
	// (get) Token: 0x0600E336 RID: 58166
	// (set) Token: 0x0600E337 RID: 58167
	int Priority { get; set; }

	// Token: 0x170015B0 RID: 5552
	// (get) Token: 0x0600E338 RID: 58168
	// (set) Token: 0x0600E339 RID: 58169
	[Nullable(1)]
	TPreemptiveExecuteMethod Execute { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170015B1 RID: 5553
	// (get) Token: 0x0600E33A RID: 58170
	// (set) Token: 0x0600E33B RID: 58171
	TPreemptiveExecuteMethod FrameExecute { get; set; }

	// Token: 0x170015B2 RID: 5554
	// (get) Token: 0x0600E33C RID: 58172
	// (set) Token: 0x0600E33D RID: 58173
	TPreemptiveIsCompleteMethod IsComplete { get; set; }

	// Token: 0x170015B3 RID: 5555
	// (get) Token: 0x0600E33E RID: 58174
	// (set) Token: 0x0600E33F RID: 58175
	TPreemptiveCancelMethod Cancel { get; set; }

	// Token: 0x170015B4 RID: 5556
	// (get) Token: 0x0600E340 RID: 58176
	// (set) Token: 0x0600E341 RID: 58177
	TGetPreemptiveResultMethod GetResult { get; set; }
}
