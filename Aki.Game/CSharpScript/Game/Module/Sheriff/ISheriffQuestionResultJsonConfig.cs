using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C36 RID: 19510
	[NullableContext(1)]
	[JsonConverter(typeof(SheriffQuestionResultJsonConfigConverter))]
	public interface ISheriffQuestionResultJsonConfig
	{
		// Token: 0x17007C94 RID: 31892
		// (get) Token: 0x06032792 RID: 206738
		// (set) Token: 0x06032793 RID: 206739
		List<int> ClueCombination { get; set; }

		// Token: 0x17007C95 RID: 31893
		// (get) Token: 0x06032794 RID: 206740
		// (set) Token: 0x06032795 RID: 206741
		List<string> ReasoningStateId { get; set; }

		// Token: 0x17007C96 RID: 31894
		// (get) Token: 0x06032796 RID: 206742
		// (set) Token: 0x06032797 RID: 206743
		List<string> ResultDesc { get; set; }

		// Token: 0x17007C97 RID: 31895
		// (get) Token: 0x06032798 RID: 206744
		// (set) Token: 0x06032799 RID: 206745
		int? NextQuestionId { get; set; }

		// Token: 0x17007C98 RID: 31896
		// (get) Token: 0x0603279A RID: 206746
		// (set) Token: 0x0603279B RID: 206747
		int? CaseProgressId { get; set; }

		// Token: 0x17007C99 RID: 31897
		// (get) Token: 0x0603279C RID: 206748
		// (set) Token: 0x0603279D RID: 206749
		int? EndingId { get; set; }
	}
}
