using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F1 RID: 28913
	public class CableWayRailDataImpl : ICableWayRailData, IRailParam
	{
		// Token: 0x17009CCE RID: 40142
		// (get) Token: 0x06046954 RID: 289108 RVA: 0x011C2939 File Offset: 0x011C0B39
		// (set) Token: 0x06046955 RID: 289109 RVA: 0x011C2941 File Offset: 0x011C0B41
		public ERailMoveType RailType { get; set; }

		// Token: 0x17009CCF RID: 40143
		// (get) Token: 0x06046956 RID: 289110 RVA: 0x011C294A File Offset: 0x011C0B4A
		// (set) Token: 0x06046957 RID: 289111 RVA: 0x011C2952 File Offset: 0x011C0B52
		public ERailJumpType JumpType { get; set; }
	}
}
