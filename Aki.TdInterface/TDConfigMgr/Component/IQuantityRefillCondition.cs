using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D9 RID: 1753
	public class IQuantityRefillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x0600251A RID: 9498 RVA: 0x00064A54 File Offset: 0x00062C54
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

		// Token: 0x0600251B RID: 9499 RVA: 0x00064A8C File Offset: 0x00062C8C
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

		// Token: 0x0600251C RID: 9500 RVA: 0x00064A9F File Offset: 0x00062C9F
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

		// Token: 0x0600251D RID: 9501 RVA: 0x00064AB2 File Offset: 0x00062CB2
		public new IQuantityRefillCondition_SetValue ToSetValue()
		{
			return new IQuantityRefillCondition_SetValue
			{
				Type = this.Type,
				Quantity = this.Quantity,
				DelayRefill = this.DelayRefill
			};
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x00064ADD File Offset: 0x00062CDD
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00064B08 File Offset: 0x00062D08
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

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x00064B16 File Offset: 0x00062D16
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x00064B41 File Offset: 0x00062D41
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

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x00064B50 File Offset: 0x00062D50
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x00064B8A File Offset: 0x00062D8A
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

		// Token: 0x040019A3 RID: 6563
		[Nullable(2)]
		protected new IQuantityRefillCondition FbInstance;

		// Token: 0x040019A4 RID: 6564
		[Nullable(2)]
		protected new IQuantityRefillCondition_SetValue PocoInterface;
	}
}
