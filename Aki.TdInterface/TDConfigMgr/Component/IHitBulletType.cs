using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000467 RID: 1127
	public class IHitBulletType
	{
		// Token: 0x0600168F RID: 5775 RVA: 0x000461D8 File Offset: 0x000443D8
		private IHitBulletType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitBulletType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitBulletType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitBulletType_SetValue());
			}
			return result;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00046210 File Offset: 0x00044410
		public static IHitBulletType Create([Nullable(2)] IHitBulletType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00046223 File Offset: 0x00044423
		public static IHitBulletType CreateFromSetValue([Nullable(2)] IHitBulletType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitBulletType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00046236 File Offset: 0x00044436
		public IHitBulletType_SetValue ToSetValue()
		{
			return new IHitBulletType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00046249 File Offset: 0x00044449
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x00046274 File Offset: 0x00044474
		public virtual EHitBulletType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitBulletType.OnlyDropAttack;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001178 RID: 4472
		[Nullable(2)]
		protected IHitBulletType FbInstance;

		// Token: 0x04001179 RID: 4473
		[Nullable(2)]
		protected IHitBulletType_SetValue PocoInterface;
	}
}
