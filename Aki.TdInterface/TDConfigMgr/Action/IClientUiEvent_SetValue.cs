using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D3 RID: 6355
	public class IClientUiEvent_SetValue
	{
		// Token: 0x040055A0 RID: 21920
		public EClientEventTarget Type;

		// Token: 0x040055A1 RID: 21921
		[Nullable(1)]
		public IClientEventUi Ui;
	}
}
