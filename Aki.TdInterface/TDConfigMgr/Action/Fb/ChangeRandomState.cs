using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025BB RID: 9659
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeRandomState : ActionParams
	{
		// Token: 0x0600D946 RID: 55622 RVA: 0x00206A0A File Offset: 0x00204C0A
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

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x0600D947 RID: 55623 RVA: 0x00206A2C File Offset: 0x00204C2C
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

		// Token: 0x040078AF RID: 30895
		private IChangeRandomState Instance;

		// Token: 0x040078B0 RID: 30896
		private List<int> _StateIdsCache;

		// Token: 0x040078B1 RID: 30897
		private bool _StateIdsInited;
	}
}
