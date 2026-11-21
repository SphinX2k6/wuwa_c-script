using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DCB RID: 11723
	public class SetWayOccupancyState : ActionParams
	{
		// Token: 0x0600FF39 RID: 65337 RVA: 0x0024C8F9 File Offset: 0x0024AAF9
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

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x0600FF3A RID: 65338 RVA: 0x0024C918 File Offset: 0x0024AB18
		public virtual bool Occupy
		{
			get
			{
				return this.Instance.Occupy;
			}
		}

		// Token: 0x17005052 RID: 20562
		// (get) Token: 0x0600FF3B RID: 65339 RVA: 0x0024C928 File Offset: 0x0024AB28
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

		// Token: 0x04008B53 RID: 35667
		private ISetWayOccupancyState Instance;

		// Token: 0x04008B54 RID: 35668
		private List<int> _TargetWayCache;

		// Token: 0x04008B55 RID: 35669
		private bool _TargetWayInited;
	}
}
