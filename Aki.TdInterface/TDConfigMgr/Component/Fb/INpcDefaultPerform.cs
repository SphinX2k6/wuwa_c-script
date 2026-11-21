using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9D RID: 3229
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcDefaultPerform
	{
		// Token: 0x060049D4 RID: 18900 RVA: 0x000B9FA9 File Offset: 0x000B81A9
		[NullableContext(0)]
		public static INpcDefaultPerform Create(INpcDefaultPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcDefaultPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x060049D5 RID: 18901 RVA: 0x000B9FC8 File Offset: 0x000B81C8
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

		// Token: 0x040029CE RID: 10702
		private INpcDefaultPerform Instance;

		// Token: 0x040029CF RID: 10703
		private List<int> _BuffEffectIdsCache;

		// Token: 0x040029D0 RID: 10704
		private bool _BuffEffectIdsInited;
	}
}
