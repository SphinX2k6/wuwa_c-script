using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE4 RID: 3044
	public class IMotorHookPerformanceConfig
	{
		// Token: 0x060045DD RID: 17885 RVA: 0x000B22A2 File Offset: 0x000B04A2
		public static IMotorHookPerformanceConfig Create(IMotorHookPerformanceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorHookPerformanceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060045DE RID: 17886 RVA: 0x000B22C4 File Offset: 0x000B04C4
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

		// Token: 0x0400272F RID: 10031
		private IMotorHookPerformanceConfig Instance;
	}
}
