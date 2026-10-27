using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC4 RID: 2756
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06003F77 RID: 16247 RVA: 0x000A21B9 File Offset: 0x000A03B9
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

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x000A21D8 File Offset: 0x000A03D8
		public override EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x000A21E8 File Offset: 0x000A03E8
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

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003F7A RID: 16250 RVA: 0x000A2254 File Offset: 0x000A0454
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

		// Token: 0x04002343 RID: 9027
		private ISequenceBatchRefresh Instance;

		// Token: 0x04002344 RID: 9028
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04002345 RID: 9029
		private bool _EntityBatchesInited;
	}
}
