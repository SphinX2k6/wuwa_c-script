using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA1 RID: 7073
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractConfig_SetValue
	{
		// Token: 0x04005C77 RID: 23671
		public float PressDuration;

		// Token: 0x04005C78 RID: 23672
		public ILongPressEffectConfig PressEffect;

		// Token: 0x04005C79 RID: 23673
		public ILongPressInteractStyleConfig Style;

		// Token: 0x04005C7A RID: 23674
		public bool? ResetFromCurrentProgress;

		// Token: 0x04005C7B RID: 23675
		public ILongPressButtonActionMapping LongPressButtonActionMapping;

		// Token: 0x04005C7C RID: 23676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> LongPressStartActions;

		// Token: 0x04005C7D RID: 23677
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> LongPressInterruptedActions;

		// Token: 0x04005C7E RID: 23678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> LongPressSuccessActions;

		// Token: 0x04005C7F RID: 23679
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ILongPressProgressAction> LongPressProgressActions;
	}
}
