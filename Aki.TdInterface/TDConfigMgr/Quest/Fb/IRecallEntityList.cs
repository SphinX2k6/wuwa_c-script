using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015AE RID: 5550
	public class IRecallEntityList
	{
		// Token: 0x06007D21 RID: 32033 RVA: 0x001295D1 File Offset: 0x001277D1
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

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x001295F0 File Offset: 0x001277F0
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x06007D23 RID: 32035 RVA: 0x00129600 File Offset: 0x00127800
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

		// Token: 0x0400484C RID: 18508
		private IRecallEntityList Instance;

		// Token: 0x0400484D RID: 18509
		private List<int> _EntityListCache;

		// Token: 0x0400484E RID: 18510
		private bool _EntityListInited;
	}
}
