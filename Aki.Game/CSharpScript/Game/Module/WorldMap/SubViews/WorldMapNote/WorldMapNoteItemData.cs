using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapNote
{
	// Token: 0x020047DD RID: 18397
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNoteItemData
	{
		// Token: 0x04019F49 RID: 106313
		public int Id;

		// Token: 0x04019F4A RID: 106314
		public string IconRes = "";

		// Token: 0x04019F4B RID: 106315
		public string DescId = "";

		// Token: 0x04019F4C RID: 106316
		public EMapNoteStyle NoteStyle;

		// Token: 0x04019F4D RID: 106317
		[Nullable(2)]
		public Action<int> ClickCallback;

		// Token: 0x04019F4E RID: 106318
		[Nullable(2)]
		public string CustomDesc;
	}
}
