using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA9 RID: 11433
	public class IExitVehicleLaunch : IExitVehicleType
	{
		// Token: 0x0600FADC RID: 64220 RVA: 0x00245C4F File Offset: 0x00243E4F
		public static IExitVehicleLaunch Create(IExitVehicleLaunch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleLaunch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x0600FADD RID: 64221 RVA: 0x00245C6E File Offset: 0x00243E6E
		public override EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x04008905 RID: 35077
		private IExitVehicleLaunch Instance;
	}
}
