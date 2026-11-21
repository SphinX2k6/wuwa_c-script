using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB3 RID: 11443
	public class ITriggeredVehicle : ITargetVehicle
	{
		// Token: 0x0600FAFF RID: 64255 RVA: 0x00245F55 File Offset: 0x00244155
		public static ITriggeredVehicle Create(ITriggeredVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggeredVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x0600FB00 RID: 64256 RVA: 0x00245F74 File Offset: 0x00244174
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008917 RID: 35095
		private ITriggeredVehicle Instance;
	}
}
