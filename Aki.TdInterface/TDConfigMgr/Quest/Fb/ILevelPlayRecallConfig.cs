using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B1 RID: 5553
	public class ILevelPlayRecallConfig : IRecallConfig
	{
		// Token: 0x06007D2C RID: 32044 RVA: 0x0012973D File Offset: 0x0012793D
		public static ILevelPlayRecallConfig Create(ILevelPlayRecallConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayRecallConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x06007D2D RID: 32045 RVA: 0x0012975C File Offset: 0x0012795C
		public override int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x06007D2E RID: 32046 RVA: 0x0012976C File Offset: 0x0012796C
		public virtual List<int> RecallEntityList
		{
			get
			{
				if (this._RecallEntityListInited)
				{
					return this._RecallEntityListCache;
				}
				this._RecallEntityListInited = true;
				int recallEntityListLength = this.Instance.RecallEntityListLength;
				this._RecallEntityListCache = new List<int>(recallEntityListLength);
				for (int i = 0; i < recallEntityListLength; i++)
				{
					this._RecallEntityListCache.Add(this.Instance.RecallEntityList(i));
				}
				return this._RecallEntityListCache;
			}
		}

		// Token: 0x04004853 RID: 18515
		private ILevelPlayRecallConfig Instance;

		// Token: 0x04004854 RID: 18516
		private List<int> _RecallEntityListCache;

		// Token: 0x04004855 RID: 18517
		private bool _RecallEntityListInited;
	}
}
