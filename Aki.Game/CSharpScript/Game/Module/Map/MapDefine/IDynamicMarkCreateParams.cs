using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005567 RID: 21863
	[NullableContext(1)]
	public interface IDynamicMarkCreateParams
	{
		// Token: 0x170085F7 RID: 34295
		// (get) Token: 0x06037BEA RID: 228330
		// (set) Token: 0x06037BEB RID: 228331
		TTrackTarget TrackTarget { get; set; }

		// Token: 0x170085F8 RID: 34296
		// (get) Token: 0x06037BEC RID: 228332
		// (set) Token: 0x06037BED RID: 228333
		int MarkConfigId { get; set; }

		// Token: 0x170085F9 RID: 34297
		// (get) Token: 0x06037BEE RID: 228334
		// (set) Token: 0x06037BEF RID: 228335
		EMarkType MarkType { get; set; }

		// Token: 0x170085FA RID: 34298
		// (get) Token: 0x06037BF0 RID: 228336
		// (set) Token: 0x06037BF1 RID: 228337
		int? MarkId { get; set; }

		// Token: 0x170085FB RID: 34299
		// (get) Token: 0x06037BF2 RID: 228338
		// (set) Token: 0x06037BF3 RID: 228339
		ETrackSource? TrackSource { get; set; }

		// Token: 0x170085FC RID: 34300
		// (get) Token: 0x06037BF4 RID: 228340
		// (set) Token: 0x06037BF5 RID: 228341
		bool? DestroyOnUnTrack { get; set; }

		// Token: 0x170085FD RID: 34301
		// (get) Token: 0x06037BF6 RID: 228342
		// (set) Token: 0x06037BF7 RID: 228343
		int? TeleportId { get; set; }

		// Token: 0x170085FE RID: 34302
		// (get) Token: 0x06037BF8 RID: 228344
		// (set) Token: 0x06037BF9 RID: 228345
		int? EntityConfigId { get; set; }

		// Token: 0x170085FF RID: 34303
		// (get) Token: 0x06037BFA RID: 228346
		// (set) Token: 0x06037BFB RID: 228347
		MarkState? ServerMarkState { get; set; }

		// Token: 0x17008600 RID: 34304
		// (get) Token: 0x06037BFC RID: 228348
		// (set) Token: 0x06037BFD RID: 228349
		[Nullable(2)]
		MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008601 RID: 34305
		// (get) Token: 0x06037BFE RID: 228350
		// (set) Token: 0x06037BFF RID: 228351
		EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17008602 RID: 34306
		// (get) Token: 0x06037C00 RID: 228352
		// (set) Token: 0x06037C01 RID: 228353
		int? AreaId { get; set; }
	}
}
