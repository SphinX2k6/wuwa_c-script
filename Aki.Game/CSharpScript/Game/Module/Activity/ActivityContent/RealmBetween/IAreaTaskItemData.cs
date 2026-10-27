using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006268 RID: 25192
	[NullableContext(1)]
	[Nullable(0)]
	public class IAreaTaskItemData
	{
		// Token: 0x04021235 RID: 135733
		public RealmBetweenAreaData AreaData;

		// Token: 0x04021236 RID: 135734
		public ActivityTaskData TaskData;

		// Token: 0x04021237 RID: 135735
		public int? UnlockJumpId;

		// Token: 0x04021238 RID: 135736
		[Nullable(2)]
		public string UnlockHintText;
	}
}
