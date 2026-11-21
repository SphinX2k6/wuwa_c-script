using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A62 RID: 10850
	public class ShowSpecificEntities : ActionParams
	{
		// Token: 0x0600EF94 RID: 61332 RVA: 0x00231E64 File Offset: 0x00230064
		public static ShowSpecificEntities Create(IShowSpecificEntities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowSpecificEntities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700477E RID: 18302
		// (get) Token: 0x0600EF95 RID: 61333 RVA: 0x00231E84 File Offset: 0x00230084
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

		// Token: 0x1700477F RID: 18303
		// (get) Token: 0x0600EF96 RID: 61334 RVA: 0x00231EE8 File Offset: 0x002300E8
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x040083B4 RID: 33716
		private IShowSpecificEntities Instance;

		// Token: 0x040083B5 RID: 33717
		private List<int> _EntityIdsCache;

		// Token: 0x040083B6 RID: 33718
		private bool _EntityIdsInited;
	}
}
