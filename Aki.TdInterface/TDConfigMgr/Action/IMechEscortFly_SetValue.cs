using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC9 RID: 7113
	public class IMechEscortFly_SetValue
	{
		// Token: 0x04005CF4 RID: 23796
		public ELeisureInteract Type;

		// Token: 0x04005CF5 RID: 23797
		public int TargetEntity;

		// Token: 0x04005CF6 RID: 23798
		public int TargetSpline;

		// Token: 0x04005CF7 RID: 23799
		[Nullable(1)]
		public List<IMechEscortPoint> EscortPoints;
	}
}
