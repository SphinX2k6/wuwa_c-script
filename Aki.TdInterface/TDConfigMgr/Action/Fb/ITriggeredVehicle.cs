using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C6 RID: 10694
	public class ITriggeredVehicle : ITargetVehicle
	{
		// Token: 0x0600EC68 RID: 60520 RVA: 0x002285D1 File Offset: 0x002267D1
		[NullableContext(1)]
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

		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x0600EC69 RID: 60521 RVA: 0x002285F0 File Offset: 0x002267F0
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x04008226 RID: 33318
		private ITriggeredVehicle Instance;
	}
}
