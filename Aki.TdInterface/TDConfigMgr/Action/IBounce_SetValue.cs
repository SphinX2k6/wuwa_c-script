using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001813 RID: 6163
	public class IBounce_SetValue
	{
		// Token: 0x040053BD RID: 21437
		public ELeisureInteract Type;

		// Token: 0x040053BE RID: 21438
		public int Height;

		// Token: 0x040053BF RID: 21439
		public float? Time;

		// Token: 0x040053C0 RID: 21440
		[Nullable(2)]
		public string MotionCurve;
	}
}
