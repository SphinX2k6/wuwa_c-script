using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE4 RID: 15332
	[NullableContext(1)]
	[JsonConverter(typeof(SheriffQuestionJsonConfigConverter))]
	public interface ISheriffQuestionJsonConfig
	{
		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x06027539 RID: 161081
		// (set) Token: 0x0602753A RID: 161082
		int QuestionId { get; set; }

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x0602753B RID: 161083
		// (set) Token: 0x0602753C RID: 161084
		List<ISheriffQuestionResultJsonConfig> ResultConfigs { get; set; }
	}
}
