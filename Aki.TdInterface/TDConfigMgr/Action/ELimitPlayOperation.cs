using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200176D RID: 5997
	[EnumExtensions]
	public enum ELimitPlayOperation
	{
		// Token: 0x04004F7F RID: 20351
		AllowCamera,
		// Token: 0x04004F80 RID: 20352
		AllowAction,
		// Token: 0x04004F81 RID: 20353
		AllowMove,
		// Token: 0x04004F82 RID: 20354
		AllowMoveNew,
		// Token: 0x04004F83 RID: 20355
		AllowUi,
		// Token: 0x04004F84 RID: 20356
		AllowMouse,
		// Token: 0x04004F85 RID: 20357
		BlockAll
	}
}
