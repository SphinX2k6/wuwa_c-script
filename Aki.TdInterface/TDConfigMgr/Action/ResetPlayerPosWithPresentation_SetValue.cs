using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002165 RID: 8549
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerPosWithPresentation_SetValue
	{
		// Token: 0x0400705F RID: 28767
		public IResetPresentationFailure Presentation;

		// Token: 0x04007060 RID: 28768
		public IResetPosType ResetPosConfig;

		// Token: 0x04007061 RID: 28769
		public bool? NeedWaitResetPos;
	}
}
