using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F7E RID: 12158
	[NullableContext(2)]
	public interface IRangeShapeWithMeshShape
	{
		// Token: 0x0601CC69 RID: 117865
		UStaticMeshComponent GetMeshComp();

		// Token: 0x0601CC6A RID: 117866
		UStaticMeshComponent GetExitMeshComp();
	}
}
