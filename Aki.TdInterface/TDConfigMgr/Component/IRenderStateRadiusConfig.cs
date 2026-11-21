using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000721 RID: 1825
	public class IRenderStateRadiusConfig
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x00068260 File Offset: 0x00066460
		private IRenderStateRadiusConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderStateRadiusConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderStateRadiusConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderStateRadiusConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00068298 File Offset: 0x00066498
		public static IRenderStateRadiusConfig Create([Nullable(2)] IRenderStateRadiusConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderStateRadiusConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000682AB File Offset: 0x000664AB
		public static IRenderStateRadiusConfig CreateFromSetValue([Nullable(2)] IRenderStateRadiusConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderStateRadiusConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000682BE File Offset: 0x000664BE
		public IRenderStateRadiusConfig_SetValue ToSetValue()
		{
			return new IRenderStateRadiusConfig_SetValue
			{
				State = this.State,
				Radius = this.Radius
			};
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000682DD File Offset: 0x000664DD
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x00068308 File Offset: 0x00066508
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x00068316 File Offset: 0x00066516
		// (set) Token: 0x060026C3 RID: 9923 RVA: 0x00068345 File Offset: 0x00066545
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x04001A96 RID: 6806
		[Nullable(2)]
		protected IRenderStateRadiusConfig FbInstance;

		// Token: 0x04001A97 RID: 6807
		[Nullable(2)]
		protected IRenderStateRadiusConfig_SetValue PocoInterface;
	}
}
