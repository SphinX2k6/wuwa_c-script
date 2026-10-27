using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CF RID: 10703
	[NullableContext(2)]
	[Nullable(0)]
	public class VehicleWaterfallClimbing : ActionParams
	{
		// Token: 0x0600EC90 RID: 60560 RVA: 0x00228AE2 File Offset: 0x00226CE2
		[NullableContext(1)]
		public static VehicleWaterfallClimbing Create(IVehicleWaterfallClimbing? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleWaterfallClimbing
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x0600EC91 RID: 60561 RVA: 0x00228B01 File Offset: 0x00226D01
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x0600EC92 RID: 60562 RVA: 0x00228B0E File Offset: 0x00226D0E
		public virtual IVehicleWaterfallClimbGravityConfig ChangeGravity
		{
			get
			{
				if (this._ChangeGravityInited)
				{
					return this._ChangeGravityCache;
				}
				this._ChangeGravityInited = true;
				this._ChangeGravityCache = IVehicleWaterfallClimbGravityConfig.Create(this.Instance.ChangeGravity);
				return this._ChangeGravityCache;
			}
		}

		// Token: 0x04008243 RID: 33347
		private IVehicleWaterfallClimbing Instance;

		// Token: 0x04008244 RID: 33348
		private IVehicleWaterfallClimbGravityConfig _ChangeGravityCache;

		// Token: 0x04008245 RID: 33349
		private bool _ChangeGravityInited;
	}
}
