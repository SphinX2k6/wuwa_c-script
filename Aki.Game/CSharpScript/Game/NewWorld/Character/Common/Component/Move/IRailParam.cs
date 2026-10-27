using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070EA RID: 28906
	public interface IRailParam
	{
		// Token: 0x17009CBC RID: 40124
		// (get) Token: 0x0604692E RID: 289070
		// (set) Token: 0x0604692F RID: 289071
		ERailMoveType RailType { get; set; }

		// Token: 0x17009CBD RID: 40125
		// (get) Token: 0x06046930 RID: 289072
		// (set) Token: 0x06046931 RID: 289073
		ERailJumpType JumpType { get; set; }
	}
}
