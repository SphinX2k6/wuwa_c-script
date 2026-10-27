using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC6 RID: 2758
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomBatchPoolRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06003F80 RID: 16256 RVA: 0x000A2331 File Offset: 0x000A0531
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

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x000A2350 File Offset: 0x000A0550
		public override EEntityBatchRefreshMode Type
		{
			get
			{
				return (EEntityBatchRefreshMode)this.Instance.Type;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x000A2360 File Offset: 0x000A0560
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

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x000A23CC File Offset: 0x000A05CC
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

		// Token: 0x04002349 RID: 9033
		private IRandomBatchPoolRefresh Instance;

		// Token: 0x0400234A RID: 9034
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x0400234B RID: 9035
		private bool _EntityBatchesInited;
	}
}
