using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x0200469E RID: 18078
	[NullableContext(1)]
	public interface IWriteLetterViewOpenParam
	{
		// Token: 0x17005B60 RID: 23392
		// (get) Token: 0x0602D723 RID: 186147
		// (set) Token: 0x0602D724 RID: 186148
		string FlowListName { get; set; }

		// Token: 0x17005B61 RID: 23393
		// (get) Token: 0x0602D725 RID: 186149
		// (set) Token: 0x0602D726 RID: 186150
		int FlowId { get; set; }

		// Token: 0x17005B62 RID: 23394
		// (get) Token: 0x0602D727 RID: 186151
		// (set) Token: 0x0602D728 RID: 186152
		int StateId { get; set; }

		// Token: 0x17005B63 RID: 23395
		// (get) Token: 0x0602D729 RID: 186153
		// (set) Token: 0x0602D72A RID: 186154
		ELetterStyle LetterStyle { get; set; }

		// Token: 0x17005B64 RID: 23396
		// (get) Token: 0x0602D72B RID: 186155
		// (set) Token: 0x0602D72C RID: 186156
		[Nullable(2)]
		string GameplayId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005B65 RID: 23397
		// (get) Token: 0x0602D72D RID: 186157
		// (set) Token: 0x0602D72E RID: 186158
		int? LetterId { get; set; }
	}
}
