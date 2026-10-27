using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058C4 RID: 22724
	[NullableContext(2)]
	public interface IInstanceDetectItemGetterData
	{
		// Token: 0x17008AA6 RID: 35494
		// (get) Token: 0x06039C40 RID: 236608
		// (set) Token: 0x06039C41 RID: 236609
		TInstanceSubtitleTextIdGetter SubtitleTextIdGetter { get; set; }

		// Token: 0x17008AA7 RID: 35495
		// (get) Token: 0x06039C42 RID: 236610
		// (set) Token: 0x06039C43 RID: 236611
		TInstanceSubtitleArgsGetter SubtitleArgsGetter { get; set; }

		// Token: 0x17008AA8 RID: 35496
		// (get) Token: 0x06039C44 RID: 236612
		// (set) Token: 0x06039C45 RID: 236613
		TInstanceCheckFinishedGetter CheckFinishedGetter { get; set; }
	}
}
