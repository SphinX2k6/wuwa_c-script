using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F4 RID: 28916
	public class JumpProjectileRailDataImpl : IJumpProjectileRailData, IRailParam, IConnectionRailData, IJumpProjectileParams
	{
		// Token: 0x17009CD7 RID: 40151
		// (get) Token: 0x06046968 RID: 289128 RVA: 0x011C29C0 File Offset: 0x011C0BC0
		// (set) Token: 0x06046969 RID: 289129 RVA: 0x011C29C8 File Offset: 0x011C0BC8
		public ERailMoveType RailType { get; set; }

		// Token: 0x17009CD8 RID: 40152
		// (get) Token: 0x0604696A RID: 289130 RVA: 0x011C29D1 File Offset: 0x011C0BD1
		// (set) Token: 0x0604696B RID: 289131 RVA: 0x011C29D9 File Offset: 0x011C0BD9
		public ERailJumpType JumpType { get; set; }

		// Token: 0x17009CD9 RID: 40153
		// (get) Token: 0x0604696C RID: 289132 RVA: 0x011C29E2 File Offset: 0x011C0BE2
		// (set) Token: 0x0604696D RID: 289133 RVA: 0x011C29EA File Offset: 0x011C0BEA
		[Nullable(1)]
		public Vector RotatorFixedDirection { [NullableContext(1)] get; [NullableContext(1)] set; } = Vector.Create();

		// Token: 0x17009CDA RID: 40154
		// (get) Token: 0x0604696E RID: 289134 RVA: 0x011C29F3 File Offset: 0x011C0BF3
		// (set) Token: 0x0604696F RID: 289135 RVA: 0x011C29FB File Offset: 0x011C0BFB
		public int ConnectionNextRail { get; set; }

		// Token: 0x17009CDB RID: 40155
		// (get) Token: 0x06046970 RID: 289136 RVA: 0x011C2A04 File Offset: 0x011C0C04
		// (set) Token: 0x06046971 RID: 289137 RVA: 0x011C2A0C File Offset: 0x011C0C0C
		public float ConnectionStartDistance { get; set; }

		// Token: 0x17009CDC RID: 40156
		// (get) Token: 0x06046972 RID: 289138 RVA: 0x011C2A15 File Offset: 0x011C0C15
		// (set) Token: 0x06046973 RID: 289139 RVA: 0x011C2A1D File Offset: 0x011C0C1D
		public float Length { get; set; }

		// Token: 0x17009CDD RID: 40157
		// (get) Token: 0x06046974 RID: 289140 RVA: 0x011C2A26 File Offset: 0x011C0C26
		// (set) Token: 0x06046975 RID: 289141 RVA: 0x011C2A2E File Offset: 0x011C0C2E
		public float AllTime { get; set; }

		// Token: 0x17009CDE RID: 40158
		// (get) Token: 0x06046976 RID: 289142 RVA: 0x011C2A37 File Offset: 0x011C0C37
		// (set) Token: 0x06046977 RID: 289143 RVA: 0x011C2A3F File Offset: 0x011C0C3F
		public float Height0 { get; set; }

		// Token: 0x17009CDF RID: 40159
		// (get) Token: 0x06046978 RID: 289144 RVA: 0x011C2A48 File Offset: 0x011C0C48
		// (set) Token: 0x06046979 RID: 289145 RVA: 0x011C2A50 File Offset: 0x011C0C50
		public float ProjectileA { get; set; }

		// Token: 0x17009CE0 RID: 40160
		// (get) Token: 0x0604697A RID: 289146 RVA: 0x011C2A59 File Offset: 0x011C0C59
		// (set) Token: 0x0604697B RID: 289147 RVA: 0x011C2A61 File Offset: 0x011C0C61
		public float ProjectileB { get; set; }

		// Token: 0x17009CE1 RID: 40161
		// (get) Token: 0x0604697C RID: 289148 RVA: 0x011C2A6A File Offset: 0x011C0C6A
		// (set) Token: 0x0604697D RID: 289149 RVA: 0x011C2A72 File Offset: 0x011C0C72
		public float LastRate { get; set; }

		// Token: 0x17009CE2 RID: 40162
		// (get) Token: 0x0604697E RID: 289150 RVA: 0x011C2A7B File Offset: 0x011C0C7B
		// (set) Token: 0x0604697F RID: 289151 RVA: 0x011C2A83 File Offset: 0x011C0C83
		public float JumpTime { get; set; }
	}
}
