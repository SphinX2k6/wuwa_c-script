using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019AD RID: 6573
	public class IBuyGoods : ISystemFunction
	{
		// Token: 0x06008BBB RID: 35771 RVA: 0x0014B47C File Offset: 0x0014967C
		private IBuyGoods_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBuyGoods 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBuyGoods_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBuyGoods_SetValue());
			}
			return result;
		}

		// Token: 0x06008BBC RID: 35772 RVA: 0x0014B4B4 File Offset: 0x001496B4
		public static IBuyGoods Create([Nullable(2)] IBuyGoods instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuyGoods
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x0014B4C7 File Offset: 0x001496C7
		public static IBuyGoods CreateFromSetValue([Nullable(2)] IBuyGoods_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBuyGoods
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x0014B4DA File Offset: 0x001496DA
		public new IBuyGoods_SetValue ToSetValue()
		{
			return new IBuyGoods_SetValue
			{
				Type = this.Type,
				GoodsId = this.GoodsId
			};
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x06008BBF RID: 35775 RVA: 0x0014B4F9 File Offset: 0x001496F9
		// (set) Token: 0x06008BC0 RID: 35776 RVA: 0x0014B524 File Offset: 0x00149724
		public override ESystemFunction Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemFunction.BuyGoods;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x06008BC1 RID: 35777 RVA: 0x0014B532 File Offset: 0x00149732
		// (set) Token: 0x06008BC2 RID: 35778 RVA: 0x0014B55D File Offset: 0x0014975D
		public virtual int GoodsId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GoodsId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GoodsId;
			}
			set
			{
				this.GetOrCreatePoco().GoodsId = value;
			}
		}

		// Token: 0x04005831 RID: 22577
		[Nullable(2)]
		protected new IBuyGoods FbInstance;

		// Token: 0x04005832 RID: 22578
		[Nullable(2)]
		protected new IBuyGoods_SetValue PocoInterface;
	}
}
