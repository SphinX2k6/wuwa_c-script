using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F2 RID: 1522
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformanceVehicleFeature : IVehicleFeature
	{
		// Token: 0x06002054 RID: 8276 RVA: 0x0005A168 File Offset: 0x00058368
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

		// Token: 0x06002055 RID: 8277 RVA: 0x0005A1A0 File Offset: 0x000583A0
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

		// Token: 0x06002056 RID: 8278 RVA: 0x0005A1B3 File Offset: 0x000583B3
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

		// Token: 0x06002057 RID: 8279 RVA: 0x0005A1C6 File Offset: 0x000583C6
		public new IPerformanceVehicleFeature_SetValue ToSetValue()
		{
			return new IPerformanceVehicleFeature_SetValue
			{
				Type = this.Type,
				PerformConfig = this.PerformConfig
			};
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x0005A1E5 File Offset: 0x000583E5
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x0005A210 File Offset: 0x00058410
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

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x0005A21E File Offset: 0x0005841E
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x0005A249 File Offset: 0x00058449
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

		// Token: 0x040016B2 RID: 5810
		[Nullable(2)]
		protected new IPerformanceVehicleFeature FbInstance;

		// Token: 0x040016B3 RID: 5811
		[Nullable(2)]
		protected new IPerformanceVehicleFeature_SetValue PocoInterface;
	}
}
