using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ACA RID: 2762
	[NullableContext(2)]
	[Nullable(0)]
	public class IStaticEntitiyMatch
	{
		// Token: 0x06003F9A RID: 16282 RVA: 0x000A2852 File Offset: 0x000A0A52
		[NullableContext(1)]
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

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x000A2871 File Offset: 0x000A0A71
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06003F9C RID: 16284 RVA: 0x000A28A8 File Offset: 0x000A0AA8
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

		// Token: 0x0400235D RID: 9053
		private IStaticEntitiyMatch Instance;

		// Token: 0x0400235E RID: 9054
		private IEntityCategory _CategoryCache;

		// Token: 0x0400235F RID: 9055
		private bool _CategoryInited;
	}
}
