using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E41 RID: 3649
	public class IBattleVehicleFeature : IVehicleFeature
	{
		// Token: 0x0600529E RID: 21150 RVA: 0x000CC3F6 File Offset: 0x000CA5F6
		public static IBattleVehicleFeature Create(IBattleVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x000CC415 File Offset: 0x000CA615
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x04002F30 RID: 12080
		private IBattleVehicleFeature Instance;
	}
}
