using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapNote
{
	// Token: 0x0200370E RID: 14094
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNoteItemData
	{
		// Token: 0x040145FD RID: 83453
		public int Id;

		// Token: 0x040145FE RID: 83454
		public string IconRes = "";

		// Token: 0x040145FF RID: 83455
		public string DescId = "";

		// Token: 0x04014600 RID: 83456
		public EMapNoteStyle NoteStyle;

		// Token: 0x04014601 RID: 83457
		[Nullable(2)]
		public Action<int> ClickCallback;

		// Token: 0x04014602 RID: 83458
		[Nullable(2)]
		public string CustomDesc;
	}
}
