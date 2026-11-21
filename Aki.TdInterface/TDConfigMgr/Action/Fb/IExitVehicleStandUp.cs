using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CAA RID: 11434
	public class IExitVehicleStandUp : IExitVehicleType
	{
		// Token: 0x0600FADF RID: 64223 RVA: 0x00245C83 File Offset: 0x00243E83
		public static IExitVehicleStandUp Create(IExitVehicleStandUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleStandUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x0600FAE0 RID: 64224 RVA: 0x00245CA2 File Offset: 0x00243EA2
		public override EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x04008906 RID: 35078
		private IExitVehicleStandUp Instance;
	}
}
