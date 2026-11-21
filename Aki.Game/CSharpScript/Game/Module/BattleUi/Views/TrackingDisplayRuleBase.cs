using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA4 RID: 19620
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrackingDisplayRuleBase
	{
		// Token: 0x170061C4 RID: 25028
		// (get) Token: 0x06031014 RID: 200724
		public abstract EMissionRuleId Id { get; }

		// Token: 0x170061C5 RID: 25029
		// (get) Token: 0x06031015 RID: 200725
		public abstract bool Enabled { get; }

		// Token: 0x170061C6 RID: 25030
		// (get) Token: 0x06031016 RID: 200726
		public abstract int Priority { get; }

		// Token: 0x06031017 RID: 200727
		public abstract EMissionItemView? CustomTypeCheck(IMissionItemViewShowData showData, ETreeTextExpressReason? reason = null);

		// Token: 0x06031018 RID: 200728
		public abstract void SortShowData(List<IMissionItemViewShowData> showData);
	}
}
