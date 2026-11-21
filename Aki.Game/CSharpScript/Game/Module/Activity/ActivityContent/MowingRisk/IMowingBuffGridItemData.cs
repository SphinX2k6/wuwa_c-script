using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200533B RID: 21307
	[NullableContext(1)]
	public interface IMowingBuffGridItemData
	{
		// Token: 0x17006713 RID: 26387
		// (get) Token: 0x06035081 RID: 217217
		// (set) Token: 0x06035082 RID: 217218
		int BuffId { get; set; }

		// Token: 0x17006714 RID: 26388
		// (get) Token: 0x06035083 RID: 217219
		// (set) Token: 0x06035084 RID: 217220
		string QualityPath { get; set; }

		// Token: 0x17006715 RID: 26389
		// (get) Token: 0x06035085 RID: 217221
		// (set) Token: 0x06035086 RID: 217222
		string IconPath { get; set; }

		// Token: 0x17006716 RID: 26390
		// (get) Token: 0x06035087 RID: 217223
		// (set) Token: 0x06035088 RID: 217224
		string NameTextId { get; set; }

		// Token: 0x17006717 RID: 26391
		// (get) Token: 0x06035089 RID: 217225
		// (set) Token: 0x0603508A RID: 217226
		bool IsShowBackground { get; set; }

		// Token: 0x17006718 RID: 26392
		// (get) Token: 0x0603508B RID: 217227
		// (set) Token: 0x0603508C RID: 217228
		bool IsChosen { get; set; }

		// Token: 0x17006719 RID: 26393
		// (get) Token: 0x0603508D RID: 217229
		// (set) Token: 0x0603508E RID: 217230
		bool IsUnlock { get; set; }

		// Token: 0x1700671A RID: 26394
		// (get) Token: 0x0603508F RID: 217231
		// (set) Token: 0x06035090 RID: 217232
		string LevelContent { get; set; }
	}
}
