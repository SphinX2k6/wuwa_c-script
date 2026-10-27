using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A5F RID: 19039
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseResultUnlockTab
	{
		// Token: 0x17007A88 RID: 31368
		// (get) Token: 0x06031610 RID: 202256 RVA: 0x00B72577 File Offset: 0x00B70777
		// (set) Token: 0x06031611 RID: 202257 RVA: 0x00B7257F File Offset: 0x00B7077F
		public ETrapDefenseResultUnlockType Type { get; set; }

		// Token: 0x17007A89 RID: 31369
		// (get) Token: 0x06031612 RID: 202258 RVA: 0x00B72588 File Offset: 0x00B70788
		// (set) Token: 0x06031613 RID: 202259 RVA: 0x00B72590 File Offset: 0x00B70790
		public List<ITrapDefenseResultUnlockInfo> DataList { get; set; }
	}
}
