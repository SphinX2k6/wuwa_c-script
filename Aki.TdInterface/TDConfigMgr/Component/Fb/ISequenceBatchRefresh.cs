using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8E RID: 2958
	public class ISequenceBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x060043A1 RID: 17313 RVA: 0x000AB7AD File Offset: 0x000A99AD
		public static ISequenceBatchRefresh Create(ISequenceBatchRefresh? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceBatchRefresh
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060043A2 RID: 17314 RVA: 0x000AB7CC File Offset: 0x000A99CC
		public override EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x000AB7DC File Offset: 0x000A99DC
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

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x000AB848 File Offset: 0x000A9A48
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

		// Token: 0x0400255F RID: 9567
		private ISequenceBatchRefresh Instance;

		// Token: 0x04002560 RID: 9568
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04002561 RID: 9569
		private bool _EntityBatchesInited;
	}
}
