using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F6F RID: 20335
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpRewardData
	{
		// Token: 0x0401B159 RID: 110937
		public int Id;

		// Token: 0x0401B15A RID: 110938
		public int Score;

		// Token: 0x0401B15B RID: 110939
		public ETotalTopUpRewardState State;

		// Token: 0x0401B15C RID: 110940
		public List<int> ItemIdList = new List<int>();

		// Token: 0x0401B15D RID: 110941
		public Dictionary<int, int> ItemMap = new Dictionary<int, int>();

		// Token: 0x0401B15E RID: 110942
		public int FirstItemId;

		// Token: 0x0401B15F RID: 110943
		public int FirstItemCount;

		// Token: 0x0401B160 RID: 110944
		public List<int> PreviewButtonRegistry = new List<int>();

		// Token: 0x0401B161 RID: 110945
		[Nullable(2)]
		public TotalTopUpRolePackageData TotalTopUpRolePackageData;

		// Token: 0x0401B162 RID: 110946
		[Nullable(2)]
		public TotalTopUpWeaponPackageData TotalTopUpWeaponPackageData;
	}
}
