using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F6 RID: 5366
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCook : IShowUiCrafting
	{
		// Token: 0x0600798E RID: 31118 RVA: 0x001226BD File Offset: 0x001208BD
		[NullableContext(0)]
		public static IShowUiCook Create(IShowUiCook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiCook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x0600798F RID: 31119 RVA: 0x001226DC File Offset: 0x001208DC
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x06007990 RID: 31120 RVA: 0x001226EC File Offset: 0x001208EC
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

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x06007991 RID: 31121 RVA: 0x00122764 File Offset: 0x00120964
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

		// Token: 0x040045EA RID: 17898
		private IShowUiCook Instance;

		// Token: 0x040045EB RID: 17899
		private List<int> _EntityIdsCache;

		// Token: 0x040045EC RID: 17900
		private bool _EntityIdsInited;

		// Token: 0x040045ED RID: 17901
		private List<int> _ProductIdsCache;

		// Token: 0x040045EE RID: 17902
		private bool _ProductIdsInited;
	}
}
