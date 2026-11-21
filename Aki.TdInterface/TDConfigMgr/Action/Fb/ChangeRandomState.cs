using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286A RID: 10346
	public class ChangeRandomState : ActionParams
	{
		// Token: 0x0600E6C0 RID: 59072 RVA: 0x002226DE File Offset: 0x002208DE
		public static ChangeRandomState Create(IChangeRandomState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeRandomState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x0600E6C1 RID: 59073 RVA: 0x00222700 File Offset: 0x00220900
		public virtual List<int> StateIds
		{
			get
			{
				if (this._StateIdsInited)
				{
					return this._StateIdsCache;
				}
				this._StateIdsInited = true;
				int stateIdsLength = this.Instance.StateIdsLength;
				this._StateIdsCache = new List<int>(stateIdsLength);
				for (int i = 0; i < stateIdsLength; i++)
				{
					this._StateIdsCache.Add(this.Instance.StateIds(i));
				}
				return this._StateIdsCache;
			}
		}

		// Token: 0x04007F16 RID: 32534
		private IChangeRandomState Instance;

		// Token: 0x04007F17 RID: 32535
		private List<int> _StateIdsCache;

		// Token: 0x04007F18 RID: 32536
		private bool _StateIdsInited;
	}
}
