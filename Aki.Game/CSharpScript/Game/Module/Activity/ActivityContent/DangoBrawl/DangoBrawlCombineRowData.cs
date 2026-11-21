using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056DE RID: 22238
	public struct DangoBrawlCombineRowData
	{
		// Token: 0x0401D064 RID: 118884
		[Nullable(1)]
		public CombineItem[] SourceItems;

		// Token: 0x0401D065 RID: 118885
		public int ResultItemId;

		// Token: 0x0401D066 RID: 118886
		public int ComposeId;

		// Token: 0x0401D067 RID: 118887
		public bool CanCombine;

		// Token: 0x0401D068 RID: 118888
		public bool IsLock;

		// Token: 0x0401D069 RID: 118889
		public int SortTier;

		// Token: 0x0401D06A RID: 118890
		public int ResultQuality;
	}
}
