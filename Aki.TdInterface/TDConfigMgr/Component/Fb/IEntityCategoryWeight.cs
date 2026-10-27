using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B36 RID: 2870
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityCategoryWeight
	{
		// Token: 0x06004240 RID: 16960 RVA: 0x000A9A6F File Offset: 0x000A7C6F
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

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x000A9A8E File Offset: 0x000A7C8E
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

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x000A9AC2 File Offset: 0x000A7CC2
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002559 RID: 9561
		private IEntityCategoryWeight Instance;

		// Token: 0x0400255A RID: 9562
		[Nullable(2)]
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x0400255B RID: 9563
		private bool _EntitiyMatchInited;
	}
}
