using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D88 RID: 7560
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractConfig_SetValue
	{
		// Token: 0x0400618C RID: 24972
		public float PressDuration;

		// Token: 0x0400618D RID: 24973
		public ILongPressEffectConfig PressEffect;

		// Token: 0x0400618E RID: 24974
		public ILongPressInteractStyleConfig Style;

		// Token: 0x0400618F RID: 24975
		public bool? ResetFromCurrentProgress;

		// Token: 0x04006190 RID: 24976
		public ILongPressButtonActionMapping LongPressButtonActionMapping;

		// Token: 0x04006191 RID: 24977
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> LongPressStartActions;

		// Token: 0x04006192 RID: 24978
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> LongPressInterruptedActions;

		// Token: 0x04006193 RID: 24979
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> LongPressSuccessActions;

		// Token: 0x04006194 RID: 24980
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ILongPressProgressAction> LongPressProgressActions;
	}
}
