using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x0200489C RID: 18588
	[NullableContext(2)]
	public interface IInstanceDetectItemGetterData
	{
		// Token: 0x17005E72 RID: 24178
		// (get) Token: 0x0602EB63 RID: 191331
		// (set) Token: 0x0602EB64 RID: 191332
		TInstanceSubtitleTextIdGetter SubtitleTextIdGetter { get; set; }

		// Token: 0x17005E73 RID: 24179
		// (get) Token: 0x0602EB65 RID: 191333
		// (set) Token: 0x0602EB66 RID: 191334
		TInstanceSubtitleArgsGetter SubtitleArgsGetter { get; set; }

		// Token: 0x17005E74 RID: 24180
		// (get) Token: 0x0602EB67 RID: 191335
		// (set) Token: 0x0602EB68 RID: 191336
		TInstanceCheckFinishedGetter CheckFinishedGetter { get; set; }
	}
}
