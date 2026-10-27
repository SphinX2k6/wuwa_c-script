using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D42 RID: 3394
	public class IVehicleFeature
	{
		// Token: 0x06004D6A RID: 19818 RVA: 0x000C09C1 File Offset: 0x000BEBC1
		[NullableContext(1)]
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

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06004D6B RID: 19819 RVA: 0x000C09E0 File Offset: 0x000BEBE0
		public virtual EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x04002C63 RID: 11363
		private IVehicleFeature Instance;
	}
}
