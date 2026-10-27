using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F00 RID: 7936
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchEffectState_SetValue
	{
		// Token: 0x040064E9 RID: 25833
		public EEffectType Type;

		// Token: 0x040064EA RID: 25834
		public string Path;

		// Token: 0x040064EB RID: 25835
		public ISwitchEffectStateEffectBase EffectType;

		// Token: 0x040064EC RID: 25836
		public int TargetStateIndex;
	}
}
