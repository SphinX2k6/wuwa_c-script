using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Custom
{
	// Token: 0x020070A4 RID: 28836
	[NullableContext(1)]
	[Nullable(0)]
	public class CompConfig
	{
		// Token: 0x04024D10 RID: 150800
		public object NeedReqEntityAccessRange = false;

		// Token: 0x04024D11 RID: 150801
		public object NeedReqPlayerAccessRange = false;

		// Token: 0x04024D12 RID: 150802
		public object NeedPendingEmitEvent = false;

		// Token: 0x04024D13 RID: 150803
		public object NeedDisablePassiveCollision = false;

		// Token: 0x04024D14 RID: 150804
		public object NeedUseFullCollisionPreset = false;
	}
}
