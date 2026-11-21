using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B6 RID: 5558
	public class IRecallEntityGroup
	{
		// Token: 0x06007D45 RID: 32069 RVA: 0x00129AD8 File Offset: 0x00127CD8
		public static IRecallEntityGroup Create(IRecallEntityGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x06007D46 RID: 32070 RVA: 0x00129AF7 File Offset: 0x00127CF7
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x06007D47 RID: 32071 RVA: 0x00129B04 File Offset: 0x00127D04
		public virtual string Source
		{
			get
			{
				return this.Instance.Source;
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x06007D48 RID: 32072 RVA: 0x00129B11 File Offset: 0x00127D11
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x06007D49 RID: 32073 RVA: 0x00129B20 File Offset: 0x00127D20
		public virtual List<int> Entities
		{
			get
			{
				if (this._EntitiesInited)
				{
					return this._EntitiesCache;
				}
				this._EntitiesInited = true;
				int entitiesLength = this.Instance.EntitiesLength;
				this._EntitiesCache = new List<int>(entitiesLength);
				for (int i = 0; i < entitiesLength; i++)
				{
					this._EntitiesCache.Add(this.Instance.Entities(i));
				}
				return this._EntitiesCache;
			}
		}

		// Token: 0x04004864 RID: 18532
		private IRecallEntityGroup Instance;

		// Token: 0x04004865 RID: 18533
		private List<int> _EntitiesCache;

		// Token: 0x04004866 RID: 18534
		private bool _EntitiesInited;
	}
}
