using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CC2 RID: 23746
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrackingDisplayRuleBase
	{
		// Token: 0x17008DF2 RID: 36338
		// (get) Token: 0x0603C0BF RID: 245951
		public abstract EMissionRuleId Id { get; }

		// Token: 0x17008DF3 RID: 36339
		// (get) Token: 0x0603C0C0 RID: 245952
		public abstract bool Enabled { get; }

		// Token: 0x17008DF4 RID: 36340
		// (get) Token: 0x0603C0C1 RID: 245953
		public abstract int Priority { get; }

		// Token: 0x0603C0C2 RID: 245954
		public abstract EMissionItemView? CustomTypeCheck(IMissionItemViewShowData showData, ETreeTextExpressReason? reason = null);

		// Token: 0x0603C0C3 RID: 245955
		public abstract void SortShowData(List<IMissionItemViewShowData> showData);
	}
}
