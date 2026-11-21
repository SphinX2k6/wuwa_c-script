using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042C7 RID: 17095
	public interface IRogueEndingItemParam
	{
		// Token: 0x170056DA RID: 22234
		// (get) Token: 0x0602B4B3 RID: 177331
		// (set) Token: 0x0602B4B4 RID: 177332
		int ConfigId { get; set; }

		// Token: 0x170056DB RID: 22235
		// (get) Token: 0x0602B4B5 RID: 177333
		// (set) Token: 0x0602B4B6 RID: 177334
		int Index { get; set; }

		// Token: 0x170056DC RID: 22236
		// (get) Token: 0x0602B4B7 RID: 177335
		// (set) Token: 0x0602B4B8 RID: 177336
		float? Rotation { get; set; }

		// Token: 0x170056DD RID: 22237
		// (get) Token: 0x0602B4B9 RID: 177337
		// (set) Token: 0x0602B4BA RID: 177338
		bool IsSubView { get; set; }

		// Token: 0x170056DE RID: 22238
		// (get) Token: 0x0602B4BB RID: 177339
		// (set) Token: 0x0602B4BC RID: 177340
		bool IsUnlock { get; set; }
	}
}
