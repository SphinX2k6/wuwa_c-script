using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D1 RID: 10705
	public class EnableHostility : ActionParams
	{
		// Token: 0x0600ECEF RID: 60655 RVA: 0x0022D8F0 File Offset: 0x0022BAF0
		public static EnableHostility Create(IEnableHostility? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableHostility
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x0600ECF0 RID: 60656 RVA: 0x0022D90F File Offset: 0x0022BB0F
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x0600ECF1 RID: 60657 RVA: 0x0022D91C File Offset: 0x0022BB1C
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

		// Token: 0x04008269 RID: 33385
		private IEnableHostility Instance;

		// Token: 0x0400826A RID: 33386
		private List<int> _EntityIdsCache;

		// Token: 0x0400826B RID: 33387
		private bool _EntityIdsInited;
	}
}
