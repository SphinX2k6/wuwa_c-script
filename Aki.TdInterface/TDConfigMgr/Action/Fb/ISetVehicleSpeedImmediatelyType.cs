using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA3 RID: 10915
	public class ISetVehicleSpeedImmediatelyType
	{
		// Token: 0x0600EFB0 RID: 61360 RVA: 0x0022D640 File Offset: 0x0022B840
		[NullableContext(1)]
		public static ISetVehicleSpeedImmediatelyType Create(ISetVehicleSpeedImmediatelyType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetVehicleSpeedImmediatelyType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x0600EFB1 RID: 61361 RVA: 0x0022D65F File Offset: 0x0022B85F
		public virtual ESetVehicleSpeedImmediatelyType Type
		{
			get
			{
				return (ESetVehicleSpeedImmediatelyType)this.Instance.Type;
			}
		}

		// Token: 0x040083D9 RID: 33753
		private ISetVehicleSpeedImmediatelyType Instance;
	}
}
