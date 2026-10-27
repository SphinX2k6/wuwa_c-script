using System;
using System.Runtime.CompilerServices;

// Token: 0x020021F8 RID: 8696
[NullableContext(2)]
public interface IPreemptiveFrameTask
{
	// Token: 0x17001578 RID: 5496
	// (get) Token: 0x06010EA3 RID: 69283
	// (set) Token: 0x06010EA4 RID: 69284
	int Priority { get; set; }

	// Token: 0x17001579 RID: 5497
	// (get) Token: 0x06010EA5 RID: 69285
	// (set) Token: 0x06010EA6 RID: 69286
	[Nullable(1)]
	TPreemptiveExecuteMethod Execute { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700157A RID: 5498
	// (get) Token: 0x06010EA7 RID: 69287
	// (set) Token: 0x06010EA8 RID: 69288
	TPreemptiveExecuteMethod FrameExecute { get; set; }

	// Token: 0x1700157B RID: 5499
	// (get) Token: 0x06010EA9 RID: 69289
	// (set) Token: 0x06010EAA RID: 69290
	TPreemptiveIsCompleteMethod IsComplete { get; set; }

	// Token: 0x1700157C RID: 5500
	// (get) Token: 0x06010EAB RID: 69291
	// (set) Token: 0x06010EAC RID: 69292
	TPreemptiveCancelMethod Cancel { get; set; }

	// Token: 0x1700157D RID: 5501
	// (get) Token: 0x06010EAD RID: 69293
	// (set) Token: 0x06010EAE RID: 69294
	TGetPreemptiveResultMethod GetResult { get; set; }
}
