using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A7 RID: 10407
	public class ISwitchEffectStateEffectBase
	{
		// Token: 0x0600E7DF RID: 59359 RVA: 0x0022496B File Offset: 0x00222B6B
		public static ISwitchEffectStateEffectBase Create(ISwitchEffectStateEffectBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchEffectStateEffectBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x0600E7E0 RID: 59360 RVA: 0x0022498A File Offset: 0x00222B8A
		public virtual ESwitchEffectStateEffectType Type
		{
			get
			{
				return (ESwitchEffectStateEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007FB3 RID: 32691
		private ISwitchEffectStateEffectBase Instance;
	}
}
