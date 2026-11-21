using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5D RID: 10845
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlay : IHideRangeType
	{
		// Token: 0x0600EF7F RID: 61311 RVA: 0x00231B27 File Offset: 0x0022FD27
		[NullableContext(0)]
		public static IHideWorldEntityAndLevelPlay Create(IHideWorldEntityAndLevelPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldEntityAndLevelPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004773 RID: 18291
		// (get) Token: 0x0600EF80 RID: 61312 RVA: 0x00231B46 File Offset: 0x0022FD46
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004774 RID: 18292
		// (get) Token: 0x0600EF81 RID: 61313 RVA: 0x00231B54 File Offset: 0x0022FD54
		public virtual List<int> ExcludeEntities
		{
			get
			{
				if (this._ExcludeEntitiesInited)
				{
					return this._ExcludeEntitiesCache;
				}
				this._ExcludeEntitiesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int excludeEntitiesLength = this.Instance.ExcludeEntitiesLength;
				this._ExcludeEntitiesCache = new List<int>(excludeEntitiesLength);
				for (int i = 0; i < excludeEntitiesLength; i++)
				{
					this._ExcludeEntitiesCache.Add(this.Instance.ExcludeEntities(i));
				}
				return this._ExcludeEntitiesCache;
			}
		}

		// Token: 0x040083A5 RID: 33701
		private IHideWorldEntityAndLevelPlay Instance;

		// Token: 0x040083A6 RID: 33702
		private List<int> _ExcludeEntitiesCache;

		// Token: 0x040083A7 RID: 33703
		private bool _ExcludeEntitiesInited;
	}
}
