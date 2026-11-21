using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C04 RID: 3076
	public class IEntityCategoryWeight
	{
		// Token: 0x06004699 RID: 18073 RVA: 0x000B3B33 File Offset: 0x000B1D33
		public static IEntityCategoryWeight Create(IEntityCategoryWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityCategoryWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x000B3B52 File Offset: 0x000B1D52
		public virtual IStaticEntitiyMatch EntitiyMatch
		{
			get
			{
				if (this._EntitiyMatchInited)
				{
					return this._EntitiyMatchCache;
				}
				this._EntitiyMatchInited = true;
				this._EntitiyMatchCache = IStaticEntitiyMatch.Create(this.Instance.EntitiyMatch);
				return this._EntitiyMatchCache;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x000B3B86 File Offset: 0x000B1D86
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x040027A1 RID: 10145
		private IEntityCategoryWeight Instance;

		// Token: 0x040027A2 RID: 10146
		[Nullable(2)]
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x040027A3 RID: 10147
		private bool _EntitiyMatchInited;
	}
}
