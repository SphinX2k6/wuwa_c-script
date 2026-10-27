using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E35 RID: 7733
	public class ISetNpcHighFivePerform_SetValue
	{
		// Token: 0x040062E9 RID: 25321
		public ENpcGroupPerformType Type;

		// Token: 0x040062EA RID: 25322
		[Nullable(1)]
		public IPlayerInitiator Initiator;

		// Token: 0x040062EB RID: 25323
		public int Target;

		// Token: 0x040062EC RID: 25324
		public ENpcGroupPerformNpcType NpcType;
	}
}
