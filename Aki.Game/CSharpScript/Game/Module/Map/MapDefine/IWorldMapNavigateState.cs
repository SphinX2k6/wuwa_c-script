using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005571 RID: 21873
	[NullableContext(1)]
	public interface IWorldMapNavigateState
	{
		// Token: 0x1700861F RID: 34335
		// (get) Token: 0x06037C37 RID: 228407
		int StateId { get; }

		// Token: 0x17008620 RID: 34336
		// (get) Token: 0x06037C38 RID: 228408
		int SortIndex { get; }

		// Token: 0x17008621 RID: 34337
		// (get) Token: 0x06037C39 RID: 228409
		List<IWorldMapNavigate> AreaNavigateList { get; }
	}
}
