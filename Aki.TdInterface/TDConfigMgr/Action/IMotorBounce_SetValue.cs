using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E00 RID: 7680
	public class IMotorBounce_SetValue
	{
		// Token: 0x040062DF RID: 25311
		public ELeisureInteract Type;

		// Token: 0x040062E0 RID: 25312
		public int Height;

		// Token: 0x040062E1 RID: 25313
		public float? Time;

		// Token: 0x040062E2 RID: 25314
		[Nullable(2)]
		public string MotionCurve;

		// Token: 0x040062E3 RID: 25315
		public EMotorBounceSkillType? SkillType;
	}
}
