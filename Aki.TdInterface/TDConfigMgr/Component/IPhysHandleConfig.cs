using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000697 RID: 1687
	public class IPhysHandleConfig
	{
		// Token: 0x0600238C RID: 9100 RVA: 0x0006151C File Offset: 0x0005F71C
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

		// Token: 0x0600238D RID: 9101 RVA: 0x00061554 File Offset: 0x0005F754
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

		// Token: 0x0600238E RID: 9102 RVA: 0x00061567 File Offset: 0x0005F767
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

		// Token: 0x0600238F RID: 9103 RVA: 0x0006157A File Offset: 0x0005F77A
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

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x000615B1 File Offset: 0x0005F7B1
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x000615DC File Offset: 0x0005F7DC
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x000615EA File Offset: 0x0005F7EA
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x00061615 File Offset: 0x0005F815
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

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x00061623 File Offset: 0x0005F823
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x0006164E File Offset: 0x0005F84E
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0006165C File Offset: 0x0005F85C
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x00061687 File Offset: 0x0005F887
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

		// Token: 0x040018C1 RID: 6337
		[Nullable(2)]
		protected IPhysHandleConfig FbInstance;

		// Token: 0x040018C2 RID: 6338
		[Nullable(2)]
		protected IPhysHandleConfig_SetValue PocoInterface;
	}
}
