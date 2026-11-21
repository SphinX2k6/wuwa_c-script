using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x020063B7 RID: 25527
	[NullableContext(2)]
	[Nullable(0)]
	public class AttachMoveRelation
	{
		// Token: 0x04020DDE RID: 134622
		[Nullable(1)]
		public string Key = "";

		// Token: 0x04020DDF RID: 134623
		public CharacterActorComponent Leader;

		// Token: 0x04020DE0 RID: 134624
		public BaseActorComponent FollowerActor;

		// Token: 0x04020DE1 RID: 134625
		public BaseMoveComponent FollowerMoveComp;

		// Token: 0x04020DE2 RID: 134626
		public int LeaderEntityId;

		// Token: 0x04020DE3 RID: 134627
		public int FollowerEntityId;

		// Token: 0x04020DE4 RID: 134628
		public Action StopFn;
	}
}
