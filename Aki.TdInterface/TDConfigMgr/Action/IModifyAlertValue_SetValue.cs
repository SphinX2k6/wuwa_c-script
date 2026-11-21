using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD6 RID: 7638
	[NullableContext(2)]
	[Nullable(0)]
	public class IModifyAlertValue_SetValue
	{
		// Token: 0x0400625C RID: 25180
		public EAlertSystemOption Type;

		// Token: 0x0400625D RID: 25181
		public int AreaId;

		// Token: 0x0400625E RID: 25182
		public ISetAlertValueType SetType;

		// Token: 0x0400625F RID: 25183
		public IAlertValueSpeedChangeType ChangeSpeed;
	}
}
