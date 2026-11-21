using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu
{
	// Token: 0x02003718 RID: 14104
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackMenuItemData : ITrackMenuItemData
	{
		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x06024B37 RID: 150327 RVA: 0x00A5C9C7 File Offset: 0x00A5ABC7
		// (set) Token: 0x06024B38 RID: 150328 RVA: 0x00A5C9CF File Offset: 0x00A5ABCF
		public string Icon { get; set; }

		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x06024B39 RID: 150329 RVA: 0x00A5C9D8 File Offset: 0x00A5ABD8
		// (set) Token: 0x06024B3A RID: 150330 RVA: 0x00A5C9E0 File Offset: 0x00A5ABE0
		public string Title { get; set; }

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x06024B3B RID: 150331 RVA: 0x00A5C9E9 File Offset: 0x00A5ABE9
		// (set) Token: 0x06024B3C RID: 150332 RVA: 0x00A5C9F1 File Offset: 0x00A5ABF1
		public string StateIcon { get; set; }

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x06024B3D RID: 150333 RVA: 0x00A5C9FA File Offset: 0x00A5ABFA
		// (set) Token: 0x06024B3E RID: 150334 RVA: 0x00A5CA02 File Offset: 0x00A5AC02
		public bool IsPlayerSelf { get; set; }

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x06024B3F RID: 150335 RVA: 0x00A5CA0B File Offset: 0x00A5AC0B
		// (set) Token: 0x06024B40 RID: 150336 RVA: 0x00A5CA13 File Offset: 0x00A5AC13
		public MarkItem MarkItem { get; set; }
	}
}
