using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA3 RID: 3491
	public class IPlaneMovementOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x06004F5A RID: 20314 RVA: 0x000C49ED File Offset: 0x000C2BED
		[NullableContext(1)]
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

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x000C4A0C File Offset: 0x000C2C0C
		public override EPerformanceOptimizationType Type
		{
			get
			{
				return (EPerformanceOptimizationType)this.Instance.Type;
			}
		}

		// Token: 0x04002D8A RID: 11658
		private IPlaneMovementOptimizationConfig Instance;
	}
}
