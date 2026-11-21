using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F48 RID: 16200
	[NullableContext(1)]
	public interface IQuickHackLockTargetInfo
	{
		// Token: 0x17005307 RID: 21255
		// (get) Token: 0x06029049 RID: 168009
		// (set) Token: 0x0602904A RID: 168010
		EQuickHackTargetType? HackType { get; set; }

		// Token: 0x17005308 RID: 21256
		// (get) Token: 0x0602904B RID: 168011
		// (set) Token: 0x0602904C RID: 168012
		IEnumerable<EntityHandle> Targets { get; set; }
	}
}
