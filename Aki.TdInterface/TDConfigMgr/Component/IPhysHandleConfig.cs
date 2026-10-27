using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FA RID: 1530
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhysHandleConfig
	{
		// Token: 0x06002086 RID: 8326 RVA: 0x0005A808 File Offset: 0x00058A08
		private IPhysHandleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhysHandleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhysHandleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhysHandleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0005A840 File Offset: 0x00058A40
		public static IPhysHandleConfig Create([Nullable(2)] IPhysHandleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhysHandleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x0005A853 File Offset: 0x00058A53
		public static IPhysHandleConfig CreateFromSetValue([Nullable(2)] IPhysHandleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhysHandleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x0005A866 File Offset: 0x00058A66
		public IPhysHandleConfig_SetValue ToSetValue()
		{
			return new IPhysHandleConfig_SetValue
			{
				PhysHandleLinearDamping = this.PhysHandleLinearDamping,
				PhysHandleAngularStiffness = this.PhysHandleAngularStiffness,
				PhysHandleLinearStiffness = this.PhysHandleLinearStiffness,
				PhysHandleAngularDamping = this.PhysHandleAngularDamping
			};
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0005A89D File Offset: 0x00058A9D
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x0005A8C8 File Offset: 0x00058AC8
		public virtual int PhysHandleLinearDamping
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhysHandleLinearDamping;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PhysHandleLinearDamping;
			}
			set
			{
				this.GetOrCreatePoco().PhysHandleLinearDamping = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0005A8D6 File Offset: 0x00058AD6
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x0005A901 File Offset: 0x00058B01
		public virtual int PhysHandleAngularStiffness
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhysHandleAngularStiffness;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PhysHandleAngularStiffness;
			}
			set
			{
				this.GetOrCreatePoco().PhysHandleAngularStiffness = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x0005A90F File Offset: 0x00058B0F
		// (set) Token: 0x0600208F RID: 8335 RVA: 0x0005A93A File Offset: 0x00058B3A
		public virtual int PhysHandleLinearStiffness
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhysHandleLinearStiffness;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PhysHandleLinearStiffness;
			}
			set
			{
				this.GetOrCreatePoco().PhysHandleLinearStiffness = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x0005A948 File Offset: 0x00058B48
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x0005A973 File Offset: 0x00058B73
		public virtual int PhysHandleAngularDamping
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhysHandleAngularDamping;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PhysHandleAngularDamping;
			}
			set
			{
				this.GetOrCreatePoco().PhysHandleAngularDamping = value;
			}
		}

		// Token: 0x040016CF RID: 5839
		[Nullable(2)]
		protected IPhysHandleConfig FbInstance;

		// Token: 0x040016D0 RID: 5840
		[Nullable(2)]
		protected IPhysHandleConfig_SetValue PocoInterface;
	}
}
