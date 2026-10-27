using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x02007107 RID: 28935
	[NullableContext(2)]
	[Nullable(0)]
	public class AttachMoveRelation
	{
		// Token: 0x04025149 RID: 151881
		[Nullable(1)]
		public string Key = "";

		// Token: 0x0402514A RID: 151882
		public CharacterActorComponent Leader;

		// Token: 0x0402514B RID: 151883
		public BaseActorComponent FollowerActor;

		// Token: 0x0402514C RID: 151884
		public BaseMoveComponent FollowerMoveComp;

		// Token: 0x0402514D RID: 151885
		public int LeaderEntityId;

		// Token: 0x0402514E RID: 151886
		public int FollowerEntityId;

		// Token: 0x0402514F RID: 151887
		public Action StopFn;
	}
}
