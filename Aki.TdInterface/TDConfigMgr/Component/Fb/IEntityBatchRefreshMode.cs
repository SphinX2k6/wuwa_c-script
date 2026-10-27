using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC3 RID: 2755
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityBatchRefreshMode
	{
		// Token: 0x06003F73 RID: 16243 RVA: 0x000A211C File Offset: 0x000A031C
		public static IEntityBatchRefreshMode Create(IEntityBatchRefreshMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityBatchRefreshMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x000A213B File Offset: 0x000A033B
		public virtual EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x000A2148 File Offset: 0x000A0348
		public virtual List<IEntityListBatch> EntityBatches
		{
			get
			{
				if (this._EntityBatchesInited)
				{
					return this._EntityBatchesCache;
				}
				this._EntityBatchesInited = true;
				int entityBatchesLength = this.Instance.EntityBatchesLength;
				this._EntityBatchesCache = new List<IEntityListBatch>(entityBatchesLength);
				for (int i = 0; i < entityBatchesLength; i++)
				{
					this._EntityBatchesCache.Add(IEntityListBatch.Create(this.Instance.EntityBatches(i)));
				}
				return this._EntityBatchesCache;
			}
		}

		// Token: 0x04002340 RID: 9024
		private IEntityBatchRefreshMode Instance;

		// Token: 0x04002341 RID: 9025
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04002342 RID: 9026
		private bool _EntityBatchesInited;
	}
}
