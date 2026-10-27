using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x02007204 RID: 29188
	[NullableContext(1)]
	[Nullable(0)]
	public class ElevatorContext
	{
		// Token: 0x0402595D RID: 153949
		public BaseActorComponent ActorComp;

		// Token: 0x0402595E RID: 153950
		public int CurFloor = 1;

		// Token: 0x0402595F RID: 153951
		public float? DelayMoveTime;

		// Token: 0x04025960 RID: 153952
		public Entity Entity;

		// Token: 0x04025961 RID: 153953
		public int? EntityConfigId;

		// Token: 0x04025962 RID: 153954
		public bool IsAnnular;

		// Token: 0x04025963 RID: 153955
		public float? MaxSpeed;

		// Token: 0x04025964 RID: 153956
		public EGamePlayElevatorState State;

		// Token: 0x04025965 RID: 153957
		public int TargetFloor;

		// Token: 0x04025966 RID: 153958
		public bool? UniformMovement;
	}
}
