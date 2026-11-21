using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D39 RID: 11577
	public class IBuyGoods : ISystemFunction
	{
		// Token: 0x0600FCEB RID: 64747 RVA: 0x00248CFC File Offset: 0x00246EFC
		public static IBuyGoods Create(IBuyGoods? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuyGoods
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x0600FCEC RID: 64748 RVA: 0x00248D1B File Offset: 0x00246F1B
		public override ESystemFunction Type
		{
			get
			{
				return (ESystemFunction)this.Instance.Type;
			}
		}

		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x0600FCED RID: 64749 RVA: 0x00248D28 File Offset: 0x00246F28
		public virtual int GoodsId
		{
			get
			{
				return this.Instance.GoodsId;
			}
		}

		// Token: 0x04008A19 RID: 35353
		private IBuyGoods Instance;
	}
}
