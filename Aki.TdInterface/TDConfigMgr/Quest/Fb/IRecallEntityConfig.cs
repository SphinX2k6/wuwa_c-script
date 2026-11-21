using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B8 RID: 5560
	public class IRecallEntityConfig
	{
		// Token: 0x06007D50 RID: 32080 RVA: 0x00129C88 File Offset: 0x00127E88
		public static IRecallEntityConfig Create(IRecallEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06007D51 RID: 32081 RVA: 0x00129CA8 File Offset: 0x00127EA8
		public virtual List<IRecallEntityGroup> EntityGroups
		{
			get
			{
				if (this._EntityGroupsInited)
				{
					return this._EntityGroupsCache;
				}
				this._EntityGroupsInited = true;
				int entityGroupsLength = this.Instance.EntityGroupsLength;
				this._EntityGroupsCache = new List<IRecallEntityGroup>(entityGroupsLength);
				for (int i = 0; i < entityGroupsLength; i++)
				{
					this._EntityGroupsCache.Add(IRecallEntityGroup.Create(this.Instance.EntityGroups(i)));
				}
				return this._EntityGroupsCache;
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x06007D52 RID: 32082 RVA: 0x00129D14 File Offset: 0x00127F14
		public virtual List<IRecallEntry> Recalls
		{
			get
			{
				if (this._RecallsInited)
				{
					return this._RecallsCache;
				}
				this._RecallsInited = true;
				int recallsLength = this.Instance.RecallsLength;
				this._RecallsCache = new List<IRecallEntry>(recallsLength);
				for (int i = 0; i < recallsLength; i++)
				{
					this._RecallsCache.Add(IRecallEntry.Create(this.Instance.Recalls(i)));
				}
				return this._RecallsCache;
			}
		}

		// Token: 0x0400486C RID: 18540
		private IRecallEntityConfig Instance;

		// Token: 0x0400486D RID: 18541
		private List<IRecallEntityGroup> _EntityGroupsCache;

		// Token: 0x0400486E RID: 18542
		private bool _EntityGroupsInited;

		// Token: 0x0400486F RID: 18543
		private List<IRecallEntry> _RecallsCache;

		// Token: 0x04004870 RID: 18544
		private bool _RecallsInited;
	}
}
