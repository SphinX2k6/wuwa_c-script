using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005587 RID: 21895
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMarkCreateParams : IDynamicMarkCreateParams
	{
		// Token: 0x1700865E RID: 34398
		// (get) Token: 0x06037CCD RID: 228557 RVA: 0x00D395DF File Offset: 0x00D377DF
		// (set) Token: 0x06037CCE RID: 228558 RVA: 0x00D395E7 File Offset: 0x00D377E7
		public TTrackTarget TrackTarget { get; set; }

		// Token: 0x1700865F RID: 34399
		// (get) Token: 0x06037CCF RID: 228559 RVA: 0x00D395F0 File Offset: 0x00D377F0
		// (set) Token: 0x06037CD0 RID: 228560 RVA: 0x00D395F8 File Offset: 0x00D377F8
		public int MarkConfigId { get; set; }

		// Token: 0x17008660 RID: 34400
		// (get) Token: 0x06037CD1 RID: 228561 RVA: 0x00D39601 File Offset: 0x00D37801
		// (set) Token: 0x06037CD2 RID: 228562 RVA: 0x00D39609 File Offset: 0x00D37809
		public EMarkType MarkType { get; set; }

		// Token: 0x17008661 RID: 34401
		// (get) Token: 0x06037CD3 RID: 228563 RVA: 0x00D39612 File Offset: 0x00D37812
		// (set) Token: 0x06037CD4 RID: 228564 RVA: 0x00D3961A File Offset: 0x00D3781A
		public int? MarkId { get; set; }

		// Token: 0x17008662 RID: 34402
		// (get) Token: 0x06037CD5 RID: 228565 RVA: 0x00D39623 File Offset: 0x00D37823
		// (set) Token: 0x06037CD6 RID: 228566 RVA: 0x00D3962B File Offset: 0x00D3782B
		public ETrackSource? TrackSource { get; set; }

		// Token: 0x17008663 RID: 34403
		// (get) Token: 0x06037CD7 RID: 228567 RVA: 0x00D39634 File Offset: 0x00D37834
		// (set) Token: 0x06037CD8 RID: 228568 RVA: 0x00D3963C File Offset: 0x00D3783C
		public bool? DestroyOnUnTrack { get; set; }

		// Token: 0x17008664 RID: 34404
		// (get) Token: 0x06037CD9 RID: 228569 RVA: 0x00D39645 File Offset: 0x00D37845
		// (set) Token: 0x06037CDA RID: 228570 RVA: 0x00D3964D File Offset: 0x00D3784D
		public int? TeleportId { get; set; }

		// Token: 0x17008665 RID: 34405
		// (get) Token: 0x06037CDB RID: 228571 RVA: 0x00D39656 File Offset: 0x00D37856
		// (set) Token: 0x06037CDC RID: 228572 RVA: 0x00D3965E File Offset: 0x00D3785E
		public int? EntityConfigId { get; set; }

		// Token: 0x17008666 RID: 34406
		// (get) Token: 0x06037CDD RID: 228573 RVA: 0x00D39667 File Offset: 0x00D37867
		// (set) Token: 0x06037CDE RID: 228574 RVA: 0x00D3966F File Offset: 0x00D3786F
		public MarkState? ServerMarkState { get; set; }

		// Token: 0x17008667 RID: 34407
		// (get) Token: 0x06037CDF RID: 228575 RVA: 0x00D39678 File Offset: 0x00D37878
		// (set) Token: 0x06037CE0 RID: 228576 RVA: 0x00D39680 File Offset: 0x00D37880
		[Nullable(2)]
		public MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008668 RID: 34408
		// (get) Token: 0x06037CE1 RID: 228577 RVA: 0x00D39689 File Offset: 0x00D37889
		// (set) Token: 0x06037CE2 RID: 228578 RVA: 0x00D39691 File Offset: 0x00D37891
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17008669 RID: 34409
		// (get) Token: 0x06037CE3 RID: 228579 RVA: 0x00D3969A File Offset: 0x00D3789A
		// (set) Token: 0x06037CE4 RID: 228580 RVA: 0x00D396A2 File Offset: 0x00D378A2
		public int? AreaId { get; set; }

		// Token: 0x0401D559 RID: 120153
		public long TreeId;

		// Token: 0x0401D55A RID: 120154
		public int NodeId;

		// Token: 0x0401D55B RID: 120155
		public bool? IsBoundToParentQuest;
	}
}
