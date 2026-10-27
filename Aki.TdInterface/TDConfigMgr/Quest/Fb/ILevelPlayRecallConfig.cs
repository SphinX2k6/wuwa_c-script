using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001458 RID: 5208
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayRecallConfig : IRecallConfig
	{
		// Token: 0x0600765F RID: 30303 RVA: 0x0011AB59 File Offset: 0x00118D59
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

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06007660 RID: 30304 RVA: 0x0011AB78 File Offset: 0x00118D78
		public override int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x06007661 RID: 30305 RVA: 0x0011AB88 File Offset: 0x00118D88
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

		// Token: 0x040044BA RID: 17594
		private ILevelPlayRecallConfig Instance;

		// Token: 0x040044BB RID: 17595
		private List<int> _RecallEntityListCache;

		// Token: 0x040044BC RID: 17596
		private bool _RecallEntityListInited;
	}
}
