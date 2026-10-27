using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D63 RID: 3427
	public class IInhaledPerformance
	{
		// Token: 0x06004E0A RID: 19978 RVA: 0x000C1DED File Offset: 0x000BFFED
		[NullableContext(1)]
		public static IInhaledPerformance Create(IInhaledPerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledPerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06004E0B RID: 19979 RVA: 0x000C1E0C File Offset: 0x000C000C
		public virtual float InhaledTime
		{
			get
			{
				return this.Instance.InhaledTime;
			}
		}

		// Token: 0x04002CBE RID: 11454
		private IInhaledPerformance Instance;
	}
}
