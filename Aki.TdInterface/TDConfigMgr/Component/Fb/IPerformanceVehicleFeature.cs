using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4C RID: 3404
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformanceVehicleFeature : IVehicleFeature
	{
		// Token: 0x06004D97 RID: 19863 RVA: 0x000C0EAE File Offset: 0x000BF0AE
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

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06004D98 RID: 19864 RVA: 0x000C0ECD File Offset: 0x000BF0CD
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06004D99 RID: 19865 RVA: 0x000C0EDA File Offset: 0x000BF0DA
		public virtual string PerformConfig
		{
			get
			{
				return this.Instance.PerformConfig;
			}
		}

		// Token: 0x04002C79 RID: 11385
		private IPerformanceVehicleFeature Instance;
	}
}
