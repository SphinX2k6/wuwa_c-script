using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E37 RID: 7735
	public class ISetNpcHuggingBearPerform_SetValue
	{
		// Token: 0x040062F1 RID: 25329
		public ENpcGroupPerformType Type;

		// Token: 0x040062F2 RID: 25330
		[Nullable(1)]
		public IPlayerInitiator Initiator;

		// Token: 0x040062F3 RID: 25331
		public int Target;

		// Token: 0x040062F4 RID: 25332
		public ENpcGroupPerformNpcType NpcType;
	}
}
