using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036BE RID: 14014
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapViewOpenParams : IWorldMapViewOpenParams
	{
		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x0602466F RID: 149103 RVA: 0x00A49A05 File Offset: 0x00A47C05
		// (set) Token: 0x06024670 RID: 149104 RVA: 0x00A49A0D File Offset: 0x00A47C0D
		public EMarkType MarkType { get; set; }

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x06024671 RID: 149105 RVA: 0x00A49A16 File Offset: 0x00A47C16
		// (set) Token: 0x06024672 RID: 149106 RVA: 0x00A49A1E File Offset: 0x00A47C1E
		public int? MarkId { get; set; }

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x06024673 RID: 149107 RVA: 0x00A49A27 File Offset: 0x00A47C27
		// (set) Token: 0x06024674 RID: 149108 RVA: 0x00A49A2F File Offset: 0x00A47C2F
		public Vector2D StartWorldPosition { get; set; }

		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x06024675 RID: 149109 RVA: 0x00A49A38 File Offset: 0x00A47C38
		// (set) Token: 0x06024676 RID: 149110 RVA: 0x00A49A40 File Offset: 0x00A47C40
		public Vector DebugWorldPosition { get; set; }

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x06024677 RID: 149111 RVA: 0x00A49A49 File Offset: 0x00A47C49
		// (set) Token: 0x06024678 RID: 149112 RVA: 0x00A49A51 File Offset: 0x00A47C51
		public int? MapId { get; set; }

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x06024679 RID: 149113 RVA: 0x00A49A5A File Offset: 0x00A47C5A
		// (set) Token: 0x0602467A RID: 149114 RVA: 0x00A49A62 File Offset: 0x00A47C62
		public float? StartScale { get; set; }

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x0602467B RID: 149115 RVA: 0x00A49A6B File Offset: 0x00A47C6B
		// (set) Token: 0x0602467C RID: 149116 RVA: 0x00A49A73 File Offset: 0x00A47C73
		public int? OpenFogId { get; set; }

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x0602467D RID: 149117 RVA: 0x00A49A7C File Offset: 0x00A47C7C
		// (set) Token: 0x0602467E RID: 149118 RVA: 0x00A49A84 File Offset: 0x00A47C84
		public bool? ShowFogEffectInstant { get; set; }

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x0602467F RID: 149119 RVA: 0x00A49A8D File Offset: 0x00A47C8D
		// (set) Token: 0x06024680 RID: 149120 RVA: 0x00A49A95 File Offset: 0x00A47C95
		public bool? IsNotFocusTween { get; set; }

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x06024681 RID: 149121 RVA: 0x00A49A9E File Offset: 0x00A47C9E
		// (set) Token: 0x06024682 RID: 149122 RVA: 0x00A49AA6 File Offset: 0x00A47CA6
		public bool? IsNotFocal { get; set; }

		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x06024683 RID: 149123 RVA: 0x00A49AAF File Offset: 0x00A47CAF
		// (set) Token: 0x06024684 RID: 149124 RVA: 0x00A49AB7 File Offset: 0x00A47CB7
		public bool? IsNotNeedUnLockEffect { get; set; }

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x06024685 RID: 149125 RVA: 0x00A49AC0 File Offset: 0x00A47CC0
		// (set) Token: 0x06024686 RID: 149126 RVA: 0x00A49AC8 File Offset: 0x00A47CC8
		public int[] FocusExplorePlayPoint { get; set; }

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x06024687 RID: 149127 RVA: 0x00A49AD1 File Offset: 0x00A47CD1
		// (set) Token: 0x06024688 RID: 149128 RVA: 0x00A49AD9 File Offset: 0x00A47CD9
		public int[] SkipToExploreAreaDetailView { get; set; }

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x06024689 RID: 149129 RVA: 0x00A49AE2 File Offset: 0x00A47CE2
		// (set) Token: 0x0602468A RID: 149130 RVA: 0x00A49AEA File Offset: 0x00A47CEA
		public bool? NeedRefreshMultiFloor { get; set; }

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x0602468B RID: 149131 RVA: 0x00A49AF3 File Offset: 0x00A47CF3
		// (set) Token: 0x0602468C RID: 149132 RVA: 0x00A49AFB File Offset: 0x00A47CFB
		public EWorldMapExtraUiPanelName? SkipToExtraUiName { get; set; }

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x0602468D RID: 149133 RVA: 0x00A49B04 File Offset: 0x00A47D04
		// (set) Token: 0x0602468E RID: 149134 RVA: 0x00A49B0C File Offset: 0x00A47D0C
		public object SkipToExtraUiParam { get; set; }

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x0602468F RID: 149135 RVA: 0x00A49B15 File Offset: 0x00A47D15
		// (set) Token: 0x06024690 RID: 149136 RVA: 0x00A49B1D File Offset: 0x00A47D1D
		public IRegionalTerminalBarItemParams RegionalTerminalBarItemParams { get; set; }
	}
}
