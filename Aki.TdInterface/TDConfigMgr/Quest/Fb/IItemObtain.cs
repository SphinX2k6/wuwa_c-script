using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F4 RID: 5364
	[NullableContext(2)]
	[Nullable(0)]
	public class IItemObtain : IShowUi
	{
		// Token: 0x06007985 RID: 31109 RVA: 0x001224EE File Offset: 0x001206EE
		[NullableContext(0)]
		public static IItemObtain Create(IItemObtain? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemObtain
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x06007986 RID: 31110 RVA: 0x0012250D File Offset: 0x0012070D
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x06007987 RID: 31111 RVA: 0x0012251C File Offset: 0x0012071C
		public virtual List<int> ItemIds
		{
			get
			{
				if (this._ItemIdsInited)
				{
					return this._ItemIdsCache;
				}
				this._ItemIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int itemIdsLength = this.Instance.ItemIdsLength;
				this._ItemIdsCache = new List<int>(itemIdsLength);
				for (int i = 0; i < itemIdsLength; i++)
				{
					this._ItemIdsCache.Add(this.Instance.ItemIds(i));
				}
				return this._ItemIdsCache;
			}
		}

		// Token: 0x040045E2 RID: 17890
		private IItemObtain Instance;

		// Token: 0x040045E3 RID: 17891
		private List<int> _ItemIdsCache;

		// Token: 0x040045E4 RID: 17892
		private bool _ItemIdsInited;
	}
}
