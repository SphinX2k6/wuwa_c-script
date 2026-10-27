using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005553 RID: 21843
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicMarkCreateParams : IDynamicMarkCreateParams
	{
		// Token: 0x170085DC RID: 34268
		// (get) Token: 0x06037BB0 RID: 228272 RVA: 0x00D38D12 File Offset: 0x00D36F12
		// (set) Token: 0x06037BB1 RID: 228273 RVA: 0x00D38D1A File Offset: 0x00D36F1A
		public TTrackTarget TrackTarget { get; set; }

		// Token: 0x170085DD RID: 34269
		// (get) Token: 0x06037BB2 RID: 228274 RVA: 0x00D38D23 File Offset: 0x00D36F23
		// (set) Token: 0x06037BB3 RID: 228275 RVA: 0x00D38D2B File Offset: 0x00D36F2B
		public int MarkConfigId { get; set; }

		// Token: 0x170085DE RID: 34270
		// (get) Token: 0x06037BB4 RID: 228276 RVA: 0x00D38D34 File Offset: 0x00D36F34
		// (set) Token: 0x06037BB5 RID: 228277 RVA: 0x00D38D3C File Offset: 0x00D36F3C
		public EMarkType MarkType { get; set; }

		// Token: 0x170085DF RID: 34271
		// (get) Token: 0x06037BB6 RID: 228278 RVA: 0x00D38D45 File Offset: 0x00D36F45
		// (set) Token: 0x06037BB7 RID: 228279 RVA: 0x00D38D4D File Offset: 0x00D36F4D
		public int? MarkId { get; set; }

		// Token: 0x170085E0 RID: 34272
		// (get) Token: 0x06037BB8 RID: 228280 RVA: 0x00D38D56 File Offset: 0x00D36F56
		// (set) Token: 0x06037BB9 RID: 228281 RVA: 0x00D38D5E File Offset: 0x00D36F5E
		public ETrackSource? TrackSource { get; set; }

		// Token: 0x170085E1 RID: 34273
		// (get) Token: 0x06037BBA RID: 228282 RVA: 0x00D38D67 File Offset: 0x00D36F67
		// (set) Token: 0x06037BBB RID: 228283 RVA: 0x00D38D6F File Offset: 0x00D36F6F
		public bool? DestroyOnUnTrack { get; set; }

		// Token: 0x170085E2 RID: 34274
		// (get) Token: 0x06037BBC RID: 228284 RVA: 0x00D38D78 File Offset: 0x00D36F78
		// (set) Token: 0x06037BBD RID: 228285 RVA: 0x00D38D80 File Offset: 0x00D36F80
		public int? TeleportId { get; set; }

		// Token: 0x170085E3 RID: 34275
		// (get) Token: 0x06037BBE RID: 228286 RVA: 0x00D38D89 File Offset: 0x00D36F89
		// (set) Token: 0x06037BBF RID: 228287 RVA: 0x00D38D91 File Offset: 0x00D36F91
		public int? EntityConfigId { get; set; }

		// Token: 0x170085E4 RID: 34276
		// (get) Token: 0x06037BC0 RID: 228288 RVA: 0x00D38D9A File Offset: 0x00D36F9A
		// (set) Token: 0x06037BC1 RID: 228289 RVA: 0x00D38DA2 File Offset: 0x00D36FA2
		public MarkState? ServerMarkState { get; set; }

		// Token: 0x170085E5 RID: 34277
		// (get) Token: 0x06037BC2 RID: 228290 RVA: 0x00D38DAB File Offset: 0x00D36FAB
		// (set) Token: 0x06037BC3 RID: 228291 RVA: 0x00D38DB3 File Offset: 0x00D36FB3
		[Nullable(2)]
		public MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170085E6 RID: 34278
		// (get) Token: 0x06037BC4 RID: 228292 RVA: 0x00D38DBC File Offset: 0x00D36FBC
		// (set) Token: 0x06037BC5 RID: 228293 RVA: 0x00D38DC4 File Offset: 0x00D36FC4
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x170085E7 RID: 34279
		// (get) Token: 0x06037BC6 RID: 228294 RVA: 0x00D38DCD File Offset: 0x00D36FCD
		// (set) Token: 0x06037BC7 RID: 228295 RVA: 0x00D38DD5 File Offset: 0x00D36FD5
		public int? AreaId { get; set; }
	}
}
