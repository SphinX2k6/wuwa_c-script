using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B66 RID: 2918
	[NullableContext(1)]
	[Nullable(0)]
	public class IPullingCategoryMatchingFoundation : IPullingFoundationType
	{
		// Token: 0x0600432D RID: 17197 RVA: 0x000AB409 File Offset: 0x000A9609
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

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x000AB428 File Offset: 0x000A9628
		public override EPullingFoundation Type
		{
			get
			{
				return (EPullingFoundation)this.Instance.Type;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x000AB438 File Offset: 0x000A9638
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

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x000AB470 File Offset: 0x000A9670
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

		// Token: 0x040025EF RID: 9711
		private IPullingCategoryMatchingFoundation Instance;

		// Token: 0x040025F0 RID: 9712
		private List<ICategoryMatchingConfigBase> _MatchingConfigsCache;

		// Token: 0x040025F1 RID: 9713
		private bool _MatchingConfigsInited;
	}
}
