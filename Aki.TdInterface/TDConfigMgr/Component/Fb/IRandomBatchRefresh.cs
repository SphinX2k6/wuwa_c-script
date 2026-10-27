using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC5 RID: 2757
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06003F7C RID: 16252 RVA: 0x000A2292 File Offset: 0x000A0492
		public static IRandomBatchRefresh Create(IRandomBatchRefresh? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomBatchRefresh
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x000A22B1 File Offset: 0x000A04B1
		public override EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06003F7E RID: 16254 RVA: 0x000A22C0 File Offset: 0x000A04C0
		public override List<IEntityListBatch> EntityBatches
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

		// Token: 0x04002346 RID: 9030
		private IRandomBatchRefresh Instance;

		// Token: 0x04002347 RID: 9031
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04002348 RID: 9032
		private bool _EntityBatchesInited;
	}
}
