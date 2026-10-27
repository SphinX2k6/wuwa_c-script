using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA4 RID: 2980
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureConditionHitTargetEntity : ITargetGearGroupFailureCondition
	{
		// Token: 0x06004469 RID: 17513 RVA: 0x000ADC60 File Offset: 0x000ABE60
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

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x000ADC7F File Offset: 0x000ABE7F
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x000ADC8C File Offset: 0x000ABE8C
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

		// Token: 0x0400269F RID: 9887
		private IFailureConditionHitTargetEntity Instance;

		// Token: 0x040026A0 RID: 9888
		private List<int> _EntityIdsCache;

		// Token: 0x040026A1 RID: 9889
		private bool _EntityIdsInited;
	}
}
