using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006580 RID: 25984
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTaskData
	{
		// Token: 0x04021ED2 RID: 138962
		public int TaskId;

		// Token: 0x04021ED3 RID: 138963
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x04021ED4 RID: 138964
		public int JumpId;

		// Token: 0x04021ED5 RID: 138965
		public int Current;

		// Token: 0x04021ED6 RID: 138966
		public int Target;

		// Token: 0x04021ED7 RID: 138967
		public string TitleTextId = "";

		// Token: 0x04021ED8 RID: 138968
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x04021ED9 RID: 138969
		[Nullable(2)]
		public Action<int> ReceiveDelegate;
	}
}
