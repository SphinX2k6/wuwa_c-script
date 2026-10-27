using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001457 RID: 5207
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestRecallConfig : IRecallConfig
	{
		// Token: 0x0600765B RID: 30299 RVA: 0x0011AABC File Offset: 0x00118CBC
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

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x0600765C RID: 30300 RVA: 0x0011AADB File Offset: 0x00118CDB
		public override int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x0600765D RID: 30301 RVA: 0x0011AAE8 File Offset: 0x00118CE8
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

		// Token: 0x040044B7 RID: 17591
		private IQuestRecallConfig Instance;

		// Token: 0x040044B8 RID: 17592
		private List<IRecallEntityList> _RecallEntityListCache;

		// Token: 0x040044B9 RID: 17593
		private bool _RecallEntityListInited;
	}
}
