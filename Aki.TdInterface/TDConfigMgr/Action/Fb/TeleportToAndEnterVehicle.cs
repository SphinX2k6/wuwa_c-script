using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CBF RID: 11455
	public class TeleportToAndEnterVehicle : ActionParams
	{
		// Token: 0x0600FB31 RID: 64305 RVA: 0x00246536 File Offset: 0x00244736
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

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x0600FB32 RID: 64306 RVA: 0x00246555 File Offset: 0x00244755
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

		// Token: 0x04008939 RID: 35129
		private ITeleportToAndEnterVehicle Instance;

		// Token: 0x0400893A RID: 35130
		[Nullable(2)]
		private ITeleportToAndEnterFishingBoat _ToVehicleCache;

		// Token: 0x0400893B RID: 35131
		private bool _ToVehicleInited;
	}
}
