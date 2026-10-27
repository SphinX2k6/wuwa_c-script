using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005564 RID: 21860
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingPointMarkCreateParam : IDynamicMarkCreateParams
	{
		// Token: 0x170085E9 RID: 34281
		// (get) Token: 0x06037BCB RID: 228299 RVA: 0x00D38E01 File Offset: 0x00D37001
		// (set) Token: 0x06037BCC RID: 228300 RVA: 0x00D38E09 File Offset: 0x00D37009
		public TTrackTarget TrackTarget { get; set; }

		// Token: 0x170085EA RID: 34282
		// (get) Token: 0x06037BCD RID: 228301 RVA: 0x00D38E12 File Offset: 0x00D37012
		// (set) Token: 0x06037BCE RID: 228302 RVA: 0x00D38E1A File Offset: 0x00D3701A
		public int MarkConfigId { get; set; }

		// Token: 0x170085EB RID: 34283
		// (get) Token: 0x06037BCF RID: 228303 RVA: 0x00D38E23 File Offset: 0x00D37023
		// (set) Token: 0x06037BD0 RID: 228304 RVA: 0x00D38E2B File Offset: 0x00D3702B
		public EMarkType MarkType { get; set; }

		// Token: 0x170085EC RID: 34284
		// (get) Token: 0x06037BD1 RID: 228305 RVA: 0x00D38E34 File Offset: 0x00D37034
		// (set) Token: 0x06037BD2 RID: 228306 RVA: 0x00D38E3C File Offset: 0x00D3703C
		public int? MarkId { get; set; }

		// Token: 0x170085ED RID: 34285
		// (get) Token: 0x06037BD3 RID: 228307 RVA: 0x00D38E45 File Offset: 0x00D37045
		// (set) Token: 0x06037BD4 RID: 228308 RVA: 0x00D38E4D File Offset: 0x00D3704D
		public ETrackSource? TrackSource { get; set; }

		// Token: 0x170085EE RID: 34286
		// (get) Token: 0x06037BD5 RID: 228309 RVA: 0x00D38E56 File Offset: 0x00D37056
		// (set) Token: 0x06037BD6 RID: 228310 RVA: 0x00D38E5E File Offset: 0x00D3705E
		public bool? DestroyOnUnTrack { get; set; }

		// Token: 0x170085EF RID: 34287
		// (get) Token: 0x06037BD7 RID: 228311 RVA: 0x00D38E67 File Offset: 0x00D37067
		// (set) Token: 0x06037BD8 RID: 228312 RVA: 0x00D38E6F File Offset: 0x00D3706F
		public int? TeleportId { get; set; }

		// Token: 0x170085F0 RID: 34288
		// (get) Token: 0x06037BD9 RID: 228313 RVA: 0x00D38E78 File Offset: 0x00D37078
		// (set) Token: 0x06037BDA RID: 228314 RVA: 0x00D38E80 File Offset: 0x00D37080
		public int? EntityConfigId { get; set; }

		// Token: 0x170085F1 RID: 34289
		// (get) Token: 0x06037BDB RID: 228315 RVA: 0x00D38E89 File Offset: 0x00D37089
		// (set) Token: 0x06037BDC RID: 228316 RVA: 0x00D38E91 File Offset: 0x00D37091
		public MarkState? ServerMarkState { get; set; }

		// Token: 0x170085F2 RID: 34290
		// (get) Token: 0x06037BDD RID: 228317 RVA: 0x00D38E9A File Offset: 0x00D3709A
		// (set) Token: 0x06037BDE RID: 228318 RVA: 0x00D38EA2 File Offset: 0x00D370A2
		[Nullable(2)]
		public MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170085F3 RID: 34291
		// (get) Token: 0x06037BDF RID: 228319 RVA: 0x00D38EAB File Offset: 0x00D370AB
		// (set) Token: 0x06037BE0 RID: 228320 RVA: 0x00D38EB3 File Offset: 0x00D370B3
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x170085F4 RID: 34292
		// (get) Token: 0x06037BE1 RID: 228321 RVA: 0x00D38EBC File Offset: 0x00D370BC
		// (set) Token: 0x06037BE2 RID: 228322 RVA: 0x00D38EC4 File Offset: 0x00D370C4
		public int? AreaId { get; set; }

		// Token: 0x170085F5 RID: 34293
		// (get) Token: 0x06037BE3 RID: 228323 RVA: 0x00D38ECD File Offset: 0x00D370CD
		// (set) Token: 0x06037BE4 RID: 228324 RVA: 0x00D38ED5 File Offset: 0x00D370D5
		public EFishPointDetectSourceType FishPointDetectSourceType { get; set; }
	}
}
