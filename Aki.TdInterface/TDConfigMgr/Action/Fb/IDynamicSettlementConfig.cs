using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002983 RID: 10627
	public class IDynamicSettlementConfig
	{
		// Token: 0x0600EB67 RID: 60263 RVA: 0x00226F5C File Offset: 0x0022515C
		[NullableContext(1)]
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

		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x0600EB68 RID: 60264 RVA: 0x00226F7B File Offset: 0x0022517B
		public virtual EDynamicSettlementType Type
		{
			get
			{
				return (EDynamicSettlementType)this.Instance.Type;
			}
		}

		// Token: 0x040081A7 RID: 33191
		private IDynamicSettlementConfig Instance;
	}
}
