using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x0200518B RID: 20875
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipSubLevelRatingData : IRhythmShipSubLevelRatingData
	{
		// Token: 0x1700659E RID: 26014
		// (get) Token: 0x060341D7 RID: 213463 RVA: 0x00E93D4D File Offset: 0x00E91F4D
		// (set) Token: 0x060341D8 RID: 213464 RVA: 0x00E93D55 File Offset: 0x00E91F55
		public int PlayerId { get; set; }

		// Token: 0x1700659F RID: 26015
		// (get) Token: 0x060341D9 RID: 213465 RVA: 0x00E93D5E File Offset: 0x00E91F5E
		// (set) Token: 0x060341DA RID: 213466 RVA: 0x00E93D66 File Offset: 0x00E91F66
		public string NameText { get; set; }

		// Token: 0x170065A0 RID: 26016
		// (get) Token: 0x060341DB RID: 213467 RVA: 0x00E93D6F File Offset: 0x00E91F6F
		// (set) Token: 0x060341DC RID: 213468 RVA: 0x00E93D77 File Offset: 0x00E91F77
		public int RoleId { get; set; }

		// Token: 0x170065A1 RID: 26017
		// (get) Token: 0x060341DD RID: 213469 RVA: 0x00E93D80 File Offset: 0x00E91F80
		// (set) Token: 0x060341DE RID: 213470 RVA: 0x00E93D88 File Offset: 0x00E91F88
		public int Score { get; set; }

		// Token: 0x170065A2 RID: 26018
		// (get) Token: 0x060341DF RID: 213471 RVA: 0x00E93D91 File Offset: 0x00E91F91
		// (set) Token: 0x060341E0 RID: 213472 RVA: 0x00E93D99 File Offset: 0x00E91F99
		public int Accuracy { get; set; }

		// Token: 0x170065A3 RID: 26019
		// (get) Token: 0x060341E1 RID: 213473 RVA: 0x00E93DA2 File Offset: 0x00E91FA2
		// (set) Token: 0x060341E2 RID: 213474 RVA: 0x00E93DAA File Offset: 0x00E91FAA
		public int? RankingNumber { get; set; }
	}
}
