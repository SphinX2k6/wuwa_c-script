using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2D RID: 3117
	public class ICategoryMatchingFoundation : IItemFoundationType
	{
		// Token: 0x06004766 RID: 18278 RVA: 0x000B5105 File Offset: 0x000B3305
		public static ICategoryMatchingFoundation Create(ICategoryMatchingFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x000B5124 File Offset: 0x000B3324
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x000B5134 File Offset: 0x000B3334
		public virtual int? InitMatchEntity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InitMatchEntity);
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x000B516C File Offset: 0x000B336C
		public virtual List<ICategoryMatchingConfig> MatchingConfigs
		{
			get
			{
				if (this._MatchingConfigsInited)
				{
					return this._MatchingConfigsCache;
				}
				this._MatchingConfigsInited = true;
				int matchingConfigsLength = this.Instance.MatchingConfigsLength;
				this._MatchingConfigsCache = new List<ICategoryMatchingConfig>(matchingConfigsLength);
				for (int i = 0; i < matchingConfigsLength; i++)
				{
					this._MatchingConfigsCache.Add(ICategoryMatchingConfig.Create(this.Instance.MatchingConfigs(i)));
				}
				return this._MatchingConfigsCache;
			}
		}

		// Token: 0x04002820 RID: 10272
		private ICategoryMatchingFoundation Instance;

		// Token: 0x04002821 RID: 10273
		private List<ICategoryMatchingConfig> _MatchingConfigsCache;

		// Token: 0x04002822 RID: 10274
		private bool _MatchingConfigsInited;
	}
}
