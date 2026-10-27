using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02002C14 RID: 11284
[NullableContext(2)]
[Nullable(0)]
public class TrackData : ITrackData
{
	// Token: 0x17001F7E RID: 8062
	// (get) Token: 0x060176F8 RID: 95992 RVA: 0x005F7A31 File Offset: 0x005F5C31
	// (set) Token: 0x060176F9 RID: 95993 RVA: 0x005F7A39 File Offset: 0x005F5C39
	public ETrackSource TrackSource { get; set; }

	// Token: 0x17001F7F RID: 8063
	// (get) Token: 0x060176FA RID: 95994 RVA: 0x005F7A42 File Offset: 0x005F5C42
	// (set) Token: 0x060176FB RID: 95995 RVA: 0x005F7A4A File Offset: 0x005F5C4A
	public EMarkType? MarkType { get; set; }

	// Token: 0x17001F80 RID: 8064
	// (get) Token: 0x060176FC RID: 95996 RVA: 0x005F7A53 File Offset: 0x005F5C53
	// (set) Token: 0x060176FD RID: 95997 RVA: 0x005F7A5B File Offset: 0x005F5C5B
	public int Id { get; set; }

	// Token: 0x17001F81 RID: 8065
	// (get) Token: 0x060176FE RID: 95998 RVA: 0x005F7A64 File Offset: 0x005F5C64
	// (set) Token: 0x060176FF RID: 95999 RVA: 0x005F7A6C File Offset: 0x005F5C6C
	[Nullable(1)]
	public string IconPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001F82 RID: 8066
	// (get) Token: 0x06017700 RID: 96000 RVA: 0x005F7A75 File Offset: 0x005F5C75
	// (set) Token: 0x06017701 RID: 96001 RVA: 0x005F7A7D File Offset: 0x005F5C7D
	public TTrackTarget TrackTarget { get; set; }

	// Token: 0x17001F83 RID: 8067
	// (get) Token: 0x06017702 RID: 96002 RVA: 0x005F7A86 File Offset: 0x005F5C86
	// (set) Token: 0x06017703 RID: 96003 RVA: 0x005F7A8E File Offset: 0x005F5C8E
	public int? TrackInstanceId { get; set; }

	// Token: 0x17001F84 RID: 8068
	// (get) Token: 0x06017704 RID: 96004 RVA: 0x005F7A97 File Offset: 0x005F5C97
	// (set) Token: 0x06017705 RID: 96005 RVA: 0x005F7A9F File Offset: 0x005F5C9F
	public bool? TrackHudEnable { get; set; }

	// Token: 0x17001F85 RID: 8069
	// (get) Token: 0x06017706 RID: 96006 RVA: 0x005F7AA8 File Offset: 0x005F5CA8
	// (set) Token: 0x06017707 RID: 96007 RVA: 0x005F7AB0 File Offset: 0x005F5CB0
	public float? TrackAutoCancelDistance { get; set; }

	// Token: 0x17001F86 RID: 8070
	// (get) Token: 0x06017708 RID: 96008 RVA: 0x005F7AB9 File Offset: 0x005F5CB9
	// (set) Token: 0x06017709 RID: 96009 RVA: 0x005F7AC1 File Offset: 0x005F5CC1
	public bool? IsSubTrack { get; set; }

	// Token: 0x17001F87 RID: 8071
	// (get) Token: 0x0601770A RID: 96010 RVA: 0x005F7ACA File Offset: 0x005F5CCA
	// (set) Token: 0x0601770B RID: 96011 RVA: 0x005F7AD2 File Offset: 0x005F5CD2
	public float? TrackHideDis { get; set; }

	// Token: 0x17001F88 RID: 8072
	// (get) Token: 0x0601770C RID: 96012 RVA: 0x005F7ADB File Offset: 0x005F5CDB
	// (set) Token: 0x0601770D RID: 96013 RVA: 0x005F7AE3 File Offset: 0x005F5CE3
	public int? ShowGroupId { get; set; }

	// Token: 0x17001F89 RID: 8073
	// (get) Token: 0x0601770E RID: 96014 RVA: 0x005F7AEC File Offset: 0x005F5CEC
	// (set) Token: 0x0601770F RID: 96015 RVA: 0x005F7AF4 File Offset: 0x005F5CF4
	public ETrackType? TrackType { get; set; }

	// Token: 0x17001F8A RID: 8074
	// (get) Token: 0x06017710 RID: 96016 RVA: 0x005F7AFD File Offset: 0x005F5CFD
	// (set) Token: 0x06017711 RID: 96017 RVA: 0x005F7B05 File Offset: 0x005F5D05
	public bool? AutoHideTrack { get; set; }

	// Token: 0x17001F8B RID: 8075
	// (get) Token: 0x06017712 RID: 96018 RVA: 0x005F7B0E File Offset: 0x005F5D0E
	// (set) Token: 0x06017713 RID: 96019 RVA: 0x005F7B16 File Offset: 0x005F5D16
	public string PrefabPath { get; set; }

	// Token: 0x17001F8C RID: 8076
	// (get) Token: 0x06017714 RID: 96020 RVA: 0x005F7B1F File Offset: 0x005F5D1F
	// (set) Token: 0x06017715 RID: 96021 RVA: 0x005F7B27 File Offset: 0x005F5D27
	public Vector Offset { get; set; }

	// Token: 0x17001F8D RID: 8077
	// (get) Token: 0x06017716 RID: 96022 RVA: 0x005F7B30 File Offset: 0x005F5D30
	// (set) Token: 0x06017717 RID: 96023 RVA: 0x005F7B38 File Offset: 0x005F5D38
	public bool? IsInTrackRange { get; set; }

	// Token: 0x17001F8E RID: 8078
	// (get) Token: 0x06017718 RID: 96024 RVA: 0x005F7B41 File Offset: 0x005F5D41
	// (set) Token: 0x06017719 RID: 96025 RVA: 0x005F7B49 File Offset: 0x005F5D49
	public int? AreaId { get; set; }

	// Token: 0x17001F8F RID: 8079
	// (get) Token: 0x0601771A RID: 96026 RVA: 0x005F7B52 File Offset: 0x005F5D52
	// (set) Token: 0x0601771B RID: 96027 RVA: 0x005F7B5A File Offset: 0x005F5D5A
	public int? MultiMapId { get; set; }

	// Token: 0x17001F90 RID: 8080
	// (get) Token: 0x0601771C RID: 96028 RVA: 0x005F7B63 File Offset: 0x005F5D63
	// (set) Token: 0x0601771D RID: 96029 RVA: 0x005F7B6B File Offset: 0x005F5D6B
	public int? TaskMarkConfigId { get; set; }

	// Token: 0x17001F91 RID: 8081
	// (get) Token: 0x0601771E RID: 96030 RVA: 0x005F7B74 File Offset: 0x005F5D74
	// (set) Token: 0x0601771F RID: 96031 RVA: 0x005F7B7C File Offset: 0x005F5D7C
	public bool? WeakTrack { get; set; }
}
