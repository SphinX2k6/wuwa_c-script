using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x0200489D RID: 18589
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDetectItemGetterData : IInstanceDetectItemGetterData
	{
		// Token: 0x17005E75 RID: 24181
		// (get) Token: 0x0602EB69 RID: 191337 RVA: 0x00D0910D File Offset: 0x00D0730D
		// (set) Token: 0x0602EB6A RID: 191338 RVA: 0x00D09115 File Offset: 0x00D07315
		public TInstanceSubtitleTextIdGetter SubtitleTextIdGetter { get; set; }

		// Token: 0x17005E76 RID: 24182
		// (get) Token: 0x0602EB6B RID: 191339 RVA: 0x00D0911E File Offset: 0x00D0731E
		// (set) Token: 0x0602EB6C RID: 191340 RVA: 0x00D09126 File Offset: 0x00D07326
		public TInstanceSubtitleArgsGetter SubtitleArgsGetter { get; set; }

		// Token: 0x17005E77 RID: 24183
		// (get) Token: 0x0602EB6D RID: 191341 RVA: 0x00D0912F File Offset: 0x00D0732F
		// (set) Token: 0x0602EB6E RID: 191342 RVA: 0x00D09137 File Offset: 0x00D07337
		public TInstanceCheckFinishedGetter CheckFinishedGetter { get; set; }
	}
}
