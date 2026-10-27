using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA2 RID: 3490
	public class IPerformanceOptimization
	{
		// Token: 0x06004F57 RID: 20311 RVA: 0x000C49B9 File Offset: 0x000C2BB9
		[NullableContext(1)]
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

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06004F58 RID: 20312 RVA: 0x000C49D8 File Offset: 0x000C2BD8
		public virtual EPerformanceOptimizationType Type
		{
			get
			{
				return (EPerformanceOptimizationType)this.Instance.Type;
			}
		}

		// Token: 0x04002D89 RID: 11657
		private IPerformanceOptimization Instance;
	}
}
