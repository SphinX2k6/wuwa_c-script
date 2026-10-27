using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002735 RID: 10037
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600DFBC RID: 57276 RVA: 0x00212419 File Offset: 0x00210619
		public static IVehicleNewSplineStopTarget Create(IVehicleNewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleNewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x0600DFBD RID: 57277 RVA: 0x00212438 File Offset: 0x00210638
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x0600DFBE RID: 57278 RVA: 0x00212445 File Offset: 0x00210645
		public virtual ITargetVehicle TargetVehicle
		{
			get
			{
				if (this._TargetVehicleInited)
				{
					return this._TargetVehicleCache;
				}
				this._TargetVehicleInited = true;
				this._TargetVehicleCache = ActionReadHelper.ReadIVehicleNewSplineStopTarget_TargetVehicle(this.Instance);
				return this._TargetVehicleCache;
			}
		}

		// Token: 0x04007C21 RID: 31777
		private IVehicleNewSplineStopTarget Instance;

		// Token: 0x04007C22 RID: 31778
		private ITargetVehicle _TargetVehicleCache;

		// Token: 0x04007C23 RID: 31779
		private bool _TargetVehicleInited;
	}
}
