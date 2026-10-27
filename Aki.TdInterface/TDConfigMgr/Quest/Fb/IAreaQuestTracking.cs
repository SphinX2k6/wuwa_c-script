using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001466 RID: 5222
	[NullableContext(1)]
	[Nullable(0)]
	public class IAreaQuestTracking
	{
		// Token: 0x060076DA RID: 30426 RVA: 0x0011C289 File Offset: 0x0011A489
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

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x060076DB RID: 30427 RVA: 0x0011C2A8 File Offset: 0x0011A4A8
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x060076DC RID: 30428 RVA: 0x0011C2B5 File Offset: 0x0011A4B5
		public virtual int NodeId
		{
			get
			{
				return this.Instance.NodeId;
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x060076DD RID: 30429 RVA: 0x0011C2C4 File Offset: 0x0011A4C4
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

		// Token: 0x0400451A RID: 17690
		private IAreaQuestTracking Instance;

		// Token: 0x0400451B RID: 17691
		private List<int> _AreaIdsCache;

		// Token: 0x0400451C RID: 17692
		private bool _AreaIdsInited;
	}
}
