using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02002C13 RID: 11283
[NullableContext(2)]
public interface ITrackData
{
	// Token: 0x17001F6A RID: 8042
	// (get) Token: 0x060176D0 RID: 95952
	// (set) Token: 0x060176D1 RID: 95953
	ETrackSource TrackSource { get; set; }

	// Token: 0x17001F6B RID: 8043
	// (get) Token: 0x060176D2 RID: 95954
	// (set) Token: 0x060176D3 RID: 95955
	EMarkType? MarkType { get; set; }

	// Token: 0x17001F6C RID: 8044
	// (get) Token: 0x060176D4 RID: 95956
	// (set) Token: 0x060176D5 RID: 95957
	int Id { get; set; }

	// Token: 0x17001F6D RID: 8045
	// (get) Token: 0x060176D6 RID: 95958
	// (set) Token: 0x060176D7 RID: 95959
	[Nullable(1)]
	string IconPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001F6E RID: 8046
	// (get) Token: 0x060176D8 RID: 95960
	// (set) Token: 0x060176D9 RID: 95961
	TTrackTarget TrackTarget { get; set; }

	// Token: 0x17001F6F RID: 8047
	// (get) Token: 0x060176DA RID: 95962
	// (set) Token: 0x060176DB RID: 95963
	int? TrackInstanceId { get; set; }

	// Token: 0x17001F70 RID: 8048
	// (get) Token: 0x060176DC RID: 95964
	// (set) Token: 0x060176DD RID: 95965
	bool? TrackHudEnable { get; set; }

	// Token: 0x17001F71 RID: 8049
	// (get) Token: 0x060176DE RID: 95966
	// (set) Token: 0x060176DF RID: 95967
	float? TrackAutoCancelDistance { get; set; }

	// Token: 0x17001F72 RID: 8050
	// (get) Token: 0x060176E0 RID: 95968
	// (set) Token: 0x060176E1 RID: 95969
	bool? IsSubTrack { get; set; }

	// Token: 0x17001F73 RID: 8051
	// (get) Token: 0x060176E2 RID: 95970
	// (set) Token: 0x060176E3 RID: 95971
	float? TrackHideDis { get; set; }

	// Token: 0x17001F74 RID: 8052
	// (get) Token: 0x060176E4 RID: 95972
	// (set) Token: 0x060176E5 RID: 95973
	int? ShowGroupId { get; set; }

	// Token: 0x17001F75 RID: 8053
	// (get) Token: 0x060176E6 RID: 95974
	// (set) Token: 0x060176E7 RID: 95975
	ETrackType? TrackType { get; set; }

	// Token: 0x17001F76 RID: 8054
	// (get) Token: 0x060176E8 RID: 95976
	// (set) Token: 0x060176E9 RID: 95977
	bool? AutoHideTrack { get; set; }

	// Token: 0x17001F77 RID: 8055
	// (get) Token: 0x060176EA RID: 95978
	// (set) Token: 0x060176EB RID: 95979
	string PrefabPath { get; set; }

	// Token: 0x17001F78 RID: 8056
	// (get) Token: 0x060176EC RID: 95980
	// (set) Token: 0x060176ED RID: 95981
	Vector Offset { get; set; }

	// Token: 0x17001F79 RID: 8057
	// (get) Token: 0x060176EE RID: 95982
	// (set) Token: 0x060176EF RID: 95983
	bool? IsInTrackRange { get; set; }

	// Token: 0x17001F7A RID: 8058
	// (get) Token: 0x060176F0 RID: 95984
	// (set) Token: 0x060176F1 RID: 95985
	int? AreaId { get; set; }

	// Token: 0x17001F7B RID: 8059
	// (get) Token: 0x060176F2 RID: 95986
	// (set) Token: 0x060176F3 RID: 95987
	int? MultiMapId { get; set; }

	// Token: 0x17001F7C RID: 8060
	// (get) Token: 0x060176F4 RID: 95988
	// (set) Token: 0x060176F5 RID: 95989
	int? TaskMarkConfigId { get; set; }

	// Token: 0x17001F7D RID: 8061
	// (get) Token: 0x060176F6 RID: 95990
	// (set) Token: 0x060176F7 RID: 95991
	bool? WeakTrack { get; set; }
}
