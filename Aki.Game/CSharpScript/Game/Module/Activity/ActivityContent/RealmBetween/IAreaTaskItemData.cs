using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051E6 RID: 20966
	[NullableContext(1)]
	[Nullable(0)]
	public class IAreaTaskItemData
	{
		// Token: 0x0401BB64 RID: 113508
		public RealmBetweenAreaData AreaData;

		// Token: 0x0401BB65 RID: 113509
		public ActivityTaskData TaskData;

		// Token: 0x0401BB66 RID: 113510
		public int? UnlockJumpId;

		// Token: 0x0401BB67 RID: 113511
		[Nullable(2)]
		public string UnlockHintText;
	}
}
