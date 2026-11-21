using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB5 RID: 11445
	public class IVehicleTeam : ITargetVehicle
	{
		// Token: 0x0600FB05 RID: 64261 RVA: 0x00245FBD File Offset: 0x002441BD
		public static IVehicleTeam Create(IVehicleTeam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleTeam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x0600FB06 RID: 64262 RVA: 0x00245FDC File Offset: 0x002441DC
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x0600FB07 RID: 64263 RVA: 0x00245FE9 File Offset: 0x002441E9
		public virtual int TeamId
		{
			get
			{
				return this.Instance.TeamId;
			}
		}

		// Token: 0x04008919 RID: 35097
		private IVehicleTeam Instance;
	}
}
