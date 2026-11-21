using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CEE RID: 3310
	public class IMonsterNpcInteractionEnableConfig
	{
		// Token: 0x06004B79 RID: 19321 RVA: 0x000BD2A4 File Offset: 0x000BB4A4
		public static IMonsterNpcInteractionEnableConfig Create(IMonsterNpcInteractionEnableConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionEnableConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x000BD2C3 File Offset: 0x000BB4C3
		public virtual List<IMonsterNpcInteractionConfig> Interactions
		{
			get
			{
				if (this._InteractionsInited)
				{
					return this._InteractionsCache;
				}
				this._InteractionsInited = true;
				this._InteractionsCache = ComponentReadHelper.ReadIMonsterNpcInteractionEnableConfig_Interactions(this.Instance);
				return this._InteractionsCache;
			}
		}

		// Token: 0x04002AA5 RID: 10917
		private IMonsterNpcInteractionEnableConfig Instance;

		// Token: 0x04002AA6 RID: 10918
		private List<IMonsterNpcInteractionConfig> _InteractionsCache;

		// Token: 0x04002AA7 RID: 10919
		private bool _InteractionsInited;
	}
}
