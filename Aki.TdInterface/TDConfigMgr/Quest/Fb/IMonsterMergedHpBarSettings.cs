using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001442 RID: 5186
	[NullableContext(2)]
	[Nullable(0)]
	public class IMonsterMergedHpBarSettings
	{
		// Token: 0x060075F2 RID: 30194 RVA: 0x00119B85 File Offset: 0x00117D85
		[NullableContext(1)]
		public static IMonsterMergedHpBarSettings Create(IMonsterMergedHpBarSettings? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterMergedHpBarSettings
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x00119BA4 File Offset: 0x00117DA4
		public virtual List<long> DisplayBuffIds
		{
			get
			{
				if (this._DisplayBuffIdsInited)
				{
					return this._DisplayBuffIdsCache;
				}
				this._DisplayBuffIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int displayBuffIdsLength = this.Instance.DisplayBuffIdsLength;
				this._DisplayBuffIdsCache = new List<long>(displayBuffIdsLength);
				for (int i = 0; i < displayBuffIdsLength; i++)
				{
					this._DisplayBuffIdsCache.Add(this.Instance.DisplayBuffIds(i));
				}
				return this._DisplayBuffIdsCache;
			}
		}

		// Token: 0x04004470 RID: 17520
		private IMonsterMergedHpBarSettings Instance;

		// Token: 0x04004471 RID: 17521
		private List<long> _DisplayBuffIdsCache;

		// Token: 0x04004472 RID: 17522
		private bool _DisplayBuffIdsInited;
	}
}
