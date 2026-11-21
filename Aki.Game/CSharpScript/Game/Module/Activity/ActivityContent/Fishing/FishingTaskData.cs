using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020054FE RID: 21758
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTaskData
	{
		// Token: 0x0401C803 RID: 116739
		public int TaskId;

		// Token: 0x0401C804 RID: 116740
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x0401C805 RID: 116741
		public int JumpId;

		// Token: 0x0401C806 RID: 116742
		public int Current;

		// Token: 0x0401C807 RID: 116743
		public int Target;

		// Token: 0x0401C808 RID: 116744
		public string TitleTextId = "";

		// Token: 0x0401C809 RID: 116745
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x0401C80A RID: 116746
		[Nullable(2)]
		public Action<int> ReceiveDelegate;
	}
}
