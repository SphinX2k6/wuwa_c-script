using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B16 RID: 2838
	public class IMotorHookPerformanceConfig
	{
		// Token: 0x06004187 RID: 16775 RVA: 0x000A8276 File Offset: 0x000A6476
		[NullableContext(1)]
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

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x000A8298 File Offset: 0x000A6498
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

		// Token: 0x040024EB RID: 9451
		private IMotorHookPerformanceConfig Instance;
	}
}
