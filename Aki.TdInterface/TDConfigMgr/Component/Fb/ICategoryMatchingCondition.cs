using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B57 RID: 2903
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingCondition
	{
		// Token: 0x060042D8 RID: 17112 RVA: 0x000AA8E9 File Offset: 0x000A8AE9
		[NullableContext(1)]
		public static ICategoryMatchingCondition Create(ICategoryMatchingCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x000AA908 File Offset: 0x000A8B08
		public virtual IDynamicEntityMatch EntityMatch
		{
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

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x000AA93C File Offset: 0x000A8B3C
		public virtual string SelfState
		{
			get
			{
				return this.Instance.SelfState;
			}
		}

		// Token: 0x040025AC RID: 9644
		private ICategoryMatchingCondition Instance;

		// Token: 0x040025AD RID: 9645
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x040025AE RID: 9646
		private bool _EntityMatchInited;
	}
}
