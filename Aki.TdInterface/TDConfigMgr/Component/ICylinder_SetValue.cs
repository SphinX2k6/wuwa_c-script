using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002A6 RID: 678
	public class ICylinder_SetValue
	{
		// Token: 0x04000BC6 RID: 3014
		public bool IsUse;

		// Token: 0x04000BC7 RID: 3015
		public int Radius;

		// Token: 0x04000BC8 RID: 3016
		public int Height;

		// Token: 0x04000BC9 RID: 3017
		[Nullable(1)]
		public PosA CylinderPos;
	}
}
