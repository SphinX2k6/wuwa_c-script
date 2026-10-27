using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C08 RID: 23560
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelDetailInfo : IBossPilingLevelDetailInfo
	{
		// Token: 0x17008D9F RID: 36255
		// (get) Token: 0x0603B8A0 RID: 243872 RVA: 0x00E3222A File Offset: 0x00E3042A
		// (set) Token: 0x0603B8A1 RID: 243873 RVA: 0x00E32232 File Offset: 0x00E30432
		public bool IsFirst { get; set; }

		// Token: 0x17008DA0 RID: 36256
		// (get) Token: 0x0603B8A2 RID: 243874 RVA: 0x00E3223B File Offset: 0x00E3043B
		// (set) Token: 0x0603B8A3 RID: 243875 RVA: 0x00E32243 File Offset: 0x00E30443
		public List<BossPilingLevelDescInfo> LevelList { get; set; }
	}
}
