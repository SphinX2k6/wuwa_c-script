using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002736 RID: 10038
	[NullableContext(1)]
	[Nullable(0)]
	public class StopNewMoveWithSpline : ActionParams
	{
		// Token: 0x0600DFC0 RID: 57280 RVA: 0x0021247C File Offset: 0x0021067C
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

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x0600DFC1 RID: 57281 RVA: 0x0021249B File Offset: 0x0021069B
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

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x0600DFC2 RID: 57282 RVA: 0x002124CA File Offset: 0x002106CA
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

		// Token: 0x04007C24 RID: 31780
		private IStopNewMoveWithSpline Instance;

		// Token: 0x04007C25 RID: 31781
		private INewSplineStopTarget _StopTargetCache;

		// Token: 0x04007C26 RID: 31782
		private bool _StopTargetInited;

		// Token: 0x04007C27 RID: 31783
		private IStopNewMoveWithSplineType _StopTypeCache;

		// Token: 0x04007C28 RID: 31784
		private bool _StopTypeInited;
	}
}
