using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C25 RID: 3109
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingCondition
	{
		// Token: 0x06004731 RID: 18225 RVA: 0x000B49AD File Offset: 0x000B2BAD
		[NullableContext(0)]
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x000B49CC File Offset: 0x000B2BCC
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

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06004733 RID: 18227 RVA: 0x000B4A00 File Offset: 0x000B2C00
		public virtual string SelfState
		{
			get
			{
				return this.Instance.SelfState;
			}
		}

		// Token: 0x040027F4 RID: 10228
		private ICategoryMatchingCondition Instance;

		// Token: 0x040027F5 RID: 10229
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x040027F6 RID: 10230
		private bool _EntityMatchInited;
	}
}
