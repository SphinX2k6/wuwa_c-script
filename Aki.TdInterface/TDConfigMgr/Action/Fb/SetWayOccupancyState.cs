using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD7 RID: 10967
	[NullableContext(1)]
	[Nullable(0)]
	public class SetWayOccupancyState : ActionParams
	{
		// Token: 0x0600F083 RID: 61571 RVA: 0x0022EBED File Offset: 0x0022CDED
		public static SetWayOccupancyState Create(ISetWayOccupancyState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWayOccupancyState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x0600F084 RID: 61572 RVA: 0x0022EC0C File Offset: 0x0022CE0C
		public virtual bool Occupy
		{
			get
			{
				return this.Instance.Occupy;
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x0600F085 RID: 61573 RVA: 0x0022EC1C File Offset: 0x0022CE1C
		public virtual List<int> TargetWay
		{
			get
			{
				if (this._TargetWayInited)
				{
					return this._TargetWayCache;
				}
				this._TargetWayInited = true;
				int targetWayLength = this.Instance.TargetWayLength;
				this._TargetWayCache = new List<int>(targetWayLength);
				for (int i = 0; i < targetWayLength; i++)
				{
					this._TargetWayCache.Add(this.Instance.TargetWay(i));
				}
				return this._TargetWayCache;
			}
		}

		// Token: 0x0400844F RID: 33871
		private ISetWayOccupancyState Instance;

		// Token: 0x04008450 RID: 33872
		private List<int> _TargetWayCache;

		// Token: 0x04008451 RID: 33873
		private bool _TargetWayInited;
	}
}
