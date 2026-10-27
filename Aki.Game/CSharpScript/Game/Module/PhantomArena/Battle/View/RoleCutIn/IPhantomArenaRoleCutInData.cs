using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.RoleCutIn
{
	// Token: 0x02005251 RID: 21073
	[NullableContext(1)]
	public interface IPhantomArenaRoleCutInData
	{
		// Token: 0x1700825F RID: 33375
		// (get) Token: 0x06035D96 RID: 220566
		// (set) Token: 0x06035D97 RID: 220567
		int SkillId { get; set; }

		// Token: 0x17008260 RID: 33376
		// (get) Token: 0x06035D98 RID: 220568
		// (set) Token: 0x06035D99 RID: 220569
		Action CloseCallback { get; set; }
	}
}
