using System;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070EC RID: 28908
	public class SplineRailDataImpl : ISplineRailData, IRailParam
	{
		// Token: 0x17009CC1 RID: 40129
		// (get) Token: 0x06046938 RID: 289080 RVA: 0x011C2874 File Offset: 0x011C0A74
		// (set) Token: 0x06046939 RID: 289081 RVA: 0x011C287C File Offset: 0x011C0A7C
		public ERailMoveType RailType { get; set; }

		// Token: 0x17009CC2 RID: 40130
		// (get) Token: 0x0604693A RID: 289082 RVA: 0x011C2885 File Offset: 0x011C0A85
		// (set) Token: 0x0604693B RID: 289083 RVA: 0x011C288D File Offset: 0x011C0A8D
		public ERailJumpType JumpType { get; set; }

		// Token: 0x17009CC3 RID: 40131
		// (get) Token: 0x0604693C RID: 289084 RVA: 0x011C2896 File Offset: 0x011C0A96
		// (set) Token: 0x0604693D RID: 289085 RVA: 0x011C289E File Offset: 0x011C0A9E
		public int DefaultNextRailId { get; set; }

		// Token: 0x17009CC4 RID: 40132
		// (get) Token: 0x0604693E RID: 289086 RVA: 0x011C28A7 File Offset: 0x011C0AA7
		// (set) Token: 0x0604693F RID: 289087 RVA: 0x011C28AF File Offset: 0x011C0AAF
		public ETriggerKey DefaultTriggerKey { get; set; }

		// Token: 0x17009CC5 RID: 40133
		// (get) Token: 0x06046940 RID: 289088 RVA: 0x011C28B8 File Offset: 0x011C0AB8
		// (set) Token: 0x06046941 RID: 289089 RVA: 0x011C28C0 File Offset: 0x011C0AC0
		public int RailId { get; set; }
	}
}
