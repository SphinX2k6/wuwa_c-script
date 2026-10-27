using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001822 RID: 6178
	[NullableContext(1)]
	[Nullable(0)]
	public class IBuyGoods : ISystemFunction
	{
		// Token: 0x06008495 RID: 33941 RVA: 0x0013BC88 File Offset: 0x00139E88
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

		// Token: 0x06008496 RID: 33942 RVA: 0x0013BCC0 File Offset: 0x00139EC0
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

		// Token: 0x06008497 RID: 33943 RVA: 0x0013BCD3 File Offset: 0x00139ED3
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

		// Token: 0x06008498 RID: 33944 RVA: 0x0013BCE6 File Offset: 0x00139EE6
		public new IBuyGoods_SetValue ToSetValue()
		{
			return new IBuyGoods_SetValue
			{
				Type = this.Type,
				GoodsId = this.GoodsId
			};
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x06008499 RID: 33945 RVA: 0x0013BD05 File Offset: 0x00139F05
		// (set) Token: 0x0600849A RID: 33946 RVA: 0x0013BD30 File Offset: 0x00139F30
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

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x0600849B RID: 33947 RVA: 0x0013BD3E File Offset: 0x00139F3E
		// (set) Token: 0x0600849C RID: 33948 RVA: 0x0013BD69 File Offset: 0x00139F69
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

		// Token: 0x040053E5 RID: 21477
		[Nullable(2)]
		protected new IBuyGoods FbInstance;

		// Token: 0x040053E6 RID: 21478
		[Nullable(2)]
		protected new IBuyGoods_SetValue PocoInterface;
	}
}
