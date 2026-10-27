using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x020062CA RID: 25290
	[NullableContext(1)]
	public interface IPinballMainRootViewOpenParam
	{
		// Token: 0x17009289 RID: 37513
		// (get) Token: 0x0603FA44 RID: 260676
		// (set) Token: 0x0603FA45 RID: 260677
		string ChildView { get; set; }

		// Token: 0x1700928A RID: 37514
		// (get) Token: 0x0603FA46 RID: 260678
		// (set) Token: 0x0603FA47 RID: 260679
		int? LevelId { get; set; }

		// Token: 0x1700928B RID: 37515
		// (get) Token: 0x0603FA48 RID: 260680
		// (set) Token: 0x0603FA49 RID: 260681
		bool? IsFromInstanceDungeon { get; set; }
	}
}
