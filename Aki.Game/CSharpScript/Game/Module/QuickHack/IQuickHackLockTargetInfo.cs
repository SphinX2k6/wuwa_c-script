using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F7F RID: 20351
	[NullableContext(1)]
	public interface IQuickHackLockTargetInfo
	{
		// Token: 0x17007F57 RID: 32599
		// (get) Token: 0x060341DB RID: 213467
		// (set) Token: 0x060341DC RID: 213468
		EQuickHackTargetType? HackType { get; set; }

		// Token: 0x17007F58 RID: 32600
		// (get) Token: 0x060341DD RID: 213469
		// (set) Token: 0x060341DE RID: 213470
		IEnumerable<EntityHandle> Targets { get; set; }
	}
}
