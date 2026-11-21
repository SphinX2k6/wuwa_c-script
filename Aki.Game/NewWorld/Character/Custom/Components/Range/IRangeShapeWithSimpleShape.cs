using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F7C RID: 12156
	[NullableContext(1)]
	public interface IRangeShapeWithSimpleShape
	{
		// Token: 0x0601CC66 RID: 117862
		IReadOnlyList<UShapeComponent> GetShapeComps();

		// Token: 0x0601CC67 RID: 117863
		IReadOnlyList<UShapeComponent> GetExitShapeComps();
	}
}
