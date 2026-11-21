using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CAC RID: 11436
	public class IExitVehicleSeatStandUp : IExitVehicleType
	{
		// Token: 0x0600FAE7 RID: 64231 RVA: 0x00245D53 File Offset: 0x00243F53
		public static IExitVehicleSeatStandUp Create(IExitVehicleSeatStandUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleSeatStandUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x0600FAE8 RID: 64232 RVA: 0x00245D72 File Offset: 0x00243F72
		public override EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x0400890C RID: 35084
		private IExitVehicleSeatStandUp Instance;
	}
}
