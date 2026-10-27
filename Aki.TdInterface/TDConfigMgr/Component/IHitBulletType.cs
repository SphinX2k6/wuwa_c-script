using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200040E RID: 1038
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletType
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x00042490 File Offset: 0x00040690
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

		// Token: 0x060014F6 RID: 5366 RVA: 0x000424C8 File Offset: 0x000406C8
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

		// Token: 0x060014F7 RID: 5367 RVA: 0x000424DB File Offset: 0x000406DB
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

		// Token: 0x060014F8 RID: 5368 RVA: 0x000424EE File Offset: 0x000406EE
		public IHitBulletType_SetValue ToSetValue()
		{
			return new IHitBulletType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00042501 File Offset: 0x00040701
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0004252C File Offset: 0x0004072C
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

		// Token: 0x04001056 RID: 4182
		[Nullable(2)]
		protected IHitBulletType FbInstance;

		// Token: 0x04001057 RID: 4183
		[Nullable(2)]
		protected IHitBulletType_SetValue PocoInterface;
	}
}
