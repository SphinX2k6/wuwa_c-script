using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200478D RID: 18317
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapViewOpenParams : IWorldMapViewOpenParams
	{
		// Token: 0x170077C5 RID: 30661
		// (get) Token: 0x0602FEA4 RID: 196260 RVA: 0x00B19B29 File Offset: 0x00B17D29
		// (set) Token: 0x0602FEA5 RID: 196261 RVA: 0x00B19B31 File Offset: 0x00B17D31
		public EMarkType MarkType { get; set; }

		// Token: 0x170077C6 RID: 30662
		// (get) Token: 0x0602FEA6 RID: 196262 RVA: 0x00B19B3A File Offset: 0x00B17D3A
		// (set) Token: 0x0602FEA7 RID: 196263 RVA: 0x00B19B42 File Offset: 0x00B17D42
		public int? MarkId { get; set; }

		// Token: 0x170077C7 RID: 30663
		// (get) Token: 0x0602FEA8 RID: 196264 RVA: 0x00B19B4B File Offset: 0x00B17D4B
		// (set) Token: 0x0602FEA9 RID: 196265 RVA: 0x00B19B53 File Offset: 0x00B17D53
		public Vector2D StartWorldPosition { get; set; }

		// Token: 0x170077C8 RID: 30664
		// (get) Token: 0x0602FEAA RID: 196266 RVA: 0x00B19B5C File Offset: 0x00B17D5C
		// (set) Token: 0x0602FEAB RID: 196267 RVA: 0x00B19B64 File Offset: 0x00B17D64
		public Vector DebugWorldPosition { get; set; }

		// Token: 0x170077C9 RID: 30665
		// (get) Token: 0x0602FEAC RID: 196268 RVA: 0x00B19B6D File Offset: 0x00B17D6D
		// (set) Token: 0x0602FEAD RID: 196269 RVA: 0x00B19B75 File Offset: 0x00B17D75
		public int? MapId { get; set; }

		// Token: 0x170077CA RID: 30666
		// (get) Token: 0x0602FEAE RID: 196270 RVA: 0x00B19B7E File Offset: 0x00B17D7E
		// (set) Token: 0x0602FEAF RID: 196271 RVA: 0x00B19B86 File Offset: 0x00B17D86
		public float? StartScale { get; set; }

		// Token: 0x170077CB RID: 30667
		// (get) Token: 0x0602FEB0 RID: 196272 RVA: 0x00B19B8F File Offset: 0x00B17D8F
		// (set) Token: 0x0602FEB1 RID: 196273 RVA: 0x00B19B97 File Offset: 0x00B17D97
		public int? OpenFogId { get; set; }

		// Token: 0x170077CC RID: 30668
		// (get) Token: 0x0602FEB2 RID: 196274 RVA: 0x00B19BA0 File Offset: 0x00B17DA0
		// (set) Token: 0x0602FEB3 RID: 196275 RVA: 0x00B19BA8 File Offset: 0x00B17DA8
		public bool? ShowFogEffectInstant { get; set; }

		// Token: 0x170077CD RID: 30669
		// (get) Token: 0x0602FEB4 RID: 196276 RVA: 0x00B19BB1 File Offset: 0x00B17DB1
		// (set) Token: 0x0602FEB5 RID: 196277 RVA: 0x00B19BB9 File Offset: 0x00B17DB9
		public bool? IsNotFocusTween { get; set; }

		// Token: 0x170077CE RID: 30670
		// (get) Token: 0x0602FEB6 RID: 196278 RVA: 0x00B19BC2 File Offset: 0x00B17DC2
		// (set) Token: 0x0602FEB7 RID: 196279 RVA: 0x00B19BCA File Offset: 0x00B17DCA
		public bool? IsNotFocal { get; set; }

		// Token: 0x170077CF RID: 30671
		// (get) Token: 0x0602FEB8 RID: 196280 RVA: 0x00B19BD3 File Offset: 0x00B17DD3
		// (set) Token: 0x0602FEB9 RID: 196281 RVA: 0x00B19BDB File Offset: 0x00B17DDB
		public bool? IsNotNeedUnLockEffect { get; set; }

		// Token: 0x170077D0 RID: 30672
		// (get) Token: 0x0602FEBA RID: 196282 RVA: 0x00B19BE4 File Offset: 0x00B17DE4
		// (set) Token: 0x0602FEBB RID: 196283 RVA: 0x00B19BEC File Offset: 0x00B17DEC
		public int[] FocusExplorePlayPoint { get; set; }

		// Token: 0x170077D1 RID: 30673
		// (get) Token: 0x0602FEBC RID: 196284 RVA: 0x00B19BF5 File Offset: 0x00B17DF5
		// (set) Token: 0x0602FEBD RID: 196285 RVA: 0x00B19BFD File Offset: 0x00B17DFD
		public int[] SkipToExploreAreaDetailView { get; set; }

		// Token: 0x170077D2 RID: 30674
		// (get) Token: 0x0602FEBE RID: 196286 RVA: 0x00B19C06 File Offset: 0x00B17E06
		// (set) Token: 0x0602FEBF RID: 196287 RVA: 0x00B19C0E File Offset: 0x00B17E0E
		public bool? NeedRefreshMultiFloor { get; set; }

		// Token: 0x170077D3 RID: 30675
		// (get) Token: 0x0602FEC0 RID: 196288 RVA: 0x00B19C17 File Offset: 0x00B17E17
		// (set) Token: 0x0602FEC1 RID: 196289 RVA: 0x00B19C1F File Offset: 0x00B17E1F
		public EWorldMapExtraUiPanelName? SkipToExtraUiName { get; set; }

		// Token: 0x170077D4 RID: 30676
		// (get) Token: 0x0602FEC2 RID: 196290 RVA: 0x00B19C28 File Offset: 0x00B17E28
		// (set) Token: 0x0602FEC3 RID: 196291 RVA: 0x00B19C30 File Offset: 0x00B17E30
		public object SkipToExtraUiParam { get; set; }

		// Token: 0x170077D5 RID: 30677
		// (get) Token: 0x0602FEC4 RID: 196292 RVA: 0x00B19C39 File Offset: 0x00B17E39
		// (set) Token: 0x0602FEC5 RID: 196293 RVA: 0x00B19C41 File Offset: 0x00B17E41
		public IRegionalTerminalBarItemParams RegionalTerminalBarItemParams { get; set; }
	}
}
