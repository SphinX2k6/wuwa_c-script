using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297A RID: 10618
	public class INearestEntity : ITeleportConfig
	{
		// Token: 0x0600EB92 RID: 60306 RVA: 0x0022B41A File Offset: 0x0022961A
		public static INearestEntity Create(INearestEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INearestEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x0600EB93 RID: 60307 RVA: 0x0022B439 File Offset: 0x00229639
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x0600EB94 RID: 60308 RVA: 0x0022B448 File Offset: 0x00229648
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

		// Token: 0x040081B8 RID: 33208
		private INearestEntity Instance;

		// Token: 0x040081B9 RID: 33209
		private List<int> _EntityIdsCache;

		// Token: 0x040081BA RID: 33210
		private bool _EntityIdsInited;
	}
}
