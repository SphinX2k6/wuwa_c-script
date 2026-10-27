using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058C5 RID: 22725
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDetectItemGetterData : IInstanceDetectItemGetterData
	{
		// Token: 0x17008AA9 RID: 35497
		// (get) Token: 0x06039C46 RID: 236614 RVA: 0x00DBA1F5 File Offset: 0x00DB83F5
		// (set) Token: 0x06039C47 RID: 236615 RVA: 0x00DBA1FD File Offset: 0x00DB83FD
		public TInstanceSubtitleTextIdGetter SubtitleTextIdGetter { get; set; }

		// Token: 0x17008AAA RID: 35498
		// (get) Token: 0x06039C48 RID: 236616 RVA: 0x00DBA206 File Offset: 0x00DB8406
		// (set) Token: 0x06039C49 RID: 236617 RVA: 0x00DBA20E File Offset: 0x00DB840E
		public TInstanceSubtitleArgsGetter SubtitleArgsGetter { get; set; }

		// Token: 0x17008AAB RID: 35499
		// (get) Token: 0x06039C4A RID: 236618 RVA: 0x00DBA217 File Offset: 0x00DB8417
		// (set) Token: 0x06039C4B RID: 236619 RVA: 0x00DBA21F File Offset: 0x00DB841F
		public TInstanceCheckFinishedGetter CheckFinishedGetter { get; set; }
	}
}
