using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C72 RID: 3186
	public class IFailureConditionHitTargetEntity : ITargetGearGroupFailureCondition
	{
		// Token: 0x060048C2 RID: 18626 RVA: 0x000B7D24 File Offset: 0x000B5F24
		public static IFailureConditionHitTargetEntity Create(IFailureConditionHitTargetEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureConditionHitTargetEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x000B7D43 File Offset: 0x000B5F43
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x000B7D50 File Offset: 0x000B5F50
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x040028E7 RID: 10471
		private IFailureConditionHitTargetEntity Instance;

		// Token: 0x040028E8 RID: 10472
		private List<int> _EntityIdsCache;

		// Token: 0x040028E9 RID: 10473
		private bool _EntityIdsInited;
	}
}
