using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237B RID: 9083
	public class PlayMontage_SetValue
	{
		// Token: 0x040075D2 RID: 30162
		public int EntityId;

		// Token: 0x040075D3 RID: 30163
		public IActionMontage ActionMontage;

		// Token: 0x040075D4 RID: 30164
		[Nullable(2)]
		public string ExpressionMontage;

		// Token: 0x040075D5 RID: 30165
		[Nullable(2)]
		public string MouthSequence;

		// Token: 0x040075D6 RID: 30166
		public int? Duration;
	}
}
