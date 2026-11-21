using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C69 RID: 11369
	public class IDynamicSettlementConfig
	{
		// Token: 0x0600F9E2 RID: 63970 RVA: 0x002446B4 File Offset: 0x002428B4
		public static IDynamicSettlementConfig Create(IDynamicSettlementConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicSettlementConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DBE RID: 19902
		// (get) Token: 0x0600F9E3 RID: 63971 RVA: 0x002446D3 File Offset: 0x002428D3
		public virtual EDynamicSettlementType Type
		{
			get
			{
				return (EDynamicSettlementType)this.Instance.Type;
			}
		}

		// Token: 0x0400888B RID: 34955
		private IDynamicSettlementConfig Instance;
	}
}
