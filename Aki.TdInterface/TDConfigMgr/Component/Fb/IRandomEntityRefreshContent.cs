using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B89 RID: 2953
	public class IRandomEntityRefreshContent : IRefreshContent
	{
		// Token: 0x06004389 RID: 17289 RVA: 0x000AB422 File Offset: 0x000A9622
		public static IRandomEntityRefreshContent Create(IRandomEntityRefreshContent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomEntityRefreshContent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x000AB441 File Offset: 0x000A9641
		public override ERefreshContent Type
		{
			get
			{
				return (ERefreshContent)this.Instance.Type;
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600438B RID: 17291 RVA: 0x000AB450 File Offset: 0x000A9650
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

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x000AB4B4 File Offset: 0x000A96B4
		public virtual bool? EdEnableSyncCamp
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400254C RID: 9548
		private IRandomEntityRefreshContent Instance;

		// Token: 0x0400254D RID: 9549
		private List<int> _EntityIdsCache;

		// Token: 0x0400254E RID: 9550
		private bool _EntityIdsInited;
	}
}
