using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB0 RID: 7600
	public class IMechEscortFly_SetValue
	{
		// Token: 0x04006209 RID: 25097
		public ELeisureInteract Type;

		// Token: 0x0400620A RID: 25098
		public int TargetEntity;

		// Token: 0x0400620B RID: 25099
		public int TargetSpline;

		// Token: 0x0400620C RID: 25100
		public List<IMechEscortPoint> EscortPoints;
	}
}
