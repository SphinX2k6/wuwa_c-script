using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D2 RID: 10706
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportToAndEnterVehicle : ActionParams
	{
		// Token: 0x0600EC9A RID: 60570 RVA: 0x00228BB2 File Offset: 0x00226DB2
		public static TeleportToAndEnterVehicle Create(ITeleportToAndEnterVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportToAndEnterVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AB8 RID: 19128
		// (get) Token: 0x0600EC9B RID: 60571 RVA: 0x00228BD1 File Offset: 0x00226DD1
		public virtual ITeleportToAndEnterFishingBoat ToVehicle
		{
			get
			{
				if (this._ToVehicleInited)
				{
					return this._ToVehicleCache;
				}
				this._ToVehicleInited = true;
				this._ToVehicleCache = ITeleportToAndEnterFishingBoat.Create(this.Instance.ToVehicle);
				return this._ToVehicleCache;
			}
		}

		// Token: 0x04008248 RID: 33352
		private ITeleportToAndEnterVehicle Instance;

		// Token: 0x04008249 RID: 33353
		[Nullable(2)]
		private ITeleportToAndEnterFishingBoat _ToVehicleCache;

		// Token: 0x0400824A RID: 33354
		private bool _ToVehicleInited;
	}
}
