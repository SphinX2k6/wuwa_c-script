using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA4 RID: 11428
	public class IVehicleEnteringPlayerTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600FAC6 RID: 64198 RVA: 0x00245A2A File Offset: 0x00243C2A
		public static IVehicleEnteringPlayerTarget Create(IVehicleEnteringPlayerTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringPlayerTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x0600FAC7 RID: 64199 RVA: 0x00245A49 File Offset: 0x00243C49
		public override EVehicleEnteringTarget Type
		{
			get
			{
				return (EVehicleEnteringTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x0600FAC8 RID: 64200 RVA: 0x00245A58 File Offset: 0x00243C58
		public override int? TargetVehicle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TargetVehicle);
			}
		}

		// Token: 0x040088FC RID: 35068
		private IVehicleEnteringPlayerTarget Instance;
	}
}
