using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200678E RID: 26510
	public struct DangoBrawlCombineRowData
	{
		// Token: 0x04022807 RID: 141319
		[Nullable(1)]
		public CombineItem[] SourceItems;

		// Token: 0x04022808 RID: 141320
		public int ResultItemId;

		// Token: 0x04022809 RID: 141321
		public int ComposeId;

		// Token: 0x0402280A RID: 141322
		public bool CanCombine;

		// Token: 0x0402280B RID: 141323
		public bool IsLock;

		// Token: 0x0402280C RID: 141324
		public int SortTier;

		// Token: 0x0402280D RID: 141325
		public int ResultQuality;
	}
}
