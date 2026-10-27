using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A4 RID: 5028
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCrafting : IShowUi
	{
		// Token: 0x060072E2 RID: 29410 RVA: 0x00113EDD File Offset: 0x001120DD
		[NullableContext(1)]
		public static IShowUiCrafting Create(IShowUiCrafting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiCrafting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x060072E3 RID: 29411 RVA: 0x00113EFC File Offset: 0x001120FC
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x060072E4 RID: 29412 RVA: 0x00113F0C File Offset: 0x0011210C
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x060072E5 RID: 29413 RVA: 0x00113F84 File Offset: 0x00112184
		public virtual List<int> ProductIds
		{
			get
			{
				if (this._ProductIdsInited)
				{
					return this._ProductIdsCache;
				}
				this._ProductIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int productIdsLength = this.Instance.ProductIdsLength;
				this._ProductIdsCache = new List<int>(productIdsLength);
				for (int i = 0; i < productIdsLength; i++)
				{
					this._ProductIdsCache.Add(this.Instance.ProductIds(i));
				}
				return this._ProductIdsCache;
			}
		}

		// Token: 0x04004264 RID: 16996
		private IShowUiCrafting Instance;

		// Token: 0x04004265 RID: 16997
		private List<int> _EntityIdsCache;

		// Token: 0x04004266 RID: 16998
		private bool _EntityIdsInited;

		// Token: 0x04004267 RID: 16999
		private List<int> _ProductIdsCache;

		// Token: 0x04004268 RID: 17000
		private bool _ProductIdsInited;
	}
}
