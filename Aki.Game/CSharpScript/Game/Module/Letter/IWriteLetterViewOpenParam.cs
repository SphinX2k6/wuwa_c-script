using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x020056C7 RID: 22215
	[NullableContext(1)]
	public interface IWriteLetterViewOpenParam
	{
		// Token: 0x17008798 RID: 34712
		// (get) Token: 0x06038813 RID: 231443
		// (set) Token: 0x06038814 RID: 231444
		string FlowListName { get; set; }

		// Token: 0x17008799 RID: 34713
		// (get) Token: 0x06038815 RID: 231445
		// (set) Token: 0x06038816 RID: 231446
		int FlowId { get; set; }

		// Token: 0x1700879A RID: 34714
		// (get) Token: 0x06038817 RID: 231447
		// (set) Token: 0x06038818 RID: 231448
		int StateId { get; set; }

		// Token: 0x1700879B RID: 34715
		// (get) Token: 0x06038819 RID: 231449
		// (set) Token: 0x0603881A RID: 231450
		ELetterStyle LetterStyle { get; set; }

		// Token: 0x1700879C RID: 34716
		// (get) Token: 0x0603881B RID: 231451
		// (set) Token: 0x0603881C RID: 231452
		[Nullable(2)]
		string GameplayId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700879D RID: 34717
		// (get) Token: 0x0603881D RID: 231453
		// (set) Token: 0x0603881E RID: 231454
		int? LetterId { get; set; }
	}
}
