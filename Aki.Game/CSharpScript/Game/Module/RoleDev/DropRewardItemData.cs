using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CC3 RID: 19651
	public class DropRewardItemData : IDropRewardItemData
	{
		// Token: 0x17007D38 RID: 32056
		// (get) Token: 0x06032BB7 RID: 207799 RVA: 0x00BD51DD File Offset: 0x00BD33DD
		// (set) Token: 0x06032BB8 RID: 207800 RVA: 0x00BD51E5 File Offset: 0x00BD33E5
		public int ItemId { get; set; }

		// Token: 0x17007D39 RID: 32057
		// (get) Token: 0x06032BB9 RID: 207801 RVA: 0x00BD51EE File Offset: 0x00BD33EE
		// (set) Token: 0x06032BBA RID: 207802 RVA: 0x00BD51F6 File Offset: 0x00BD33F6
		public int Count { get; set; }

		// Token: 0x17007D3A RID: 32058
		// (get) Token: 0x06032BBB RID: 207803 RVA: 0x00BD51FF File Offset: 0x00BD33FF
		// (set) Token: 0x06032BBC RID: 207804 RVA: 0x00BD5207 File Offset: 0x00BD3407
		public bool HaveFinish { get; set; }
	}
}
