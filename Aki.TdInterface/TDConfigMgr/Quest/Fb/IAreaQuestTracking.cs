using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015BF RID: 5567
	public class IAreaQuestTracking
	{
		// Token: 0x06007DA8 RID: 32168 RVA: 0x0012AEA1 File Offset: 0x001290A1
		public static IAreaQuestTracking Create(IAreaQuestTracking? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAreaQuestTracking
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x0012AEC0 File Offset: 0x001290C0
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x06007DAA RID: 32170 RVA: 0x0012AECD File Offset: 0x001290CD
		public virtual int NodeId
		{
			get
			{
				return this.Instance.NodeId;
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x06007DAB RID: 32171 RVA: 0x0012AEDC File Offset: 0x001290DC
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x040048B5 RID: 18613
		private IAreaQuestTracking Instance;

		// Token: 0x040048B6 RID: 18614
		private List<int> _AreaIdsCache;

		// Token: 0x040048B7 RID: 18615
		private bool _AreaIdsInited;
	}
}
