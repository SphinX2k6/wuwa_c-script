using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200556D RID: 21869
	[NullableContext(1)]
	public interface IWorldMapNavigateCountry
	{
		// Token: 0x17008617 RID: 34327
		// (get) Token: 0x06037C26 RID: 228390
		// (set) Token: 0x06037C27 RID: 228391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Dictionary<int, IWorldMapNavigateState> StateMap { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008618 RID: 34328
		// (get) Token: 0x06037C28 RID: 228392
		// (set) Token: 0x06037C29 RID: 228393
		List<IWorldMapNavigate> AreaNavigateList { get; set; }
	}
}
