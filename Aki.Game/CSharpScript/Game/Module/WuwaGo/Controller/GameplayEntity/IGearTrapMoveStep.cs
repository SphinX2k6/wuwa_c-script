using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200476F RID: 18287
	[NullableContext(1)]
	public interface IGearTrapMoveStep
	{
		// Token: 0x17007768 RID: 30568
		// (get) Token: 0x0602FCE5 RID: 195813
		Vector Direction { get; }

		// Token: 0x17007769 RID: 30569
		// (get) Token: 0x0602FCE6 RID: 195814
		Vector TargetCoordinate { get; }
	}
}
