using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200068F RID: 1679
	public class IPerformanceVehicleFeature : IVehicleFeature
	{
		// Token: 0x06002356 RID: 9046 RVA: 0x00060DE4 File Offset: 0x0005EFE4
		private IPerformanceVehicleFeature_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerformanceVehicleFeature 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerformanceVehicleFeature_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerformanceVehicleFeature_SetValue());
			}
			return result;
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00060E1C File Offset: 0x0005F01C
		public static IPerformanceVehicleFeature Create([Nullable(2)] IPerformanceVehicleFeature instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformanceVehicleFeature
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00060E2F File Offset: 0x0005F02F
		public static IPerformanceVehicleFeature CreateFromSetValue([Nullable(2)] IPerformanceVehicleFeature_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerformanceVehicleFeature
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00060E42 File Offset: 0x0005F042
		public new IPerformanceVehicleFeature_SetValue ToSetValue()
		{
			return new IPerformanceVehicleFeature_SetValue
			{
				Type = this.Type,
				PerformConfig = this.PerformConfig
			};
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x00060E61 File Offset: 0x0005F061
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x00060E8C File Offset: 0x0005F08C
		public override EVehicleFeatureFlag Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVehicleFeatureFlag)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x00060E9A File Offset: 0x0005F09A
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x00060EC5 File Offset: 0x0005F0C5
		public virtual string PerformConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformConfig;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PerformConfig;
			}
			set
			{
				this.GetOrCreatePoco().PerformConfig = value;
			}
		}

		// Token: 0x040018A2 RID: 6306
		[Nullable(2)]
		protected new IPerformanceVehicleFeature FbInstance;

		// Token: 0x040018A3 RID: 6307
		[Nullable(2)]
		protected new IPerformanceVehicleFeature_SetValue PocoInterface;
	}
}
