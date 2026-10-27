using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200463A RID: 17978
	[NullableContext(1)]
	[Nullable(0)]
	public class SnapshotData
	{
		// Token: 0x04018D9C RID: 101788
		public int? InTimeFlowViewId;

		// Token: 0x04018D9D RID: 101789
		[Nullable(2)]
		public UiViewInfoForTimeDilation CacheTimeDilationData;

		// Token: 0x04018D9E RID: 101790
		[Nullable(2)]
		public UiViewInfoForTimeDilation TimeDilationData;

		// Token: 0x04018D9F RID: 101791
		public HashSet<string> CacheTimeDilationTagSet = new HashSet<string>();

		// Token: 0x04018DA0 RID: 101792
		public HashSet<string> WaitSetTimeDilationTagSet = new HashSet<string>();

		// Token: 0x04018DA1 RID: 101793
		public List<int> ViewIdList = new List<int>();

		// Token: 0x04018DA2 RID: 101794
		public Dictionary<int, UiViewInfoForTimeDilation> TimeDilationMap = new Dictionary<int, UiViewInfoForTimeDilation>();
	}
}
