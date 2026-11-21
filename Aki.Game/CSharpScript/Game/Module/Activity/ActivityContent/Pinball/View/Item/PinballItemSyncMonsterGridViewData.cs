using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C4 RID: 21188
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncMonsterGridViewData : IPinballItemSyncMonsterGridViewData
	{
		// Token: 0x17006674 RID: 26228
		// (get) Token: 0x06034BF9 RID: 216057 RVA: 0x00EC0AB9 File Offset: 0x00EBECB9
		// (set) Token: 0x06034BFA RID: 216058 RVA: 0x00EC0AC1 File Offset: 0x00EBECC1
		public IPinballItemDataMonster ItemData { get; set; }

		// Token: 0x17006675 RID: 26229
		// (get) Token: 0x06034BFB RID: 216059 RVA: 0x00EC0ACA File Offset: 0x00EBECCA
		// (set) Token: 0x06034BFC RID: 216060 RVA: 0x00EC0AD2 File Offset: 0x00EBECD2
		public bool IsSelected { get; set; }

		// Token: 0x17006676 RID: 26230
		// (get) Token: 0x06034BFD RID: 216061 RVA: 0x00EC0ADB File Offset: 0x00EBECDB
		// (set) Token: 0x06034BFE RID: 216062 RVA: 0x00EC0AE3 File Offset: 0x00EBECE3
		public Action<IPinballItemToggleCallback> OnStateChangeDelegate { get; set; }
	}
}
