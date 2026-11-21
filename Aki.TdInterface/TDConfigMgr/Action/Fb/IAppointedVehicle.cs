using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB2 RID: 11442
	public class IAppointedVehicle : ITargetVehicle
	{
		// Token: 0x0600FAFB RID: 64251 RVA: 0x00245F14 File Offset: 0x00244114
		public static IAppointedVehicle Create(IAppointedVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAppointedVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x0600FAFC RID: 64252 RVA: 0x00245F33 File Offset: 0x00244133
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x0600FAFD RID: 64253 RVA: 0x00245F40 File Offset: 0x00244140
		public virtual int VehicleId
		{
			get
			{
				return this.Instance.VehicleId;
			}
		}

		// Token: 0x04008916 RID: 35094
		private IAppointedVehicle Instance;
	}
}
