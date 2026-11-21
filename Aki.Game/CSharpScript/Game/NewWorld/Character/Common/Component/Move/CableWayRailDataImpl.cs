using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A1 RID: 25505
	public class CableWayRailDataImpl : ICableWayRailData, IRailParam
	{
		// Token: 0x17007557 RID: 30039
		// (get) Token: 0x0603DD4D RID: 253261 RVA: 0x011F1AED File Offset: 0x011EFCED
		// (set) Token: 0x0603DD4E RID: 253262 RVA: 0x011F1AF5 File Offset: 0x011EFCF5
		public ERailMoveType RailType { get; set; }

		// Token: 0x17007558 RID: 30040
		// (get) Token: 0x0603DD4F RID: 253263 RVA: 0x011F1AFE File Offset: 0x011EFCFE
		// (set) Token: 0x0603DD50 RID: 253264 RVA: 0x011F1B06 File Offset: 0x011EFD06
		public ERailJumpType JumpType { get; set; }
	}
}
