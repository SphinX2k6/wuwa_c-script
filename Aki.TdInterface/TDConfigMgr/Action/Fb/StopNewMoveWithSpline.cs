using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A02 RID: 10754
	public class StopNewMoveWithSpline : ActionParams
	{
		// Token: 0x0600EDC0 RID: 60864 RVA: 0x0022EFB4 File Offset: 0x0022D1B4
		public static StopNewMoveWithSpline Create(IStopNewMoveWithSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopNewMoveWithSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x0600EDC1 RID: 60865 RVA: 0x0022EFD3 File Offset: 0x0022D1D3
		public virtual INewSplineStopTarget StopTarget
		{
			get
			{
				if (this._StopTargetInited)
				{
					return this._StopTargetCache;
				}
				this._StopTargetInited = true;
				this._StopTargetCache = ActionReadHelper.ReadStopNewMoveWithSpline_StopTarget(this.Instance);
				return this._StopTargetCache;
			}
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x0600EDC2 RID: 60866 RVA: 0x0022F002 File Offset: 0x0022D202
		public virtual IStopNewMoveWithSplineType StopType
		{
			get
			{
				if (this._StopTypeInited)
				{
					return this._StopTypeCache;
				}
				this._StopTypeInited = true;
				this._StopTypeCache = ActionReadHelper.ReadStopNewMoveWithSpline_StopType(this.Instance);
				return this._StopTypeCache;
			}
		}

		// Token: 0x040082D2 RID: 33490
		private IStopNewMoveWithSpline Instance;

		// Token: 0x040082D3 RID: 33491
		private INewSplineStopTarget _StopTargetCache;

		// Token: 0x040082D4 RID: 33492
		private bool _StopTargetInited;

		// Token: 0x040082D5 RID: 33493
		private IStopNewMoveWithSplineType _StopTypeCache;

		// Token: 0x040082D6 RID: 33494
		private bool _StopTypeInited;
	}
}
