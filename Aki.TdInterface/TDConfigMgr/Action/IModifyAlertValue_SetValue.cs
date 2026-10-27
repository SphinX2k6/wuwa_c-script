using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE7 RID: 7143
	[NullableContext(2)]
	[Nullable(0)]
	public class IModifyAlertValue_SetValue
	{
		// Token: 0x04005D36 RID: 23862
		public EAlertSystemOption Type;

		// Token: 0x04005D37 RID: 23863
		public int AreaId;

		// Token: 0x04005D38 RID: 23864
		public ISetAlertValueType SetType;

		// Token: 0x04005D39 RID: 23865
		public IAlertValueSpeedChangeType ChangeSpeed;
	}
}
