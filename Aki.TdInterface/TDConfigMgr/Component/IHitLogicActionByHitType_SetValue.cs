using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041F RID: 1055
	public class IHitLogicActionByHitType_SetValue
	{
		// Token: 0x04001082 RID: 4226
		public EHitLogicType Type;

		// Token: 0x04001083 RID: 4227
		[Nullable(1)]
		public List<IActionByHitTypeConfig> Configs;
	}
}
