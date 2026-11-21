using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004544 RID: 17732
	[NullableContext(1)]
	public interface IWorldMapNavigateState
	{
		// Token: 0x170059C8 RID: 22984
		// (get) Token: 0x0602CB11 RID: 183057
		int StateId { get; }

		// Token: 0x170059C9 RID: 22985
		// (get) Token: 0x0602CB12 RID: 183058
		int SortIndex { get; }

		// Token: 0x170059CA RID: 22986
		// (get) Token: 0x0602CB13 RID: 183059
		List<IWorldMapNavigate> AreaNavigateList { get; }
	}
}
