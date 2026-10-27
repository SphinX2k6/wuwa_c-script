using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF4 RID: 3316
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeStopTarget
	{
		// Token: 0x06004BC4 RID: 19396 RVA: 0x000BD202 File Offset: 0x000BB402
		public static ITimeStopTarget Create(ITimeStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x000BD224 File Offset: 0x000BB424
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

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x000BD288 File Offset: 0x000BB488
		[Nullable(2)]
		public virtual IDynamicEntityMatch EntityMatch
		{
			[NullableContext(2)]
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				this._EntityMatchCache = IDynamicEntityMatch.Create(this.Instance.EntityMatch);
				return this._EntityMatchCache;
			}
		}

		// Token: 0x04002B51 RID: 11089
		private ITimeStopTarget Instance;

		// Token: 0x04002B52 RID: 11090
		private List<int> _EntityIdsCache;

		// Token: 0x04002B53 RID: 11091
		private bool _EntityIdsInited;

		// Token: 0x04002B54 RID: 11092
		[Nullable(2)]
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x04002B55 RID: 11093
		private bool _EntityMatchInited;
	}
}
