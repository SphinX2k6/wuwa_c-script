using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200145F RID: 5215
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntityConfig
	{
		// Token: 0x06007683 RID: 30339 RVA: 0x0011B0A4 File Offset: 0x001192A4
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

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x06007684 RID: 30340 RVA: 0x0011B0C4 File Offset: 0x001192C4
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

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x06007685 RID: 30341 RVA: 0x0011B130 File Offset: 0x00119330
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

		// Token: 0x040044D3 RID: 17619
		private IRecallEntityConfig Instance;

		// Token: 0x040044D4 RID: 17620
		private List<IRecallEntityGroup> _EntityGroupsCache;

		// Token: 0x040044D5 RID: 17621
		private bool _EntityGroupsInited;

		// Token: 0x040044D6 RID: 17622
		private List<IRecallEntry> _RecallsCache;

		// Token: 0x040044D7 RID: 17623
		private bool _RecallsInited;
	}
}
