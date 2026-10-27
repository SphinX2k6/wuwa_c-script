using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000856 RID: 2134
	public class PickInteractComponent_SetValue
	{
		// Token: 0x04001F1B RID: 7963
		public bool? Disabled;

		// Token: 0x04001F1C RID: 7964
		public bool? EdIsLocked;

		// Token: 0x04001F1D RID: 7965
		[Nullable(1)]
		public IChessmanPickInteraction PickInteractType;
	}
}
