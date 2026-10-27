using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289C RID: 10396
	[NullableContext(2)]
	[Nullable(0)]
	public class SetWeatherLockState : ActionParams
	{
		// Token: 0x0600E62A RID: 58922 RVA: 0x0021D2D9 File Offset: 0x0021B4D9
		[NullableContext(1)]
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

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x0600E62B RID: 58923 RVA: 0x0021D2F8 File Offset: 0x0021B4F8
		public virtual ELockState LockState
		{
			get
			{
				return (ELockState)this.Instance.LockState;
			}
		}

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x0600E62C RID: 58924 RVA: 0x0021D308 File Offset: 0x0021B508
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

		// Token: 0x04007F40 RID: 32576
		private ISetWeatherLockState Instance;

		// Token: 0x04007F41 RID: 32577
		private List<int> _AreaIdsCache;

		// Token: 0x04007F42 RID: 32578
		private bool _AreaIdsInited;
	}
}
