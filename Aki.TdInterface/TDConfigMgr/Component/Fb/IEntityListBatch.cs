using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC2 RID: 2754
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityListBatch : IEntityBatchType
	{
		// Token: 0x06003F6F RID: 16239 RVA: 0x000A2082 File Offset: 0x000A0282
		public static IEntityListBatch Create(IEntityListBatch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityListBatch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x000A20A1 File Offset: 0x000A02A1
		public override EEntityBatchType Type
		{
			get
			{
				return (EEntityBatchType)this.Instance.Type;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x000A20B0 File Offset: 0x000A02B0
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x0400233D RID: 9021
		private IEntityListBatch Instance;

		// Token: 0x0400233E RID: 9022
		private List<int> _EntityIdsCache;

		// Token: 0x0400233F RID: 9023
		private bool _EntityIdsInited;
	}
}
