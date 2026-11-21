using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000962 RID: 2402
	public class TeleportComponent_SetValue
	{
		// Token: 0x0400231F RID: 8991
		public bool? Disabled;

		// Token: 0x04002320 RID: 8992
		public bool? EdIsLocked;

		// Token: 0x04002321 RID: 8993
		public int TeleporterId;

		// Token: 0x04002322 RID: 8994
		public PosA TeleportPos;

		// Token: 0x04002323 RID: 8995
		[Nullable(2)]
		public IGravityFlipTeleportConfig GravityConfig;
	}
}
