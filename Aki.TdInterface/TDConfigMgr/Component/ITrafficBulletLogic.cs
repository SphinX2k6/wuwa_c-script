using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000799 RID: 1945
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrafficBulletLogic : ICustomBulletLogic
	{
		// Token: 0x06002A28 RID: 10792 RVA: 0x0006EC54 File Offset: 0x0006CE54
		private ITrafficBulletLogic_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrafficBulletLogic 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrafficBulletLogic_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrafficBulletLogic_SetValue());
			}
			return result;
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0006EC8C File Offset: 0x0006CE8C
		public static ITrafficBulletLogic Create([Nullable(2)] ITrafficBulletLogic instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrafficBulletLogic
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x0006EC9F File Offset: 0x0006CE9F
		public static ITrafficBulletLogic CreateFromSetValue([Nullable(2)] ITrafficBulletLogic_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrafficBulletLogic
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0006ECB2 File Offset: 0x0006CEB2
		public new ITrafficBulletLogic_SetValue ToSetValue()
		{
			return new ITrafficBulletLogic_SetValue
			{
				Type = this.Type,
				MinSpeed = this.MinSpeed
			};
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x0006ECD1 File Offset: 0x0006CED1
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x0006ECFC File Offset: 0x0006CEFC
		public override ECustomBulletLogic Type
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

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x0006ED0A File Offset: 0x0006CF0A
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x0006ED39 File Offset: 0x0006CF39
		public virtual float MinSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MinSpeed = value;
			}
		}

		// Token: 0x04001C31 RID: 7217
		[Nullable(2)]
		protected new ITrafficBulletLogic FbInstance;

		// Token: 0x04001C32 RID: 7218
		[Nullable(2)]
		protected new ITrafficBulletLogic_SetValue PocoInterface;
	}
}
