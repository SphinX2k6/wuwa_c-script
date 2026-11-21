using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0A RID: 10762
	public class EnableAI : ActionParams
	{
		// Token: 0x0600EDE4 RID: 60900 RVA: 0x0022F2F4 File Offset: 0x0022D4F4
		public static EnableAI Create(IEnableAI? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableAI
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x0600EDE5 RID: 60901 RVA: 0x0022F314 File Offset: 0x0022D514
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

		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x0600EDE6 RID: 60902 RVA: 0x0022F378 File Offset: 0x0022D578
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x040082E6 RID: 33510
		private IEnableAI Instance;

		// Token: 0x040082E7 RID: 33511
		private List<int> _EntityIdsCache;

		// Token: 0x040082E8 RID: 33512
		private bool _EntityIdsInited;
	}
}
