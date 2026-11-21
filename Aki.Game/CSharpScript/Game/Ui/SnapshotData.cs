using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200356B RID: 13675
	[NullableContext(1)]
	[Nullable(0)]
	public class SnapshotData
	{
		// Token: 0x040133F5 RID: 78837
		public int? InTimeFlowViewId;

		// Token: 0x040133F6 RID: 78838
		[Nullable(2)]
		public UiViewInfoForTimeDilation CacheTimeDilationData;

		// Token: 0x040133F7 RID: 78839
		[Nullable(2)]
		public UiViewInfoForTimeDilation TimeDilationData;

		// Token: 0x040133F8 RID: 78840
		public HashSet<string> CacheTimeDilationTagSet = new HashSet<string>();

		// Token: 0x040133F9 RID: 78841
		public HashSet<string> WaitSetTimeDilationTagSet = new HashSet<string>();

		// Token: 0x040133FA RID: 78842
		public List<int> ViewIdList = new List<int>();

		// Token: 0x040133FB RID: 78843
		public Dictionary<int, UiViewInfoForTimeDilation> TimeDilationMap = new Dictionary<int, UiViewInfoForTimeDilation>();
	}
}
