using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD6 RID: 10966
	[NullableContext(1)]
	[Nullable(0)]
	public class StartRoadNetworkNavigation : ActionParams
	{
		// Token: 0x0600F07E RID: 61566 RVA: 0x0022EB2A File Offset: 0x0022CD2A
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

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x0600F07F RID: 61567 RVA: 0x0022EB49 File Offset: 0x0022CD49
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

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x0600F080 RID: 61568 RVA: 0x0022EB7D File Offset: 0x0022CD7D
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

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x0600F081 RID: 61569 RVA: 0x0022EBB1 File Offset: 0x0022CDB1
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

		// Token: 0x04008448 RID: 33864
		private IStartRoadNetworkNavigation Instance;

		// Token: 0x04008449 RID: 33865
		[Nullable(2)]
		private ISceneItemRoadNetworkNavigation _TargetCache;

		// Token: 0x0400844A RID: 33866
		private bool _TargetInited;

		// Token: 0x0400844B RID: 33867
		[Nullable(2)]
		private ISplineWayPoint _StartCache;

		// Token: 0x0400844C RID: 33868
		private bool _StartInited;

		// Token: 0x0400844D RID: 33869
		[Nullable(2)]
		private ISplineWayPoint _EndCache;

		// Token: 0x0400844E RID: 33870
		private bool _EndInited;
	}
}
