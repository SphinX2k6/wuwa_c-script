using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E9E RID: 3742
	public class IPerformanceOptimization
	{
		// Token: 0x0600547C RID: 21628 RVA: 0x000D0209 File Offset: 0x000CE409
		public static IPerformanceOptimization Create(IPerformanceOptimization? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformanceOptimization
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x000D0228 File Offset: 0x000CE428
		public virtual EPerformanceOptimizationType Type
		{
			get
			{
				return (EPerformanceOptimizationType)this.Instance.Type;
			}
		}

		// Token: 0x0400304F RID: 12367
		private IPerformanceOptimization Instance;
	}
}
