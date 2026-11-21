using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA8 RID: 11432
	public class IExitVehicleType
	{
		// Token: 0x0600FAD9 RID: 64217 RVA: 0x00245C1B File Offset: 0x00243E1B
		public static IExitVehicleType Create(IExitVehicleType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x0600FADA RID: 64218 RVA: 0x00245C3A File Offset: 0x00243E3A
		public virtual EExitVehicleType Type
		{
			get
			{
				return (EExitVehicleType)this.Instance.Type;
			}
		}

		// Token: 0x04008904 RID: 35076
		private IExitVehicleType Instance;
	}
}
