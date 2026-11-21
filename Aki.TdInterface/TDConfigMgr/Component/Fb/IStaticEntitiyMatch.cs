using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B94 RID: 2964
	[NullableContext(2)]
	[Nullable(0)]
	public class IStaticEntitiyMatch
	{
		// Token: 0x060043C4 RID: 17348 RVA: 0x000ABE46 File Offset: 0x000AA046
		[NullableContext(0)]
		public static IStaticEntitiyMatch Create(IStaticEntitiyMatch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStaticEntitiyMatch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x000ABE65 File Offset: 0x000AA065
		public virtual IEntityCategory Category
		{
			get
			{
				if (this._CategoryInited)
				{
					return this._CategoryCache;
				}
				this._CategoryInited = true;
				this._CategoryCache = IEntityCategory.Create(this.Instance.Category);
				return this._CategoryCache;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060043C6 RID: 17350 RVA: 0x000ABE9C File Offset: 0x000AA09C
		public virtual EEntityCategory? CategoryType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EEntityCategory?((EEntityCategory)this.Instance.CategoryType);
			}
		}

		// Token: 0x04002579 RID: 9593
		private IStaticEntitiyMatch Instance;

		// Token: 0x0400257A RID: 9594
		private IEntityCategory _CategoryCache;

		// Token: 0x0400257B RID: 9595
		private bool _CategoryInited;
	}
}
