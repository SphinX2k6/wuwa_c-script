using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A8 RID: 10408
	public class ISwitchScreenEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600E7E2 RID: 59362 RVA: 0x0022499F File Offset: 0x00222B9F
		public static ISwitchScreenEffectState Create(ISwitchScreenEffectState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchScreenEffectState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x002249BE File Offset: 0x00222BBE
		public override ESwitchEffectStateEffectType Type
		{
			get
			{
				return (ESwitchEffectStateEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x0600E7E4 RID: 59364 RVA: 0x002249CB File Offset: 0x00222BCB
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007FB4 RID: 32692
		private ISwitchScreenEffectState Instance;
	}
}
