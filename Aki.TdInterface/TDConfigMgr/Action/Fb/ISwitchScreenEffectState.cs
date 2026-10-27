using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025E9 RID: 9705
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchScreenEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600DA19 RID: 55833 RVA: 0x002082B3 File Offset: 0x002064B3
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

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x002082D2 File Offset: 0x002064D2
		public override ESwitchEffectStateEffectType Type
		{
			get
			{
				return (ESwitchEffectStateEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x0600DA1B RID: 55835 RVA: 0x002082DF File Offset: 0x002064DF
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x0400791D RID: 31005
		private ISwitchScreenEffectState Instance;
	}
}
