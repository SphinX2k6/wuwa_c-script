using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E9F RID: 3743
	public class IPlaneMovementOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x0600547F RID: 21631 RVA: 0x000D023D File Offset: 0x000CE43D
		public static IPlaneMovementOptimizationConfig Create(IPlaneMovementOptimizationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlaneMovementOptimizationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x000D025C File Offset: 0x000CE45C
		public override EPerformanceOptimizationType Type
		{
			get
			{
				return (EPerformanceOptimizationType)this.Instance.Type;
			}
		}

		// Token: 0x04003050 RID: 12368
		private IPlaneMovementOptimizationConfig Instance;
	}
}
