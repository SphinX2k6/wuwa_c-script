using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C5 RID: 10693
	public class IAppointedVehicle : ITargetVehicle
	{
		// Token: 0x0600EC64 RID: 60516 RVA: 0x00228590 File Offset: 0x00226790
		[NullableContext(1)]
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

		// Token: 0x17004A9C RID: 19100
		// (get) Token: 0x0600EC65 RID: 60517 RVA: 0x002285AF File Offset: 0x002267AF
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x0600EC66 RID: 60518 RVA: 0x002285BC File Offset: 0x002267BC
		public virtual int VehicleId
		{
			get
			{
				return this.Instance.VehicleId;
			}
		}

		// Token: 0x04008225 RID: 33317
		private IAppointedVehicle Instance;
	}
}
