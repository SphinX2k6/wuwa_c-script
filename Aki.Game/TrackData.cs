using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x0200218F RID: 8591
[NullableContext(2)]
[Nullable(0)]
public class TrackData : ITrackData
{
	// Token: 0x17001FD6 RID: 8150
	// (get) Token: 0x0601512A RID: 86314 RVA: 0x00624555 File Offset: 0x00622755
	// (set) Token: 0x0601512B RID: 86315 RVA: 0x0062455D File Offset: 0x0062275D
	public ETrackSource TrackSource { get; set; }

	// Token: 0x17001FD7 RID: 8151
	// (get) Token: 0x0601512C RID: 86316 RVA: 0x00624566 File Offset: 0x00622766
	// (set) Token: 0x0601512D RID: 86317 RVA: 0x0062456E File Offset: 0x0062276E
	public EMarkType? MarkType { get; set; }

	// Token: 0x17001FD8 RID: 8152
	// (get) Token: 0x0601512E RID: 86318 RVA: 0x00624577 File Offset: 0x00622777
	// (set) Token: 0x0601512F RID: 86319 RVA: 0x0062457F File Offset: 0x0062277F
	public int Id { get; set; }

	// Token: 0x17001FD9 RID: 8153
	// (get) Token: 0x06015130 RID: 86320 RVA: 0x00624588 File Offset: 0x00622788
	// (set) Token: 0x06015131 RID: 86321 RVA: 0x00624590 File Offset: 0x00622790
	[Nullable(1)]
	public string IconPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001FDA RID: 8154
	// (get) Token: 0x06015132 RID: 86322 RVA: 0x00624599 File Offset: 0x00622799
	// (set) Token: 0x06015133 RID: 86323 RVA: 0x006245A1 File Offset: 0x006227A1
	public TTrackTarget TrackTarget { get; set; }

	// Token: 0x17001FDB RID: 8155
	// (get) Token: 0x06015134 RID: 86324 RVA: 0x006245AA File Offset: 0x006227AA
	// (set) Token: 0x06015135 RID: 86325 RVA: 0x006245B2 File Offset: 0x006227B2
	public int? TrackInstanceId { get; set; }

	// Token: 0x17001FDC RID: 8156
	// (get) Token: 0x06015136 RID: 86326 RVA: 0x006245BB File Offset: 0x006227BB
	// (set) Token: 0x06015137 RID: 86327 RVA: 0x006245C3 File Offset: 0x006227C3
	public bool? TrackHudEnable { get; set; }

	// Token: 0x17001FDD RID: 8157
	// (get) Token: 0x06015138 RID: 86328 RVA: 0x006245CC File Offset: 0x006227CC
	// (set) Token: 0x06015139 RID: 86329 RVA: 0x006245D4 File Offset: 0x006227D4
	public float? TrackAutoCancelDistance { get; set; }

	// Token: 0x17001FDE RID: 8158
	// (get) Token: 0x0601513A RID: 86330 RVA: 0x006245DD File Offset: 0x006227DD
	// (set) Token: 0x0601513B RID: 86331 RVA: 0x006245E5 File Offset: 0x006227E5
	public bool? IsSubTrack { get; set; }

	// Token: 0x17001FDF RID: 8159
	// (get) Token: 0x0601513C RID: 86332 RVA: 0x006245EE File Offset: 0x006227EE
	// (set) Token: 0x0601513D RID: 86333 RVA: 0x006245F6 File Offset: 0x006227F6
	public float? TrackHideDis { get; set; }

	// Token: 0x17001FE0 RID: 8160
	// (get) Token: 0x0601513E RID: 86334 RVA: 0x006245FF File Offset: 0x006227FF
	// (set) Token: 0x0601513F RID: 86335 RVA: 0x00624607 File Offset: 0x00622807
	public int? ShowGroupId { get; set; }

	// Token: 0x17001FE1 RID: 8161
	// (get) Token: 0x06015140 RID: 86336 RVA: 0x00624610 File Offset: 0x00622810
	// (set) Token: 0x06015141 RID: 86337 RVA: 0x00624618 File Offset: 0x00622818
	public ETrackType? TrackType { get; set; }

	// Token: 0x17001FE2 RID: 8162
	// (get) Token: 0x06015142 RID: 86338 RVA: 0x00624621 File Offset: 0x00622821
	// (set) Token: 0x06015143 RID: 86339 RVA: 0x00624629 File Offset: 0x00622829
	public bool? AutoHideTrack { get; set; }

	// Token: 0x17001FE3 RID: 8163
	// (get) Token: 0x06015144 RID: 86340 RVA: 0x00624632 File Offset: 0x00622832
	// (set) Token: 0x06015145 RID: 86341 RVA: 0x0062463A File Offset: 0x0062283A
	public string PrefabPath { get; set; }

	// Token: 0x17001FE4 RID: 8164
	// (get) Token: 0x06015146 RID: 86342 RVA: 0x00624643 File Offset: 0x00622843
	// (set) Token: 0x06015147 RID: 86343 RVA: 0x0062464B File Offset: 0x0062284B
	public Vector Offset { get; set; }

	// Token: 0x17001FE5 RID: 8165
	// (get) Token: 0x06015148 RID: 86344 RVA: 0x00624654 File Offset: 0x00622854
	// (set) Token: 0x06015149 RID: 86345 RVA: 0x0062465C File Offset: 0x0062285C
	public bool? IsInTrackRange { get; set; }

	// Token: 0x17001FE6 RID: 8166
	// (get) Token: 0x0601514A RID: 86346 RVA: 0x00624665 File Offset: 0x00622865
	// (set) Token: 0x0601514B RID: 86347 RVA: 0x0062466D File Offset: 0x0062286D
	public int? AreaId { get; set; }

	// Token: 0x17001FE7 RID: 8167
	// (get) Token: 0x0601514C RID: 86348 RVA: 0x00624676 File Offset: 0x00622876
	// (set) Token: 0x0601514D RID: 86349 RVA: 0x0062467E File Offset: 0x0062287E
	public int? MultiMapId { get; set; }

	// Token: 0x17001FE8 RID: 8168
	// (get) Token: 0x0601514E RID: 86350 RVA: 0x00624687 File Offset: 0x00622887
	// (set) Token: 0x0601514F RID: 86351 RVA: 0x0062468F File Offset: 0x0062288F
	public int? TaskMarkConfigId { get; set; }

	// Token: 0x17001FE9 RID: 8169
	// (get) Token: 0x06015150 RID: 86352 RVA: 0x00624698 File Offset: 0x00622898
	// (set) Token: 0x06015151 RID: 86353 RVA: 0x006246A0 File Offset: 0x006228A0
	public bool? WeakTrack { get; set; }
}
