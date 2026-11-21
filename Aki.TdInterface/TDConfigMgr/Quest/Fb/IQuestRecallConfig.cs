using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B0 RID: 5552
	public class IQuestRecallConfig : IRecallConfig
	{
		// Token: 0x06007D28 RID: 32040 RVA: 0x001296A0 File Offset: 0x001278A0
		public static IQuestRecallConfig Create(IQuestRecallConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestRecallConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x06007D29 RID: 32041 RVA: 0x001296BF File Offset: 0x001278BF
		public override int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x06007D2A RID: 32042 RVA: 0x001296CC File Offset: 0x001278CC
		public virtual List<IRecallEntityList> RecallEntityList
		{
			get
			{
				if (this._RecallEntityListInited)
				{
					return this._RecallEntityListCache;
				}
				this._RecallEntityListInited = true;
				int recallEntityListLength = this.Instance.RecallEntityListLength;
				this._RecallEntityListCache = new List<IRecallEntityList>(recallEntityListLength);
				for (int i = 0; i < recallEntityListLength; i++)
				{
					this._RecallEntityListCache.Add(IRecallEntityList.Create(this.Instance.RecallEntityList(i)));
				}
				return this._RecallEntityListCache;
			}
		}

		// Token: 0x04004850 RID: 18512
		private IQuestRecallConfig Instance;

		// Token: 0x04004851 RID: 18513
		private List<IRecallEntityList> _RecallEntityListCache;

		// Token: 0x04004852 RID: 18514
		private bool _RecallEntityListInited;
	}
}
