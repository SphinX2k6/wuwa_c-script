using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x020062B9 RID: 25273
	[NullableContext(1)]
	[Nullable(0)]
	public class ElevatorContext
	{
		// Token: 0x040205CC RID: 132556
		public BaseActorComponent ActorComp;

		// Token: 0x040205CD RID: 132557
		public int CurFloor = 1;

		// Token: 0x040205CE RID: 132558
		public float? DelayMoveTime;

		// Token: 0x040205CF RID: 132559
		public Entity Entity;

		// Token: 0x040205D0 RID: 132560
		public int? EntityConfigId;

		// Token: 0x040205D1 RID: 132561
		public bool IsAnnular;

		// Token: 0x040205D2 RID: 132562
		public float? MaxSpeed;

		// Token: 0x040205D3 RID: 132563
		public EGamePlayElevatorState State;

		// Token: 0x040205D4 RID: 132564
		public int TargetFloor;

		// Token: 0x040205D5 RID: 132565
		public bool? UniformMovement;
	}
}
