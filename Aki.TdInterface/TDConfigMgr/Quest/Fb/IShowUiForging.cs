using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A7 RID: 5031
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiForging : IShowUiCrafting
	{
		// Token: 0x060072F1 RID: 29425 RVA: 0x00114249 File Offset: 0x00112449
		[NullableContext(1)]
		public static IShowUiForging Create(IShowUiForging? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiForging
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x060072F2 RID: 29426 RVA: 0x00114268 File Offset: 0x00112468
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x060072F3 RID: 29427 RVA: 0x00114278 File Offset: 0x00112478
		public override List<int> EntityIds
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

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x060072F4 RID: 29428 RVA: 0x001142F0 File Offset: 0x001124F0
		public override List<int> ProductIds
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

		// Token: 0x04004273 RID: 17011
		private IShowUiForging Instance;

		// Token: 0x04004274 RID: 17012
		private List<int> _EntityIdsCache;

		// Token: 0x04004275 RID: 17013
		private bool _EntityIdsInited;

		// Token: 0x04004276 RID: 17014
		private List<int> _ProductIdsCache;

		// Token: 0x04004277 RID: 17015
		private bool _ProductIdsInited;
	}
}
