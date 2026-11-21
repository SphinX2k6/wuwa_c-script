using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A64 RID: 10852
	public class IHideWorldMonsterAndMonsterTreasureGroup : IHideGroupType
	{
		// Token: 0x0600EF9B RID: 61339 RVA: 0x00231F31 File Offset: 0x00230131
		public static IHideWorldMonsterAndMonsterTreasureGroup Create(IHideWorldMonsterAndMonsterTreasureGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasureGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004781 RID: 18305
		// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x00231F50 File Offset: 0x00230150
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004782 RID: 18306
		// (get) Token: 0x0600EF9D RID: 61341 RVA: 0x00231F60 File Offset: 0x00230160
		public virtual List<int> HideRangeEntities
		{
			get
			{
				if (this._HideRangeEntitiesInited)
				{
					return this._HideRangeEntitiesCache;
				}
				this._HideRangeEntitiesInited = true;
				int hideRangeEntitiesLength = this.Instance.HideRangeEntitiesLength;
				this._HideRangeEntitiesCache = new List<int>(hideRangeEntitiesLength);
				for (int i = 0; i < hideRangeEntitiesLength; i++)
				{
					this._HideRangeEntitiesCache.Add(this.Instance.HideRangeEntities(i));
				}
				return this._HideRangeEntitiesCache;
			}
		}

		// Token: 0x040083B8 RID: 33720
		private IHideWorldMonsterAndMonsterTreasureGroup Instance;

		// Token: 0x040083B9 RID: 33721
		private List<int> _HideRangeEntitiesCache;

		// Token: 0x040083BA RID: 33722
		private bool _HideRangeEntitiesInited;
	}
}
