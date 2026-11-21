using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE9 RID: 3049
	public class IHookPerformanceConfig
	{
		// Token: 0x060045F3 RID: 17907 RVA: 0x000B256E File Offset: 0x000B076E
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

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x000B2590 File Offset: 0x000B0790
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

		// Token: 0x0400273E RID: 10046
		private IHookPerformanceConfig Instance;
	}
}
