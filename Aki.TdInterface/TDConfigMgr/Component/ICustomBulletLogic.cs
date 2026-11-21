using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002DE RID: 734
	public class ICustomBulletLogic
	{
		// Token: 0x06000D8D RID: 3469 RVA: 0x00033014 File Offset: 0x00031214
		private ICustomBulletLogic_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomBulletLogic 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomBulletLogic_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomBulletLogic_SetValue());
			}
			return result;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0003304C File Offset: 0x0003124C
		public static ICustomBulletLogic Create([Nullable(2)] ICustomBulletLogic instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomBulletLogic
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0003305F File Offset: 0x0003125F
		public static ICustomBulletLogic CreateFromSetValue([Nullable(2)] ICustomBulletLogic_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomBulletLogic
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00033072 File Offset: 0x00031272
		public ICustomBulletLogic_SetValue ToSetValue()
		{
			return new ICustomBulletLogic_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00033085 File Offset: 0x00031285
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x000330B0 File Offset: 0x000312B0
		public virtual ECustomBulletLogic Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomBulletLogic.TrafficBullet;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000C8E RID: 3214
		[Nullable(2)]
		protected ICustomBulletLogic FbInstance;

		// Token: 0x04000C8F RID: 3215
		[Nullable(2)]
		protected ICustomBulletLogic_SetValue PocoInterface;
	}
}
