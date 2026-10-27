using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200186F RID: 6255
	public class IChangeEntityStateDirectly_SetValue
	{
		// Token: 0x040054C4 RID: 21700
		public EChangeEntityState Type;

		// Token: 0x040054C5 RID: 21701
		public int EntityId;

		// Token: 0x040054C6 RID: 21702
		[Nullable(1)]
		public string State;

		// Token: 0x040054C7 RID: 21703
		public bool? DelayChange;
	}
}
