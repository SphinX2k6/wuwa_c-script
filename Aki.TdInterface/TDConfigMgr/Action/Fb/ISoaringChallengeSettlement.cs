using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C6B RID: 11371
	public class ISoaringChallengeSettlement : IDynamicSettlementConfig
	{
		// Token: 0x0600F9EA RID: 63978 RVA: 0x0024478A File Offset: 0x0024298A
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

		// Token: 0x17004DC2 RID: 19906
		// (get) Token: 0x0600F9EB RID: 63979 RVA: 0x002447A9 File Offset: 0x002429A9
		public override EDynamicSettlementType Type
		{
			get
			{
				return (EDynamicSettlementType)this.Instance.Type;
			}
		}

		// Token: 0x0400888D RID: 34957
		private ISoaringChallengeSettlement Instance;
	}
}
