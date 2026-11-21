using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036BD RID: 14013
	[NullableContext(2)]
	public interface IWorldMapViewOpenParams
	{
		// Token: 0x17004A70 RID: 19056
		// (get) Token: 0x0602464D RID: 149069
		// (set) Token: 0x0602464E RID: 149070
		EMarkType MarkType { get; set; }

		// Token: 0x17004A71 RID: 19057
		// (get) Token: 0x0602464F RID: 149071
		// (set) Token: 0x06024650 RID: 149072
		int? MarkId { get; set; }

		// Token: 0x17004A72 RID: 19058
		// (get) Token: 0x06024651 RID: 149073
		// (set) Token: 0x06024652 RID: 149074
		Vector2D StartWorldPosition { get; set; }

		// Token: 0x17004A73 RID: 19059
		// (get) Token: 0x06024653 RID: 149075
		// (set) Token: 0x06024654 RID: 149076
		Vector DebugWorldPosition { get; set; }

		// Token: 0x17004A74 RID: 19060
		// (get) Token: 0x06024655 RID: 149077
		// (set) Token: 0x06024656 RID: 149078
		int? MapId { get; set; }

		// Token: 0x17004A75 RID: 19061
		// (get) Token: 0x06024657 RID: 149079
		// (set) Token: 0x06024658 RID: 149080
		float? StartScale { get; set; }

		// Token: 0x17004A76 RID: 19062
		// (get) Token: 0x06024659 RID: 149081
		// (set) Token: 0x0602465A RID: 149082
		int? OpenFogId { get; set; }

		// Token: 0x17004A77 RID: 19063
		// (get) Token: 0x0602465B RID: 149083
		// (set) Token: 0x0602465C RID: 149084
		bool? ShowFogEffectInstant { get; set; }

		// Token: 0x17004A78 RID: 19064
		// (get) Token: 0x0602465D RID: 149085
		// (set) Token: 0x0602465E RID: 149086
		bool? IsNotFocusTween { get; set; }

		// Token: 0x17004A79 RID: 19065
		// (get) Token: 0x0602465F RID: 149087
		// (set) Token: 0x06024660 RID: 149088
		bool? IsNotFocal { get; set; }

		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x06024661 RID: 149089
		// (set) Token: 0x06024662 RID: 149090
		bool? IsNotNeedUnLockEffect { get; set; }

		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x06024663 RID: 149091
		// (set) Token: 0x06024664 RID: 149092
		int[] FocusExplorePlayPoint { get; set; }

		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x06024665 RID: 149093
		// (set) Token: 0x06024666 RID: 149094
		int[] SkipToExploreAreaDetailView { get; set; }

		// Token: 0x17004A7D RID: 19069
		// (get) Token: 0x06024667 RID: 149095
		// (set) Token: 0x06024668 RID: 149096
		bool? NeedRefreshMultiFloor { get; set; }

		// Token: 0x17004A7E RID: 19070
		// (get) Token: 0x06024669 RID: 149097
		// (set) Token: 0x0602466A RID: 149098
		EWorldMapExtraUiPanelName? SkipToExtraUiName { get; set; }

		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x0602466B RID: 149099
		// (set) Token: 0x0602466C RID: 149100
		object SkipToExtraUiParam { get; set; }

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x0602466D RID: 149101
		// (set) Token: 0x0602466E RID: 149102
		IRegionalTerminalBarItemParams RegionalTerminalBarItemParams { get; set; }
	}
}
