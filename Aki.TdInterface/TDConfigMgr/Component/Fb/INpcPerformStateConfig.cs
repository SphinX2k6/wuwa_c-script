using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C99 RID: 3225
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcPerformStateConfig
	{
		// Token: 0x060049C5 RID: 18885 RVA: 0x000B9DC7 File Offset: 0x000B7FC7
		[NullableContext(0)]
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

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x060049C6 RID: 18886 RVA: 0x000B9DE6 File Offset: 0x000B7FE6
		[Nullable(0)]
		public virtual string State
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x060049C7 RID: 18887 RVA: 0x000B9DF3 File Offset: 0x000B7FF3
		public virtual string MaterialDa
		{
			get
			{
				return this.Instance.MaterialDa;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x060049C8 RID: 18888 RVA: 0x000B9E00 File Offset: 0x000B8000
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

		// Token: 0x040029C4 RID: 10692
		private INpcPerformStateConfig Instance;

		// Token: 0x040029C5 RID: 10693
		private List<int> _BuffEffectIdsCache;

		// Token: 0x040029C6 RID: 10694
		private bool _BuffEffectIdsInited;
	}
}
