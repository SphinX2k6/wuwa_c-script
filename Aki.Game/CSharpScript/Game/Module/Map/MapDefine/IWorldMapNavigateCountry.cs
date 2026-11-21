using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004540 RID: 17728
	[NullableContext(1)]
	public interface IWorldMapNavigateCountry
	{
		// Token: 0x170059C0 RID: 22976
		// (get) Token: 0x0602CB00 RID: 183040
		// (set) Token: 0x0602CB01 RID: 183041
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

		// Token: 0x170059C1 RID: 22977
		// (get) Token: 0x0602CB02 RID: 183042
		// (set) Token: 0x0602CB03 RID: 183043
		List<IWorldMapNavigate> AreaNavigateList { get; set; }
	}
}
