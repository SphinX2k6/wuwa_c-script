using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200631F RID: 25375
	[NullableContext(2)]
	[Nullable(0)]
	public class RelativeMove
	{
		// Token: 0x04020920 RID: 133408
		public long BaseMovementEntityId;

		// Token: 0x04020921 RID: 133409
		public Vector RelativeLocation;

		// Token: 0x04020922 RID: 133410
		public Rotator RelativeRotation;
	}
}
