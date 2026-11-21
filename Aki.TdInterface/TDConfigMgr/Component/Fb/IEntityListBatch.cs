using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8C RID: 2956
	public class IEntityListBatch : IEntityBatchType
	{
		// Token: 0x06004399 RID: 17305 RVA: 0x000AB676 File Offset: 0x000A9876
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x000AB695 File Offset: 0x000A9895
		public override EEntityBatchType Type
		{
			get
			{
				return (EEntityBatchType)this.Instance.Type;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x000AB6A4 File Offset: 0x000A98A4
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

		// Token: 0x04002559 RID: 9561
		private IEntityListBatch Instance;

		// Token: 0x0400255A RID: 9562
		private List<int> _EntityIdsCache;

		// Token: 0x0400255B RID: 9563
		private bool _EntityIdsInited;
	}
}
