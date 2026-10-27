using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000299 RID: 665
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomBulletLogic
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x00030224 File Offset: 0x0002E424
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

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003025C File Offset: 0x0002E45C
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

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003026F File Offset: 0x0002E46F
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

		// Token: 0x06000C6C RID: 3180 RVA: 0x00030282 File Offset: 0x0002E482
		public ICustomBulletLogic_SetValue ToSetValue()
		{
			return new ICustomBulletLogic_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00030295 File Offset: 0x0002E495
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x000302C0 File Offset: 0x0002E4C0
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

		// Token: 0x04000BA9 RID: 2985
		[Nullable(2)]
		protected ICustomBulletLogic FbInstance;

		// Token: 0x04000BAA RID: 2986
		[Nullable(2)]
		protected ICustomBulletLogic_SetValue PocoInterface;
	}
}
