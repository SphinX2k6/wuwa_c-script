using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A0 RID: 13984
	[NullableContext(1)]
	public interface IGearTrapMoveStep
	{
		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x060244AF RID: 148655
		Vector Direction { get; }

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x060244B0 RID: 148656
		Vector TargetCoordinate { get; }
	}
}
