using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200639A RID: 25498
	public interface IRailParam
	{
		// Token: 0x17007545 RID: 30021
		// (get) Token: 0x0603DD27 RID: 253223
		// (set) Token: 0x0603DD28 RID: 253224
		ERailMoveType RailType { get; set; }

		// Token: 0x17007546 RID: 30022
		// (get) Token: 0x0603DD29 RID: 253225
		// (set) Token: 0x0603DD2A RID: 253226
		ERailJumpType JumpType { get; set; }
	}
}
