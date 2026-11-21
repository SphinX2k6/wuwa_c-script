using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB1 RID: 11441
	public class ISelfVehicle : ITargetVehicle
	{
		// Token: 0x0600FAF8 RID: 64248 RVA: 0x00245EE0 File Offset: 0x002440E0
		public static ISelfVehicle Create(ISelfVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x0600FAF9 RID: 64249 RVA: 0x00245EFF File Offset: 0x002440FF
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008915 RID: 35093
		private ISelfVehicle Instance;
	}
}
