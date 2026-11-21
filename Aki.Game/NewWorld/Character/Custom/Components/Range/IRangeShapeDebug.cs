using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F7B RID: 12155
	[NullableContext(1)]
	public interface IRangeShapeDebug
	{
		// Token: 0x0601CC65 RID: 117861
		IReadOnlyList<string> GetRangeShapeWorldTransformsDebugString();
	}
}
