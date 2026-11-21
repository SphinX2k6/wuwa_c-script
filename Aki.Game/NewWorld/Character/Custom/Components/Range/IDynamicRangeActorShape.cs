using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F7A RID: 12154
	public interface IDynamicRangeActorShape : IRangeActorShape
	{
		// Token: 0x0601CC64 RID: 117860
		[NullableContext(2)]
		void AttachRangeActorToParent(AActor parent, bool resetPosition, FName? socket);
	}
}
