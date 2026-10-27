using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005550 RID: 21840
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonLevelPlayPanelRewardData
	{
		// Token: 0x170085CD RID: 34253
		// (get) Token: 0x06037B95 RID: 228245 RVA: 0x00D38937 File Offset: 0x00D36B37
		// (set) Token: 0x06037B96 RID: 228246 RVA: 0x00D3893F File Offset: 0x00D36B3F
		public bool FinishRecord { get; set; }

		// Token: 0x170085CE RID: 34254
		// (get) Token: 0x06037B97 RID: 228247 RVA: 0x00D38948 File Offset: 0x00D36B48
		// (set) Token: 0x06037B98 RID: 228248 RVA: 0x00D38950 File Offset: 0x00D36B50
		public List<TItem> ItemList { get; set; }
	}
}
