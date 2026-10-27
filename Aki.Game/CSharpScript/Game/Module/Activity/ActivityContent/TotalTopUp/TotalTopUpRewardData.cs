using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F88 RID: 24456
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpRewardData
	{
		// Token: 0x04020687 RID: 132743
		public int Id;

		// Token: 0x04020688 RID: 132744
		public int Score;

		// Token: 0x04020689 RID: 132745
		public ETotalTopUpRewardState State;

		// Token: 0x0402068A RID: 132746
		public List<int> ItemIdList = new List<int>();

		// Token: 0x0402068B RID: 132747
		public Dictionary<int, int> ItemMap = new Dictionary<int, int>();

		// Token: 0x0402068C RID: 132748
		public int FirstItemId;

		// Token: 0x0402068D RID: 132749
		public int FirstItemCount;

		// Token: 0x0402068E RID: 132750
		public List<int> PreviewButtonRegistry = new List<int>();

		// Token: 0x0402068F RID: 132751
		[Nullable(2)]
		public TotalTopUpRolePackageData TotalTopUpRolePackageData;

		// Token: 0x04020690 RID: 132752
		[Nullable(2)]
		public TotalTopUpWeaponPackageData TotalTopUpWeaponPackageData;
	}
}
