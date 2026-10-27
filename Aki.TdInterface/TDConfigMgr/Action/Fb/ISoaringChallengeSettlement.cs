using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002985 RID: 10629
	public class ISoaringChallengeSettlement : IDynamicSettlementConfig
	{
		// Token: 0x0600EB6F RID: 60271 RVA: 0x00227032 File Offset: 0x00225232
		[NullableContext(1)]
		public static ISoaringChallengeSettlement Create(ISoaringChallengeSettlement? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoaringChallengeSettlement
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x0600EB70 RID: 60272 RVA: 0x00227051 File Offset: 0x00225251
		public override EDynamicSettlementType Type
		{
			get
			{
				return (EDynamicSettlementType)this.Instance.Type;
			}
		}

		// Token: 0x040081A9 RID: 33193
		private ISoaringChallengeSettlement Instance;
	}
}
