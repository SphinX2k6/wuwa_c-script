using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu
{
	// Token: 0x02003717 RID: 14103
	[NullableContext(1)]
	public interface ITrackMenuItemData
	{
		// Token: 0x17004B7E RID: 19326
		// (get) Token: 0x06024B2D RID: 150317
		// (set) Token: 0x06024B2E RID: 150318
		string Icon { get; set; }

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x06024B2F RID: 150319
		// (set) Token: 0x06024B30 RID: 150320
		string Title { get; set; }

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x06024B31 RID: 150321
		// (set) Token: 0x06024B32 RID: 150322
		string StateIcon { get; set; }

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x06024B33 RID: 150323
		// (set) Token: 0x06024B34 RID: 150324
		bool IsPlayerSelf { get; set; }

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x06024B35 RID: 150325
		// (set) Token: 0x06024B36 RID: 150326
		MarkItem MarkItem { get; set; }
	}
}
