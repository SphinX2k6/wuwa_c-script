using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200063C RID: 1596
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuantityRefillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x06002214 RID: 8724 RVA: 0x0005DD40 File Offset: 0x0005BF40
		private IQuantityRefillCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuantityRefillCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuantityRefillCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuantityRefillCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0005DD78 File Offset: 0x0005BF78
		public static IQuantityRefillCondition Create([Nullable(2)] IQuantityRefillCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuantityRefillCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0005DD8B File Offset: 0x0005BF8B
		public static IQuantityRefillCondition CreateFromSetValue([Nullable(2)] IQuantityRefillCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuantityRefillCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0005DD9E File Offset: 0x0005BF9E
		public new IQuantityRefillCondition_SetValue ToSetValue()
		{
			return new IQuantityRefillCondition_SetValue
			{
				Type = this.Type,
				Quantity = this.Quantity,
				DelayRefill = this.DelayRefill
			};
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x0005DDC9 File Offset: 0x0005BFC9
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x0005DDF4 File Offset: 0x0005BFF4
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x0005DE02 File Offset: 0x0005C002
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x0005DE2D File Offset: 0x0005C02D
		public virtual int Quantity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Quantity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Quantity;
			}
			set
			{
				this.GetOrCreatePoco().Quantity = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x0005DE3C File Offset: 0x0005C03C
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x0005DE76 File Offset: 0x0005C076
		public virtual float? DelayRefill
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayRefill;
				}
				IQuantityRefillCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayRefill;
			}
			set
			{
				this.GetOrCreatePoco().DelayRefill = value;
			}
		}

		// Token: 0x040017B1 RID: 6065
		[Nullable(2)]
		protected new IQuantityRefillCondition FbInstance;

		// Token: 0x040017B2 RID: 6066
		[Nullable(2)]
		protected new IQuantityRefillCondition_SetValue PocoInterface;
	}
}
