using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006346 RID: 25414
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncMonsterGridViewData : IPinballItemSyncMonsterGridViewData
	{
		// Token: 0x17009312 RID: 37650
		// (get) Token: 0x0603FF38 RID: 261944 RVA: 0x00F79B59 File Offset: 0x00F77D59
		// (set) Token: 0x0603FF39 RID: 261945 RVA: 0x00F79B61 File Offset: 0x00F77D61
		public IPinballItemDataMonster ItemData { get; set; }

		// Token: 0x17009313 RID: 37651
		// (get) Token: 0x0603FF3A RID: 261946 RVA: 0x00F79B6A File Offset: 0x00F77D6A
		// (set) Token: 0x0603FF3B RID: 261947 RVA: 0x00F79B72 File Offset: 0x00F77D72
		public bool IsSelected { get; set; }

		// Token: 0x17009314 RID: 37652
		// (get) Token: 0x0603FF3C RID: 261948 RVA: 0x00F79B7B File Offset: 0x00F77D7B
		// (set) Token: 0x0603FF3D RID: 261949 RVA: 0x00F79B83 File Offset: 0x00F77D83
		public Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }
	}
}
