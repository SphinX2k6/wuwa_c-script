using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.RoleCutIn
{
	// Token: 0x02004221 RID: 16929
	[NullableContext(1)]
	public interface IPhantomArenaRoleCutInData
	{
		// Token: 0x1700561F RID: 22047
		// (get) Token: 0x0602AC91 RID: 175249
		// (set) Token: 0x0602AC92 RID: 175250
		int SkillId { get; set; }

		// Token: 0x17005620 RID: 22048
		// (get) Token: 0x0602AC93 RID: 175251
		// (set) Token: 0x0602AC94 RID: 175252
		Action CloseCallback { get; set; }
	}
}
