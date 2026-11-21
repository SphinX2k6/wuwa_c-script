using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A61 RID: 10849
	public class HideSpecificEntities : ActionParams
	{
		// Token: 0x0600EF91 RID: 61329 RVA: 0x00231DD9 File Offset: 0x0022FFD9
		public static HideSpecificEntities Create(IHideSpecificEntities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideSpecificEntities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700477D RID: 18301
		// (get) Token: 0x0600EF92 RID: 61330 RVA: 0x00231DF8 File Offset: 0x0022FFF8
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

		// Token: 0x040083B1 RID: 33713
		private IHideSpecificEntities Instance;

		// Token: 0x040083B2 RID: 33714
		private List<int> _EntityIdsCache;

		// Token: 0x040083B3 RID: 33715
		private bool _EntityIdsInited;
	}
}
