using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B70 RID: 2928
	public class ITimeScaleConfig
	{
		// Token: 0x060042F1 RID: 17137 RVA: 0x000A9EE2 File Offset: 0x000A80E2
		public static ITimeScaleConfig Create(ITimeScaleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x000A9F01 File Offset: 0x000A8101
		public virtual bool IgnoreGlobalTimeScale
		{
			get
			{
				return this.Instance.IgnoreGlobalTimeScale;
			}
		}

		// Token: 0x040024F9 RID: 9465
		private ITimeScaleConfig Instance;
	}
}
