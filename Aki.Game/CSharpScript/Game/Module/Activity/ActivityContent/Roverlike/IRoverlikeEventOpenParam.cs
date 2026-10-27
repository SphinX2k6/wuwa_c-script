using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006101 RID: 24833
	[NullableContext(1)]
	public interface IRoverlikeEventOpenParam
	{
		// Token: 0x17009169 RID: 37225
		// (get) Token: 0x0603EC90 RID: 257168
		// (set) Token: 0x0603EC91 RID: 257169
		int EventIncId { get; set; }

		// Token: 0x1700916A RID: 37226
		// (get) Token: 0x0603EC92 RID: 257170
		// (set) Token: 0x0603EC93 RID: 257171
		List<int> ChoiceList { get; set; }
	}
}
