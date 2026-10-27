using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4C RID: 10828
	public class IBuyGoods : ISystemFunction
	{
		// Token: 0x0600EE53 RID: 61011 RVA: 0x0022B348 File Offset: 0x00229548
		[NullableContext(1)]
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

		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x0600EE54 RID: 61012 RVA: 0x0022B367 File Offset: 0x00229567
		public override ESystemFunction Type
		{
			get
			{
				return (ESystemFunction)this.Instance.Type;
			}
		}

		// Token: 0x17004B7E RID: 19326
		// (get) Token: 0x0600EE55 RID: 61013 RVA: 0x0022B374 File Offset: 0x00229574
		public virtual int GoodsId
		{
			get
			{
				return this.Instance.GoodsId;
			}
		}

		// Token: 0x04008326 RID: 33574
		private IBuyGoods Instance;
	}
}
