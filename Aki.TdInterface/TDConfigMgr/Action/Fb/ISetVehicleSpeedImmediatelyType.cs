using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D97 RID: 11671
	public class ISetVehicleSpeedImmediatelyType
	{
		// Token: 0x0600FE66 RID: 65126 RVA: 0x0024B34C File Offset: 0x0024954C
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

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x0600FE67 RID: 65127 RVA: 0x0024B36B File Offset: 0x0024956B
		public virtual ESetVehicleSpeedImmediatelyType Type
		{
			get
			{
				return (ESetVehicleSpeedImmediatelyType)this.Instance.Type;
			}
		}

		// Token: 0x04008ADD RID: 35549
		private ISetVehicleSpeedImmediatelyType Instance;
	}
}
