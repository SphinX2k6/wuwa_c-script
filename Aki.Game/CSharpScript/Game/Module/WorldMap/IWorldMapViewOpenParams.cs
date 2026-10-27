using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200478C RID: 18316
	[NullableContext(2)]
	public interface IWorldMapViewOpenParams
	{
		// Token: 0x170077B4 RID: 30644
		// (get) Token: 0x0602FE82 RID: 196226
		// (set) Token: 0x0602FE83 RID: 196227
		EMarkType MarkType { get; set; }

		// Token: 0x170077B5 RID: 30645
		// (get) Token: 0x0602FE84 RID: 196228
		// (set) Token: 0x0602FE85 RID: 196229
		int? MarkId { get; set; }

		// Token: 0x170077B6 RID: 30646
		// (get) Token: 0x0602FE86 RID: 196230
		// (set) Token: 0x0602FE87 RID: 196231
		Vector2D StartWorldPosition { get; set; }

		// Token: 0x170077B7 RID: 30647
		// (get) Token: 0x0602FE88 RID: 196232
		// (set) Token: 0x0602FE89 RID: 196233
		Vector DebugWorldPosition { get; set; }

		// Token: 0x170077B8 RID: 30648
		// (get) Token: 0x0602FE8A RID: 196234
		// (set) Token: 0x0602FE8B RID: 196235
		int? MapId { get; set; }

		// Token: 0x170077B9 RID: 30649
		// (get) Token: 0x0602FE8C RID: 196236
		// (set) Token: 0x0602FE8D RID: 196237
		float? StartScale { get; set; }

		// Token: 0x170077BA RID: 30650
		// (get) Token: 0x0602FE8E RID: 196238
		// (set) Token: 0x0602FE8F RID: 196239
		int? OpenFogId { get; set; }

		// Token: 0x170077BB RID: 30651
		// (get) Token: 0x0602FE90 RID: 196240
		// (set) Token: 0x0602FE91 RID: 196241
		bool? ShowFogEffectInstant { get; set; }

		// Token: 0x170077BC RID: 30652
		// (get) Token: 0x0602FE92 RID: 196242
		// (set) Token: 0x0602FE93 RID: 196243
		bool? IsNotFocusTween { get; set; }

		// Token: 0x170077BD RID: 30653
		// (get) Token: 0x0602FE94 RID: 196244
		// (set) Token: 0x0602FE95 RID: 196245
		bool? IsNotFocal { get; set; }

		// Token: 0x170077BE RID: 30654
		// (get) Token: 0x0602FE96 RID: 196246
		// (set) Token: 0x0602FE97 RID: 196247
		bool? IsNotNeedUnLockEffect { get; set; }

		// Token: 0x170077BF RID: 30655
		// (get) Token: 0x0602FE98 RID: 196248
		// (set) Token: 0x0602FE99 RID: 196249
		int[] FocusExplorePlayPoint { get; set; }

		// Token: 0x170077C0 RID: 30656
		// (get) Token: 0x0602FE9A RID: 196250
		// (set) Token: 0x0602FE9B RID: 196251
		int[] SkipToExploreAreaDetailView { get; set; }

		// Token: 0x170077C1 RID: 30657
		// (get) Token: 0x0602FE9C RID: 196252
		// (set) Token: 0x0602FE9D RID: 196253
		bool? NeedRefreshMultiFloor { get; set; }

		// Token: 0x170077C2 RID: 30658
		// (get) Token: 0x0602FE9E RID: 196254
		// (set) Token: 0x0602FE9F RID: 196255
		EWorldMapExtraUiPanelName? SkipToExtraUiName { get; set; }

		// Token: 0x170077C3 RID: 30659
		// (get) Token: 0x0602FEA0 RID: 196256
		// (set) Token: 0x0602FEA1 RID: 196257
		object SkipToExtraUiParam { get; set; }

		// Token: 0x170077C4 RID: 30660
		// (get) Token: 0x0602FEA2 RID: 196258
		// (set) Token: 0x0602FEA3 RID: 196259
		IRegionalTerminalBarItemParams RegionalTerminalBarItemParams { get; set; }
	}
}
