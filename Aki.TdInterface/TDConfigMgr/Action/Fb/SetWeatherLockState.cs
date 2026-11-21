using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B71 RID: 11121
	[NullableContext(2)]
	[Nullable(0)]
	public class SetWeatherLockState : ActionParams
	{
		// Token: 0x0600F459 RID: 62553 RVA: 0x0023A259 File Offset: 0x00238459
		[NullableContext(0)]
		public static SetWeatherLockState Create(ISetWeatherLockState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWeatherLockState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x0600F45A RID: 62554 RVA: 0x0023A278 File Offset: 0x00238478
		public virtual ELockState LockState
		{
			get
			{
				return (ELockState)this.Instance.LockState;
			}
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x0600F45B RID: 62555 RVA: 0x0023A288 File Offset: 0x00238488
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x040085FF RID: 34303
		private ISetWeatherLockState Instance;

		// Token: 0x04008600 RID: 34304
		private List<int> _AreaIdsCache;

		// Token: 0x04008601 RID: 34305
		private bool _AreaIdsInited;
	}
}
