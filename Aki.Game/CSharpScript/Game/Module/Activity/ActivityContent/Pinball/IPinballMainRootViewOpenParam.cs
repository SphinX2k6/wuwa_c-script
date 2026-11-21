using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x02005248 RID: 21064
	[NullableContext(1)]
	public interface IPinballMainRootViewOpenParam
	{
		// Token: 0x170065EB RID: 26091
		// (get) Token: 0x06034705 RID: 214789
		// (set) Token: 0x06034706 RID: 214790
		string ChildView { get; set; }

		// Token: 0x170065EC RID: 26092
		// (get) Token: 0x06034707 RID: 214791
		// (set) Token: 0x06034708 RID: 214792
		int? LevelId { get; set; }

		// Token: 0x170065ED RID: 26093
		// (get) Token: 0x06034709 RID: 214793
		// (set) Token: 0x0603470A RID: 214794
		bool? IsFromInstanceDungeon { get; set; }
	}
}
