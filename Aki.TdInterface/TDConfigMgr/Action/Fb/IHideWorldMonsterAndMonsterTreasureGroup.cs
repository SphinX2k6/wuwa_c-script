using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002792 RID: 10130
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideWorldMonsterAndMonsterTreasureGroup : IHideGroupType
	{
		// Token: 0x0600E17D RID: 57725 RVA: 0x0021519D File Offset: 0x0021339D
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

		// Token: 0x1700441B RID: 17435
		// (get) Token: 0x0600E17E RID: 57726 RVA: 0x002151BC File Offset: 0x002133BC
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x1700441C RID: 17436
		// (get) Token: 0x0600E17F RID: 57727 RVA: 0x002151CC File Offset: 0x002133CC
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

		// Token: 0x04007D02 RID: 32002
		private IHideWorldMonsterAndMonsterTreasureGroup Instance;

		// Token: 0x04007D03 RID: 32003
		private List<int> _HideRangeEntitiesCache;

		// Token: 0x04007D04 RID: 32004
		private bool _HideRangeEntitiesInited;
	}
}
