using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x0200724F RID: 29263
	[NullableContext(1)]
	public interface IShowTalk
	{
		// Token: 0x17009E68 RID: 40552
		// (get) Token: 0x06047BB4 RID: 293812
		// (set) Token: 0x06047BB5 RID: 293813
		bool? ResetCamera { get; set; }

		// Token: 0x17009E69 RID: 40553
		// (get) Token: 0x06047BB6 RID: 293814
		// (set) Token: 0x06047BB7 RID: 293815
		ITalkItem[] TalkItems { get; set; }
	}
}
