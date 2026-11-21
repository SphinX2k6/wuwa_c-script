using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E46 RID: 3654
	public class IPerformanceVehicleFeature : IVehicleFeature
	{
		// Token: 0x060052B3 RID: 21171 RVA: 0x000CC5F2 File Offset: 0x000CA7F2
		public static IPerformanceVehicleFeature Create(IPerformanceVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformanceVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060052B4 RID: 21172 RVA: 0x000CC611 File Offset: 0x000CA811
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060052B5 RID: 21173 RVA: 0x000CC61E File Offset: 0x000CA81E
		public virtual string PerformConfig
		{
			get
			{
				return this.Instance.PerformConfig;
			}
		}

		// Token: 0x04002F39 RID: 12089
		private IPerformanceVehicleFeature Instance;
	}
}
