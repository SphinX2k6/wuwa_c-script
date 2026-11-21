using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015A RID: 346
	[NullableContext(1)]
	public interface IEulerStrokeJudge
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000C25 RID: 3109
		// (set) Token: 0x06000C26 RID: 3110
		EEulerStrokeKind Kind { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000C27 RID: 3111
		// (set) Token: 0x06000C28 RID: 3112
		bool CanDrawInOneStroke { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000C29 RID: 3113
		// (set) Token: 0x06000C2A RID: 3114
		bool Connected { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000C2B RID: 3115
		// (set) Token: 0x06000C2C RID: 3116
		List<int> OddNodeIds { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000C2D RID: 3117
		// (set) Token: 0x06000C2E RID: 3118
		int? SuggestedStartId { get; set; }
	}
}
