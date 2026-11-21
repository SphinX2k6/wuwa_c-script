using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DCA RID: 11722
	public class StartRoadNetworkNavigation : ActionParams
	{
		// Token: 0x0600FF34 RID: 65332 RVA: 0x0024C836 File Offset: 0x0024AA36
		public static StartRoadNetworkNavigation Create(IStartRoadNetworkNavigation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StartRoadNetworkNavigation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x0600FF35 RID: 65333 RVA: 0x0024C855 File Offset: 0x0024AA55
		public virtual ISceneItemRoadNetworkNavigation Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ISceneItemRoadNetworkNavigation.Create(this.Instance.Target);
				return this._TargetCache;
			}
		}

		// Token: 0x1700504F RID: 20559
		// (get) Token: 0x0600FF36 RID: 65334 RVA: 0x0024C889 File Offset: 0x0024AA89
		public virtual ISplineWayPoint Start
		{
			get
			{
				if (this._StartInited)
				{
					return this._StartCache;
				}
				this._StartInited = true;
				this._StartCache = ISplineWayPoint.Create(this.Instance.Start);
				return this._StartCache;
			}
		}

		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x0600FF37 RID: 65335 RVA: 0x0024C8BD File Offset: 0x0024AABD
		public virtual ISplineWayPoint End
		{
			get
			{
				if (this._EndInited)
				{
					return this._EndCache;
				}
				this._EndInited = true;
				this._EndCache = ISplineWayPoint.Create(this.Instance.End);
				return this._EndCache;
			}
		}

		// Token: 0x04008B4C RID: 35660
		private IStartRoadNetworkNavigation Instance;

		// Token: 0x04008B4D RID: 35661
		[Nullable(2)]
		private ISceneItemRoadNetworkNavigation _TargetCache;

		// Token: 0x04008B4E RID: 35662
		private bool _TargetInited;

		// Token: 0x04008B4F RID: 35663
		[Nullable(2)]
		private ISplineWayPoint _StartCache;

		// Token: 0x04008B50 RID: 35664
		private bool _StartInited;

		// Token: 0x04008B51 RID: 35665
		[Nullable(2)]
		private ISplineWayPoint _EndCache;

		// Token: 0x04008B52 RID: 35666
		private bool _EndInited;
	}
}
