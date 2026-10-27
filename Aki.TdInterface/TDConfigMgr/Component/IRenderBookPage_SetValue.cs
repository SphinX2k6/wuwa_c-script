using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000677 RID: 1655
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderBookPage_SetValue
	{
		// Token: 0x04001872 RID: 6258
		public ERenderSpecifiedRangeType Type;

		// Token: 0x04001873 RID: 6259
		public int Radius;

		// Token: 0x04001874 RID: 6260
		public ITargetEntityType CenterTarget;

		// Token: 0x04001875 RID: 6261
		public string AkEvent;
	}
}
