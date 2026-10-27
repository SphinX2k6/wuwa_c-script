using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E5 RID: 6117
	public class IAttenuatedGamepadShake_SetValue
	{
		// Token: 0x0400535F RID: 21343
		public EGamepadShakeType Type;

		// Token: 0x04005360 RID: 21344
		public int CenterEntity;

		// Token: 0x04005361 RID: 21345
		public bool IsFollowEntityMovement;

		// Token: 0x04005362 RID: 21346
		[Nullable(1)]
		public string ForceFeedbackAttenuation;

		// Token: 0x04005363 RID: 21347
		public float Duration;

		// Token: 0x04005364 RID: 21348
		public bool IsLoop;
	}
}
