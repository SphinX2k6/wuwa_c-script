using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200159A RID: 5530
	[NullableContext(2)]
	[Nullable(0)]
	public class IMonsterMergedHpBarSettings
	{
		// Token: 0x06007CBA RID: 31930 RVA: 0x00128659 File Offset: 0x00126859
		[NullableContext(0)]
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

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x06007CBB RID: 31931 RVA: 0x00128678 File Offset: 0x00126878
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

		// Token: 0x04004806 RID: 18438
		private IMonsterMergedHpBarSettings Instance;

		// Token: 0x04004807 RID: 18439
		private List<long> _DisplayBuffIdsCache;

		// Token: 0x04004808 RID: 18440
		private bool _DisplayBuffIdsInited;
	}
}
