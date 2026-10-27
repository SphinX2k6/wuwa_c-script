using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070BB RID: 28859
	[NullableContext(2)]
	[Nullable(0)]
	public class RelativeMove
	{
		// Token: 0x04024DE2 RID: 151010
		public long BaseMovementEntityId;

		// Token: 0x04024DE3 RID: 151011
		public Vector RelativeLocation;

		// Token: 0x04024DE4 RID: 151012
		public Rotator RelativeRotation;
	}
}
