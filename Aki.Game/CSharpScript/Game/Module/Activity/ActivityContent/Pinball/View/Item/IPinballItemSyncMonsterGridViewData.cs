using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006345 RID: 25413
	[NullableContext(1)]
	public interface IPinballItemSyncMonsterGridViewData
	{
		// Token: 0x1700930F RID: 37647
		// (get) Token: 0x0603FF32 RID: 261938
		// (set) Token: 0x0603FF33 RID: 261939
		IPinballItemDataMonster ItemData { get; set; }

		// Token: 0x17009310 RID: 37648
		// (get) Token: 0x0603FF34 RID: 261940
		// (set) Token: 0x0603FF35 RID: 261941
		bool IsSelected { get; set; }

		// Token: 0x17009311 RID: 37649
		// (get) Token: 0x0603FF36 RID: 261942
		// (set) Token: 0x0603FF37 RID: 261943
		Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }
	}
}
