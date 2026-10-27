using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C07 RID: 23559
	[NullableContext(1)]
	public interface IBossPilingLevelDetailInfo
	{
		// Token: 0x17008D9D RID: 36253
		// (get) Token: 0x0603B89C RID: 243868
		// (set) Token: 0x0603B89D RID: 243869
		bool IsFirst { get; set; }

		// Token: 0x17008D9E RID: 36254
		// (get) Token: 0x0603B89E RID: 243870
		// (set) Token: 0x0603B89F RID: 243871
		List<BossPilingLevelDescInfo> LevelList { get; set; }
	}
}
