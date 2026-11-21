using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CBC RID: 11452
	[NullableContext(2)]
	[Nullable(0)]
	public class VehicleWaterfallClimbing : ActionParams
	{
		// Token: 0x0600FB27 RID: 64295 RVA: 0x00246466 File Offset: 0x00244666
		[NullableContext(0)]
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

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x0600FB28 RID: 64296 RVA: 0x00246485 File Offset: 0x00244685
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x0600FB29 RID: 64297 RVA: 0x00246492 File Offset: 0x00244692
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

		// Token: 0x04008934 RID: 35124
		private IVehicleWaterfallClimbing Instance;

		// Token: 0x04008935 RID: 35125
		private IVehicleWaterfallClimbGravityConfig _ChangeGravityCache;

		// Token: 0x04008936 RID: 35126
		private bool _ChangeGravityInited;
	}
}
