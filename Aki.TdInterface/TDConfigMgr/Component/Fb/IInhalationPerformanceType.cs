using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5E RID: 3422
	public class IInhalationPerformanceType
	{
		// Token: 0x06004DF8 RID: 19960 RVA: 0x000C1BE5 File Offset: 0x000BFDE5
		[NullableContext(1)]
		public static IInhalationPerformanceType Create(IInhalationPerformanceType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationPerformanceType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06004DF9 RID: 19961 RVA: 0x000C1C04 File Offset: 0x000BFE04
		public virtual EInhalationPerformanceType Type
		{
			get
			{
				return (EInhalationPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002CB3 RID: 11443
		private IInhalationPerformanceType Instance;
	}
}
