using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B90 RID: 2960
	public class IRandomBatchPoolRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x060043AA RID: 17322 RVA: 0x000AB925 File Offset: 0x000A9B25
		public static IRandomBatchPoolRefresh Create(IRandomBatchPoolRefresh? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomBatchPoolRefresh
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x000AB944 File Offset: 0x000A9B44
		public override EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x000AB954 File Offset: 0x000A9B54
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

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060043AD RID: 17325 RVA: 0x000AB9C0 File Offset: 0x000A9BC0
		public virtual bool? IsRestartAfterAllBatchesFinished
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRestartAfterAllBatchesFinished);
			}
		}

		// Token: 0x04002565 RID: 9573
		private IRandomBatchPoolRefresh Instance;

		// Token: 0x04002566 RID: 9574
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04002567 RID: 9575
		private bool _EntityBatchesInited;
	}
}
