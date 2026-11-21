using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE7 RID: 15335
	[NullableContext(1)]
	[JsonConverter(typeof(SheriffQuestionResultJsonConfigConverter))]
	public interface ISheriffQuestionResultJsonConfig
	{
		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x06027545 RID: 161093
		// (set) Token: 0x06027546 RID: 161094
		List<int> ClueCombination { get; set; }

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x06027547 RID: 161095
		// (set) Token: 0x06027548 RID: 161096
		List<string> ReasoningStateId { get; set; }

		// Token: 0x17005040 RID: 20544
		// (get) Token: 0x06027549 RID: 161097
		// (set) Token: 0x0602754A RID: 161098
		List<string> ResultDesc { get; set; }

		// Token: 0x17005041 RID: 20545
		// (get) Token: 0x0602754B RID: 161099
		// (set) Token: 0x0602754C RID: 161100
		int? NextQuestionId { get; set; }

		// Token: 0x17005042 RID: 20546
		// (get) Token: 0x0602754D RID: 161101
		// (set) Token: 0x0602754E RID: 161102
		int? CaseProgressId { get; set; }

		// Token: 0x17005043 RID: 20547
		// (get) Token: 0x0602754F RID: 161103
		// (set) Token: 0x06027550 RID: 161104
		int? EndingId { get; set; }
	}
}
