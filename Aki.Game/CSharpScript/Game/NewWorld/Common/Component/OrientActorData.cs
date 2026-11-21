using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200620E RID: 25102
	[NullableContext(1)]
	[Nullable(0)]
	internal class OrientActorData
	{
		// Token: 0x0603C57C RID: 247164 RVA: 0x01135883 File Offset: 0x01133A83
		public OrientActorData(AActor origin, BaseActorComponent target)
		{
			this.OriginActor = origin;
			this.TargetActor = target;
		}

		// Token: 0x0401FF2A RID: 130858
		public AActor OriginActor;

		// Token: 0x0401FF2B RID: 130859
		public BaseActorComponent TargetActor;
	}
}
