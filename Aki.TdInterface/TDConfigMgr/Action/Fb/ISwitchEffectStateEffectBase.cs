using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025E8 RID: 9704
	public class ISwitchEffectStateEffectBase
	{
		// Token: 0x0600DA16 RID: 55830 RVA: 0x0020827F File Offset: 0x0020647F
		[NullableContext(1)]
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

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x0600DA17 RID: 55831 RVA: 0x0020829E File Offset: 0x0020649E
		public virtual ESwitchEffectStateEffectType Type
		{
			get
			{
				return (ESwitchEffectStateEffectType)this.Instance.Type;
			}
		}

		// Token: 0x0400791C RID: 31004
		private ISwitchEffectStateEffectBase Instance;
	}
}
