using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8D RID: 2957
	public class IEntityBatchRefreshMode
	{
		// Token: 0x0600439D RID: 17309 RVA: 0x000AB710 File Offset: 0x000A9910
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

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x000AB72F File Offset: 0x000A992F
		public virtual EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x000AB73C File Offset: 0x000A993C
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

		// Token: 0x0400255C RID: 9564
		private IEntityBatchRefreshMode Instance;

		// Token: 0x0400255D RID: 9565
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x0400255E RID: 9566
		private bool _EntityBatchesInited;
	}
}
