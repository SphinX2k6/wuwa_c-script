using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA6 RID: 10918
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleSetSpeedImmediately : ActionParams
	{
		// Token: 0x0600EFBC RID: 61372 RVA: 0x0022D769 File Offset: 0x0022B969
		public static VehicleSetSpeedImmediately Create(IVehicleSetSpeedImmediately? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehicleSetSpeedImmediately
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x0600EFBD RID: 61373 RVA: 0x0022D788 File Offset: 0x0022B988
		public virtual ISetVehicleSpeedImmediatelyType SetSpeedConfig
		{
			get
			{
				if (this._SetSpeedConfigInited)
				{
					return this._SetSpeedConfigCache;
				}
				this._SetSpeedConfigInited = true;
				this._SetSpeedConfigCache = ActionReadHelper.ReadVehicleSetSpeedImmediately_SetSpeedConfig(this.Instance);
				return this._SetSpeedConfigCache;
			}
		}

		// Token: 0x040083E2 RID: 33762
		private IVehicleSetSpeedImmediately Instance;

		// Token: 0x040083E3 RID: 33763
		private ISetVehicleSpeedImmediatelyType _SetSpeedConfigCache;

		// Token: 0x040083E4 RID: 33764
		private bool _SetSpeedConfigInited;
	}
}
