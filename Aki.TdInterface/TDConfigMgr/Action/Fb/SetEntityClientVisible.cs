using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002904 RID: 10500
	public class SetEntityClientVisible : ActionParams
	{
		// Token: 0x0600E994 RID: 59796 RVA: 0x00227D2E File Offset: 0x00225F2E
		public static SetEntityClientVisible Create(ISetEntityClientVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityClientVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x0600E995 RID: 59797 RVA: 0x00227D50 File Offset: 0x00225F50
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

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x0600E996 RID: 59798 RVA: 0x00227DB4 File Offset: 0x00225FB4
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x040080BC RID: 32956
		private ISetEntityClientVisible Instance;

		// Token: 0x040080BD RID: 32957
		private List<int> _EntityIdsCache;

		// Token: 0x040080BE RID: 32958
		private bool _EntityIdsInited;
	}
}
