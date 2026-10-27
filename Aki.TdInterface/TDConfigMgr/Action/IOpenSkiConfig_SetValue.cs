using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CAD RID: 7341
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenSkiConfig_SetValue
	{
		// Token: 0x04005F60 RID: 24416
		public ESkiConfig Type;

		// Token: 0x04005F61 RID: 24417
		public ITargetEntityType Target;

		// Token: 0x04005F62 RID: 24418
		public string SkiConfig;
	}
}
