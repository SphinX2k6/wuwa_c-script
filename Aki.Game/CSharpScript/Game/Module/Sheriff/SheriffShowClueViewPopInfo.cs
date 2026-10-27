using System;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C50 RID: 19536
	public class SheriffShowClueViewPopInfo : ISheriffShowClueViewPopInfo
	{
		// Token: 0x17007CCC RID: 31948
		// (get) Token: 0x06032810 RID: 206864 RVA: 0x00BC345E File Offset: 0x00BC165E
		// (set) Token: 0x06032811 RID: 206865 RVA: 0x00BC3466 File Offset: 0x00BC1666
		public int AnomalyId { get; set; }

		// Token: 0x17007CCD RID: 31949
		// (get) Token: 0x06032812 RID: 206866 RVA: 0x00BC346F File Offset: 0x00BC166F
		// (set) Token: 0x06032813 RID: 206867 RVA: 0x00BC3477 File Offset: 0x00BC1677
		public int? ClueId { get; set; }
	}
}
