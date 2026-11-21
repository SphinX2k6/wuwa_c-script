using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02005B96 RID: 23446
	[NullableContext(1)]
	public interface IKeyPointState
	{
		// Token: 0x17006DEB RID: 28139
		// (get) Token: 0x06039AC4 RID: 236228
		// (set) Token: 0x06039AC5 RID: 236229
		IDragActorPlayKeyPointConfig Config { get; set; }

		// Token: 0x17006DEC RID: 28140
		// (get) Token: 0x06039AC6 RID: 236230
		// (set) Token: 0x06039AC7 RID: 236231
		Vector Position { get; set; }

		// Token: 0x17006DED RID: 28141
		// (get) Token: 0x06039AC8 RID: 236232
		// (set) Token: 0x06039AC9 RID: 236233
		bool IsInside { get; set; }
	}
}
