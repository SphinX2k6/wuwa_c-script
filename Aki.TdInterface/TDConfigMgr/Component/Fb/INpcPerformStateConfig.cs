using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BCB RID: 3019
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcPerformStateConfig
	{
		// Token: 0x0600456C RID: 17772 RVA: 0x000AFD03 File Offset: 0x000ADF03
		[NullableContext(1)]
		public static INpcPerformStateConfig Create(INpcPerformStateConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformStateConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x000AFD22 File Offset: 0x000ADF22
		[Nullable(1)]
		public virtual string State
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x000AFD2F File Offset: 0x000ADF2F
		public virtual string MaterialDa
		{
			get
			{
				return this.Instance.MaterialDa;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x000AFD3C File Offset: 0x000ADF3C
		public virtual List<int> BuffEffectIds
		{
			get
			{
				if (this._BuffEffectIdsInited)
				{
					return this._BuffEffectIdsCache;
				}
				this._BuffEffectIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int buffEffectIdsLength = this.Instance.BuffEffectIdsLength;
				this._BuffEffectIdsCache = new List<int>(buffEffectIdsLength);
				for (int i = 0; i < buffEffectIdsLength; i++)
				{
					this._BuffEffectIdsCache.Add(this.Instance.BuffEffectIds(i));
				}
				return this._BuffEffectIdsCache;
			}
		}

		// Token: 0x0400277C RID: 10108
		private INpcPerformStateConfig Instance;

		// Token: 0x0400277D RID: 10109
		private List<int> _BuffEffectIdsCache;

		// Token: 0x0400277E RID: 10110
		private bool _BuffEffectIdsInited;
	}
}
