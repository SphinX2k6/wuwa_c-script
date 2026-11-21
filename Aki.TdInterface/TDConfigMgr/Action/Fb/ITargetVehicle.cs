using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CAF RID: 11439
	public class ITargetVehicle
	{
		// Token: 0x0600FAF2 RID: 64242 RVA: 0x00245E78 File Offset: 0x00244078
		public static ITargetVehicle Create(ITargetVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x0600FAF3 RID: 64243 RVA: 0x00245E97 File Offset: 0x00244097
		public virtual ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008913 RID: 35091
		private ITargetVehicle Instance;
	}
}
