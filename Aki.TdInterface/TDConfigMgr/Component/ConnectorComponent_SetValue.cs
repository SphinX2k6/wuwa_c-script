using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004B RID: 75
	public class ConnectorComponent_SetValue
	{
		// Token: 0x0400018A RID: 394
		public bool? Disabled;

		// Token: 0x0400018B RID: 395
		public bool? EdIsLocked;

		// Token: 0x0400018C RID: 396
		[Nullable(1)]
		public IConnectorLogicType LogicType;
	}
}
