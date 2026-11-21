using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B88 RID: 2952
	public class IAllRefreshContent : IRefreshContent
	{
		// Token: 0x06004384 RID: 17284 RVA: 0x000AB373 File Offset: 0x000A9573
		public static IAllRefreshContent Create(IAllRefreshContent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAllRefreshContent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x000AB392 File Offset: 0x000A9592
		public override ERefreshContent Type
		{
			get
			{
				return (ERefreshContent)this.Instance.Type;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x000AB3A0 File Offset: 0x000A95A0
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

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x000AB404 File Offset: 0x000A9604
		public virtual bool? EdEnableSyncCamp
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002549 RID: 9545
		private IAllRefreshContent Instance;

		// Token: 0x0400254A RID: 9546
		private List<int> _EntityIdsCache;

		// Token: 0x0400254B RID: 9547
		private bool _EntityIdsInited;
	}
}
