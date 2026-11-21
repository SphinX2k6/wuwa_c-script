using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002905 RID: 10501
	public class SetEntityClientVisibleSave : ActionParams
	{
		// Token: 0x0600E998 RID: 59800 RVA: 0x00227DC9 File Offset: 0x00225FC9
		public static SetEntityClientVisibleSave Create(ISetEntityClientVisibleSave? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityClientVisibleSave
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x0600E999 RID: 59801 RVA: 0x00227DE8 File Offset: 0x00225FE8
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

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x0600E99A RID: 59802 RVA: 0x00227E4C File Offset: 0x0022604C
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x040080BF RID: 32959
		private ISetEntityClientVisibleSave Instance;

		// Token: 0x040080C0 RID: 32960
		private List<int> _EntityIdsCache;

		// Token: 0x040080C1 RID: 32961
		private bool _EntityIdsInited;
	}
}
