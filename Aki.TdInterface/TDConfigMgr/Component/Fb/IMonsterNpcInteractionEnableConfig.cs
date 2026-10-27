using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1E RID: 3102
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractionEnableConfig
	{
		// Token: 0x06004716 RID: 18198 RVA: 0x000B30D8 File Offset: 0x000B12D8
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

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x000B30F7 File Offset: 0x000B12F7
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

		// Token: 0x04002859 RID: 10329
		private IMonsterNpcInteractionEnableConfig Instance;

		// Token: 0x0400285A RID: 10330
		private List<IMonsterNpcInteractionConfig> _InteractionsCache;

		// Token: 0x0400285B RID: 10331
		private bool _InteractionsInited;
	}
}
