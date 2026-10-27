using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C11 RID: 7185
	public class IMotorBounce_SetValue
	{
		// Token: 0x04005DB8 RID: 23992
		public ELeisureInteract Type;

		// Token: 0x04005DB9 RID: 23993
		public int Height;

		// Token: 0x04005DBA RID: 23994
		public float? Time;

		// Token: 0x04005DBB RID: 23995
		[Nullable(2)]
		public string MotionCurve;

		// Token: 0x04005DBC RID: 23996
		public EMotorBounceSkillType? SkillType;
	}
}
