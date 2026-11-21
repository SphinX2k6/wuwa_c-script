using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052E0 RID: 21216
	[NullableContext(1)]
	public interface IPinballFormationSelectRoleViewData
	{
		// Token: 0x17006690 RID: 26256
		// (get) Token: 0x06034CE6 RID: 216294
		// (set) Token: 0x06034CE7 RID: 216295
		List<int> RoleList { get; set; }

		// Token: 0x17006691 RID: 26257
		// (get) Token: 0x06034CE8 RID: 216296
		// (set) Token: 0x06034CE9 RID: 216297
		List<int> RecommendRoleList { get; set; }

		// Token: 0x17006692 RID: 26258
		// (get) Token: 0x06034CEA RID: 216298
		// (set) Token: 0x06034CEB RID: 216299
		Action<List<int>> OnConfirm { get; set; }

		// Token: 0x17006693 RID: 26259
		// (get) Token: 0x06034CEC RID: 216300
		// (set) Token: 0x06034CED RID: 216301
		int? OpenRole { get; set; }
	}
}
