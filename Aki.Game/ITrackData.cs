using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x0200218E RID: 8590
[NullableContext(2)]
public interface ITrackData
{
	// Token: 0x17001FC2 RID: 8130
	// (get) Token: 0x06015102 RID: 86274
	// (set) Token: 0x06015103 RID: 86275
	ETrackSource TrackSource { get; set; }

	// Token: 0x17001FC3 RID: 8131
	// (get) Token: 0x06015104 RID: 86276
	// (set) Token: 0x06015105 RID: 86277
	EMarkType? MarkType { get; set; }

	// Token: 0x17001FC4 RID: 8132
	// (get) Token: 0x06015106 RID: 86278
	// (set) Token: 0x06015107 RID: 86279
	int Id { get; set; }

	// Token: 0x17001FC5 RID: 8133
	// (get) Token: 0x06015108 RID: 86280
	// (set) Token: 0x06015109 RID: 86281
	[Nullable(1)]
	string IconPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001FC6 RID: 8134
	// (get) Token: 0x0601510A RID: 86282
	// (set) Token: 0x0601510B RID: 86283
	TTrackTarget TrackTarget { get; set; }

	// Token: 0x17001FC7 RID: 8135
	// (get) Token: 0x0601510C RID: 86284
	// (set) Token: 0x0601510D RID: 86285
	int? TrackInstanceId { get; set; }

	// Token: 0x17001FC8 RID: 8136
	// (get) Token: 0x0601510E RID: 86286
	// (set) Token: 0x0601510F RID: 86287
	bool? TrackHudEnable { get; set; }

	// Token: 0x17001FC9 RID: 8137
	// (get) Token: 0x06015110 RID: 86288
	// (set) Token: 0x06015111 RID: 86289
	float? TrackAutoCancelDistance { get; set; }

	// Token: 0x17001FCA RID: 8138
	// (get) Token: 0x06015112 RID: 86290
	// (set) Token: 0x06015113 RID: 86291
	bool? IsSubTrack { get; set; }

	// Token: 0x17001FCB RID: 8139
	// (get) Token: 0x06015114 RID: 86292
	// (set) Token: 0x06015115 RID: 86293
	float? TrackHideDis { get; set; }

	// Token: 0x17001FCC RID: 8140
	// (get) Token: 0x06015116 RID: 86294
	// (set) Token: 0x06015117 RID: 86295
	int? ShowGroupId { get; set; }

	// Token: 0x17001FCD RID: 8141
	// (get) Token: 0x06015118 RID: 86296
	// (set) Token: 0x06015119 RID: 86297
	ETrackType? TrackType { get; set; }

	// Token: 0x17001FCE RID: 8142
	// (get) Token: 0x0601511A RID: 86298
	// (set) Token: 0x0601511B RID: 86299
	bool? AutoHideTrack { get; set; }

	// Token: 0x17001FCF RID: 8143
	// (get) Token: 0x0601511C RID: 86300
	// (set) Token: 0x0601511D RID: 86301
	string PrefabPath { get; set; }

	// Token: 0x17001FD0 RID: 8144
	// (get) Token: 0x0601511E RID: 86302
	// (set) Token: 0x0601511F RID: 86303
	Vector Offset { get; set; }

	// Token: 0x17001FD1 RID: 8145
	// (get) Token: 0x06015120 RID: 86304
	// (set) Token: 0x06015121 RID: 86305
	bool? IsInTrackRange { get; set; }

	// Token: 0x17001FD2 RID: 8146
	// (get) Token: 0x06015122 RID: 86306
	// (set) Token: 0x06015123 RID: 86307
	int? AreaId { get; set; }

	// Token: 0x17001FD3 RID: 8147
	// (get) Token: 0x06015124 RID: 86308
	// (set) Token: 0x06015125 RID: 86309
	int? MultiMapId { get; set; }

	// Token: 0x17001FD4 RID: 8148
	// (get) Token: 0x06015126 RID: 86310
	// (set) Token: 0x06015127 RID: 86311
	int? TaskMarkConfigId { get; set; }

	// Token: 0x17001FD5 RID: 8149
	// (get) Token: 0x06015128 RID: 86312
	// (set) Token: 0x06015129 RID: 86313
	bool? WeakTrack { get; set; }
}
