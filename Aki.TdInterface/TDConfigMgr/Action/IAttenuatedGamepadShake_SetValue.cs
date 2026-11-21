using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196E RID: 6510
	public class IAttenuatedGamepadShake_SetValue
	{
		// Token: 0x040057A7 RID: 22439
		public EGamepadShakeType Type;

		// Token: 0x040057A8 RID: 22440
		public int CenterEntity;

		// Token: 0x040057A9 RID: 22441
		public bool IsFollowEntityMovement;

		// Token: 0x040057AA RID: 22442
		public string ForceFeedbackAttenuation;

		// Token: 0x040057AB RID: 22443
		public float Duration;

		// Token: 0x040057AC RID: 22444
		public bool IsLoop;
	}
}
