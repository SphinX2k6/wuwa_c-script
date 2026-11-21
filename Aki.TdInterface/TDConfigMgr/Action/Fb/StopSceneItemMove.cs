using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B00 RID: 11008
	public class StopSceneItemMove : ActionParams
	{
		// Token: 0x0600F23C RID: 62012 RVA: 0x00236502 File Offset: 0x00234702
		public static StopSceneItemMove Create(IStopSceneItemMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopSceneItemMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x0600F23D RID: 62013 RVA: 0x00236524 File Offset: 0x00234724
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

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x0600F23E RID: 62014 RVA: 0x00236588 File Offset: 0x00234788
		public virtual EStopSceneItemMoveType? StopType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EStopSceneItemMoveType?((EStopSceneItemMoveType)this.Instance.StopType);
			}
		}

		// Token: 0x040084F6 RID: 34038
		private IStopSceneItemMove Instance;

		// Token: 0x040084F7 RID: 34039
		private List<int> _EntityIdsCache;

		// Token: 0x040084F8 RID: 34040
		private bool _EntityIdsInited;
	}
}
