using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8F RID: 2959
	public class IRandomBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x060043A6 RID: 17318 RVA: 0x000AB886 File Offset: 0x000A9A86
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

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x000AB8A5 File Offset: 0x000A9AA5
		public override EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x000AB8B4 File Offset: 0x000A9AB4
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

		// Token: 0x04002562 RID: 9570
		private IRandomBatchRefresh Instance;

		// Token: 0x04002563 RID: 9571
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04002564 RID: 9572
		private bool _EntityBatchesInited;
	}
}
