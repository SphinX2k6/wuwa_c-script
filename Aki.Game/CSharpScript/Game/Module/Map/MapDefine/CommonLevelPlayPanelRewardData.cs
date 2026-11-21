using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004522 RID: 17698
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonLevelPlayPanelRewardData
	{
		// Token: 0x1700596D RID: 22893
		// (get) Token: 0x0602CA65 RID: 182885 RVA: 0x00C8640B File Offset: 0x00C8460B
		// (set) Token: 0x0602CA66 RID: 182886 RVA: 0x00C86413 File Offset: 0x00C84613
		public bool FinishRecord { get; set; }

		// Token: 0x1700596E RID: 22894
		// (get) Token: 0x0602CA67 RID: 182887 RVA: 0x00C8641C File Offset: 0x00C8461C
		// (set) Token: 0x0602CA68 RID: 182888 RVA: 0x00C86424 File Offset: 0x00C84624
		public List<TItem> ItemList { get; set; }
	}
}
