using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E47 RID: 3655
	public class IVehiclePassengerConfig
	{
		// Token: 0x060052B7 RID: 21175 RVA: 0x000CC633 File Offset: 0x000CA833
		public static IVehiclePassengerConfig Create(IVehiclePassengerConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehiclePassengerConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060052B8 RID: 21176 RVA: 0x000CC652 File Offset: 0x000CA852
		public virtual int PassengerNpc
		{
			get
			{
				return this.Instance.PassengerNpc;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060052B9 RID: 21177 RVA: 0x000CC65F File Offset: 0x000CA85F
		public virtual int Seat
		{
			get
			{
				return this.Instance.Seat;
			}
		}

		// Token: 0x04002F3A RID: 12090
		private IVehiclePassengerConfig Instance;
	}
}
