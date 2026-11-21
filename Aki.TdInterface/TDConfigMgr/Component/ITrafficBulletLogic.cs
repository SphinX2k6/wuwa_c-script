using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200083A RID: 2106
	public class ITrafficBulletLogic : ICustomBulletLogic
	{
		// Token: 0x06002D50 RID: 11600 RVA: 0x00075EFC File Offset: 0x000740FC
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

		// Token: 0x06002D51 RID: 11601 RVA: 0x00075F34 File Offset: 0x00074134
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

		// Token: 0x06002D52 RID: 11602 RVA: 0x00075F47 File Offset: 0x00074147
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

		// Token: 0x06002D53 RID: 11603 RVA: 0x00075F5A File Offset: 0x0007415A
		public new ITrafficBulletLogic_SetValue ToSetValue()
		{
			return new ITrafficBulletLogic_SetValue
			{
				Type = this.Type,
				MinSpeed = this.MinSpeed
			};
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x00075F79 File Offset: 0x00074179
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x00075FA4 File Offset: 0x000741A4
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

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x00075FB2 File Offset: 0x000741B2
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x00075FE1 File Offset: 0x000741E1
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

		// Token: 0x04001E3A RID: 7738
		[Nullable(2)]
		protected new ITrafficBulletLogic FbInstance;

		// Token: 0x04001E3B RID: 7739
		[Nullable(2)]
		protected new ITrafficBulletLogic_SetValue PocoInterface;
	}
}
