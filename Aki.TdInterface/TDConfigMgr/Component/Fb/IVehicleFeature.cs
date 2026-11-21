using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3C RID: 3644
	public class IVehicleFeature
	{
		// Token: 0x06005286 RID: 21126 RVA: 0x000CC105 File Offset: 0x000CA305
		public static IVehicleFeature Create(IVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x000CC124 File Offset: 0x000CA324
		public virtual EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x04002F23 RID: 12067
		private IVehicleFeature Instance;
	}
}
