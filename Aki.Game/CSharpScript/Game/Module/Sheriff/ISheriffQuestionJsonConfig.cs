using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C33 RID: 19507
	[NullableContext(1)]
	[JsonConverter(typeof(SheriffQuestionJsonConfigConverter))]
	public interface ISheriffQuestionJsonConfig
	{
		// Token: 0x17007C90 RID: 31888
		// (get) Token: 0x06032786 RID: 206726
		// (set) Token: 0x06032787 RID: 206727
		int QuestionId { get; set; }

		// Token: 0x17007C91 RID: 31889
		// (get) Token: 0x06032788 RID: 206728
		// (set) Token: 0x06032789 RID: 206729
		List<ISheriffQuestionResultJsonConfig> ResultConfigs { get; set; }
	}
}
