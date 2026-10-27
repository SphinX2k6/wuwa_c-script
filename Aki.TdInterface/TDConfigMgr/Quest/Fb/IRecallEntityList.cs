using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001455 RID: 5205
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntityList
	{
		// Token: 0x06007654 RID: 30292 RVA: 0x0011A9ED File Offset: 0x00118BED
		public static IRecallEntityList Create(IRecallEntityList? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityList
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x06007655 RID: 30293 RVA: 0x0011AA0C File Offset: 0x00118C0C
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06007656 RID: 30294 RVA: 0x0011AA1C File Offset: 0x00118C1C
		public virtual List<int> EntityList
		{
			get
			{
				if (this._EntityListInited)
				{
					return this._EntityListCache;
				}
				this._EntityListInited = true;
				int entityListLength = this.Instance.EntityListLength;
				this._EntityListCache = new List<int>(entityListLength);
				for (int i = 0; i < entityListLength; i++)
				{
					this._EntityListCache.Add(this.Instance.EntityList(i));
				}
				return this._EntityListCache;
			}
		}

		// Token: 0x040044B3 RID: 17587
		private IRecallEntityList Instance;

		// Token: 0x040044B4 RID: 17588
		private List<int> _EntityListCache;

		// Token: 0x040044B5 RID: 17589
		private bool _EntityListInited;
	}
}
