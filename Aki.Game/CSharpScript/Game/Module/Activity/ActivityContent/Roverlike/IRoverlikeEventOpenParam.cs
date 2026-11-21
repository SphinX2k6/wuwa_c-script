using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200507F RID: 20607
	[NullableContext(1)]
	public interface IRoverlikeEventOpenParam
	{
		// Token: 0x170064CB RID: 25803
		// (get) Token: 0x06033952 RID: 211282
		// (set) Token: 0x06033953 RID: 211283
		int EventIncId { get; set; }

		// Token: 0x170064CC RID: 25804
		// (get) Token: 0x06033954 RID: 211284
		// (set) Token: 0x06033955 RID: 211285
		List<int> ChoiceList { get; set; }
	}
}
