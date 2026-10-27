using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5F RID: 2911
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingFoundation : IItemFoundationType
	{
		// Token: 0x0600430D RID: 17165 RVA: 0x000AB041 File Offset: 0x000A9241
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

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x000AB060 File Offset: 0x000A9260
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x000AB070 File Offset: 0x000A9270
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

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x000AB0A8 File Offset: 0x000A92A8
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

		// Token: 0x040025D8 RID: 9688
		private ICategoryMatchingFoundation Instance;

		// Token: 0x040025D9 RID: 9689
		private List<ICategoryMatchingConfig> _MatchingConfigsCache;

		// Token: 0x040025DA RID: 9690
		private bool _MatchingConfigsInited;
	}
}
