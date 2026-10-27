using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1B RID: 2843
	public class IHookPerformanceConfig
	{
		// Token: 0x0600419D RID: 16797 RVA: 0x000A8542 File Offset: 0x000A6742
		[NullableContext(1)]
		public static IHookPerformanceConfig Create(IHookPerformanceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookPerformanceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x0600419E RID: 16798 RVA: 0x000A8564 File Offset: 0x000A6764
		public virtual long? HookEffectBuffId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new long?(this.Instance.HookEffectBuffId);
			}
		}

		// Token: 0x040024FA RID: 9466
		private IHookPerformanceConfig Instance;
	}
}
