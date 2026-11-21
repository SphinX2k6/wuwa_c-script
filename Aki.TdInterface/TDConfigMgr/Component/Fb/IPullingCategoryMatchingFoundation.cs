using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C34 RID: 3124
	public class IPullingCategoryMatchingFoundation : IPullingFoundationType
	{
		// Token: 0x06004786 RID: 18310 RVA: 0x000B54CD File Offset: 0x000B36CD
		public static IPullingCategoryMatchingFoundation Create(IPullingCategoryMatchingFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPullingCategoryMatchingFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004787 RID: 18311 RVA: 0x000B54EC File Offset: 0x000B36EC
		public override EPullingFoundation Type
		{
			get
			{
				return (EPullingFoundation)this.Instance.Type;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x000B54FC File Offset: 0x000B36FC
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

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x000B5534 File Offset: 0x000B3734
		public virtual List<ICategoryMatchingConfigBase> MatchingConfigs
		{
			get
			{
				if (this._MatchingConfigsInited)
				{
					return this._MatchingConfigsCache;
				}
				this._MatchingConfigsInited = true;
				int matchingConfigsLength = this.Instance.MatchingConfigsLength;
				this._MatchingConfigsCache = new List<ICategoryMatchingConfigBase>(matchingConfigsLength);
				for (int i = 0; i < matchingConfigsLength; i++)
				{
					this._MatchingConfigsCache.Add(ICategoryMatchingConfigBase.Create(this.Instance.MatchingConfigs(i)));
				}
				return this._MatchingConfigsCache;
			}
		}

		// Token: 0x04002837 RID: 10295
		private IPullingCategoryMatchingFoundation Instance;

		// Token: 0x04002838 RID: 10296
		private List<ICategoryMatchingConfigBase> _MatchingConfigsCache;

		// Token: 0x04002839 RID: 10297
		private bool _MatchingConfigsInited;
	}
}
