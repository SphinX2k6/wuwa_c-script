using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC0 RID: 11456
	public class IVehicleControlType
	{
		// Token: 0x0600FB34 RID: 64308 RVA: 0x00246591 File Offset: 0x00244791
		public static IVehicleControlType Create(IVehicleControlType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleControlType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x0600FB35 RID: 64309 RVA: 0x002465B0 File Offset: 0x002447B0
		public virtual EVehicleControlType Type
		{
			get
			{
				return (EVehicleControlType)this.Instance.Type;
			}
		}

		// Token: 0x0400893C RID: 35132
		private IVehicleControlType Instance;
	}
}
