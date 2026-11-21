using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003643 RID: 13891
	[NullableContext(1)]
	public interface IWuWaGoMovableFloorBatchResult
	{
		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x06024091 RID: 147601
		bool Committed { get; }

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x06024092 RID: 147602
		IReadOnlyList<int> MovedRoleIds { get; }
	}
}
