using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02006A39 RID: 27193
	[NullableContext(1)]
	public interface IKeyPointState
	{
		// Token: 0x17009906 RID: 39174
		// (get) Token: 0x06043A76 RID: 277110
		// (set) Token: 0x06043A77 RID: 277111
		IDragActorPlayKeyPointConfig Config { get; set; }

		// Token: 0x17009907 RID: 39175
		// (get) Token: 0x06043A78 RID: 277112
		// (set) Token: 0x06043A79 RID: 277113
		Vector Position { get; set; }

		// Token: 0x17009908 RID: 39176
		// (get) Token: 0x06043A7A RID: 277114
		// (set) Token: 0x06043A7B RID: 277115
		bool IsInside { get; set; }
	}
}
